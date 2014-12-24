using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.UIControl;

namespace PullingStatusTool
{
    public partial class Frm_UploadPath : XtaFrm_Skin
    {
        public Frm_UploadPath()
        {
            InitializeComponent();
        }
        string FileSetid = "";
        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Frm_UploadPath(string FileSetid,string retailer,string vendor, string filetype)
        {
            InitializeComponent();
            this.FileSetid = FileSetid;
            lbl_FileSet.Text = "FileSet: " + retailer + " " + vendor + " " + filetype;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_uploadpath.Text != "")
            {
                UploadFilePath uploadpath = new UploadFilePath();
                DB_Helper dbhelper = new DB_Helper();
                uploadpath.c_filesetid = FileSetid;
                uploadpath.c_pathname = txt_pathName.Text;
                uploadpath.c_uploadpath = txt_uploadpath.Text;
                if(dbhelper.addUploadPath(uploadpath))
                   getDS();
            }
            else
            {

               ShowMessage("Fill the path!");
            }

        }

        private void UploadPath_Load(object sender, EventArgs e)
        {
            getDS();
        }

        private void getDS()
        {
            DB_Helper dbhelp = new DB_Helper();
            gridControl1.DataSource = dbhelp.getUploadPath(FileSetid);
        
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_uploadpath.Text != ""&&pathid!="")
            {
                UploadFilePath uploadpath = new UploadFilePath();
                DB_Helper dbhelper = new DB_Helper();
                uploadpath.c_pathname = txt_pathName.Text;
                uploadpath.c_uploadpath = txt_uploadpath.Text;
                uploadpath.c_id = pathid;
                if(dbhelper.editUploadPath(uploadpath))
                 getDS();
                
            }
            else
            {
               ShowMessage("Fill the path!");
            }
        }
        string pathid = "";
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("c_id") != null)
            {
                pathid = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                txt_pathName.Text = gridView1.GetFocusedRowCellValue("c_pathname").ToString().Trim();
                txt_uploadpath.Text = gridView1.GetFocusedRowCellValue("c_uploadpath").ToString().Trim();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
                pathid = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                DB_Helper dbhelper = new DB_Helper();
                if(dbhelper.deleteUploadPath(pathid))
                 getDS();
                
         
            
        }

    }
}