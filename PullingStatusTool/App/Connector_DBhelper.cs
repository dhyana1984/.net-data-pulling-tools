using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PullingStatusTool.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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
            string sqlStr = "update [RSI_TOOLS_Conn_REPORTCONFIG]"
                              + " set stores='" + schedule.c_storenumber + "', "
                              + " nextruntime='" + schedule.c_nextruntime + "',"
                              + " time='" + schedule.c_time + "',"
                              + " enable='" + schedule.c_enable.ToString() + "'"
                              + " where rid in(" + schedule.c_id + ")";
            dbhelper.submit(sqlStr);
        
        }
        public void runnow(string id)
        {
            string sqlStr = "update [RSI_TOOLS_Conn_REPORTCONFIG]"
                              + " set nextruntime=GETDATE()"
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
    
    }

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
                                      + " set configname='" + schedule.c_configname + "', "
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
                                      + " set nextruntime=GETDATE()"
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


    class ConnectDB
    {
        public ConnectDB() { }
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
                MessageBox.Show(ex.Message);
                flag = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public void submit(string sql)
        {
            if (submitData(sql))
            {
                MessageBox.Show("Save Successfully!");

            }
        }
    }
}
