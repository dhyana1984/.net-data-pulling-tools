using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.Model;

namespace PullingStatusTool
{
    public partial class Frm_PullingPerformance : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PullingPerformance()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void Frm_PullingPerformance_Load(object sender, EventArgs e)
        {
         
            drp_DailyDate.Text = DateTime.Now.ToShortDateString();

        }

     
        string weekly = "";
        private void getDS()
        {
            getWeekly();
            DB_Helper db_helper = new DB_Helper();
            string dailydate = "";
            dailydate = drp_DailyDate.Text;//在daily上不打钩就传""去查询
            string weeklyPeriod = weekly;
            //resdate = dailydate == "" ? "" : String.Format("%{0:yyyy-MM-dd}-%", Convert.ToDateTime(dailydate.Replace("%", "")).AddDays(-7).ToString("yyyy-MM-dd"));//如果查daily的，也要讲7天前的日期传过去作为查询R7文件的条件

                GC_Performance.DataSource = db_helper.getPerformance(dailydate, weeklyPeriod);

        }

        private void getWeekly()
        {
            DB_Helper dbhelper = new DB_Helper();
            weekly =dbhelper.getIRCalendarbyDate( drp_DailyDate.Text);//根据当前日期查询Target IR Calendar 出来的mohth_weekofmonth
          

        }

        private void brn_Chart_Click(object sender, EventArgs e)
        {
            Frm_SLAChart SLAChart = new Frm_SLAChart();
            SLAChart.Show();
        }

    }
}