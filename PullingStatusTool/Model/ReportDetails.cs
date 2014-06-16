using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    class ReportDetails
    {
        public ReportDetails(string ReportName, string ReportStatus, string DownLoadStatus, string FormatStatus, string UploadStatus)
        {

            this.reportname = ReportName;
            this.reportstatus = ReportStatus;
            this.downloadstatus = DownLoadStatus;
            this.formatstatus = FormatStatus;
            this.uploadstatus = UploadStatus;
        }

        string reportname;

        public string c_reportname
        {
            get { return reportname; }
            set { reportname = value; }
        }
        string reportstatus;

        public string c_reportstatus
        {
            get { return reportstatus; }
            set { reportstatus = value; }
        }
        string downloadstatus;

        public string c_downloadstatus
        {
            get { return downloadstatus; }
            set { downloadstatus = value; }
        }
        string formatstatus;

        public string c_formatstatus
        {
            get { return formatstatus; }
            set { formatstatus = value; }
        }
        string uploadstatus;

        public string c_uploadstatus
        {
            get { return uploadstatus; }
            set { uploadstatus = value; }
        }

    }
}
