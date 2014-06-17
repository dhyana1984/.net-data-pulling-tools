using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
namespace PullingStatusTool
{
    public partial class Frm_SLAChart : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SLAChart()
        {
            InitializeComponent();
        }



        private void Frm_SLAChart_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //本月第一天时间   
            DateTime dt_First = dt.AddDays(-(dt.Day) + 1);
            txt_StartDate.Text = dt_First.ToString("MM/dd/yyyy");
         
            txt_EndDate.Text = txt_EndDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void btn_Fresh_Click(object sender, EventArgs e)
        {

            getDS();
        }

        private void getDS()
        {
            DB_Helper db_helper = new DB_Helper();
            DB_Helper db_hhelper = new DB_Helper();
            List<Repull> ListSLA = new List<Repull>();
            List<Repull> ListRepull = new List<Repull>();
            string period = "";
            if (Convert.ToDateTime(txt_StartDate.Text).DayOfWeek.ToString() == "Monday")
                period = "%" + ExcelApplication.getIRCalendarWeek(Convert.ToDateTime(txt_StartDate.Text)) + "%";


             db_helper.getSLAChart("192.168.10.68", "T3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            //db_helper.getSLAChart("192.168.28.70", "T3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            //db_helper.getSLAChart("192.168.10.71", "t3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            //db_helper.getSLAChart("192.168.10.72", "T3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            //db_helper.getSLAChart("192.168.10.77", "T3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            //db_helper.getSLAChart("192.168.10.78", "T3ci94043", txt_StartDate.Text, txt_EndDate.Text, period);
            ListSLA = db_helper.getRePullChart();
            string startDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_StartDate.Text + " 00:00:00")).ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = AMESTime.BeijingTimeToAMESTime(Convert.ToDateTime(txt_EndDate.Text + " 23:59:59")).ToString("yyyy-MM-dd HH:mm:ss");

            db_hhelper.getRepullChart("192.168.10.68", "T3ci94043", startDate, endDate); 
            //db_hhelper.getRepullChart("192.168.28.70", "T3ci94043", startDate, endDate);
            //db_hhelper.getRepullChart("192.168.10.71", "t3ci94043", startDate, endDate);
            //db_hhelper.getRepullChart("192.168.10.72", "T3ci94043", startDate, endDate);
            //db_hhelper.getRepullChart("192.168.10.77", "T3ci94043", startDate, endDate);
            //db_hhelper.getRepullChart("192.168.10.78", "T3ci94043", startDate, endDate);
            ListRepull = db_hhelper.getRePullChart();
            int count = ListRepull.Count < ListSLA.Count ? ListRepull.Count : ListSLA.Count;
            for (int i = 0; i < count; i++)
            {

                ListSLA[i].c_ffilecount = ListRepull[i].c_filecount;
            }
                ChartSLA.DataSource = ListSLA;


        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string txtPath = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                txtPath = folderBrowserDialog.SelectedPath;
            }
            ChartSLA.ExportToImage(txtPath + "\\Chart.png", System.Drawing.Imaging.ImageFormat.Png);
           // ChartSLA.ExportToPdf(txtPath + "\\Chart.pdf");
        }
    }

    }
