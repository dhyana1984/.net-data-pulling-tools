using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    class ServerStatus
    {
        public ServerStatus(string vendor, string dataType, string status, string starttime, string downstatus, string formatstatus, string uploadstatus, string configname, string id, string serverIP, string psw,string IRid,string period)
        {
            this.vendor = vendor;
            this.configName = configname;
            this.dataType = dataType;
            this.eventstarttime = starttime;
            this.downloadingStatus = downstatus;
            this.formattingStatus = formatstatus;
            this.uploadingStatus = uploadstatus;
            this.serverIP = serverIP;
            this.password = psw;
            this.eventid = id;
            this.IRaccount = IRid;
            this.dataPeriod = period;
        }
        string eventid;

        public string c_eventid
        {
            get { return eventid; }
            set { eventid = value; }
        }
        string vendor;

        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        string dataType;

        public string c_dataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        string subgroup;

        public string c_subgroup
        {
            get { return subgroup; }
            set { subgroup = value; }
        }

        public string c_ubgroup
        {
            get { return subgroup; }
            set { subgroup = value; }
        }

        string configName;

        public string c_configName
        {
            get { return configName; }
            set { configName = value; }
        }
        string eventstarttime;

        public string c_starttime
        {
            get { return eventstarttime; }
            set { eventstarttime = value; }
        }
        string downloadingStatus;

        public string c_downloadingStatus
        {
            get { return downloadingStatus; }
            set { downloadingStatus = value; }
        }
        string formattingStatus;

        public string c_formattingStatus
        {
            get { return formattingStatus; }
            set { formattingStatus = value; }
        }
        string uploadingStatus;

        public string c_uploadingStatus
        {
            get { return uploadingStatus; }
            set { uploadingStatus = value; }
        }

        string serverIP;

        public string c_serverIP
        {
            get { return serverIP; }
            set { serverIP = value; }
        }

        string password;

        public string c_password
        {
            get { return password; }
            set { password = value; }
        }
        string IRaccount;

        public string c_IRaccount
        {
            get { return IRaccount; }
            set { IRaccount = value; }
        }

        string dataPeriod;

        public string c_dataperiod
        {
            get { return dataPeriod; }
            set { dataPeriod = value; }
        }
    }
}
