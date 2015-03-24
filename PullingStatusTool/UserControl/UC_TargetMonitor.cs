using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using PullingStatusTool.RestfulAPI;
using PullingStatusTool.App;

namespace PullingStatusTool.UserControl
{
    public partial class UC_TargetMonitor : UC_Functions
    {
        public UC_TargetMonitor()
        {
            InitializeComponent();
        }
        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Frm_PullingStatusService_Load(object sender, EventArgs e)
        {

            DB_Helper db_helper = new DB_Helper();
            drp_DailyDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            string period = db_helper.getIRCalendarbyDate(drp_DailyDate.Text);//根据当前日期查询Target IR Calendar 出来的mohth_weekofmonth
            // string weekly = "2014-08 wk 3";
            txt_year.Text = period.Substring(0, 4);
            txt_month.Text = period.Substring(5, 2);
            txt_Week.Text = period.Substring(11, 1);
        }
        //List<ReportExpect> ListReportExpect = new List<ReportExpect>();

        //private List<ReportExpect> getReportExpect(bool isMonday)
        //{
        //    string dayofweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
        //    DB_Helper db_helper = new DB_Helper();
        //    string dayOfweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
        //    DataPullingFileCountStatus fileStatus = new DataPullingFileCountStatus();
        //    ListReportExpect = isMonday ? db_helper.getReportExpect("retailer='Target'").Where(t => t.c_dayofweek.Contains("VIP")).ToList() : db_helper.getReportExpect("retailer='Target'").Where(t => t.c_dayofweek.Contains(dayofweek)).ToList();

        //    string vendor = "";
        //    string subgroup = "";
        //    string fileCountsUpload = "";
        //    string datatype = "";
        //    string fileCountsFormatted = "";
        //    string fileExceot = "";
        //    foreach (ReportExpect file in ListReportExpect)
        //    {
        //        vendor = file.c_vendor.Trim().ToLower();
        //        subgroup = file.c_subgroup.ToLower().Trim();
        //        datatype = file.c_datatype.ToLower().Trim();
        //        var temp = ListFileStatus.Where(
        //                                        t => t.c_vendor.Trim().ToLower() == vendor &&
        //                                        t.c_dataType.ToLower().Trim() == datatype &&
        //                                        t.c_subgroup.Trim().ToLower() == subgroup

        //                                        );


        //        fileCountsUpload = temp.Where(t => t.c_status.Trim() == "Uploaded").ToList().Count > 0 ? temp.Where(t => t.c_status.Trim() == "Uploaded").ToList()[0].c_filecount : "0";
        //        fileCountsFormatted = temp.Where(t => t.c_status.Trim() == "Formatted").ToList().Count > 0 ? temp.Where(t => t.c_status.Trim() == "Formatted").ToList()[0].c_filecount : "0";
        //        file.c_serverIP = temp.Count() > 0 ? temp.ToList()[0].c_serverIP : "";
        //        file.c_status = temp.Count() > 0 ? temp.ToList()[0].c_status : "";
        //        fileExceot = file.c_filexpectuploaded.Split('/')[file.c_filexpectuploaded.Split('/').Count() - 1];
        //        file.c_filexpectuploaded = fileCountsUpload + "/" + fileExceot;
        //        file.c_filexpectformatted = fileCountsFormatted == "0" ? fileCountsUpload : fileCountsFormatted;
        //        //file.c_filexpectformatted = fileCountsFormatted;
        //        file.c_filexpectformatted += "/" + fileExceot;
        //        file.c_finishuploaded = file.c_filexpectuploaded.Split('/')[0] == file.c_filexpectuploaded.Split('/')[1] ? "Y" : "N";
        //        file.c_finishformatted = file.c_filexpectformatted.Split('/')[0] == file.c_filexpectformatted.Split('/')[1] ? "Y" : "N";
        //        file.c_finishtime = temp.Count() > 0 ? AMESTime.AMESTimeToBeijingTime(temp.ToList()[0].c_finishTime).ToString() : "";

        //    }

        //    return ListReportExpect.OrderBy(t => t.c_vendor).ThenBy(t => t.c_datatype).ThenBy(t => t.c_subgroup).ToList();

        //}
        //List<DataPullingFileCountStatus> ListFileStatus = new List<DataPullingFileCountStatus>();
        //private void getDS(bool isMonday)
        //{

        //    DB_Helper db_helper = new DB_Helper();
        //    string dailydate = "";
        //    string resdate = "";//R7文件的日期
        //    dailydate = String.Format("%{0:yyyy-MM-dd}%", Convert.ToDateTime(drp_DailyDate.Text).AddDays(-1));//在daily上不打钩就传""去查询
        //    string weeklyPeriod = String.Format("%{0}-{1} WK {2}%", txt_year.Text.Trim(), txt_month.Text.Trim(), txt_Week.Text.Trim());
        //    resdate = dailydate == "" ? "" : String.Format("%{0:yyyy-MM-dd}-%", Convert.ToDateTime(dailydate.Replace("%", "")).AddDays(-7).ToString("yyyy-MM-dd"));//如果查daily的，也要讲7天前的日期传过去作为查询R7文件的条件
        //    ListFileStatus = db_helper.getPullingFileCount(dailydate, weeklyPeriod, resdate, true, isMonday);
        //    GC_PullingFileStatus.DataSource = getReportExpect(isMonday);

        //}

        private void getDS(bool isMonday)
        {
            WCFRestfulAPI api = new WCFRestfulAPI();
            string isMondayDay = isMonday ? "True" : "False";
            string StrJson = api.GetTargetPullingStatus(isMondayDay, drp_DailyDate.Text, txt_year.Text.Trim(), txt_month.Text.Trim(), txt_Week.Text.Trim());
            List<ReportExpect> TGTPullingStatus = JsonHelper.JsonDeserialize<List<ReportExpect>>(StrJson);
            GC_PullingFileStatus.DataSource = TGTPullingStatus;
        }



        private void btn_refresh_Click(object sender, EventArgs e)
        {

            if (txt_month.Text != "" && txt_year.Text != "" && txt_Week.Text != "")
            {

                getDS(false);//获得所有的vendor的status，不仅仅是礼拜一的VIP

            }
            else
            {
                ShowMessage("Fill the period!");
            }


        }






        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }



        private void Btn_MondayStatus_Click(object sender, EventArgs e)
        {

            if (txt_month.Text != "" && txt_year.Text != "" && txt_Week.Text != "")
            {

                getDS(true);//获得礼拜一的VIP vendor的Status

            }
            else
            {
                ShowMessage("Fill the period!");
            }
        }








    }
}
