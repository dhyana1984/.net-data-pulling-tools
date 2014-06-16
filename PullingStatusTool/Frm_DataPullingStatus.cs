using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PullingStatusTool
{
    public partial class Frm_DataPullingStatus : Form
    {
        public Frm_DataPullingStatus()
        {
            InitializeComponent();
        }

        private void Frm_DataPullingStatus_Load(object sender, EventArgs e)
        {
            initialDate();

        }

        private void initialDate()
        {
            txt_StartDate.Text = DateTime.Now.ToShortDateString();
            txt_EndDate.Text = DateTime.Now.ToShortDateString();

        }

        private void getDS()
        {
            if (Convert.ToDateTime(txt_EndDate.Text).CompareTo(Convert.ToDateTime(txt_StartDate.Text)) >= 0)
            {
                DB_Helper db_heler = new DB_Helper();
                if (ckbx_68.Checked)
                {
                    db_heler.getStatusData("192.168.10.68", "T3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");

                }
                if (ckbx_70.Checked)
                {
                    db_heler.getStatusData("192.168.28.70", "T3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");
                }
                if (ckbx_71.Checked)
                {
                    db_heler.getStatusData("192.168.10.71", "t3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");
                }
                if (ckbx_72.Checked)
                {
                    db_heler.getStatusData("192.168.10.72", "T3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");
                }
                if (ckbx_77.Checked)
                {
                    db_heler.getStatusData("192.168.10.77", "T3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");
                }
                if (ckbx_78.Checked)
                {
                    db_heler.getStatusData("192.168.10.78", "T3ci94043", txt_StartDate.Text + " 00:00:00", txt_EndDate.Text + " 23:59:59");
                }
                GC_PullingStatus.DataSource = db_heler.getServerStatus();
            }
            else
            {
                MessageBox.Show("Error!End Date must after start date!");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }

        private void GC_PullingStatus_DoubleClick(object sender, EventArgs e)
        {
            int selectedHandle;
            if (this.gridView1.SelectedRowsCount>0)
            {
                selectedHandle = this.gridView1.GetSelectedRows()[0];
                if (gridView1.GetRowCellValue(selectedHandle, "c_eventid") != null)
                {
                    string eventID = gridView1.GetRowCellValue(selectedHandle, "c_eventid").ToString();
                    string serverIP = gridView1.GetRowCellValue(selectedHandle, "c_serverIP").ToString();
                    string passwd = gridView1.GetRowCellValue(selectedHandle, "c_password").ToString();
                    string vendor = gridView1.GetRowCellValue(selectedHandle, "c_vendor").ToString();
                    string dataType = gridView1.GetRowCellValue(selectedHandle, "c_dataType").ToString();
                    string configname = gridView1.GetRowCellValue(selectedHandle, "c_configName").ToString();
                    Frm_ReportDetail frm_reportdetail = new Frm_ReportDetail(serverIP, passwd, eventID, vendor, configname, dataType);
                    frm_reportdetail.ShowDialog();
                }

            }

           
            
        }
    }
}