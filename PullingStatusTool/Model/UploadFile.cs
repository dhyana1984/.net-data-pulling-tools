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

      public  class UploadRecord
        {
          public UploadRecord()
          { }
          public UploadRecord(string id, string retailer, string vendor, string downloadpath, string uploadpath, string uploadtime, bool issla, bool isongoing, string filetype,string filename)
          {
              Id = id;
              Retailer = retailer;
              Vendor = vendor;
              Downloadpath = downloadpath;
              Uploadpath = uploadpath;
              UploadTime = uploadtime;
              isSLA = issla;
              isOngoing = isongoing;
              FileType = filetype;
              FileName = filename;
          }
          string Id;

          public string c_id
          {
              get { return Id; }
              set { Id = value; }
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
          string Downloadpath;

          public string c_downloadpath
          {
              get { return Downloadpath; }
              set { Downloadpath = value; }
          }
          string Uploadpath;

          public string c_uploadpath
          {
              get { return Uploadpath; }
              set { Uploadpath = value; }
          }
          string UploadTime;

          public string c_uploadtime
          {
              get { return UploadTime; }
              set { UploadTime = value; }
          }
          bool isSLA;

          public bool c_issla
          {
              get { return isSLA; }
              set { isSLA = value; }
          }
          bool isOngoing;

          public bool c_isongoing
          {
              get { return isOngoing; }
              set { isOngoing = value; }
          }
          string FileType;

          public string c_filetype
          {
              get { return FileType; }
              set { FileType = value; }
          }
          string FileName;

          public string c_filename
          {
              get { return FileName; }
              set { FileName = value; }
          }
        }

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

            public UploadFileSet(string id, string retailer, string vendor, string downloadpath, string fileType, string slatime, string frequency, string dayof, bool flag,int datalag,string fileextend)
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
                DataLag = datalag;
                fileExtend = fileextend;
            }
            bool isReUpload;

            public bool c_isreupload
            {
                get { return isReUpload; }
                set { isReUpload = value; }
            }
            string fileExtend;

            public string c_fileextend
            {
                get { return fileExtend; }
                set { fileExtend = value; }
            }

            int DataLag;

            public int c_datalag
            {
                get { return DataLag; }
                set { DataLag = value; }
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


