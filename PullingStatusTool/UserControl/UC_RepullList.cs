using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;

namespace PullingStatusTool.UserControl
{
    public partial class UC_RepullList : UC_Functions
    {
        public UC_RepullList()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            getDS();


        }

        private string getHostName()
        {
            string hosName = "Cannot get creater name!";
            try
            {
                hosName = System.Environment.UserName;
            }
            catch
            {

            }

            return hosName;

        }

        private string getSqlstring() //查询repulllist的sql
        {
            string str = "";
            switch (rgp_isFinish.SelectedIndex)
            {
                case 0:
                    str = " and RepullStatus ='Pending' "; //所有未完成
                    break;
                case 1:
                    str = " and RepullStatus!= 'Pending' and DATEDIFF(day, CreateDate, getdate())<=7 ";//7天之内已完成
                    break;
                case 2:
                    str = " and RepullStatus!= 'Pending' and DATEDIFF(day, CreateDate, getdate())<=30";//30天之内已完成
                    break;
            }

            return str;
        }
        private void getDS()
        {


            DB_Helper dbhelper = new DB_Helper();
            string str = getSqlstring();
            DataTable dt = dbhelper.getTargetRepullList(str);
            GC_RepullList.DataSource = dt;
            gridView1.BestFitColumns();
            //if(gridView1.RowCount==0)
            //      gridView1.AddNewRow();


        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) //新加一行时，初始化
        {
            gridView1.SetFocusedRowCellValue("c_createdate", DateTime.Now);
            gridView1.SetFocusedRowCellValue("c_retailer", "Target"); //默认Target作为retailer
            gridView1.SetFocusedRowCellValue("c_isneedformat", "需要格式");
            gridView1.SetFocusedRowCellValue("c_isneedupload", "需要上传");
            gridView1.SetFocusedRowCellValue("c_flag", false); //Flag字段用来区分是新加的，还没存入数据库的行还是从数据库拿出来的行
        }

        private void UC_RepullList_Load(object sender, EventArgs e)
        {
            getDS();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {


            List<TargetRepullList> Listrepull = new List<TargetRepullList>();
            DB_Helper dbgelper = new DB_Helper();

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                if (!(bool)gridView1.GetDataRow(i)["c_flag"]) //将新加的行的保存到Listrepull中批量新增
                {
                    TargetRepullList repull = new TargetRepullList();
                    repull.c_retailer = gridView1.GetDataRow(i)["c_retailer"].ToString();
                    repull.c_vendor = gridView1.GetDataRow(i)["c_vendor"].ToString();
                    repull.c_reportname = gridView1.GetDataRow(i)["c_reportname"].ToString();
                    repull.c_finishbefore =Convert.ToDateTime( gridView1.GetDataRow(i)["c_eta"]);
                    repull.c_creatime = Convert.ToDateTime(gridView1.GetDataRow(i)["c_createdate"]);
                    repull.c_isneedformat = gridView1.GetDataRow(i)["c_isneedformat"].ToString();
                    repull.c_isneedupload = gridView1.GetDataRow(i)["c_isneedupload"].ToString();
                    repull.c_serverip = gridView1.GetDataRow(i)["c_serverip"].ToString();
                    repull.c_account = gridView1.GetDataRow(i)["c_account"].ToString();
                    repull.c_repullstatus = "Pending";
                    repull.c_creater = getHostName();
                    Listrepull.Add(repull);
                }
            }

            if (Listrepull.Count > 0)
                if (dbgelper.addRepullList(Listrepull))
                    getDS();

        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Frm_Password password = new Frm_Password();
            if (!Users.Flag)
            {
                if (password.ShowDialog() == DialogResult.OK)
                {
                    Users.Flag = true;
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }

            if (flag)
            {
                List<TargetRepullList> Listrepull = new List<TargetRepullList>();
                DB_Helper dbgelper = new DB_Helper();
                for (int i = 0; i < gridView1.GetSelectedRows().Length; i++) //所有选择的行
                {
                    int rowIndex = gridView1.GetSelectedRows()[i]; //获取行号
                    if ((bool)gridView1.GetDataRow(rowIndex)["c_flag"] && gridView1.GetDataRow(rowIndex)["c_repullstatus"].ToString() == "Pending") //判断已存入数据库以及status是空的行
                    {

                        TargetRepullList repull = new TargetRepullList();

                        string isNeedFormat = gridView1.GetDataRow(rowIndex)["c_isneedformat"].ToString();
                        string isNeedUpload = gridView1.GetDataRow(rowIndex)["c_isneedupload"].ToString();

                        if (isNeedUpload == "需要上传")
                            gridView1.GetDataRow(rowIndex)["c_repullstatus"] = "Uploaded"; //如果是需要上传，则stauts是Uploaded
                        else if (isNeedFormat == "需要格式")
                            gridView1.GetDataRow(rowIndex)["c_repullstatus"] = "Formatted";//如果不需要上传，是需要格式，则stauts是Uploaded
                        else
                            gridView1.GetDataRow(rowIndex)["c_repullstatus"] = "Downloaded";//如果都不用，则status是Downloaded
                        repull.c_account = gridView1.GetDataRow(rowIndex)["c_account"].ToString();
                        repull.c_serverip = gridView1.GetDataRow(rowIndex)["c_serverip"].ToString();
                        repull.c_repullstatus = gridView1.GetDataRow(rowIndex)["c_repullstatus"].ToString();
                        repull.c_id = gridView1.GetDataRow(rowIndex)["c_id"].ToString();
                        Listrepull.Add(repull);
                    }

                }

                if (Listrepull.Count > 0)
                {
                    dbgelper.editRepull(Listrepull);

                }

            }


        }

        private void rgp_isFinish_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDS();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Frm_Password password = new Frm_Password();
            if (!Users.Flag)
            {
                if (password.ShowDialog() == DialogResult.OK)
                {
                    Users.Flag = true;
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }

            if (flag)
            {
                DB_Helper dbgelper = new DB_Helper();
                string id = "";
                for (int i = 0; i < gridView1.GetSelectedRows().Length; i++) //所有选择的行
                {
                    int rowIndex = gridView1.GetSelectedRows()[i]; //获取行号
                    if ((bool)gridView1.GetDataRow(rowIndex)["c_flag"]) //判断已存入数据库以及status是空的行
                    {
                        id += gridView1.GetDataRow(rowIndex)["c_id"].ToString() + ",";
                    }

                }
                if (id != "")
                {

                    if (dbgelper.deleteRepullList(id.TrimEnd(',')))
                    {
                        getDS();

                    }
                }

            }
        }
    }
}
