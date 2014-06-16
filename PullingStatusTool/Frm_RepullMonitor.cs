using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PullingStatusTool
{
    public partial class Frm_RepullMonitor : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RepullMonitor()
        {
            InitializeComponent();
        }
        private void Frm_RepullMonitor_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;  
            //本月第一天时间   
            DateTime dt_First = dt.AddDays(-(dt.Day) + 1);
            txt_StartDate.Text = dt_First.ToString("MM/dd/yyyy");
           

            txt_EndDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private string timeZoneConvert(string ChinaTime)
        {

            TimeZoneInfo EST = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeToUtc(Convert.ToDateTime(ChinaTime), EST).ToString();
        }
          DB_Helper db_heler = new DB_Helper();
          string startDate = "";
          string endDate = "";
        private void getDS()
        {
            if (Convert.ToDateTime(txt_EndDate.Text).CompareTo(Convert.ToDateTime(txt_StartDate.Text)) >= 0)
            {
                startDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_StartDate.Text + " 00:00:00")).ToString("yyyy-MM-dd HH:mm:ss");
                endDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_EndDate.Text + " 23:59:59")).ToString("yyyy-MM-dd HH:mm:ss");
              
                if (ckbx_68.Checked)
                {
                    db_heler.getRepull("192.168.10.68", "T3ci94043", startDate, endDate);

                }
                if (ckbx_70.Checked)
                {
                    db_heler.getRepull("192.168.28.70", "T3ci94043", startDate, endDate);
                }
                if (ckbx_71.Checked)
                {
                    db_heler.getRepull("192.168.10.71", "t3ci94043", startDate, endDate);
                }
                if (ckbx_72.Checked)
                {
                    db_heler.getRepull("192.168.10.72", "T3ci94043", startDate, endDate);
                }
                if (ckbx_77.Checked)
                {
                    db_heler.getRepull("192.168.10.77", "T3ci94043", startDate, endDate);
                }
                if (ckbx_78.Checked)
                {
                    db_heler.getRepull("192.168.10.78", "T3ci94043", startDate, endDate);
                }
                GC_Repull.DataSource = db_heler.getRePullList();
            }
            else
            {
                MessageBox.Show("Error!End Date must after start date!");
            }
        }

        private void brn_Chart_Click(object sender, EventArgs e)
        {
            startDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_StartDate.Text + " 00:00:00")).ToString("yyyy-MM-dd");
            endDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_EndDate.Text + " 23:59:59")).ToString("yyyy-MM-dd");
            Frm_RepullChart repullChart = new Frm_RepullChart(startDate, endDate, ckbx_68.Checked, ckbx_70.Checked, ckbx_71.Checked, ckbx_72.Checked, ckbx_77.Checked, ckbx_78.Checked);
            repullChart.Show();
        }

  
    }
}