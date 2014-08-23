using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using PullingStatusTool.Model;

namespace PullingStatusTool
{
    class DB_Helper
    {
        List<ServerStatus> ListServerstatus = new List<ServerStatus>();
        List<ReportDetails> ListReportDetails = new List<ReportDetails>();
        List<DataPullingFileCountStatus> ListPullFileStatus = new List<DataPullingFileCountStatus>();
        List<ReportExpect> ListReportExpect = new List<ReportExpect>();
        List<Repull> ListRePull = new List<Repull>();
        List<Repull> ListRePullChart = new List<Repull>();
        List<PullingPerformance> ListPerformance = new List<PullingPerformance>();
        public string getIRCalendarbyDate(string serverIP, string psw,string date)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select top 1 * from IRCalendar  "
                                    + "where endingdate<='" + Convert.ToDateTime(date).AddDays(-7) + "' order by endingdate desc";
            string period = "2014-01 WK 1";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Read();
                period = sdr[0].ToString();
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  
              

            }
            return period;
        }

        public void getSLAChart(string serverIP, string psw, string startDate, string endDate)
        {
            DB_Helper db_helper = new DB_Helper();
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            try
            {
    
                mySqlConnection.Open();//打开连接  
                while (Convert.ToDateTime(startDate).CompareTo(Convert.ToDateTime(endDate)) <= 0)
                {
                    string period = "";
                    if (Convert.ToDateTime(startDate).DayOfWeek.ToString() == "Monday")
                        period = "%" + db_helper.getIRCalendarbyDate("192.168.10.68", "T3ci94043", startDate) + "%";
                    string sqlStr = "select"
                                 + " count(distinct ReportName)"
                                 + " from View_PullingStatus "
                                 + " where reportname not like '%attrib%' and reportname not like '%-r%'  and reportname not like '%adhoc%' and "
                                 + " (ReportName like '" + period + "' or ReportName like '%" + Convert.ToDateTime(startDate).AddDays(-1).ToString("yyyy-MM-dd") + "%') and"
                                 + " dateadd(hour,12, EndFormattingTime)>'" + Convert.ToDateTime(startDate).ToString("yyyy-MM-dd") + " 17:00:00.000'";

                    SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                    SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                    while (sdr.Read())
                    {
                        Repull repull = new Repull(startDate + " " + Convert.ToDateTime(startDate).DayOfWeek.ToString(), sdr[0].ToString(), "Chart");
                        bool flag = true;
                        foreach (Repull data in ListRePullChart)
                        {
                            if (data.c_repulldate == repull.c_repulldate)
                            {
                                data.c_filecount += repull.c_filecount;
                                flag = false;
                                break;
                            }

                        }
                        if (flag)
                            ListRePullChart.Add(repull);
                    }
                    sdr.Close();//读取完毕即关闭  
                    startDate = Convert.ToDateTime(startDate).AddDays(1).ToShortDateString();
                }
              

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

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

        public int getAllPulledFileByWeek(string StarDate, string endDate, string serverIP, string psw)
        {
            int FileCount=1;
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select COUNT(*) from View_PullingStatus  "
                                    + "where	DATEADD(hour, 12, EndFormattingTime) between '"+StarDate+"' and '"+endDate+"' ";


            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                sdr.Read();
                FileCount = int.Parse(sdr[0].ToString());
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  


            }
            return FileCount;
        }

        public void getRepullChart(string serverIP, string psw, string startDate, string endDate)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select repulldate,COUNT(*)-1 from "
                           + " (select ReportName,Vendor,CONVERT(VARCHAR(10),dateadd(hour,12,EndFormattingTime) ,120) repulldate from"
                           + " View_PullingStatus"
                           + " where EndFormattingTime between '"+startDate+"' and '"+endDate+"'"

                           + " group by ReportName,Vendor,CONVERT(VARCHAR(10),dateadd(hour,12,EndFormattingTime) ,120) "
                           + " having COUNT(ReportName)>1) t"
                           + " group by repulldate";
                        


            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    if (sdr[0] == null)
                        continue;
                    Repull repull = new Repull(sdr[0].ToString() + " " + Convert.ToDateTime(sdr[0].ToString()).DayOfWeek.ToString(), sdr[1].ToString(), "Chart");
                    bool flag = true;
                    foreach (Repull data in ListRePullChart)
                    {
                        if (data.c_repulldate == repull.c_repulldate)
                        {
                            data.c_filecount += repull.c_filecount;
                            flag = false;
                            break;
                        }
                            
                    }
                    if (flag)
                    ListRePullChart.Add(repull);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

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
        public void getRepull(string serverIP, string psw, string startDate, string endDate)
        {
            string connStr = "server=" + serverIP + ";database =TargetConnector;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select"
                           + " case "
                           + " when reportname like '%Category%' or ScheduleName like '%Category%' or configname like '%Category%'  or ScheduleName like '%Cattrib%' or configname like '%Cattrib%' then vendor +' Category' else vendor end vendor,"
                           + " count(reportname)- COUNT(distinct ReportName)"
                           + " from  v$RSI_TOOLS_TargetConn_FormattedReport a join  v$RSI_TOOLS_TargetConn_EventStatus b on a.EventID=b.EventID"
                           + " where EndFormattingTime between '"+startDate+"' and '"+endDate+"'"
                           + " and CurrentLocation not like '%existent%' and DataFormatStatus like '%succ%'"
                           + " group by "
                           + " case "
                           + " when reportname like '%Category%' or ScheduleName like '%Category%' or configname like '%Category%'  or ScheduleName like '%Cattrib%' or configname like '%Cattrib%' then vendor +' Category' else vendor end"
                           + " having count(reportname)- COUNT(distinct ReportName)>0";


            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    Repull repull = new Repull(sdr[0].ToString(), sdr[1].ToString());
                    ListRePull.Add(repull);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

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

        public void getStatusData(string serverIP,string psw,string startDate,string endDate)
        {
             string connStr ="server="+serverIP+";database =TargetConnector;user id=sa;password="+psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            string sqlStr = "select vendor,schedulename,t.status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID from " +
                          " ( select  vendor,IRID,a.EventID,schedulename,a.status,eventstarttime,reportname,DownloadingStatus,FormattingStatus,UploadingStatus,configname," +
                          " ROW_NUMBER() over (partition  by vendor,schedulename,IRID,reportname order by eventstarttime desc)rn from  v$RSI_TOOLS_TargetConn_EventStatus a " +
                          " join RSI_TOOLS_TargetConn_report b on a.EventID=b.EventID " +
                          " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "') t where   rn=1" +
                          " group by eventid,IRID,vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname" +
                          " order by eventstarttime desc";

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {

                    ServerStatus status = new ServerStatus(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString(), serverIP, psw, sdr[9].ToString(), getReportPeriod(sdr[8].ToString(),serverIP,psw));
                    ListServerstatus.Add(status);
                }
                sdr.Close();//读取完毕即关闭  
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
             
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

        public string getReportPeriod(string eventid, string serverIP, string psw)
        {
            string connStr = "server=" + serverIP + ";database =TargetConnector;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "select top 1 reportname from RSI_TOOLS_TargetConn_report where EventID=" + eventid;
            string period = "";
            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {

                    period = sdr[0].ToString();
                    period = period.Substring(period.IndexOf('-') + 1, period.Length - period.IndexOf('-') - 1);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  


            }
            return period.TrimStart().TrimEnd();
        
        }

        public void getReportDetailData(string eventid,string serverIP, string psw)
        {
            string connStr = "server=" + serverIP + ";database =TargetConnector;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "select reportname,status,datapullstatus,dataformatstatus,uploadstatus from RSI_TOOLS_TargetConn_report where EventID=" +eventid;

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ReportDetails detail = new ReportDetails(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString());
                  
                    ListReportDetails.Add(detail);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
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

        public void getPullingFileCountStatus_view(string IP, string pswd, string dayTime, string period, string restatementDate, bool attribute, bool isMonday)
        {

            string sql = isMonday ? getMondayStatusSQL(period) : getFileCountStatusSQL(dayTime, period, restatementDate, attribute);

            if (sql != "")
            {
                string connStr = "server=" + IP + ";database =TargetPullingStatus;user id=sa;password=" + pswd;//连接字符串  
                SqlConnection mySqlConnection = new SqlConnection();
                mySqlConnection.ConnectionString = connStr;
                try
                {
                    mySqlConnection.Open();//打开连接  
                    SqlCommand mycmd = new SqlCommand(sql, mySqlConnection);//新建SqlCommand对象  
                    SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                    while (sdr.Read())
                    {
                        if (sdr[1] != null)//只选取当天的Attribute
                        {
                            DataPullingFileCountStatus fileCount = new DataPullingFileCountStatus(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[6].ToString(), pswd, sdr[5].ToString());
                            ListPullFileStatus.Add(fileCount);
                        }
                    }
                    sdr.Close();//读取完毕即关闭  

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(IP + ":" + ex.Message);

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



        }
        public void getPullingFileCountStatus(string IP,string pswd,string dayTime,string period,string restatementDate,bool attribute,bool isMonday)
        {

            string sql = isMonday ?  getMondayStatusSQL(period):getFileCountStatusSQL(dayTime, period, restatementDate, attribute) ;
            
            if (sql != "")
            {
                string connStr = "server=" + IP + ";database =TargetConnector;user id=sa;password=" + pswd;//连接字符串  
                SqlConnection mySqlConnection = new SqlConnection();
                mySqlConnection.ConnectionString = connStr;
                try
                {
                    mySqlConnection.Open();//打开连接  
                    SqlCommand mycmd = new SqlCommand(sql, mySqlConnection);//新建SqlCommand对象  
                    SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                    while (sdr.Read())
                    {
                        if (sdr[1].ToString() != "")//只选取当天的Attribute
                        {
                            DataPullingFileCountStatus fileCount = new DataPullingFileCountStatus(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), IP, pswd, sdr[5].ToString());
                            ListPullFileStatus.Add(fileCount);
                        }
                    }
                    sdr.Close();//读取完毕即关闭  

                }
       
                catch (SqlException ex)
                {
                    MessageBox.Show(IP+":"+ex.Message);

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
         
         
        
        }


        public void getSLAPerformanceStatus(string IP, string pswd, string dayTime, string period)
        {

            string sql = getSLAPerformanceSQL(dayTime, period);

            if (sql != "")
            {
                string connStr = "server=" + IP + ";database =TargetConnector;user id=sa;password=" + pswd;//连接字符串  
                SqlConnection mySqlConnection = new SqlConnection();
                mySqlConnection.ConnectionString = connStr;
                try
                {
                    mySqlConnection.Open();//打开连接  
                    SqlCommand mycmd = new SqlCommand(sql, mySqlConnection);//新建SqlCommand对象  
                    SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                    while (sdr.Read())
                    {
                        if (sdr[1].ToString() != "")//只选取当天的Attribute
                        {
                            PullingPerformance performance = new PullingPerformance(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), sdr[6].ToString(), sdr[7].ToString());
                            ListPerformance.Add(performance);
                        }
                    }
                    sdr.Close();//读取完毕即关闭  

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(IP + ":" + ex.Message);

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
        }
         


        public void insertNewFileExpect(string dayofwk,string vendor, string datatype, string subgroup, string fileExpect, string serverIP, string psw,string delay)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = string.Format("insert into ReportDataType (dayofweek,vendor,datatype,subgroup,fileExpect,delayreason) values ('{0}','{1}','{2}','{3}','{4}','{5}')",dayofwk, vendor, datatype, subgroup, fileExpect,delay);
            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
               mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 
               MessageBox.Show("Successfully Saved!");
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
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
        public void editFileExpect(ReportExpect fileExpect, string serverIP, string psw)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string vendor = fileExpect.c_vendor;
            string dataType = fileExpect.c_datatype;
            string subGroup = fileExpect.c_subgroup;
            string fileCount = fileExpect.c_filexpectuploaded;
            string id = fileExpect.c_expfileid;
            string dayofweek = fileExpect.c_dayofweek;
            string delay = fileExpect.c_delayreason;
            string sqlStr = "update reportdatatype set "
                            + " dayofweek ='" + dayofweek + "',"
                            + " vendor='" + vendor + "',"
                            + " datatype='" + dataType + "',"
                            + " subgroup ='" + subGroup + "',"
                            + " fileexpect='" + fileCount + "',"
                            + " delayreason='" + delay + "' "
                            + " where id = "+id;
          try  {
                
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                MessageBox.Show("Successfully Saved!");
      

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
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

        public void deleteFileExpect(string  id, string serverIP, string psw)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;

            string sqlStr = "delete from  reportdatatype where id= " + id;
                           
            try
            {

                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                MessageBox.Show("Successfully Delete!");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
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
        public void getReportExpectData(string serverIP, string psw)
        {
            string connStr = "server=" + serverIP + ";database =TargetPullingStatus;user id=sa;password=" + psw;//连接字符串  
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "select vendor,datatype,subgroup,fileexpect,id,dayofweek,delayreason from ReportDataType";

        

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ReportExpect reportExpect = new ReportExpect(sdr[4].ToString(), sdr[5].ToString(), sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(),sdr[6].ToString(),"");

                    ListReportExpect.Add(reportExpect);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
                MessageBox.Show(serverIP + ":" + ex.Message);
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

        public List<PullingPerformance> getPerformance()
        {
            return ListPerformance;
        
        }
        public List<ReportExpect> getReportExpect()
        {

            return ListReportExpect;
        }
        public List<ReportDetails> getReportDetail()
        {

            return ListReportDetails;
        }

        public List<Repull> getRePullList()
        {
            return ListRePull;
        }
        public void clearRePullList()
        {
            ListRePullChart.Clear();
        
        }

        public List<Repull> getRePullChart()
        {
            return ListRePullChart;
        }
        public List<ServerStatus> getServerStatus()
        {

            return ListServerstatus.OrderBy(t => t.c_vendor).ThenBy(t => t.c_dataType).ToList();
        }
        public List<DataPullingFileCountStatus> getPullingFileCount()
        {

             //去掉重复行，并将文件数累加，针对同个vendor的同种类型数据在不同server上跑
            foreach (DataPullingFileCountStatus t in ListPullFileStatus)
            {
                foreach (DataPullingFileCountStatus p in ListPullFileStatus)
                {
                    if (t.c_subgroup==p.c_subgroup&&t.c_serverIP != p.c_serverIP && t.c_vendor == p.c_vendor && t.c_dataType == p.c_dataType && t.c_status=="Uploaded"&&p.c_status=="Uploaded")
                    {
                        int i =  int.Parse( p.c_filecount)+ int.Parse(t.c_filecount);
                        t.c_filecount = i.ToString();
                        t.c_serverIP += ", " + p.c_serverIP;
                        p.c_vendor = "";
                    
                    }

                    
                
                }
            
            }


            return ListPullFileStatus.Where(t=>t.c_vendor!="").OrderBy(t => t.c_vendor).ThenBy(t => t.c_dataType).ThenBy(t => t.c_subgroup).ToList();
          //  return status.ToList();
        }

        private string getAttriDataTypeDate(string date)//找Attrib的时间后缀
        {
            DateTime selectDate = Convert.ToDateTime(date.Replace("%",""));//选择的时间
            string str = "";
            DayOfWeek day = selectDate.DayOfWeek;
      
            str += " ReportName like '%" + selectDate.ToString("Md") + "%' or";//
            str += " ReportName like '%" + selectDate.AddDays(1).ToString("Md") + "%' or";//如果晚一天跑也在内
            str += " ReportName like '%" + selectDate.AddDays(-1).ToString("Md") + "%' or";//如果提前一天天跑也在内

               str = "(" + str.Substring(0, str.Length - 2) + ") ";//去掉最后的or
            
     
            return str;
        }

         private string getSLAPerformanceSQL(string date,string period)
        {
            string query = "";

            string dailydate =  Convert.ToDateTime(date).AddDays(-1).ToString("yyyy-MM-dd");//在daily上不打钩就传""去查询
             string daytime= Convert.ToDateTime(date).ToString("yyyy-MM-dd");

            try
            {
                StreamReader sr = new StreamReader("SQL\\SLAPerformance.txt", Encoding.Default);
                string sql = "";
                while ((sql = sr.ReadLine()) != null)
                {
                    if( Convert.ToDateTime(date).DayOfWeek.ToString()=="Monday")
                    query+=sql.Replace("@Date",daytime).Replace("@Daily",dailydate).Replace("@Period",period);
                    else
                    query += sql.Replace("@Date", daytime).Replace("@Daily", dailydate).Replace("@Period", dailydate);


                }
                sr.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
            return query;
        }
         private string getMondayStatusSQL(string period)
         {

             string query = "";


        

             try
             {
                 StreamReader sr = new StreamReader("SQL\\VIP.txt", Encoding.Default);
                 string sql = "";
                 while ((sql = sr.ReadLine()) != null)
                 {
                            

                     query += " " + sql.Replace("@period",period) + " ";
                 }
                 sr.Close();
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);

             }
             return query;
         
         }
        private string getFileCountStatusSQL(string date,string period,string resdate,bool attribute)
        {
            string query = "";


            string attriDate = !attribute ? " ReportName  like '%1234%' " : getAttriDataTypeDate(date);

            try
            {
                StreamReader sr = new StreamReader("SQL\\DataPullingFileStatusSql.txt", Encoding.Default);
                string sql = "";
                while ((sql = sr.ReadLine()) != null)
                {
                    if (sql.Trim().ToUpper() == "WHERE")
                    {
                        //sql += " (a.uploadstatus like '%suc%' or a.dataformatstatus like '%suc%') and a.currentlocation !='existent' and ";
                        sql += " ((reportname not like '%r7%' and ReportName like '" + date + "') or ReportName like '" + period + "' ";//查询daily或者weekly的时间条件     
                        sql +=resdate==""?")": " or ReportName like '" + resdate + "')";//如果查询R7的数据就把条件附上
                    }
                    if (sql.Trim().Contains("1=1"))
                    {
                        sql = sql.Replace("1=1", attriDate);
                    }
                    
                    query += " " + sql + " ";
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
            return query;
        }
    }


}
