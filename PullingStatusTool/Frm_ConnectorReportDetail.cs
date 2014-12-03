using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.App;

namespace PullingStatusTool
{
    public partial class Frm_ConnectorReportDetail : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ConnectorReportDetail()
        {
            InitializeComponent();
        }

        string reportSmryid = "";
        public Frm_ConnectorReportDetail(string reportsummaryid)
        {
            InitializeComponent();
            reportSmryid = reportsummaryid;
        }

        private void Frm_ConnectorReportDetail_Load(object sender, EventArgs e)
        {
            getDS();
        }

        void getDS()
        {
            BasketDBHelper conDBhelper = new BasketDBHelper();
            gc_Record.DataSource = conDBhelper.getReportDetail(reportSmryid);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }
    }
}