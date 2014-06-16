using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool.Model
{
    class PullingPerformance
    {
        public PullingPerformance(string Vendor, string DataType, string OnTimeUpload, string LateUpload,string OnTimeFormat, string LateFormat, string FirstFormatTime, string LastFormatTime)
        {
             vendor = Vendor;
             datetype = DataType;
             ontimeupload=OnTimeUpload;
             lateupload=LateUpload;
             ontimeformat=OnTimeFormat;
             lateformat=LateFormat;
             firstformattime=FirstFormatTime;
             lastformattime = LastFormatTime;
        
        }

        string vendor;

        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }
        string datetype;

        public string c_datatype
        {
            get { return datetype; }
            set { datetype = value; }
        }
        string ontimeupload;

        public string c_ontimeupload
        {
            get { return ontimeupload; }
            set { ontimeupload = value; }
        }
        string lateupload;

        public string c_lateupload
        {
            get { return lateupload; }
            set { lateupload = value; }
        }
        string ontimeformat;

        public string c_ontimeformat
        {
            get { return ontimeformat; }
            set { ontimeformat = value; }
        }
        string lateformat;

        public string c_lateformat
        {
            get { return lateformat; }
            set { lateformat = value; }
        }
        string firstformattime;

        public string c_firstformattime
        {
            get { return firstformattime; }
            set { firstformattime = value; }
        }
        string lastformattime;

        public string c_lastformattime
        {
            get { return lastformattime; }
            set { lastformattime = value; }
        }

    }
}
