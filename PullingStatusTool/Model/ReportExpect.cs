using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
 public   class ReportExpect
    {
        public ReportExpect() { }

        public ReportExpect(string id, string day, string vendor, string datatype, string subgroup, string fileexceptupload,string delay,string finTime,string retailer)
        {

            this.vendor = vendor;
            this.subgroup = subgroup;
            this.fileExpectUpload = fileexceptupload;
            this.datatype = datatype;
            this.expFileID = id;
            this.dayofweek = day;
            this.delayreason = delay;
           // this.finishTime = finishTime;
            this.retailer = retailer;
        }
        string freqency;

        public string c_freqency
        {
            get { return freqency; }
            set { freqency = value; }
        }


        string retailer;

        public string c_retailer
        {
            get { return retailer; }
            set { retailer = value; }
        }
        string finishtime;

        public string c_finishtime
        {
            get { return finishtime; }
            set { finishtime = value; }
        }
        string delayreason;

        public string c_delayreason
        {
            get { return delayreason; }
            set { delayreason = value; }
        }

        string finishupload;

        public string c_finishuploaded
        {
            get { return finishupload; }
            set { finishupload = value; }
        }
        string finishformatted;

        public string c_finishformatted
        {
            get { return finishformatted; }
            set { finishformatted = value; }
        }

        string status;
        public string c_status
        {
            get { return status; }
            set { status = value; }
        }
        string serverIP;

        public string c_serverIP
        {
            get { return serverIP; }
            set { serverIP = value; }
        }

        string dayofweek;

        public string c_dayofweek
        {
            get { return dayofweek; }
            set { dayofweek = value; }
        }
        string expFileID;

        public string c_expfileid
        {
            get { return expFileID; }
            set { expFileID = value; }
        }
        string datatype;

        public string c_datatype
        {
            get { return datatype; }
            set { datatype = value; }
        }

        string subgroup;

        public string c_subgroup
        {
            get { return subgroup; }
            set { subgroup = value; }
        }

        string vendor;

        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        string fileExpectUpload;

        public string c_filexpectuploaded
        {
            get { return fileExpectUpload; }
            set { fileExpectUpload = value; }
        }

        string fileExpectFormatted;

        public string c_filexpectformatted
        {
            get { return fileExpectFormatted; }
            set { fileExpectFormatted = value; }
        }

    }
}
