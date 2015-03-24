using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Threading;
namespace PullingStatusTool.UserControl
{
    public partial class UC_NoTargetMonitor : UC_Functions
    {
        public UC_NoTargetMonitor()
        {
            InitializeComponent();
        }


        private void Frm_ManuUplStas_Load(object sender, EventArgs e)
        {
            drp_DailyDate.Text = AMESTime.AMESTimeToBeijingTime(DateTime.Now).ToString("yyyy-MM-dd");
        }

        private void updateGridControl(DevExpress.XtraGrid.GridControl ctr, List<ReportExpect> ds)
        {

            ctr.DataSource = ds;
        }
        private void UpdateBarstats(MarqueeProgressBarControl ctrl)
        {

            ctrl.Visible = ctrl.Visible ? false : true;
        }
        delegate void UpdateGridControl(DevExpress.XtraGrid.GridControl ctr, List<ReportExpect> ds);
        private delegate void UpdateBarDelegate(MarqueeProgressBarControl ctl);
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //ThreadStart pt = new ThreadStart(getDS);
            //Thread t = new Thread(pt);
            //t.IsBackground = true;
            //t.Start();

            getDS();
        }
        private void getDS()
        {
            UpdateBarDelegate upbar = new UpdateBarDelegate(UpdateBarstats);
       //     Bar_LoadingStatus.Invoke(upbar, Bar_LoadingStatus);
            UpdateGridControl upc = new UpdateGridControl(updateGridControl);
          //  GC_ManUplStas.Invoke(upc, new object[] { GC_ManUplStas, getReportExpect() });
         GC_ManUplStas.DataSource = getReportExpect();
          //  Bar_LoadingStatus.Invoke(upbar, Bar_LoadingStatus);

        }
        private List<ReportExpect> getReportExpect()
        {
            List<DataPullingFileCountStatus> ListFileStatus = new List<DataPullingFileCountStatus>();
            List<ReportExpect> ListReportExpect = new List<ReportExpect>();
            string dayofweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();//获取所选日期是星期几
            DB_Helper db_helper = new DB_Helper();
            string dayOfweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
            DataPullingFileCountStatus fileStatus = new DataPullingFileCountStatus();
            ListReportExpect = db_helper.getReportExpect("retailer!='Target' and retailer!='TescoUK' ").Where(t => t.c_dayofweek.Contains(dayofweek)).ToList();//获得非Target的那些ExpectFile信息
            ListFileStatus = db_helper.getNoTargetFileCount(drp_DailyDate.Text);//根据所选日期，获得当天取的那些report
            string vendor = "";
            string retailer = "";
            string datatype = "";
            string fileCount = "";
            foreach (ReportExpect file in ListReportExpect)
            {
                vendor = file.c_vendor.ToLower().Trim();//应该取数据的vendor
                retailer = file.c_retailer.ToLower().Trim();//应该取数据的retailer
                datatype = file.c_datatype.ToLower().Trim();//应该取的数据类型
                var temp = ListFileStatus.Where(t =>      //根据应该取数据的vendor, retailer, datatype来匹配取下来的数据记录
                                    t.c_vendor.ToLower().Trim() == vendor &&
                                    t.c_retailer.ToLower().Trim() == retailer &&
                                    t.c_dataType.ToLower().Trim() == datatype);

                fileCount = temp.Count() > 0 ? temp.ToList()[0].c_filecount : "0";  //如果取了应该取的数据，则可以拿到取数据的个数
                file.c_filexpectuploaded = fileCount + "/" + file.c_filexpectuploaded;//把实际取的数据个数和应该取的数据个数拼接取来，例子:3/5
                file.c_finishuploaded = (file.c_filexpectuploaded.Split('/')[0] == file.c_filexpectuploaded.Split('/')[1]) && file.c_filexpectuploaded.Split('/')[0] != "0" ? "Y" : "N";//如果实际取的数据和应该取的数据相同，则显示Y，反之则是N
                file.c_finishtime = temp.Count() > 0 ? temp.ToList()[0].c_finishTime.ToString() : "";//取最后一个文件的时间


            }
            return ListReportExpect;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gridView1.GetRow(e.RowHandle) == null)
                return;
            else
            {
                string aa = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["c_filexpectuploaded"]);
                if (aa.Split('/')[0] == "0")
                {
                    e.Appearance.BackColor = Color.Gold;
                    e.Appearance.BackColor2 = Color.Gold;
                }

            }
        }





    }
}
