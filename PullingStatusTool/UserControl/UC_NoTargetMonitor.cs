using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

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


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            getDS();
        }
        private void getDS()
        {

            GC_ManUplStas.DataSource = getReportExpect();

        }
        private List<ReportExpect> getReportExpect()
        {
            List<DataPullingFileCountStatus> ListFileStatus = new List<DataPullingFileCountStatus>();
            List<ReportExpect> ListReportExpect = new List<ReportExpect>();
            string dayofweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();//获取所选日期是星期几
            DB_Helper db_helper = new DB_Helper();
            string dayOfweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
            DataPullingFileCountStatus fileStatus = new DataPullingFileCountStatus();
            ListReportExpect = db_helper.getReportExpect("retailer!='Target'").Where(t => t.c_dayofweek.Contains(dayofweek)).ToList();//获得非Target的那些ExpectFile信息
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





    }
}
