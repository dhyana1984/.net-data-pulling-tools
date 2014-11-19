using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PullingStatusTool.Model
{




    class Connectors
    {
        
        public Connectors()
        { }
        string id;

        public string c_id
        {
            get { return id; }
            set { id = value; }
        }
        string vendor;
        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        string retailer;
        public string c_retailer
        {
            get { return retailer; }
            set { retailer = value; }
        }
        string datatype;

        public string c_datatype
        {
            get { return datatype; }
            set { datatype = value; }
        }

    }

    class ConnectorSchedule:Connectors
    {
        public ConnectorSchedule()
        { }


        string configname;

        public string c_configname
        {
            get { return configname; }
            set { configname = value; }
        }

        string time;

        public string c_time
        {
            get { return time; }
            set { time = value; }
        }
        string nextruntime;

        public string c_nextruntime
        {
            get { return nextruntime; }
            set { nextruntime = value; }
        }
        string datelag;

        public string c_datelag
        {
            get { return datelag; }
            set { datelag = value; }
        }
        bool enable;

        public bool c_enable
        {
            get { return enable; }
            set { enable = value; }
        }
        bool running;

        public bool c_running
        {
            get { return running; }
            set { running = value; }
        }

        bool selected;

        public bool c_selected//这个属性是为了在表格里面有一行Select culomn用来选择多列操作
        {
            get { return selected; }
            set { selected = value; }
        }

    
    
    }


    class ConnectorAccount:Connectors
    {
        public ConnectorAccount()
        {
        
        }


            string suffix;

            public string c_suffix
            {
                get { return suffix; }
                set { suffix = value; }
            }

            string account;

            public string c_accountname
            {
                get { return account; }
                set { account = value; }
            }
            string password;

            public string c_password
            {
                get { return password; }
                set { password = value; }
            }

    
            string subvendor;

            public string c_subvendor
            {
                get { return subvendor; }
                set { subvendor = value; }
            }
          
            string category;

            public string c_category
            {
                get { return category; }
                set { category = value; }
            }
            string owner;

            public string c_owner
            {
                get { return owner; }
                set { owner = value; }
            }
    
    }

    class ConnectorRecord:Connectors
    {
        public ConnectorRecord() { }



        string configname;

        public string c_configname
        {
            get { return configname; }
            set { configname = value; }
        }
        string downloadtime;

        public string c_downloadtime
        {
            get { return downloadtime; }
            set { downloadtime = value; }
        }
        string downloadstatus;

        public string c_downloadstatus
        {
            get { return downloadstatus; }
            set { downloadstatus = value; }
        }
        string reporttype;

        public string c_reporttype
        {
            get { return reporttype; }
            set { reporttype = value; }
        }

        string filename;

        public string c_filename
        {
            get { return filename; }
            set { filename = value; }
        }
    
    }




}
