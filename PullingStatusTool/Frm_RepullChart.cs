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
        DB_Helper dbhelper = new DB_Helper();
        GC_FileExpect.DataSource=dbhelper.getReportExpect();
        
        }





         private void txt_Vendor_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
         {
          gridView1.ActiveFilterString = "c_vendor Contains " + txt_Vendor + "";
          //   gridView1.ShowFilterEditor
            // MessageBox.Show(gridView1.ActiveFilterString);
       
         }

         private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
         {
        
         }

         private void FuzzyQuery()
         {
             string newFilter = string.Empty;
             string filter = gridView1.ActiveFilterString;

             gridView1.ActiveFilterString = newFilter;
         }  
        }



    
}