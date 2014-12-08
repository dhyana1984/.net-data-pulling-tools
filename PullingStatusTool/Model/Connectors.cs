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
     private   string id;

        public string c_id
        {
            get { return id; }
            set { id = value; }
        }
        private string vendor;
        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        private string retailer;
        public string c_retailer
        {
            get { return retailer; }
            set { retailer = value; }
        }
        private string datatype;

        public string c_datatype
        {
            get { return datatype; }
            set { datatype = value; }
        }

        string getSql;

    }

    class ConnectorSchedule:Connectors
    {
        public ConnectorSchedule()
        { }


        private string configname;

        public string c_configname
        {
            get { return configname; }
            set { configname = value; }
        }

        private string time;

        public string c_time
        {
            get { return time; }
            set { time = value; }
        }
        private string nextruntime;

        public string c_nextruntime
        {
            get { return nextruntime; }
            set { nextruntime = value; }
        }
        private string datelag;

        public string c_datelag
        {
            get { return datelag; }
            set { datelag = value; }
        }
        private bool enable;

        public bool c_enable
        {
            get { return enable; }
            set { enable = value; }
        }
        private bool running;

        public bool c_running
        {
            get { return running; }
            set { running = value; }
        }

        private bool selected;

        public bool c_selected//这个属性是为了在表格里面有一行Select culomn用来选择多列操作
        {
            get { return selected; }
            set { selected = value; }
        }

        private string progress;

        public string c_progress
        {
            get { return progress; }
            set { progress = value; }
        }


        private string storenumber;

        public string c_storenumber
        {
            get { return storenumber; }
            set { storenumber = value; }
        }

        private string week;

        public string c_week
        {
            get { return week; }
            set { week = value; }
        }
    }


    class ConnectorAccount:Connectors
    {
        public ConnectorAccount()
        {
        
        }


        private string suffix;

            public string c_suffix
            {
                get { return suffix; }
                set { suffix = value; }
            }

            private string account;

            public string c_accountname
            {
                get { return account; }
                set { account = value; }
            }
            private string password;

            public string c_password
            {
                get { return password; }
                set { password = value; }
            }


            private string subvendor;

            public string c_subvendor
            {
                get { return subvendor; }
                set { subvendor = value; }
            }

            private string category;

            public string c_category
            {
                get { return category; }
                set { category = value; }
            }
            private string owner;

            public string c_owner
            {
                get { return owner; }
                set { owner = value; }
            }


    
    }

    class ConnectorRecord:Connectors
    {
        public ConnectorRecord() { }



        private string configname;

        public string c_configname
        {
            get { return configname; }
            set { configname = value; }
        }
        private string downloadtime;

        public string c_downloadtime
        {
            get { return downloadtime; }
            set { downloadtime = value; }
        }
        private string downloadstatus;

        public string c_downloadstatus
        {
            get { return downloadstatus; }
            set { downloadstatus = value; }
        }
        private string reporttype;

        public string c_reporttype
        {
            get { return reporttype; }
            set { reporttype = value; }
        }

        private string filename;

        public string c_filename
        {
            get { return filename; }
            set { filename = value; }
        }
    
    }

    //用于显示非Target的SLA曲线的颜色
 static   class RetailerColor
    {
        static RetailerColor()
        {
            ListItem.Add(new Item("Morrisons", "#FAFA5B"));
            ListItem.Add(new Item("Sainsbury","#FFA011"));
            ListItem.Add(new Item("Ocado", "#39D8D8"));
            ListItem.Add(new Item("Boots", "#0753C6"));
        }
       static private List<Item> ListItem = new List<Item>();


       static private string getColorData(string retailer)
        {
          List<Item> ColorList = ListItem.Where(t => t.c_key == retailer).ToList();
          return ColorList.Count() > 0 ? ColorList.ToList()[0].c_value : "#E6E6E6";       //如果有没有定义颜色的Retailer，则返回#E6E6E6
        }

       static public string getColorbyRetailer(string retailer)
        {
            return getColorData(retailer);
        }

     }
    class Item  
    {
        public Item()
        {

        }    
        public Item(string key,string value)
        {
            c_key = key;
            c_value = value;
        }            
            
            private     string key;

        public string c_key
        {
          get { return key; }
          set { key = value; }
        }

       private string value;

        public string c_value
        {
          get { return this.value; }
          set { this.value = value; }
        }
    }
}
