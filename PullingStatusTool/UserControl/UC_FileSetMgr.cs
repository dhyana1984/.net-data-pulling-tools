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

        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {   
                if (checkTextbox())
                {
                    UploadFileSet fileset = new UploadFileSet();
                    DB_Helper dbhelper = new DB_Helper();
                    fileset.c_dayof = cbx_Freq.Text;
                    fileset.c_downloadpath = txt_downloadpath.Text;
                    fileset.c_filetype = txt_filetype.Text;
                    fileset.c_flag = cbx_enable.Checked;
                    fileset.c_freqency = cbx_Freq.Text;
                    fileset.c_retailer = txt_retailer.Text;
                    fileset.c_slatime = txt_SLA.Text;
                    fileset.c_vendor = txt_vendor.Text;
                    fileset.c_datalag = int.Parse(txtDatalag.Text);
                    fileset.c_fileextend = txt_FileExten.Text;
                    fileset.c_isreupload = ckx_ReUploadLimit.Checked;
                    if (dbhelper.addFileSet(fileset, cbx_addExpectFile.Checked))
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
            gridView1.BestFitColumns();
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
                txt_FileExten.Text = gridView1.GetFocusedRowCellValue("c_fileextend").ToString();
                ckx_ReUploadLimit.Checked = (bool)gridView1.GetFocusedRowCellValue("c_reupload");

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
                    fileset.c_fileextend = txt_FileExten.Text;
                    fileset.c_isreupload=ckx_ReUploadLimit.Checked;
                    if (dbhelper.editFileSet(fileset,cbx_addExpectFile.Checked))
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
               ShowMessage("Fill the Download Path!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_filetype.Text))
            {
               ShowMessage("Fill the File Type!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_retailer.Text))
            {
               ShowMessage("Fill the Retailer!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_vendor.Text))
            {
               ShowMessage("Fill the Vendor!");
                return false;
            }
            return true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
       
                if (FileSetid != "")
                {
                    DB_Helper dbhelper = new DB_Helper();
                    if (dbhelper.deleteFileSet(FileSetid))
                        getDS();

                }
            }
        


    }
}
