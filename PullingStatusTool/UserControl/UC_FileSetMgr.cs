using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PullingStatusTool.UserControl
{
    public partial class UC_FileSetMgr : UC_Functions
    {
        public UC_FileSetMgr()
        {
            InitializeComponent();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkTextbox())
            {
                UploadFileSet fileset = new UploadFileSet();
                DB_Helper dbhelper = new DB_Helper();
                fileset.c_dayof = cbx_Dayof.Text;
                fileset.c_downloadpath = txt_downloadpath.Text;
                fileset.c_filetype = txt_filetype.Text;
                fileset.c_flag = cbx_enable.Checked;
                fileset.c_freqency = cbx_Freq.Text;
                fileset.c_retailer = txt_retailer.Text;
                fileset.c_slatime = txt_SLA.Text;
                fileset.c_vendor = txt_vendor.Text;
                fileset.c_datalag = int.Parse(txtDatalag.Text);
                if (dbhelper.addFileSet(fileset))
                {
                    getDS();
                }
            }

        }

        private void FileUploadManage_Load(object sender, EventArgs e)
        {
            getDS();
        }
        private void getDS()
        {
            DB_Helper dbhelper = new DB_Helper();

            gridControl1.DataSource = dbhelper.getFileSet();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("c_id") != null)
            {
                txt_vendor.Text = gridView1.GetFocusedRowCellValue("c_vendor").ToString().Trim();
                txt_filetype.Text = gridView1.GetFocusedRowCellValue("c_filetype").ToString().Trim();
                txt_retailer.Text = gridView1.GetFocusedRowCellValue("c_retailer").ToString().Trim();
                txt_SLA.EditValue= gridView1.GetFocusedRowCellValue("c_slatime").ToString().Trim();
                cbx_Freq.Text = gridView1.GetFocusedRowCellValue("c_freqency").ToString().Trim();
                FileSetid = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                cbx_Dayof.Text = gridView1.GetFocusedRowCellValue("c_dayof").ToString().Trim();
                txt_downloadpath.Text = gridView1.GetFocusedRowCellValue("c_downloadpath").ToString().Trim();
                cbx_enable.Checked = (bool)gridView1.GetFocusedRowCellValue("c_flag");
                txtDatalag.Text = gridView1.GetFocusedRowCellValue("c_datalag").ToString();



            }
        }
        string FileSetid = "";
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int selectedHandle;
            if (this.gridView1.SelectedRowsCount > 0)
            {
                selectedHandle = this.gridView1.GetSelectedRows()[0];
                if (gridView1.GetRowCellValue(selectedHandle, "c_id") != null)
                {
                    string id = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                    string vendor = gridView1.GetFocusedRowCellValue("c_vendor").ToString().Trim();
                    string filetype = gridView1.GetFocusedRowCellValue("c_filetype").ToString().Trim();
                    string retailer = gridView1.GetFocusedRowCellValue("c_retailer").ToString().Trim();
                    Frm_UploadPath Frm_uploadpath = new Frm_UploadPath(id, retailer, vendor, filetype);
                    Frm_uploadpath.Show();
                }
            }
        }

        private void cbx_Freq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Freq.Text == "Daily")
            {
                cbx_Dayof.Enabled = false;

            }
            else
            {
                cbx_Dayof.Enabled = true;

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkTextbox())
            {
                if (FileSetid != "")
                {
                    UploadFileSet fileset = new UploadFileSet();
                    DB_Helper dbhelper = new DB_Helper();
                    fileset.c_dayof = cbx_Dayof.Text;
                    fileset.c_downloadpath = txt_downloadpath.Text;
                    fileset.c_filetype = txt_filetype.Text;
                    fileset.c_flag = cbx_enable.Checked;
                    fileset.c_freqency = cbx_Freq.Text;
                    fileset.c_retailer = txt_retailer.Text;
                    fileset.c_slatime = txt_SLA.Text;
                    fileset.c_vendor = txt_vendor.Text;
                    fileset.c_id = FileSetid;
                    fileset.c_datalag = int.Parse(txtDatalag.Text);
                    if (dbhelper.editFileSet(fileset))
                    {
                        getDS();
                    }
                }


            }
        }

        private bool checkTextbox()
        {

            if (string.IsNullOrEmpty(txt_downloadpath.Text))
            {
                MessageBox.Show("Fill the Download Path!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_filetype.Text))
            {
                MessageBox.Show("Fill the File Type!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_retailer.Text))
            {
                MessageBox.Show("Fill the Retailer!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_vendor.Text))
            {
                MessageBox.Show("Fill the Vendor!");
                return false;
            }
            return true;
        }
    }
}
