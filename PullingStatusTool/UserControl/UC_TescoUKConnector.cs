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
    public partial class UC_TescoUKConnector : UC_Functions
    {
        public UC_TescoUKConnector()
        {
            InitializeComponent();
        }

        private void getAccountDS()
        {
            TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            ListAccount=dbhelper.getAllAccount();
            gc_Account.DataSource = ListAccount;

        
        }

        private void btn_RfreshAccount_Click(object sender, EventArgs e)
        {
            getAccountDS();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(accountid))
            {
              
                    TescoUKDBHelper dbhelper = new TescoUKDBHelper();
                    ConnectorAccount account = new ConnectorAccount();
                    account.c_accountname = txt_Account.Text;
                    account.c_password = txt_Password.Text;
                    account.c_vendor = txt_Desc.Text;
                    account.c_id = accountid;
                    if (dbhelper.editAccount(account))
                        getAccountDS();
                }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

    
                TescoUKDBHelper dbhelper = new TescoUKDBHelper();
                ConnectorAccount account = new ConnectorAccount();
                account.c_accountname = txt_Account.Text;
                account.c_password = txt_Password.Text;
                account.c_vendor = txt_Desc.Text;

                if (dbhelper.addNewUser(account))
                    getAccountDS();
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(accountid))
            {
                TescoUKDBHelper dbhelper = new TescoUKDBHelper();
           
                    if (dbhelper.deleteAccount(accountid))
                        getAccountDS();
                }
            
        }
        string accountid = "";

        private void gc_Account_DoubleClick(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("c_accountname") != null)
            {
                accountid = gridView3.GetFocusedRowCellValue("c_accountname").ToString().Trim();
                txt_Account.Text =  gridView3.GetFocusedRowCellValue("c_accountname").ToString();
                txt_Password.Text = gridView3.GetFocusedRowCellValue("c_password").ToString();
                txt_Desc.Text = gridView3.GetFocusedRowCellValue("c_vendor").ToString();
            }
        }


        private void btn_EditSchedule_Click(object sender, EventArgs e)
        {
            TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            if (scheduleid != "")
            { 
             TescoUKSchedule schedule = new TescoUKSchedule();
            schedule.Account = cbx_UserId.Text;
            schedule.Prodlist = txt_ProList.Text;
            schedule.Reporttype = cbx_ReportType.Text;
            schedule.Datelag = txt_DateLag.Text;
            schedule.Enable = ckc_enable.Checked == true ? "Y" : "N";
            schedule.Supplier = txt_Supplier.Text;
            schedule.Weekday = cbx_DayofWeek.Text;
            schedule.Data = cbx_Data.Text;
            schedule.Dataset = cbx_DataSet.Text;
            schedule.Downloadfolder = txt_DownLoadFolder.Text;
            schedule.Time = txt_Time.Text;
            schedule.Timeframe = cbx_TimeFrame.Text;
            schedule.STDate = txt_STDate.Text;
            schedule.Eddate = txt_EDdate.Text;
            schedule.ScheduleFreqency = cbx_Frequent.Text;
            schedule.Filename = txt_FileName.Text;
            schedule.ReportID = scheduleid;
            if (dbhelper.editSchedule(schedule))
                getScheduleDS();
            
            }
        }

        private void btn_SchedueRefresh_Click(object sender, EventArgs e)
        {
            getScheduleDS();
        }

        private void getScheduleDS()
        {
            TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            gc_Schedule.DataSource = dbhelper.getSchedule();
            try
            {
                gridView1.BestFitColumns();
                gridView1.Columns["ReportID"].Visible = false;
                gridView1.OptionsView.ShowFooter = true;
                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;

                }
                    gridView1.Columns["vendor"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridView1.Columns["Enable"].VisibleIndex = 1;
                string newFilter = string.Empty;
                string filter = "Enable like 'Y'";
                gridView1.ActiveFilterString = filter;
              
            }

            catch (Exception e)
            {
               ShowMessage(e.Message);
            }
        }

        DataTable ListAccount = new DataTable();
        private void UC_TescoUKConnector_Load(object sender, EventArgs e)
        {
            getUserIDDS();
            cbx_StartDate.Text = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            Cbx_SubmitDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void getUserIDDS()//初始化Schedule tab的account下拉框
        {
            TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            ListAccount = dbhelper.getAllAccount();
            ListAccount = ListAccount.Rows.Count == 0 ? dbhelper.getAllAccount() : ListAccount;
            foreach (DataRow row in ListAccount.Rows)
            {
                cbx_UserId.Properties.Items.Add(row["c_accountname"].ToString());

            }
            cbx_UserId.SelectedIndex = 0;
        }

          private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
               TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            TescoUKSchedule schedule = new TescoUKSchedule();
            schedule.Account = cbx_UserId.Text;
            schedule.Prodlist = txt_ProList.Text;
            schedule.Reporttype =  cbx_ReportType.Text;
            schedule.Datelag = txt_DateLag.Text;
            schedule.Enable = ckc_enable.Checked==true?"Y":"N";
            schedule.Supplier = txt_Supplier.Text;
            schedule.Weekday = cbx_DayofWeek.Text;
            schedule.Data = cbx_Data.Text;
            schedule.Dataset = cbx_DataSet.Text;
            schedule.Downloadfolder = txt_DownLoadFolder.Text;
            schedule.Time = txt_Time.Text;
            schedule.Timeframe = cbx_TimeFrame.Text;
            schedule.STDate = txt_STDate.Text;
            schedule.Eddate = txt_EDdate.Text;
            schedule.ScheduleFreqency = cbx_Frequent.Text;
            schedule.Filename = txt_FileName.Text;
            if (dbhelper.addSchedule(schedule))
                getScheduleDS();

        }    
        string scheduleid = "";
        private void gc_Schedule_DoubleClick(object sender, EventArgs e)
        {
                  
            if (gridView1.GetFocusedRowCellValue("ReportID") != null)
            {
                scheduleid = gridView1.GetFocusedRowCellValue("ReportID").ToString();
                cbx_ReportType.Text = gridView1.GetFocusedRowCellValue("ReportType").ToString();
                cbx_UserId.Text = gridView1.GetFocusedRowCellValue("UserID").ToString();
                txt_FileName.Text = gridView1.GetFocusedRowCellValue("FileName").ToString();
                txt_Supplier.Text = gridView1.GetFocusedRowCellValue("Supplier").ToString();
                cbx_Data.Text = gridView1.GetFocusedRowCellValue("Data").ToString();
                cbx_DataSet.Text = gridView1.GetFocusedRowCellValue("DataSet").ToString();
                txt_ProList.Text = gridView1.GetFocusedRowCellValue("ProductList").ToString();
                cbx_TimeFrame.Text = gridView1.GetFocusedRowCellValue("TimeFrame").ToString();
                txt_DateLag.Text = gridView1.GetFocusedRowCellValue("DataLag").ToString();
                txt_STDate.Text = gridView1.GetFocusedRowCellValue("StartDate").ToString();
                txt_EDdate.Text = gridView1.GetFocusedRowCellValue("EndDate").ToString();
                cbx_Frequent.Text = gridView1.GetFocusedRowCellValue("ScheduleFrequency").ToString();
                cbx_DayofWeek.EditValue = gridView1.GetFocusedRowCellValue("Weekday").ToString();
                txt_DownLoadFolder.Text = gridView1.GetFocusedRowCellValue("DownloadDirectory").ToString();
                txt_Time.EditValue = gridView1.GetFocusedRowCellValue("Time").ToString();
                ckc_enable.Checked = gridView1.GetFocusedRowCellValue("Enable").ToString() == "Y" ? true : false;
    

            }
        }

        private void getReportDS()
        {
            TescoUKDBHelper dbhelper = new TescoUKDBHelper();
            string STDate = ckc_StartDate.Checked ? cbx_StartDate.Text : "";
            string SubmitDate = ckc_SubmitDate.Checked ? Cbx_SubmitDate.Text : "";
            gc_Record.DataSource = dbhelper.getReport(STDate, SubmitDate);
            try
            {
                for (int i = 0; i < gridView2.Columns.Count; i++)
                {
                    gridView2.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;

                }
                gridView2.Columns["HistoryID"].Visible = false;
                gridView2.OptionsView.ShowFooter = true;
                gridView2.Columns["UserID"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridView2.Columns["SubmitTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView2.Columns["SubmitTime"].DisplayFormat.FormatString = "yyyy-MM-dd HH:ss:mm";
                gridView2.Columns["DownloadTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView2.Columns["DownloadTime"].DisplayFormat.FormatString = "yyyy-MM-dd HH:ss:mm";
                gridView2.BestFitColumns();
            }

            catch (Exception e)
            {
               ShowMessage(e.Message);
            }
        
        }
        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_ReportRefresh_Click(object sender, EventArgs e)
        {
        
            if (ckc_StartDate.Checked || ckc_SubmitDate.Checked)
            {

                getReportDS();
            }

           
        }
        string historyID = "";
        private void gc_Record_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("HistoryID") != null)
            {
                historyID = gridView2.GetFocusedRowCellValue("HistoryID").ToString();
                string vendor =  gridView2.GetFocusedRowCellValue("vendor").ToString();
                string filename = gridView2.GetFocusedRowCellValue("FileName").ToString();
                lbl_Report.Text = vendor + "  " + filename;
            }
        }

        private void btn_EditReportStatus_Click(object sender, EventArgs e)
        {
            if (historyID != "")
            {
                TescoUKDBHelper dbhelper = new TescoUKDBHelper();
                if (dbhelper.editReportStatus(historyID))
                    getReportDS();
            }
        }
    }

    public class TescoUKSchedule
    {

        string enable;

        public string Enable
        {
            get { return enable; }
            set { enable = value; }
        }
        string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        string downloadfolder;

        public string Downloadfolder
        {
            get { return downloadfolder; }
            set { downloadfolder = value; }
        }
        string weekday;

        public string Weekday
        {
            get { return weekday; }
            set { weekday = value; }
        }
        string scheduleFreqency;

        public string ScheduleFreqency
        {
            get { return scheduleFreqency; }
            set { scheduleFreqency = value; }
        }
        string eddate;

        public string Eddate
        {
            get { return eddate; }
            set { eddate = value; }
        }
        string startdate;

        public string STDate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        string datelag;

        public string Datelag
        {
            get { return datelag; }
            set { datelag = value; }
        }
        string timeframe;

        public string Timeframe
        {
            get { return timeframe; }
            set { timeframe = value; }
        }
        string prodlist;

        public string Prodlist
        {
            get { return prodlist; }
            set { prodlist = value; }
        }
        string dataset;

        public string Dataset
        {
            get { return dataset; }
            set { dataset = value; }
        }
        string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        string supplier;

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        string filename;

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        string reporttype;

        public string Reporttype
        {
            get { return reporttype; }
            set { reporttype = value; }
        }
        string reportID;

        public string ReportID
        {
            get { return reportID; }
            set { reportID = value; }
        }
        string account;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
    }
}
