using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool;
using System.Linq;

namespace PullingStatusTool.UserControl
{
    public partial class UC_TargetDPChart :UC_Functions
    {
        public UC_TargetDPChart()
        {
            InitializeComponent();
        }

        private void Frm_SLAChart_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            byte tempB = (byte)d.DayOfWeek;
            byte thursdayByte = (byte)DayOfWeek.Thursday;
            DateTime thursday = d.AddDays(thursdayByte - tempB);//本星期四
            DateTime friday = thursday.AddDays(-6);//上周五

            txt_StartDate.Text = friday.ToString("yyyy-MM-dd");

            txt_EndDate.Text = thursday.ToString("yyyy-MM-dd");
        }

        private void getDS()
        {
            DB_Helper db_helper = new DB_Helper();
            DB_Helper db_hhelper = new DB_Helper();
            List<Repull> ListSLA = new List<Repull>();
            List<Repull> ListRepull = new List<Repull>();
            ListSLA = db_helper.getSLAChart(txt_StartDate.Text, txt_EndDate.Text);
            string startDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_StartDate.Text + " 00:00:00")).ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_EndDate.Text + " 23:59:59")).ToString("yyyy-MM-dd HH:mm:ss");
            ListRepull = db_hhelper.getRePullChart(startDate, endDate);
            int count = ListRepull.Count < ListSLA.Count ? ListRepull.Count : ListSLA.Count;
            for (int i = 0; i < count; i++)
            {

                ListSLA[i].c_ffilecount = ListRepull[i].c_filecount;
            }
            ChartSLA.DataSource = ListSLA;
            string SLATotal = ListSLA.Where(t => Convert.ToDateTime(t.c_repulldate).DayOfWeek.ToString() != "Saturday").Sum(t => t.c_filecount).ToString();
            string RepullTotal = ListRepull.Where(t => Convert.ToDateTime(t.c_repulldate).DayOfWeek.ToString() != "Saturday").Sum(t => t.c_filecount).ToString();
            float Total = db_helper.getAllPulledFileByWeek(startDate, endDate);
            lblTotalRepull.Text = "RepullRate: " + (float.Parse(RepullTotal) * 100 / Total).ToString("0.00") + "%";
            lblTotalSLA.Text = "SLARate :" + ((Total - float.Parse(SLATotal)) * 100 / Total).ToString("0.00") + "%";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            getDS();
        }
      

    }
}
