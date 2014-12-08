using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.Linq;
using PullingStatusTool.Model;

namespace PullingStatusTool.UserControl
{
    public partial class UC_NoTargetDPChart : UC_Functions
    {
        public UC_NoTargetDPChart()
        {
            InitializeComponent();
        }

        private void UC_NoTargetDPChart_Load(object sender, EventArgs e)
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
            DB_Helper db_help = new DB_Helper();
            ChartSLA.Series.Clear();   //清空所有曲线
            ChartSLA.SeriesDataMember = "c_retailer";
            ChartSLA.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "c_filecount" });
            ChartSLA.SeriesTemplate.ArgumentDataMember = "c_uploaddate";
            ChartSLA.DataSource = db_help.getNoPerfomances(txt_StartDate.Text, txt_EndDate.Text);
            Random rd = new Random();
            cbx_Retailer.Properties.Items.Clear();
            cbx_Retailer.Properties.Items.Add("All");
            cbx_Retailer.SelectedIndex = 0;
            foreach (Series line in ChartSLA.Series)
            {
                string color = RetailerColor.getColorbyRetailer(line.Name);//根据retailer获得线条的颜色，有新retailer的时候需要手工定义
                ((LineSeriesView)line.View).LineStyle.Thickness = 3;
                ((LineSeriesView)line.View).Color = ColorTranslator.FromHtml(color);
                cbx_Retailer.Properties.Items.Add(line.Name);
            }
         
        
        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void cbx_Retailer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Retailer.SelectedIndex != 0)
            {
                foreach (Series line in ChartSLA.Series)
                {
                    if (line.Name != cbx_Retailer.Text)
                        line.Visible = false;
                    else
                        line.Visible = true;
                }
            }
            else
            {
                foreach (Series line in ChartSLA.Series)
                {
                    line.Visible = true;
                }
            
            }
        }
    }
}
