using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
namespace PullingStatusTool.UserControl
{
    public partial class UC_TescoUKStatus : UC_Functions
    {
        public UC_TescoUKStatus()
        {
            InitializeComponent();
            cbx_Date.Text = DateTime.Now.AddDays(-1).ToShortDateString();
        }
        private void getDS()
        {
            string html = "";
            string HtmlStatus = "";
          //  lbl_ReportDate.Text += " " + DateTime.Now;
        
            HtmlStatus = createReport(int.Parse(txt_days.Text));
            html = "<html><body><br> <table width='100%'>"
                           + HtmlStatus   //将返回的总html代码放入
                      +"</table>"
                   + "</body></html>";
            wb_Status.DocumentText = html;
        }

        private string createReport(int days)//根据天数生成多个表格
        {
            DB_Helper dbhelper = new DB_Helper();
            List<ReportExpect> ListExpect = dbhelper.getReportExpect("retailer='TescoUK'"); //拿到expect file 模板    
            string str="";
            string date="";
            for(int i=0;i<days;i++)//循环天数生成多个status表格
            {
                date =Convert.ToDateTime(cbx_Date.Text).AddDays(0-i).ToString("yyyy-MM-dd");
                DataTable status = dbhelper.getTescoUKPullingStatus(date);
                str += createTable(status, ListExpect, date);
            
            }
            return str;
        }

        private string createTable(DataTable dt, List<ReportExpect> ListExpect,string datelag)//生成一天的status表格
        {
        //    lbl_DataDate.Text += " " + STdate;
            DB_Helper dbhelper = new DB_Helper();
            string HtmlStatus="";
            bool isAll = true; //判断某个vendor是否取全
            bool isSSSD = true;//判断SSSD是否取了
            string cellColor="";
            string  fontWeight="";
            string HtmlTable = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (ListExpect.Where(t => t.c_vendor == dt.Rows[i][0].ToString()).Count() == 0)
                    continue;
                HtmlTable += "<tr>";
                isSSSD = true;
                isAll = true;
                for (int j = 0; j < 11; j++)
                {
                    cellColor = "";
                    fontWeight = "";
                    string cell = "";
                    cell = "Y"; //初始化每个cell,
               
                    if (j > 1 && j < 9) //文件类型列需要处理成1/1的格式，0和1列不需要
                    {
                        //根据vendor, account, datatype找到expect file
                        string fileExpect = ListExpect.Where(t => t.c_vendor == dt.Rows[i][0].ToString() && t.c_subgroup == dt.Rows[i][1].ToString() && dt.Columns[j].ColumnName.ToUpper().Contains(t.c_datatype.ToUpper())).Count() == 0 ? "0" : ListExpect.Where(t => t.c_vendor == dt.Rows[i][0].ToString() && t.c_subgroup == dt.Rows[i][1].ToString() && dt.Columns[j].ColumnName.ToUpper().Contains(t.c_datatype.ToUpper())).ToList()[0].c_filexpectuploaded;
                        cellColor = "";
                        fontWeight = "";
                        cell = dt.Rows[i][j].ToString() + "/" + fileExpect;
                        if ((isAll && dt.Rows[i][j].ToString() != fileExpect) || dt.Rows[i][j].ToString()=="0") //如果取的文件数和expect文件数对不上
                        {
                            isAll = false; //isAll列为N
                            fontWeight = "style='font-weight: bold'";
                            if (j == 2) //如果SSSD列取的文件数不对
                                isSSSD = false;//isSSSD列为N
                            if (dt.Rows[i][j].ToString() == "0")
                                cellColor = "bgcolor='Red'";
                            else
                                cellColor = "bgcolor='yellow'";
                        }


                    }
                    else if (j <= 1) //0和1列分别是vendor和account，不用任何处理
                    {
              
                        cell = dt.Rows[i][j].ToString();
                    }
                    else if (j == 10) // 判断isAll列
                    {
            
                        if (!isAll)
                        {
                            fontWeight = "style='font-weight: bold'";
                            cellColor = "bgcolor='Red'";
                            cell = "N";
                        }
                    }
                    else //最后判断isSSSD列
                    {
                  
                        if (!isSSSD)
                        {
                            fontWeight = "style='font-weight: bold'";
                            cellColor = "bgcolor='Red'";
                            cell = "N";
                        }
                    }
               //     xtTBRow.Cells.Add(cell);
                    HtmlTable += "<td "+fontWeight+" "+ cellColor+">" + cell + "</td>";
                }

              //  xrTB_Status.Rows.Add(xtTBRow);
                HtmlTable += "</tr>";

            }

            HtmlStatus += "<tr><td align='center'>"//第一行是写死的，从第二行起拿生成的Table,即HtmlTable
                        + "<table with='95%' border=1 >"
                        + "<tr><td colspan='11' align='left' bgcolor='lime' style='font-weight: bold'>" + "Date : " + datelag + "</tr></td>"
                                  + "<tr style='font-weight: bold'>"
                                  + "<td>Vendor</td>"
                                  + "<td>Account</td>"
                                  + " <td>SSSD</td>"
                                  + "<td>SSDCD</td>"
                                  + "<td>WASD</td>"
                                  + "<td>GSSD</td>"
                                  + "<td>RSSSD</td>"
                                  + "<td>SSSW</td>"
                                  + "<td>STCW</td>"
                                  + "<td>isSSSD</td>"
                                  + "<td>isAll</td>"
                            + " </tr>"
                            + HtmlTable
                            + "</table> <br/><br><br/><br/><br/></td></tr>";


            return HtmlStatus;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void UC_TescoUKStatus_Load(object sender, EventArgs e)
        {
            cbx_Date.Text = DateTime.Now.AddDays(-1).ToShortDateString();
        }
    }
}
