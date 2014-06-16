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
    public partial class Frm_ReportDetail : DevExpress.XtraEditors.XtraForm
    {
        string server;
        string psw;
        string eid;
        string vendorName;
        string configName;
        string scheduleName;
        public Frm_ReportDetail()
        {
            InitializeComponent();
        }
        public Frm_ReportDetail(string serverIP,string password,string eid,string vendorname,string config,string schedule)
        {

            InitializeComponent();
            this.server = serverIP;
            this.psw = password;
            this.eid = eid;
            this.vendorName = vendorname;
            this.configName = config;
            this.scheduleName = schedule;
        }
          DB_Helper db_helper = new DB_Helper();
          List<ReportDetails> listReportDetail = new List<ReportDetails>();
        
        private void getDS()
        {
            if (eid!=""&&psw!=""&&server!="")
            {

                db_helper.getReportDetailData(eid, server, psw);
                listReportDetail=db_helper.getReportDetail();
                GC_ReportDetail.DataSource = listReportDetail;
            }
            else
            {
                MessageBox.Show("Error happened!!");
            }
        }

        private void getStatus()
        {
            int allFileCount = gridView1.RowCount;
            int formatFileCount = 0;
            int uploadFileCount =0;
            int downloadFileCount=0;
            foreach (ReportDetails report in listReportDetail)
            {
                if (report.c_downloadstatus == "Succeeded")
                {
                    downloadFileCount++;
                }

                if (report.c_formatstatus == "Succeeded")
                {
                    formatFileCount++;
                }
                if (report.c_uploadstatus == "Succeeded")
                {
                    uploadFileCount++;
                }
            }
            lbl_downloadsatus.Text += downloadFileCount + "/" + allFileCount;
            lbl_formatstatus.Text += formatFileCount + "/" + allFileCount;
            lbl_uploadstatus.Text += uploadFileCount + "/" + allFileCount;

        }

        private void Frm_ReportDetail_Load(object sender, EventArgs e)
        {
            getDS();
            getStatus();
            lbl_Vendor.Text += vendorName;
            lbl_ConcigName.Text += configName;
            lbl_ScheduleName.Text += scheduleName;
        }


    }
}