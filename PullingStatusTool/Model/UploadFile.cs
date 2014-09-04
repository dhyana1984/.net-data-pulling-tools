using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


        public class UploadFilePath
        {
            public UploadFilePath()
            { }

            public UploadFilePath(string id, string filesetid, string path, string pathname)
            {
                ID = id;
                Filesetid = filesetid;
                Uploadpaths = path;
                Pathname = pathname;

            }
            string ID;

            public string c_id
            {
                get { return ID; }
                set { ID = value; }
            }
            string Filesetid;

            public string c_filesetid
            {
                get { return Filesetid; }
                set { Filesetid = value; }
            }
            string Uploadpaths;

            public string c_uploadpath
            {
                get { return Uploadpaths; }
                set { Uploadpaths = value; }
            }
            string Pathname;

            public string c_pathname
            {
                get { return Pathname; }
                set { Pathname = value; }
            }
            string FileType;


        }

        public class UploadFileSet
        {
            public UploadFileSet()
            { }

            public UploadFileSet(string id, string retailer, string vendor, string downloadpath, string fileType, string slatime, string frequency, string dayof, bool flag)
            {
                ID = id;
                Retailer = retailer;
                Vendor = vendor;
                DownloadPath = downloadpath;
                FileType = fileType;
                SLATime = slatime;
                Frequency = frequency;
                DayOf = dayof;
                Flag = flag;
            }
            string ID;

            public string c_id
            {
                get { return ID; }
                set { ID = value; }
            }
            string Retailer;

            public string c_retailer
            {
                get { return Retailer; }
                set { Retailer = value; }
            }
            string Vendor;

            public string c_vendor
            {
                get { return Vendor; }
                set { Vendor = value; }
            }
            string DownloadPath;

            public string c_downloadpath
            {
                get { return DownloadPath; }
                set { DownloadPath = value; }
            }
            string FileType;

            public string c_filetype
            {
                get { return FileType; }
                set { FileType = value; }
            }
            string SLATime;

            public string c_slatime
            {
                get { return SLATime; }
                set { SLATime = value; }
            }
            string Frequency;

            public string c_freqency
            {
                get { return Frequency; }
                set { Frequency = value; }
            }
            string DayOf;

            public string c_dayof
            {
                get { return DayOf; }
                set { DayOf = value; }
            }
            bool Flag;

            public bool c_flag
            {
                get { return Flag; }
                set { Flag = value; }
            }
        }
    }


