using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.UIControl;
using System.IO;
using System.Net;
using PullingStatusTool.RestfulAPI;
using PullingStatusTool.App;


namespace PullingStatusTool
{
    public partial class Frm_Password : XtaFrm_Skin
    {
        public Frm_Password()
        {
            InitializeComponent();
        }
        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void validPassword()
        {
            if (txt_password.Text == "T3ci94043")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
               ShowMessage("Sorry, you don't have access to this form");
                txt_password.SelectAll();
                txt_password.Focus();
            }
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            validPassword();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)     //检测是否按Enter键
            {
                validPassword();
            
            }
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //  //  string url = "http://localhost:8002/test/PostTestAPI";
        //  ////  string url = "http://localhost:8002/test/1";
        //  //  WebClient WC = new WebClient();
        //  //  UploadFilePath patha = new UploadFilePath("aa", "aa", "aa", "aa");
        //  //  UploadFilePath pathb = new UploadFilePath("bb", "bb", "bb", "bb");
        //  //  List<UploadFilePath> listPath = new List<UploadFilePath>();
        //  //  listPath.Add(patha);
        //  //  listPath.Add(pathb);
        //  //  string json = JsonHelper.JsonSerializer<List<UploadFilePath>>(listPath);
        //  //  WC.Headers[HttpRequestHeader.ContentType] = "application/json";

        //  //  string isSucess = WC.UploadString(url, "POST", json);
        //  //  //UploadFilePath path = new UploadFilePath();
        //  //  //string result = WC.DownloadString(url);
        //}



    }
}