using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.App;
using PullingStatusTool.Model;

namespace PullingStatusTool.UserControl
{
    public partial class UC_WMBasket : UC_Functions
    {
        public UC_WMBasket()
        {
            InitializeComponent();
        }

        string accountid = "";
        string scheduleid = "";
        string reportSummaryid = "";
        private void gc_Schedule_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "c_selected" && gridView1.SelectedRowsCount > 0)
            {
                gridView1.SetFocusedRowCellValue("c_selected", !(bool)gridView1.GetFocusedRowCellValue("c_selected"));
            }
        }


        private string getRidOfSpace(string str)
        {
            return str.Replace(" ", "");
        
        }



        private void getAccountDS()
        {
            BasketDBHelper BasketDBhelper = new BasketDBHelper();
            gc_Account.DataSource = BasketDBhelper.getAllAccount();
        }
        private void getScheduleDS()
        {
            BasketDBHelper BasketDBhelper = new BasketDBHelper();
            gc_Schedule.DataSource = BasketDBhelper.getAllSchedule();
        }
        private void getReportSummaryDS()
        {
            BasketDBHelper BasketDBhelper = new BasketDBHelper();
         gc_Record.DataSource=   BasketDBhelper.getAllReportSummary();
        }
        private void btn_RfreshAccount_Click(object sender, EventArgs e)
        {
            getAccountDS();
        }
        private void btn_SchedueRefresh_Click(object sender, EventArgs e)
        {
            getScheduleDS();
        }

        private void btn_ReportRefresh_Click(object sender, EventArgs e)
        {
            getReportSummaryDS();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            BasketDBHelper BasketDBhelper = new BasketDBHelper();
            ConnectorAccount account = new ConnectorAccount();
            account.c_suffix = txt_Desc.Text;
            account.c_accountname = txt_Account.Text;
            account.c_password = txt_Password.Text;
            account.c_id = accountid;
            BasketDBhelper.editAccount(account);
            getAccountDS();
        }

        private void gc_Account_DoubleClick(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("c_id") != null)
            {
                txt_Account.Text = gridView3.GetFocusedRowCellValue("c_accountname").ToString().Trim();
                txt_Password.Text = gridView3.GetFocusedRowCellValue("c_password").ToString().Trim();
                txt_Desc.Text = gridView3.GetFocusedRowCellValue("c_desc").ToString().Trim();
                accountid = gridView3.GetFocusedRowCellValue("c_id").ToString();

            }
        }

        private void btn_Runnow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to RunNow?", "Confirm to run", messButton);
          
            if (dr == DialogResult.OK)
            {
                string ids = "";
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if ((bool)gridView1.GetRowCellValue(i, "c_selected"))
                        ids += gridView1.GetRowCellValue(i, "c_id") + ",";//将显示在grid表格中的id传入runnow方法，批量runnow
                }
                if (ids != "")
                {
                    BasketDBHelper BasketDBhelper = new BasketDBHelper();
                    BasketDBhelper.runnow(ids.TrimEnd(','));
                    getScheduleDS();
                }
            }
        }

        private void btn_BulkEdit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to Edit?", "Confirm to edit", messButton);
            if (dr == DialogResult.OK)
            {
                BasketDBHelper basketdbhelper = new BasketDBHelper();
                ConnectorSchedule schedule = new ConnectorSchedule();
                schedule.c_enable = cbx_Enable.Checked;
                schedule.c_nextruntime = txt_NextRunTime.Text;
                schedule.c_time = txt_Time.Text;
                schedule.c_storenumber = string.IsNullOrEmpty(getRidOfSpace(txt_Stores.Text)) ? null : getRidOfSpace(txt_Stores.Text);
                schedule.c_week = string.IsNullOrEmpty(getRidOfSpace(txt_week.Text)) ? null : getRidOfSpace(txt_Stores.Text);
                schedule.c_id = scheduleid;
                if (scheduleid != "")
                {
                    basketdbhelper.editSchedule(schedule);
                    getScheduleDS();
                }
            }
        }

        private void gc_Schedule_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("c_id") != null)
            {
                txt_Stores.Text = gridView1.GetFocusedRowCellValue("c_stores").ToString().Trim();
                cbx_Enable.Checked = (bool)gridView1.GetFocusedRowCellValue("c_enable");
                txt_NextRunTime.Text = gridView1.GetFocusedRowCellValue("c_nextruntime").ToString().Trim();
                txt_Time.EditValue = gridView1.GetFocusedRowCellValue("c_time").ToString().Trim();
                scheduleid = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                txt_week.Text = gridView1.GetFocusedRowCellValue("c_week").ToString().Trim();

            }
        }

        private void gc_Record_DoubleClick(object sender, EventArgs e)
        {
            if (reportSummaryid != "")
            {
                Frm_ConnectorReportDetail Frm_reportdetail = new Frm_ConnectorReportDetail(reportSummaryid);
                Frm_reportdetail.Show();
            }
        }

        private void gc_Record_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("c_id") != null)
            {
                reportSummaryid = gridView2.GetFocusedRowCellValue("c_id").ToString();
                lbl_Configname.Text = gridView2.GetFocusedRowCellValue("c_configname").ToString() + " id : " + reportSummaryid;

            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (reportSummaryid!= "")
            {
                BasketDBHelper BasketDBhelper = new BasketDBHelper();
                BasketDBhelper.StopTask(reportSummaryid);
            }
        }


    }
}
