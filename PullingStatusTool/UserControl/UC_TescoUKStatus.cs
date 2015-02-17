using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Net;
using System.IO;
using PullingStatusTool.RestfulAPI;
namespace PullingStatusTool.UserControl
{
    public partial class UC_TescoUKStatus : UC_Functions
    {
        public UC_TescoUKStatus()
        {
            InitializeComponent();
            cbx_Date.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
        }
        private void getDS()
        {
            WCFRestfulAPI api = new WCFRestfulAPI();
            string html = "";
            html = api.GetTescoUKStatusHtm(txt_days.Text, cbx_Date.Text);
            wb_Status.DocumentText = html.Replace(@"\/","/").TrimStart('"').TrimEnd('"');
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void UC_TescoUKStatus_Load(object sender, EventArgs e)
        {
            cbx_Date.Text = DateTime.Now.AddDays(-1).ToShortDateString();
        }
    }
}
