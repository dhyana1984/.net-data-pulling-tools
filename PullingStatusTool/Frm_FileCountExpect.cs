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
    public partial class Frm_FileCountExpect : DevExpress.XtraEditors.XtraForm
    {
        public Frm_FileCountExpect()
        {
            InitializeComponent();
        }
   

        private void Frm_FileCountExpect_Load(object sender, EventArgs e)
        {

            getDS();
          
        }
        
        private void getDS()
        {
        DB_Helper dbhelper = new DB_Helper();
        GC_FileExpect.DataSource=dbhelper.getReportExpect(" 1=1");
        
        }
        private void btn_AddFileExpect_Click(object sender, EventArgs e)
        {
            if (txt_dayofwk.Text.Trim()!=""&&txt_DataType.Text.Trim() != "" && txt_FileExpect.Text != ""  && txt_Vendor.Text != ""&&txt_Retailer.Text!="")
            {
                DB_Helper db = new DB_Helper();
                db.insertNewFileExpect(txt_dayofwk.Text.Trim(),txt_Vendor.Text, txt_DataType.Text, txt_SubGrp.Text, txt_FileExpect.Text,  txt_delay.Text,txt_Retailer.Text);
                getDS();
            }
            else
            {
                MessageBox.Show("Complete the blanks!");
            }
            
        }

        private void updateFileExpect(ReportExpect fileExpect)
        {
            DB_Helper db = new DB_Helper();
            db.editFileExpect(fileExpect);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                ReportExpect file = new ReportExpect();
                file.c_datatype = txt_DataType.Text;
                file.c_filexpectuploaded = txt_FileExpect.Text;
                file.c_subgroup = txt_SubGrp.Text;
                file.c_vendor = txt_Vendor.Text;
                file.c_dayofweek = txt_dayofwk.Text;
                file.c_expfileid = id;
                file.c_delayreason = txt_delay.Text;
                file.c_retailer = txt_Retailer.Text.Trim();
                updateFileExpect(file);
                id = "";
            }

            getDS();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DB_Helper db = new DB_Helper();
            string id = gridView1.GetFocusedRowCellValue("c_expfileid").ToString().Trim();
            db.deleteFileExpect(id);
            getDS();
        }
         string id = "";
        private void GC_FileExpect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            if (gridView1.GetFocusedRowCellValue("c_filexpectuploaded") != null)
            {
                string vendor = gridView1.GetFocusedRowCellValue("c_vendor").ToString().Trim();
                string dataType = gridView1.GetFocusedRowCellValue("c_datatype").ToString().Trim();
                string subGroup = gridView1.GetFocusedRowCellValue("c_subgroup").ToString().Trim();
                string fileCount = gridView1.GetFocusedRowCellValue("c_filexpectuploaded").ToString().Trim();
                string delayreason = gridView1.GetFocusedRowCellValue("c_delayreason").ToString().Trim();
                id = gridView1.GetFocusedRowCellValue("c_expfileid").ToString().Trim();
                string dayOfWeek = gridView1.GetFocusedRowCellValue("c_dayofweek").ToString().Trim();
                string retailer = gridView1.GetFocusedRowCellValue("c_retailer").ToString().Trim();
                txt_dayofwk.Text = dayOfWeek;
                txt_DataType.Text = dataType;
                txt_FileExpect.Text=fileCount;
                txt_SubGrp.Text = subGroup;
                txt_Vendor.Text = vendor;
                txt_delay.Text = delayreason;
                txt_Retailer.Text = retailer;
          
            }

        }

    }
}