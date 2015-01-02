using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PullingStatusTool.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using PullingStatusTool.UserControl;

namespace PullingStatusTool.App
{
    interface IConnector_DBhelper
    {

        DataTable getAllAccount();
    }



    class BasketDBHelper
    {
        ConnectDB dbhelper = new ConnectDB();
        public BasketDBHelper()
        {
            dbhelper.c_sqlConString = "BasketConnector";
        }


        public void editSchedule(ConnectorSchedule schedule)
        {
            string store = string.IsNullOrEmpty(schedule.c_storenumber) ? " stores = null, " : "  stores='" + schedule.c_storenumber + "', ";
            string week = string.IsNullOrEmpty(schedule.c_week) ? " ext3  = null, " : " ext3='" + schedule.c_week + "',";
            string sqlStr = "update [RSI_TOOLS_Conn_REPORTCONFIG] set "
                              + store
                              + " nextruntime='" + schedule.c_nextruntime + "',"
                              + " time='" + schedule.c_time + "',"
                              + week
                              + " enable='" + schedule.c_enable.ToString() + "'"
                              + " where rid in(" + schedule.c_id + ")";
            dbhelper.submit(sqlStr);
        
        }
        public void runnow(string id)
        {
            string sqlStr = "update [RSI_TOOLS_Conn_REPORTCONFIG]"
                              + " set nextruntime=GETDATE(),"
                              +" enable =1 "
                              + " where rid in(" + id + ")";
            dbhelper.submit(sqlStr);
        }

        public void editAccount(ConnectorAccount account)
        {
            string sqlStr = "update RSI_TOOLS_Conn_USERINFO "
                              + " set username='" + account.c_accountname + "', "
                              + " password='" + account.c_password + "' ,"
                              + " [description]='" + account.c_suffix+"'"
                              + " where userid in(" + account.c_id + ")";
            dbhelper.submit(sqlStr);
        }
       public  void StopTask(string id)
       {
            string sqlStr = "update a "
                                     +"set endtime =getdate() "
                                     +" from [Basket_UL].[dbo].[RSI_TOOLS_Conn_INSTANCE] a "
                                     +"join RSI_TOOLS_Conn_CONTEXT b on a.CONTEXTID=b.id "
                                     +"join RSI_TOOLS_Conn_RLBasket_Job c on b.processid=c.pid "
                                     +" where c.id ="+id;
                    sqlStr += ";";
                    sqlStr += "update a "
                                      + " set a.running =0 "
                                      + " from RSI_TOOLS_Conn_REPORTCONFIG a "
                                      + " join RSI_TOOLS_Conn_RLBasket_Job b on a.rid=b.rid "
                                      + " where b.id=" + id;
  
            dbhelper.submit(sqlStr);
       
       }
        public DataTable getAllAccount()
        {

            string strSql = "SELECT [userid] as c_id,[username] as c_accountname ,[password] c_password,[description] c_desc "
                                                            + " FROM [Basket_UL].[dbo].[RSI_TOOLS_Conn_USERINFO]";
            return dbhelper.getTable(strSql);
        
        }

        public DataTable getAllSchedule()
        {

            string strSql = "SELECT  [rid] as c_id "
                                          +" ,[configname] as c_configname "
                                          +" ,[stores] as c_stores "
                                          +" ,[type] as c_dataType "
                                          +" ,[time] as c_time "
                                          +" ,[enable] as c_enable "
                                          +" ,[running] as c_running "
                                          +" ,[nextruntime] as c_nextruntime "
                                          + "  ,[ext3] as c_week  "
                                          +" FROM [Basket_UL].[dbo].[RSI_TOOLS_Conn_REPORTCONFIG] ";
            DataTable dt = new DataTable();
            dt = dbhelper.addSelectColomn(dbhelper.getTable(strSql));
            return dt;
        }

        public DataTable getAllReportSummary()
        {
            string strSql = " SELECT [id] as c_id "
                                     + "   ,[configname] as c_configname "
                                     + "   ,[ReportType] as c_reporttype "
                                     + "  ,[SubmitProcess] as c_process "
                                     + "  ,[status] as c_downloadstatus "
                                     + " ,[STARTTIME] as c_starttime "
                                     + "  ,[ENDTIME] as c_downloadtime "
                                     + "  ,[vendor] as c_vendor  "
                         
                                     + " FROM [Basket_UL].[dbo].[v$RSI_TOOLS_Conn_RLBasket_SummaryReport] "
                                    + " order by id desc";

            return dbhelper.getTable(strSql);
        
        }

        public DataTable getReportDetail(string id)
        {
            string strSql = "SELECT [id] c_id"
                                     + "  ,[filename] c_filename"
                                     + " ,[status] c_downloadstatus"
                                     + " ,[downloadtime] c_downloadtime"
                                     + " FROM [RSI_TOOLS_Conn_REPORT]"
                                     + " where ID in"
                                     + "  ( select * from dbo.f_split((select reportlist from RSI_TOOLS_Conn_RLBasket_Job where id="+id+" )) t)";//f_split是自己创建的方法，用于按逗号分隔字符串成一个集合

            return dbhelper.getTable(strSql);
 
        }
    
    }//WMBasket Connector的DBhelper

    class MorrisonDBHelper//Morrison connector的DBhelper
    {
        ConnectDB dbhelper = new ConnectDB();
        public MorrisonDBHelper()
        {
            dbhelper.c_sqlConString = "MRSConnector";
        }

        private DataTable getNullInstanceData()
        {
            string sqlStr = "SELECT "
                                        + " a.id c_id,"
                                        + " configname c_configname"
                                        + " FROM [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_INSTANCE] a join "
                                        + " [MorrisonConnector].dbo.RSI_TOOLS_Conn_CONTEXT b on a.CONTEXTID=b.id"
                                        + " join [MorrisonConnector].dbo.RSI_TOOLS_Conn_REPORTCONFIG c on b.reportcfgid=c.rid"
                                        + " where ENDTIME is null";
            return dbhelper.getTable(sqlStr);
        }

        private DataTable getAllRecordData(string date)
        {
            string sqlStr = "SELECT case FileName when '' then FileName else reverse(left(reverse(FileName),charindex('\\',reverse(FileName))-1)) end as c_filename, "//FileName是带路径的，这条语句是去掉路径，直接拿到文件名
                            + " [Vendor] c_vendor ,[ConfigName] c_configname,[status] c_downloadstatus ,[ReportType] c_reporttype,[DataType] c_datatype,[DownloadTime] c_downloadtime"
                            + " FROM v$RSI_TOOLS_MRSConn_REPORTINFO "
                            + " where  DownloadTime between '" + date + " 00:00:00' and '" + date + " 23:59:59' ";
            return dbhelper.getTable(sqlStr);

        }

        private void editAccountData(ConnectorAccount account)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {
            string sqlStr = "update RSI_TOOLS_Conn_USERINFO "
                                      + " set username='" + account.c_accountname + "', "
                                      + " password='" + account.c_password + "' "
                                      + " where userid in(" + account.c_id + ")" + ";"
                                      + " update a "//更新文件名的后缀
                                      + " set description ='" + account.c_suffix + "'"
                                      + " from RSI_TOOLS_Conn_VENDOR a join RSI_TOOLS_Conn_USERINFO b on a.vid=b.vendorid "
                                      + "where b.userid =" + account.c_id;
            dbhelper.submit(sqlStr);
            
        }

        private void editScheduleData(ConnectorSchedule schedule)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {
            string sqlStr = "update [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_REPORTCONFIG]"
                                      + " set configname='" + schedule.c_configname.Replace("'", "''") + "', "
                                      + " nextruntime='" + schedule.c_nextruntime + "',"
                                      + " time='" + schedule.c_time + "',"
                                      + " datelag='" + schedule.c_datelag + "',"
                                      + " enable='" + schedule.c_enable.ToString() + "'"
                                      + " where rid in(" + schedule.c_id + ")";
            dbhelper.submit(sqlStr);
        }


        private void runNow(string id)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {
            string sqlStr = "update [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_REPORTCONFIG]"
                                      + " set nextruntime=GETDATE(),enable = 1 "
                                      + " where rid in(" + id + ")";
            dbhelper.submit(sqlStr);

        }
   
        private DataTable getAllUserData()//获取所有的MorrisonConnector UserInfo
        {
            string sqlStr = "SELECT  [userid] c_id ,[username] c_accountname,[password] c_password ,vname c_vendor,b.description as c_suffix "
                                    + " FROM [RSI_TOOLS_Conn_USERINFO] a join "
                                    + " RSI_TOOLS_Conn_VENDOR b on a.vendorid=b.vid ";
            return dbhelper.getTable(sqlStr);


        }



        private DataTable getAllScheduledata()//获取所有的MorrisonConnector Schedule
        {
            string sqlStr = "select rid c_id, configname c_configname, datatype c_datatype,time c_time, nextruntime c_nextruntime, datelag c_datelag, running c_running, c.vname c_vendor,enable c_enable from RSI_TOOLS_Conn_REPORTCONFIG a inner join"
                                    + " RSI_TOOLS_Conn_USERINFO b on a.userid = b.userid inner join"
                                    + " RSI_TOOLS_Conn_VENDOR c on b.vendorid = c. vid"
                                    + " order by c.vname,datatype,configname";

            return dbhelper.addSelectColomn(dbhelper.getTable(sqlStr));
          
        }
        public DataTable getAllSchedule()
        {

            return getAllScheduledata();

        }

        public void runNowSchedules(string id)
        {
            runNow(id);
        }

        public void EditSchedules(ConnectorSchedule schedule)
        {
            editScheduleData(schedule);
        }

        public DataTable getAllAccount()
        {

            return getAllUserData(); ;

        }
        public void editAccount(ConnectorAccount account)
        {
            editAccountData(account);
        }
        public DataTable getAllRecord(string date)
        {

            return getAllRecordData(date);
        
        }

        public DataTable getNullInstance()
        {
            return getNullInstanceData();
        }



    }
    class TescoUKDBHelper//TescoUK 的DBhelper
    {
        ConnectDB dbhelper = new ConnectDB();
        public TescoUKDBHelper()
        {
            dbhelper.c_sqlConString = "TescoUKConnector";
        }

        private DataTable getAllUserData()//获取所有的MorrisonConnector UserInfo
        {
            string sqlStr = "SELECT [userid] c_accountname,[password] c_password ,vendor c_vendor "
                                    + " FROM [RSI_TOOLS_TescoConn_User] ";
                                
            return dbhelper.getTable(sqlStr);


        }
        private bool editAccountData(ConnectorAccount account)
        {
            string sqlStr = "update [RSI_TOOLS_TescoConn_User] "
                                      + " set userid='" + account.c_accountname + "', "
                                      + " vendor = '" + account.c_vendor.Replace("'","''") + "', "
                                      + " password='" + account.c_password + "' "
                                      + " where userid in ('" + account.c_id + "')";      
           return  dbhelper.submit(sqlStr);
        }

        private bool  addAccountData(ConnectorAccount account)
        {
            string sqlStr = "INSERT INTO [TescoConnector].[dbo].[RSI_TOOLS_TescoConn_User] ([UserID] ,[Password] ,[Vendor]   ,[Retailer]  ,[UserType])  VALUES"
                                    + " ('" + account.c_accountname + "' ,'" + account.c_password + "'  ,'" + account.c_vendor.Replace("'", "''") + "'  ,'Tesco' ,'Tesco Link')";
         return   dbhelper.submit(sqlStr);
        }

        private bool deleteAccountData(string id)
        {
            string sqlStr = "delete  FROM [RSI_TOOLS_TescoConn_User]  where userid='"+id +"'" ;
            return dbhelper.submit(sqlStr);     
        
        }

        private DataTable getScheduleData()
        {
            string sqlStr = " select vendor,  a.*  from [V$RSI_TOOLS_TescoConn_ReportConfig] a join RSI_TOOLS_TescoConn_User b on a. userid =b.userid";
            return dbhelper.getTable(sqlStr);
        
        }
        private bool addScheduleData(TescoUKSchedule schedule)
        {

            string sqlstr = "insert into RSI_TOOLS_TescoConn_ReportConfig " +
                                    "([ReportType] ,[UserID] ,[Supplier] ,[FileName] ,[Data] ,[DataSet],[ProductList] ,[TimeFrame] ,[DataLag] ,[StartDate],[EndDate] ,[DownloadDirectory],[ScheduleFrequency] ,[Weekday],[Time] ,[Enable]) "+
                                    "values " +
                                    string.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", schedule.Reporttype, schedule.Account, schedule.Supplier.Replace("'", "''"), schedule.Filename, schedule.Data, schedule.Dataset, schedule.Prodlist.Replace("'", "''"), schedule.Timeframe, schedule.Datelag, schedule.STDate, schedule.Eddate, schedule.Downloadfolder.Replace("'", "''"), schedule.ScheduleFreqency, schedule.Weekday, schedule.Time, schedule.Enable);
           return dbhelper.submit(sqlstr);

        }

        private bool editScheduleData(TescoUKSchedule schedule)
        {
            string sqlstr = "update RSI_TOOLS_TescoConn_ReportConfig set "
                                    + " ReportType ='" + schedule.Reporttype
                                    + "', UserId= '" + schedule.Account
                                    + "', Supplier ='" + schedule.Supplier.Replace("'", "''")
                                    + "', FileName= '" + schedule.Filename
                                    + "', Data ='" + schedule.Data
                                    + "', DataSet= '" + schedule.Dataset
                                    + "', ProductList ='" + schedule.Prodlist.Replace("'", "''")
                                    + "', TimeFrame= '" + schedule.Timeframe
                                    + "', DataLag ='" + schedule.Datelag
                                    + "', StartDate ='" + schedule.STDate
                                    + "', EndDate= '" + schedule.Eddate
                                    + "', DownloadDirectory ='" + schedule.Downloadfolder.Replace("'", "''")
                                    + "', ScheduleFrequency= '" + schedule.ScheduleFreqency
                                    + "', Weekday ='" + schedule.Weekday
                                    + "', Time= '" + schedule.Time
                                    + "', Enable ='" + schedule.Enable + "' where reportid = " + schedule.ReportID;
                         
            return dbhelper.submit(sqlstr);

        }

        private DataTable getReportData(string STdate,string submitDate)
        {
            DataTable dt = new DataTable();
            string sqlSubmitDate="";
            string sqlSTDate="";
            sqlSubmitDate =submitDate==""?"": " and [SubmitTime] between  '" + submitDate + " 00:00:00' and '" + submitDate + " 23:59:59'";
            sqlSTDate =  STdate==""?"":" and StartDate ='"+STdate+"'";

            string sqlstr = " SELECT  vendor,[HistoryID],a.[UserID] ,[Status],[FileName],[Supplier],[Data],[DataSet],[TimeFrame],[ProductList],[StartDate],[EndDate],[IsReSubmit],[SubmitTime],[DownloadTime]"
                                    + "  FROM [TescoConnector].[dbo].[RSI_TOOLS_TescoConn_History] a left join  RSI_TOOLS_TescoConn_User b on a.userid=b.userid where 1=1  "
                                    + sqlSubmitDate
                                    +sqlSTDate;
                                    
                                    
                                 
           dt= dbhelper.getTable(sqlstr);
           return dt;
        }

        private bool editReportStatusData(string historyID)
        {
            string sql = "update RSI_TOOLS_TescoConn_History set Status = 'New' where HistoryID = "+historyID;
            return dbhelper.submit(sql);
        }


        /*外部方法*/
        public DataTable getAllAccount()
        {
            return getAllUserData();
        }
        public bool addNewUser( ConnectorAccount account)
        {
            return addAccountData(account);
        }
        public bool editAccount(ConnectorAccount account)
        {
            return editAccountData(account);
        }
        public bool deleteAccount(string id)
        {
            return deleteAccountData(id);
        }

        public DataTable getSchedule()
        {
            return getScheduleData();
        }

        public bool addSchedule(TescoUKSchedule schedule)
        {
            return addScheduleData(schedule);
        }
        public bool editSchedule(TescoUKSchedule schedule)
        {
            return editScheduleData(schedule);
        }

        public DataTable getReport(string Startdate,string submitDate)
        {
            return getReportData(Startdate,submitDate);
        }

        public bool editReportStatus(string historyID)
        {
            return editReportStatusData(historyID);
        }

    }

    class ConnectDB
    {
        private DialogResult Confirm(string strString)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(strString, "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public ConnectDB() { }
        public ConnectDB( string strSqlCon) 
        {
            SqlConString = strSqlCon;
        }
        private string SqlConString;//连接字符串，用来设置不同的数据库配置

        public string c_sqlConString
        {
            get { return SqlConString; }
            set { SqlConString = value; }
        }
        /*---------------------------------------内部方法--------------------------------*/
        private DataTable addSelectCulomnData(DataTable dt)//给DataTable 加一个bool的列，作为GridControl多选框
        {
            DataColumn dtCol = new DataColumn();
            dtCol.ColumnName = "c_selected";
            dtCol.DataType = System.Type.GetType("System.Boolean");
            dtCol.DefaultValue = false;
            dt.Columns.Add(dtCol);
            return dt;
        }
        private bool submitData(string sql)//提交的方法，包括insert,edit和delete
        {
       
            bool flag = false;
            string connStr = ConfigurationManager.ConnectionStrings[SqlConString].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = sql;
            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Close();//读取完毕即关闭  
                flag = true;
            }
            catch (SqlException ex)
            {
                ShowMessage(ex.Message);
                flag = false;
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                flag = false;
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
            return flag;
        }


        private DataTable getTableData(string sql)
        {
            DataTable dt = new DataTable();
            string connStr = ConfigurationManager.ConnectionStrings[SqlConString].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = sql;
            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                dt.Load(sdr);
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
               ShowMessage(ex.Message);

            }
            catch (Exception ex)
            {
               ShowMessage(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
            return dt;
        }

        /*---------------------------------------对外开放的方法--------------------------------*/
        public DataTable addSelectColomn(DataTable dt)
        {
            return addSelectCulomnData(dt);
        }
        public DataTable getTable(string sql)
        {
            return getTableData(sql);
        }

        public bool submit(string sql)
        {
            string str = "save";
            if (sql.ToLower().ToLower().Contains("delete"))
                str = "delete";
            else if (sql.ToLower().Contains("insert"))
                str = "add";
            

            if (this.Confirm("Are you sure to "+str+"?") == DialogResult.Cancel)
                return false;
            if (submitData(sql))
            {
                ShowMessage("Save Successfully!");
                return true;
            }
            return false;
        }
    }
}
