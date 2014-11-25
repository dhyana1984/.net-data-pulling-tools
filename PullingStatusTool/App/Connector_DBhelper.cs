using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PullingStatusTool.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PullingStatusTool.App
{
    class Connector_DBhelper
    {
    }


    class MorrisonDBHelper//Morrison connector的DBhelper
    {
        public MorrisonDBHelper()
        {

        }

        
        private List<ConnectorSchedule> getNullInstanceData()//获取所有下载的report
        {
            List<ConnectorSchedule> ListSchedule = new List<ConnectorSchedule>();
            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "SELECT a.id, configname "
                                        + " FROM [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_INSTANCE] a join "
                                        + " [MorrisonConnector].dbo.RSI_TOOLS_Conn_CONTEXT b on a.CONTEXTID=b.id"
                                        + " join [MorrisonConnector].dbo.RSI_TOOLS_Conn_REPORTCONFIG c on b.reportcfgid=c.rid"
                                        + " where ENDTIME is null";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ConnectorSchedule schedule = new ConnectorSchedule();
                    schedule.c_configname=sdr["configname"].ToString();
                    schedule.c_id= sdr["id"].ToString();
                    ListSchedule.Add(schedule);

                }
                sdr.Close();//读取完毕即关闭  
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }

            return ListSchedule;
        }


        List<ConnectorRecord> ListRecord = new List<ConnectorRecord>();


        private void getAllRecordData(string date)//获取所有下载的report
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "SELECT case FileName when '' then FileName else reverse(left(reverse(FileName),charindex('\\',reverse(FileName))-1)) end as FileName, "//FileName是带路径的，这条语句是去掉路径，直接拿到文件名
                                    +" [Vendor] ,[ConfigName],[status] ,[ReportType] ,[DataType] ,[DownloadTime] "
                                    + " FROM v$RSI_TOOLS_MRSConn_REPORTINFO "
                                    + " where  DownloadTime between '" + date + " 00:00:00' and '" + date + " 23:59:59' ";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ConnectorRecord record = new ConnectorRecord();
                    record.c_configname = sdr["ConfigName"].ToString();
                    record.c_datatype = sdr["DataType"].ToString();
                    record.c_downloadstatus = sdr["status"].ToString();
                    record.c_downloadtime = sdr["DownloadTime"].ToString();
                    record.c_filename = sdr["FileName"].ToString();
                    record.c_reporttype = sdr["ReportType"].ToString();
                    record.c_vendor = sdr["Vendor"].ToString();
                    ListRecord.Add(record);

                }
                sdr.Close();//读取完毕即关闭  
        
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }
        private void editAccountData(ConnectorAccount account)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "update RSI_TOOLS_Conn_USERINFO "
                                      + " set username='" + account.c_accountname + "', "
                                      + " password='" + account.c_password + "' "
                                      + " where userid in(" + account.c_id + ")";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Close();//读取完毕即关闭  
                MessageBox.Show("Successfully Saved!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }

        private void editScheduleData(ConnectorSchedule schedule)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "update [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_REPORTCONFIG]"
                                      + " set configname='" + schedule.c_configname + "', "
                                      + " nextruntime='" + schedule.c_nextruntime + "',"
                                      + " time='" + schedule.c_time + "',"
                                      + " datelag='" + schedule.c_datelag + "',"
                                      + " enable='" + schedule.c_enable.ToString() + "'"
                                      + " where rid in(" + schedule.c_id + ")";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Close();//读取完毕即关闭  
                MessageBox.Show("Successfully Saved!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }


        private void runNow(string id)//立即run Schedule, 实际上就是update next runtime 到当前时间
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "update [MorrisonConnector].[dbo].[RSI_TOOLS_Conn_REPORTCONFIG]"
                                      + " set nextruntime=GETDATE()"
                                      + " where rid in(" + id + ")";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Close();//读取完毕即关闭  
                MessageBox.Show("Successfully Run!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }
        List<ConnectorAccount> ListAccount = new List<ConnectorAccount>();
        private void getAllUserData()//获取所有的MorrisonConnector UserInfo
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "SELECT  [userid],[username],[password],vname,b.description as suffix "
                                    + " FROM [RSI_TOOLS_Conn_USERINFO] a join "
                                    + " RSI_TOOLS_Conn_VENDOR b on a.vendorid=b.vid ";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ConnectorAccount account = new ConnectorAccount();
                    account.c_id = sdr["userid"].ToString();
                    account.c_accountname = sdr["username"].ToString();
                    account.c_password = sdr["password"].ToString();
                    account.c_vendor = sdr["vname"].ToString();
                    account.c_suffix = sdr["suffix"].ToString();
                    ListAccount.Add(account);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }


        List<ConnectorSchedule> ListSchedule = new List<ConnectorSchedule>();
        private void getAllScheduledata()//获取所有的MorrisonConnector Schedule
        {

            string connStr = ConfigurationManager.ConnectionStrings["MRSConnector"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select rid, configname, datatype,time, nextruntime, datelag, running, c.vname,enable from RSI_TOOLS_Conn_REPORTCONFIG a inner join"
                                    + " RSI_TOOLS_Conn_USERINFO b on a.userid = b.userid inner join"
                                    + " RSI_TOOLS_Conn_VENDOR c on b.vendorid = c. vid"
                                    + " order by c.vname,datatype,configname";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ConnectorSchedule schedule = new ConnectorSchedule();
                    schedule.c_id = sdr["rid"].ToString();
                    schedule.c_configname = sdr["configname"].ToString();
                    schedule.c_datatype = sdr["datatype"].ToString();
                    schedule.c_time = sdr["time"].ToString();
                    schedule.c_nextruntime = sdr["nextruntime"].ToString();
                    schedule.c_datelag = sdr["datelag"].ToString();
                    schedule.c_enable = (bool)sdr["enable"];
                    schedule.c_running = (bool)sdr["running"];
                    schedule.c_vendor = sdr["vname"].ToString();
                    schedule.c_selected = false;
                    ListSchedule.Add(schedule);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
            }
        }
        public List<ConnectorSchedule> getAllSchedule()
        {
            getAllScheduledata();
            return ListSchedule;

        }

        public void runNowSchedules(string id)
        {
            runNow(id);
        }

        public void EditSchedules(ConnectorSchedule schedule)
        {
            editScheduleData(schedule);
        }

        public List<ConnectorAccount> getAllAccount()
        {
            getAllUserData();
            return ListAccount;

        }
        public void editAccount(ConnectorAccount account)
        {
            editAccountData(account);
        }
        public List<ConnectorRecord> getAllRecord(string date)
        {
            getAllRecordData(date);
            return ListRecord;
        
        }

        public List<ConnectorSchedule> getNullInstance()
        {
            return getNullInstanceData();
        }



    }
}
