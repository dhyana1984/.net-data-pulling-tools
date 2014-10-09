using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PullingStatusTool
{
    public partial class Frm_UploadRecord : DevExpress.XtraEditors.XtraForm
    {
        public Frm_UploadRecord()
        {
            InitializeComponent();
        }

        private void Frm_UploadRecord_Load(object sender, EventArgs e)
        {
            txt_STtime.Text="1/1 2014";
            txt_EDtime.Text=DateTime.Now.ToShortDateString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void getDS()
        {
            DB_Helper dbhelper = new DB_Helper();
            string STTime = txt_STtime.Text + " 00:00:00";
            string EDTime =txt_EDtime.Text + " 23:59:59";
            string isSLA = "All";
            string isOngoing = "All";
            switch (Rdg_SLA.SelectedIndex)
            {
                case 1:
                    isSLA = "true";
                    break;
                case 2:
                    isSLA = "false";
                    break;
            }
            switch (Rdg_ongoing.SelectedIndex)
            {
                case 1:
                    isOngoing = "true";
                    break;
                case 2:
                    isOngoing = "false";
                    break;
            }
            gridControl1.DataSource = dbhelper.getUploadRecord(STTime, EDTime, isOngoing,isSLA); 
                    
        
        }
    }
}