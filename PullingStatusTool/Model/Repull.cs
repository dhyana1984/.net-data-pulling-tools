using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    public class Repull
    {
        public Repull()
        {
   
        }

        public Repull(string vendor, string fileCount)
        {
            this.Vendor = vendor;
            this.FileCount = int.Parse(fileCount);
        }
        public Repull(string repullDate, string fileCount,string Chart)
        {
            this.RepullDate = repullDate;
            this.FileCount = int.Parse(fileCount);
        }
        string RepullDate;

        public string c_repulldate
        {
            get { return RepullDate; }
            set { RepullDate = value; }
        }
        string Vendor;

        public string c_vendor
        {
            get { return Vendor; }
            set { Vendor = value; }
        }
        int FileCount;

        public int c_filecount
        {
            get { return FileCount; }
            set { FileCount = value; }
        }
        private int C_FFilecount;

        public int c_ffilecount
        {
            get { return C_FFilecount; }
            set { C_FFilecount = value; }
        }

        string retailer;

        public string c_retailer
        {
            get { return retailer; }
            set { retailer = value; }
        }

    }


    public class TargetRepullList
    {
        string creater;

        public string c_creater
        {
            get { return creater; }
            set { creater = value; }
        }
        string repullstatus;

        public string c_repullstatus
        {
            get { return repullstatus; }
            set { repullstatus = value; }
        }

        string account;

        public string c_account
        {
            get { return account; }
            set { account = value; }
        }
        string serverip;

        public string c_serverip
        {
            get { return serverip; }
            set { serverip = value; }
        }

        string isneedupload;
        public string c_isneedupload
        {
            get { return isneedupload; }
            set { isneedupload = value; }
        }
        string isneedformat;

        public string c_isneedformat
        {
            get { return isneedformat; }
            set { isneedformat = value; }
        }
        string createdate;

        DateTime FinishBefore;

        public DateTime c_finishbefore
        {
            get { return FinishBefore; }
            set { FinishBefore = value; }
        }

        DateTime creatime;

        public DateTime c_creatime
        {
            get { return creatime; }
            set { creatime = value; }
        }
        public string c_createdate
        {
            get { return createdate; }
            set { createdate = value; }
        }
        string eta;

        public string c_eta
        {
            get { return eta; }
            set { eta = value; }
        }
        string reportname;

        public string c_reportname
        {
            get { return reportname; }
            set { reportname = value; }
        }

        string Vendor;

        public string c_vendor
        {
            get { return Vendor; }
            set { Vendor = value; }
        }
        string retailer;

        public string c_retailer
        {
            get { return retailer; }
            set { retailer = value; }
        }

        string id;

        public string c_id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
