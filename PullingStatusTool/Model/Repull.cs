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
}
