using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace PullingStatusTool
{
    public partial class Frm_RepullChart : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RepullChart()
        {
            InitializeComponent();
        }
        string startDate = "";
        string endDate = "";
        List<Repull> Repull = new List<Repull>();
        bool ckbx_68;
        bool ckbx_70;
        bool ckbx_71;
        bool ckbx_72;
        bool ckbx_77;
        bool ckbx_78;
        public Frm_RepullChart(string STdate, string ENDdate, bool cbx68, bool cbx70, bool cbx71, bool cbx72, bool cbx77, bool cbx78)
        {
            InitializeComponent();
            startDate = STdate;
            endDate = ENDdate;
            ckbx_68 = cbx68;
            ckbx_70 = cbx70;
            ckbx_71 = cbx71;
            ckbx_72 = cbx72;
            ckbx_77 = cbx77;
            ckbx_78 = cbx78;
        }

        private void Frm_RepullChart_Load(object sender, EventArgs e)
        {

            getDS();
        }
       
       
        private void getDS()
        {
            DB_Helper db_heler = new DB_Helper();
            List<Repull> ListRepullChart = new List<Repull>();
                if (ckbx_68)
                {
                    db_heler.getRepullChart("192.168.10.68", "T3ci94043", startDate, endDate);
                }
                if (ckbx_70)
                {
                    db_heler.getRepullChart("192.168.28.70", "T3ci94043", startDate, endDate);
                }
                if (ckbx_71)
                {
                    db_heler.getRepullChart("192.168.10.71", "t3ci94043", startDate, endDate);
                }
                if (ckbx_72)
                {
                    db_heler.getRepullChart("192.168.10.72", "T3ci94043", startDate, endDate);
                }
                if (ckbx_77)
                {
                    db_heler.getRepullChart("192.168.10.77", "T3ci94043", startDate, endDate);
                }
                if (ckbx_78)
                {
                    db_heler.getRepullChart("192.168.10.78", "T3ci94043", startDate, endDate);
                }
             ListRepullChart = db_heler.getRePullChart();

             Chart_Repull.DataSource = null;
             Chart_Repull.DataSource = ListRepullChart;
            
                   
        }



    }
}