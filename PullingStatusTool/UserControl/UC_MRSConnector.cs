using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.Model;
using PullingStatusTool.App;
namespace PullingStatusTool.UserControl
{
    public partial class UC_MRSConnector :UC_Functions
    {
        public UC_MRSConnector()
        {
            InitializeComponent();
        }

        private void UC_MRSConnector_Load(object sender, EventArgs e)
        {

            txt_RecordTime.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }


        private void getScheduleDS()
        {
            MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
            gc_Schedule.DataSource = MorrisonConnector.getAllSchedule();
        
        }

        private void btn_SchedueRefresh_Click(object sender, EventArgs e)
        {
            getScheduleDS();
        }

        string Scheduleid = "";
        private void gc_Schedule_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("c_id") != null)
            {
                txt_Configname.Text = gridView1.GetFocusedRowCellValue("c_configname").ToString().Trim();
                cbx_Enable.Checked = (bool)gridView1.GetFocusedRowCellValue("c_enable");
                txt_NextRunTime.Text = gridView1.GetFocusedRowCellValue("c_nextruntime").ToString().Trim();
                txt_Time.EditValue = gridView1.GetFocusedRowCellValue("c_time").ToString().Trim();
                Scheduleid = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                txt_datelag.Text = gridView1.GetFocusedRowCellValue("c_datelag").ToString().Trim();

            }
        }

        private void btn_Runnow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to RunNow?","Confirm to run", messButton);
            if (dr == DialogResult.OK)
            {
                string ids = "";
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if ((bool)gridView1.GetRowCellValue(i, "c_selected"))
                    ids += gridView1.GetRowCellValue(i, "c_id") + ",";//将显示在grid表格中的id传入runnow方法，批量runnow
                }
                MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
                MorrisonConnector.runNowSchedules(ids.TrimEnd(','));
                getScheduleDS();
            }
        }

        private void btn_BulkEdit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to Edit?", "Confirm to edit", messButton);
            if (dr == DialogResult.OK)
            {
                MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
                ConnectorSchedule schedule = new ConnectorSchedule();
                schedule.c_configname = txt_Configname.Text;
                schedule.c_datelag = txt_datelag.Text;
                schedule.c_enable = cbx_Enable.Checked;
                schedule.c_nextruntime = txt_NextRunTime.Text;
                schedule.c_time = txt_Time.Text;
                schedule.c_id = Scheduleid;
                if (Scheduleid != "")
                {
                    MorrisonConnector.EditSchedules(schedule);
                    getScheduleDS();
                }
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
             MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
             ConnectorAccount account = new ConnectorAccount();
             account.c_accountname = txt_Account.Text;
             account.c_password = txt_Password.Text;
                if (userid != "")
                {
                    account.c_id = userid;
                    MorrisonConnector.editAccount(account);
                    getAccountDS();
                }
            
        }

        private void btn_RfreshAccount_Click(object sender, EventArgs e)
        {
            getAccountDS();
        }

        private void getAccountDS()
        {
            MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
            gc_Account.DataSource = MorrisonConnector.getAllAccount();
        }

        string userid = "";
        private void gc_Account_DoubleClick(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("c_id") != null)
            {
                txt_Account.Text = gridView3.GetFocusedRowCellValue("c_accountname").ToString().Trim();
                txt_Password.Text = gridView3.GetFocusedRowCellValue("c_password").ToString().Trim();
                txt_Suffix.Text = gridView3.GetFocusedRowCellValue("c_suffix").ToString().Trim();
                userid = gridView3.GetFocusedRowCellValue("c_id").ToString();

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            getRecordDS();
        }
        private void getRecordDS()
        {
       
            MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
            gc_Record.DataSource = MorrisonConnector.getAllRecord(txt_RecordTime.Text);

        }

        private void getNullInstance()
        {
            MorrisonDBHelper MorrisonConnector = new MorrisonDBHelper();
            List<ConnectorSchedule> Listschedule = new List<ConnectorSchedule>();
            Listschedule = MorrisonConnector.getNullInstance();
            foreach(ConnectorSchedule schedule in Listschedule)
            {
                lbx_NullInstance.Items.Add(schedule.c_id + " " + schedule.c_configname);
            }
        
        }

        private void gc_Schedule_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "c_selected" && gridView1.SelectedRowsCount > 0)
            {
                         gridView1.SetFocusedRowCellValue("c_selected", !(bool)gridView1.GetFocusedRowCellValue("c_selected"));
            }
        }







    }
}
