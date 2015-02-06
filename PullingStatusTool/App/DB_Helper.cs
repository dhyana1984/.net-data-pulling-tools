using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using PullingStatusTool.Model;
using System.Configuration;
using PullingStatusTool.App;
using System.Data;

namespace PullingStatusTool
{
    class DB_Helper
    {
        private void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ConnectDB connectDB_68server = new ConnectDB("68Server");
        List<DataPullingFileCountStatus> ListPullFileStatus = new List<DataPullingFileCountStatus>();
        List<ReportExpect> ListReportExpect = new List<ReportExpect>();
        List<Repull> ListRePullChart = new List<Repull>();
        private bool deleteRepullListData(string id)
        {
            string sql = "delete  FROM [TargetPullingStatus].[dbo].[RepullList] where id in (" +
                                  id+")";
            return connectDB_68server.submit(sql);
        }

        private DataTable getTargetRepullListData(string str)
        {
            string sql = "SELECT [id] c_id"
                               + "  ,[Retailer] c_retailer"
                               + ",[Vendor] c_vendor"
                               + ",[ReportName] c_reportname"
                               + ",[ETA] c_eta"
                               + ",[CreateDate] c_createdate"
                               + ",[isNeedFormat] c_isneedformat"
                               + ",[isNeedUpload] c_isneedupload"
                               + ",[ServerIP] c_serverip"
                               + ",[Account] c_account"
                                + ",[flag] c_flag "
                                 + ",[creater] c_creater "
                               + ",[RepullStatus] c_repullstatus "
                               + "FROM [TargetPullingStatus].[dbo].[RepullList] "
                               + " where  1=1 " + str
                               + " order by createdate desc";
            return connectDB_68server.getTable(sql);
        
        }

        private bool addNewRepullData(List<TargetRepullList> RepullList)
        { 
            string sqlStr ="";
            foreach (TargetRepullList repull in RepullList)
            {
                sqlStr += " insert into RepullList (retailer, vendor, reportname,eta,createdate,isneedformat,isneedupload,serverip,account,repullstatus,creater) values "
                            + string.Format("('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}','{7}','{8}','{9}','{10}');", repull.c_retailer, repull.c_vendor, repull.c_reportname, repull.c_finishbefore, repull.c_creatime, repull.c_isneedformat, repull.c_isneedupload, repull.c_serverip, repull.c_account, repull.c_repullstatus,repull.c_creater);
            
            }

            return connectDB_68server.submit(sqlStr.TrimEnd(';'));
        
        }

        private bool editRepullData(List<TargetRepullList> RepullList)
        {
            string sqlStr = "";
            foreach (TargetRepullList repull in RepullList)
            {
                sqlStr += "update RepullList set " +
                                " repullstatus='" + repull.c_repullstatus + "',"+
                                " account='" + repull.c_account + "'," +
                                " serverip='" + repull.c_serverip + "' " +
                                " where id='" + repull.c_id + "'; ";   
            }

               return connectDB_68server.submit(sqlStr.TrimEnd(';')); 
        }

        public string getTescoDataPeriod(string date,int datelag, bool isWeekly)//跟传入数据的真实时间，datelag，以及是否是Weekly的判断，拿到需要的日期以及weekly number
        {
            string sql = "select * "
                                + " from Engv1ukdp1.Tescoconnector.dbo.RSI_TOOLS_TescoConn_TescoCalendar ";//先把Calendar全部取出来
                              //  + " where '"+Convert.ToDateTime(date).ToString("dd/MM/yyyy")+"' between startdate and enddate";
            string weekNum = "";
            DataTable dt = connectDB_68server.getTable(sql);
            foreach (DataRow row in dt.Rows)//根据传入的date找到week number
            {
                //由于calendar表里面的日期格式是dd/MM/yyyy，要转成c#日期格式
                DateTime stdate = DateTime.ParseExact(row["startdate"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                DateTime endate = DateTime.ParseExact(row["enddate"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                if (Convert.ToDateTime(date).AddDays(-7) <= endate && Convert.ToDateTime(date).AddDays(-7) >=stdate)
                {
                    weekNum =  row["year"].ToString()+"/"+row["WeekNbrInYear"].ToString();//拿到weeknumber
                    break;
                }
            } 
            return  isWeekly ? weekNum : Convert.ToDateTime(date).AddDays(0 - datelag).ToString("dd/MM/yyyy");//如果是daily的period则返回dd/MM/yyyy格式的日期，如果weekly返回weekly number
        }


        private DataTable getTescoUKPullingStatusData(string stDate)
        {
            string current = getTescoDataPeriod(stDate, 0, false); //当天日期
            string restate_3 = getTescoDataPeriod(stDate, 2, false); //today -3 
            string restate_2 = getTescoDataPeriod(stDate, 1, false);//today -2  
            string week = getTescoDataPeriod(stDate, 2, true); // week number
            string sqlstr = "select  c_vendor,c_userid,SUM(SSSD) c_sssd,SUM(SSDCD) c_ssdcd,SUM(WASD) c_wasd,SUM(GSSD) c_gssd,SUM(RSSSD) c_rsssd,SUM(sssw) c_sssw,SUM(STCW) c_stcw from "
                                     + "(select   c_vendor, c_userid,c_startdate, "
                                     + "case when c_Data='Sales and Stock' and c_DataSet='Store' and c_FileName like '%SSSD%' and (c_FileName not like '%RSS%' and c_FileName not like '%SSDR%' and  c_FileName not like '% R%' ) and  c_StartDate='" + current + "' then COUNT(*) else 0 end as SSSD, "
                                     + " case when c_Data='Sales and Stock' and c_DataSet='DC' and c_FileName not like '%NPDR%' and c_startdate='"+restate_3+"'then COUNT(*) else 0 end as SSDCD, "
                                     + " case when c_Data='Waste Analysis' and c_DataSet='Store'and  c_startdate='"+restate_3+"'then COUNT(*) else 0 end as WASD, "
                                    + " case when c_Data='Gap Scan' and c_DataSet='Store' and  c_startdate='"+restate_2+"' then COUNT(*)  else 0 end as GSSD , "
                                    + " case when c_Data='Sales and Stock' and c_DataSet='Store' and (c_FileName like '%RSSSD%' or c_FileName like '%SSSDR%' or c_FileName like '%SSSD R%' )and  c_startdate='"+restate_3+"' then COUNT(*) else 0  end as RSSSD, "
                                    + " case when c_Data='Sales and Stock' and c_DataSet='Store' and  c_startdate='"+week+"' then COUNT(*)  else 0 end as SSSW, "
                                    + " case when c_Data='Sales and Stock' and c_DataSet='Total Co'  and c_startdate='"+week+"' then COUNT(*)  else 0 end as STCW "
                                    + " from View_NoTargetDPStatus a "
                                    + " group by c_vendor,c_Data,c_DataSet,c_FileName,c_startdate,c_startdate,c_userid) t "
                                    + " group by c_vendor,c_userid "
                                    + " order by c_vendor ";

        return connectDB_68server.getTable(sqlstr);
        
        }



        private bool addAccountData(ConnectorAccount account)
        {
            string sqlStr = "insert into   IRAccount (Vendor,userid,PassWord,CategoryAccess,Owner,subvendor,Retailer) values "
                           + "('" + account.c_vendor.Replace("'", "''") + "',"
                           + "'" + account.c_accountname + "',"
                           + "'" + account.c_password + "',"
                           + "'" + account.c_category + "',"
                           + "'" + account.c_owner + "',"
                           + "'" + account.c_subvendor.Replace("'", "''") + "',"
                           + "'" + account.c_retailer.Replace("'", "''") + "' )";
            return  connectDB_68server.submit(sqlStr);

        }


        private bool editAccountData(ConnectorAccount account)//
        {
            string sqlStr = "update  IRAccount "
                                      + " set [Vendor]='" + account.c_vendor.Replace("'", "''") + "', "
                                       + "  [userid]='" + account.c_accountname + "', "
                                      + "  [PassWord]='" + account.c_password + "', "
                                      + "  [CategoryAccess]='" + account.c_category + "', "
                                      + "  [Owner]='" + account.c_owner + "', "
                                      + "  [subvendor]='" + account.c_subvendor.Replace("'", "''") + "', "
                                      + "  [Retailer]='" + account.c_retailer.Replace("'", "''") + "' "
                                      + " where id in(" + account.c_id + ")";
        return    connectDB_68server.submit(sqlStr);
        }

        private DataTable getAllAccountData()
        {
            string sqlStr ="SELECT "
                                    +" userid as c_accountname,"
                                      + " owner as c_owner,"
                                        + " CategoryAccess as c_category,"
                                          + " id as c_id,"
                                            + " password as c_password,"
                                              + " retailer as c_retailer,"
                                                + " vendor as c_vendor,"
                                                  + " subvendor as c_subvendor "
                                    +" FROM [TargetPullingStatus].[dbo].[IRAccount]"
                                    + " order by Retailer,Vendor,UserID,SubVendor" ;

         return   connectDB_68server.getTable(sqlStr);
        }

        private DataTable getUploadRecordData(string STDate,string EDDate,string isSLA,string isOngoing)
        {
          
            string SLA =isSLA=="All"?"":" and isSLA = '"+isSLA+"'";
            string ongoing= isOngoing=="All"?"":" and isongoing = '"+isOngoing+"'";
            string sqlStr = @"select "
                                        +"id as c_id,"
                                        + "retailer as c_retailer,"
                                        + "vendor as c_vendor,"
                                        + "Downloadpath as c_downloadpath,"
                                        + "uploadpath as c_uploadpath,"
                                        + "uploadtime as c_uploadtime,"
                                        + "issla as c_issla,"
                                        + "isongoing as c_isongoing,"
                                        + "filetype as c_filetype,"
                                        + "filename as c_filename"
                                        +" from FileUploadRecord  where "
                                        + " uploadtime >='" + STDate+"' and "
                                        + " uploadtime <='" + EDDate+"'"
                                        + SLA
                                        + ongoing
                                         +" order by uploadtime desc";

          return  connectDB_68server.getTable(sqlStr);

        }

        private DataTable  getUploadPathByIDData(string fileSetId)
        {
            string sqlStr = "select "
                                         + " id c_id,"
                                         + " filesetid c_filesetid,"
                                         + " path c_uploadpath,"
                                         + " pathname c_pathname"
                                         +" from UploadPath  where FileSetID =" + fileSetId;
           return connectDB_68server.getTable(sqlStr);

        }

        public bool addUploadPath(UploadFilePath path)
        {
            string sqlStr = "insert into   UploadPath (filesetid,Path,pathname) values "
                           + "('" + path.c_filesetid + "',"
                           + "'" + path.c_uploadpath.Replace("'", "''") + "',"
                           + "'" + path.c_pathname + "' )";
            return connectDB_68server.submit(sqlStr);
        }
        public bool deleteUploadPath(string id)
        {
            string sqlStr = "delete from    UploadPath where id = " + id;
           return connectDB_68server.submit(sqlStr);
        }

        public bool editUploadPath(UploadFilePath path)
        {

            string sqlStr = "update   UploadPath set "

                                    + "path='" + path.c_uploadpath.Replace("'", "''") + "',"
                                    + "pathname ='" + path.c_pathname + "'"
                                    + " Where id=" + path.c_id;
            return connectDB_68server.submit(sqlStr);

        }
        public bool addFileSet(UploadFileSet fileSet,bool addToExpect)
        {
            string sqlStr = "insert into   FileUploadSet (Retailer,Vendor,DownloadPath,FileType,SLATime,Frequency,Dayof,Datalag,Flag,isReUpload,isStatusbyFileName,FileExten) values"
                                    + "('" + fileSet.c_retailer + "',"
                                    + "'" + fileSet.c_vendor.Replace("'", "''") + "',"
                                    + "'" + fileSet.c_downloadpath + "',"
                                    + "'" + fileSet.c_filetype + "',"
                                    + "'" + fileSet.c_slatime + "',"
                                    + "'" + fileSet.c_freqency + "',"
                                    + "'" + fileSet.c_dayof + "',"
                                    + "'" + fileSet.c_datalag + "',"
                                    + "'" + fileSet.c_flag +"',"
                                    + "'" + fileSet.c_isreupload + "',"
                                       + "'" + fileSet.c_isbyfilename + "',"
                                    + "'" + fileSet.c_fileextend+"' )";
            string dayofweek=fileSet.c_freqency=="Daily"?"Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday" : fileSet.c_dayof;
            string sqlStrExpect = string.Format("insert into ReportDataType (dayofweek,vendor,datatype,subgroup,fileExpect,delayreason,retailer) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", dayofweek, fileSet.c_vendor, fileSet.c_filetype, fileSet.c_freqency, "1", "", fileSet.c_retailer);//   插入一条fileSet的时候自动插入到fileExpect
            return addToExpect?connectDB_68server.submit(sqlStr + ";" + sqlStrExpect):connectDB_68server.submit(sqlStr);
       
        
        }

        public bool deleteFileSet(string id)
        {
            string sql = "delete from [FileUploadSet] where id =" +id;
            return connectDB_68server.submit(sql);


        }
        public bool editFileSet( UploadFileSet fileSet, bool editExpect )
        {
            string sqlStr = "update   FileUploadSet set "
                                    + "Retailer='" + fileSet.c_retailer.Replace("'", "''") + "',"
                                    + "Vendor='" + fileSet.c_vendor.Replace("'", "''") + "',"
                                    + "DownloadPath ='" + fileSet.c_downloadpath.Replace("'", "''") + "',"
                                    + "FileType='" + fileSet.c_filetype + "',"
                                    + "SLATime ='" + fileSet.c_slatime + "',"
                                    + "Frequency ='" + fileSet.c_freqency + "',"
                                    + "Dayof ='" + fileSet.c_dayof + "',"
                                     + "FileExten ='" + fileSet.c_fileextend + "',"
                                       + "Datalag ='" + fileSet.c_datalag + "',"
                                       + "isReupload ='" + fileSet.c_isreupload + "',"
                                          + "isStatusbyFileName ='" + fileSet.c_isbyfilename + "',"
                                    + "Flag ='" + fileSet.c_flag + "' "
                                    +" Where id=" + fileSet.c_id;
           return  connectDB_68server.submit(sqlStr);

        }
        public DataTable getTargetRepullList(string str)
        {
            return getTargetRepullListData(str);
        }
        private DataTable getFileSetData()
        {

            string sqlStr = "select  "
                                        +"id c_id,"
                                        + "retailer c_retailer,"
                                        + "vendor c_vendor,"
                                        + "downloadpath c_downloadpath,"
                                        + "dayof c_dayof,"
                                        + "slatime c_slatime,"
                                        + "filetype c_filetype,"
                                        + "flag  c_flag, "
                                        + "datalag c_datalag, "
                                         + "Frequency  c_freqency, "
                                         + "isReupLoad  c_reupload, "
                                         + "isStatusbyFileName  c_isbyfilename, "
                                         + "FileExten c_fileextend "
                                        +" from FileUploadSet   order by Retailer, Vendor,FileType,Frequency";

       return     connectDB_68server.getTable(sqlStr);

 
        }

        public string getIRCalendarbyDate(string date)
        {

            string sqlStr = "select top 1 * from IRCalendar  "
                                    + "where endingdate<='" + Convert.ToDateTime(date).ToShortDateString() + "' order by endingdate desc";
            string period = "2014-01 WK 1";
            period =connectDB_68server.getTable(sqlStr).Rows[0].ItemArray[0].ToString();
            return period;
        }
        private DataTable getExpectFileByWeekday(string weekday)
        {
            string strSql = "SELECT retailer,SUM(FileExpect) expectFile "
                                    + "  FROM [TargetPullingStatus].[dbo].[ReportDataType]"
                                    + "  where DayofWeek like '%" + weekday + "%'"
                                    + " group by Retailer";
            return connectDB_68server.getTable(strSql);
  
        
        }
        //private DataTable getNoTargetSLAChartData(string startDate, string endDate)//获得非Target Retailer的SLA Chart(加入FileExpect比对，TODO)
        //{
        //    DataTable dt = new DataTable();//从数据库拿到的dt
        //    DataTable ds = new DataTable();//用来做计算的dt
        //    DataTable listFileExpect = getReportExpectDataTable("retailer!='Target'");
        //    string sqlStr = " SELECT "
        //                            + " Retailer c_retailer,CONVERT(varchar(100), uploadtime, 23) c_uploaddate , COUNT(distinct FileName) as c_filecount "
        //                            + " FROM [TargetPullingStatus].[dbo].[FileUploadRecord]  "
        //                            + " where isSLA='false'  and CONVERT(varchar(100), uploadtime, 23) between '" + startDate + "' and '" + endDate + "' "
        //                            + " group by Retailer,CONVERT(varchar(100), uploadtime, 23)";
        //    return ds;//计算好的ds是最后的数据源
        //}


        private DataTable getNoTargetSLAChartDatas(string startDate, string endDate)//获得非Target Retailer的SLA Chart
        {
            DataTable dt = new DataTable();//从数据库拿到的dt
            DataTable ds = new DataTable();//用来做计算的dt
            DataTable listFileExpect = getReportExpectDataTable("retailer!='Target'");
            string sqlStr = " SELECT "
                                    + " Retailer c_retailer,CONVERT(varchar(100), uploadtime, 23) c_uploaddate , COUNT(distinct FileName) as c_filecount "
                                    + " FROM [TargetPullingStatus].[dbo].[FileUploadRecord]  "
                                    + " where isSLA='false'  and CONVERT(varchar(100), uploadtime, 23) between '" + startDate + "' and '" + endDate + "' "
                                    + " group by Retailer,CONVERT(varchar(100), uploadtime, 23)";


            dt = connectDB_68server.getTable(sqlStr);
            ds = dt.Copy();//ds的基础数据是从数据库中取到的
            while (Convert.ToDateTime(startDate) <= Convert.ToDateTime(endDate))//由于从数据库取到的只有missSLA文件的日期，所以要把没有miss的日期也不上去
            {
          
                foreach (DataRow retailer in dt.Rows)
                {
                    if (dt.Select("c_retailer='" + retailer["c_retailer"].ToString() + "' and c_uploaddate='" + startDate + "'").Count() > 0)
                        continue;
                    else//如果在选定的时间范围内，某一天不存在于从数据库中取出来的集合中，说明这一天没有miss，所以filecount是0,并且要把这一条加到ds中
                    {
                        DataRow row = ds.NewRow();
                        row["c_retailer"] = retailer["c_retailer"].ToString();
                        row["c_uploaddate"] = startDate.Split(' ')[0];
                        row["c_filecount"] = 0;
                        ds.Rows.Add(row);
                    }
          

                }
                startDate = Convert.ToDateTime(startDate).AddDays(1).ToString("yyyy-MM-dd");

            
            }
            DataView dv = ds.DefaultView;
            dv.Sort="c_uploaddate";//DataTable转为DataView，按照日期排序
            ds=dv.ToTable();
            return ds;//计算好的ds是最后的数据源
        }

        private DataTable getNoTargetSLAChartByRegionDatas()//获得非Target Retailer的SLA Chart
        {
        
            string sqlStr = " select "
                                      //  + "rtrim(cast(sum(case issla when 'true' then 1 else 0 end)*100.0/COUNT(a.id) as decimal(5,2)))+'%'  c_ontimerate, "
                                        + " sum(case issla when 'true' then 0 else 1 end)*1.0/COUNT(a.id)  c_ontimerate, "
                                        + " region c_region,"
                                        + " CONVERT(varchar(7),uploadtime,121) c_month"
                                        + " from FileUploadRecord a  join RetailerInfo b on a.Retailer=b.Retailer"
                                        + " group  by region,CONVERT(varchar(7),uploadtime,121)";


           return  connectDB_68server.getTable(sqlStr);

        }

        private DataTable getNoTargetSLAChartByRegionPeriodDatas(string stdate,string eddate)//获得非Target Retailer的SLA Chart
        {

            string sqlStr = " select "
                //  + "rtrim(cast(sum(case issla when 'true' then 1 else 0 end)*100.0/COUNT(a.id) as decimal(5,2)))+'%'  c_ontimerate, "
                                        + " sum(case issla when 'true' then 0 else 1 end)*1.0/COUNT(a.id)  c_ontimerate, "
                                        + " region c_region,"
                                        + " CONVERT(varchar(10),uploadtime,121) c_month"
                                        + " from FileUploadRecord a  join RetailerInfo b on a.Retailer=b.Retailer"
                                        + " where uploadtime >='" + stdate+  " 00:00:00' and uploadtime <='" + eddate + " 23:59:59'"
                                        + " group  by region,CONVERT(varchar(10),uploadtime,121)";


            return connectDB_68server.getTable(sqlStr);

        }
        private void getSLAChartData( string startDate, string endDate)
        {
            DB_Helper db_helper = new DB_Helper();
            string connStr = ConfigurationManager.ConnectionStrings["68Server"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            try
            {
    
                mySqlConnection.Open();//打开连接  
                while (Convert.ToDateTime(startDate).CompareTo(Convert.ToDateTime(endDate)) <= 0)
                {
                    string period = "";//weekly 的week number
                    string Condition = "";//区分礼拜一和礼拜二取weekly fact数据的条件
                    if (Convert.ToDateTime(startDate).DayOfWeek.ToString() == "Monday")
                    { 
                        period = "%" + db_helper.getIRCalendarbyDate(startDate) + "%";//礼拜一取的weekly数据，要加week number条件
                        Condition = "Reportname not like '%INV2%' and reportname not like '%Receipt%' and ";//礼拜一不取INV2，和Recept，所以滤去
                    }
                    else if (Convert.ToDateTime(startDate).DayOfWeek.ToString() == "Tueseday")
                    {
                        period = "%" + db_helper.getIRCalendarbyDate(startDate) + "%";
                        Condition = "(Reportname  like '%INV2%" + period + "' or reportname  like '%Receipt%" + period + "') and ";//礼拜二要取INV2，和Recept，并且facr weekly数据只有这两种，所以加上
                    }
                    string EstStartdate = Convert.ToDateTime(startDate + " 05:00:00.000")+ "'";//SLA, 传入的是中国的日期，加上早上5点，和系统内东部时间比较
                    string sqlStr = "select"
                                 + " count(distinct ReportName)"
                                 + " from View_PullingStatus "
                                 + " where " + Condition + " reportname not like '%attrib%' and reportname not like '%-r%'  and reportname not like '%adhoc%' and schedulename not like '%his%'  and configname not like '%his%' "
                                 + " and (ReportName like '" + period + "' or ReportName like '%" + Convert.ToDateTime(startDate).AddDays(-1).ToString("yyyy-MM-dd") + "%') and"
                                 + " EndFormattingTime>'" + EstStartdate ;

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


        }

        public int getAllPulledFileByWeek(string StarDate, string endDate)
        {
            int FileCount=1;
            string sqlStr = "select COUNT(*) from View_PullingStatus  "
                                    + "where	 EndFormattingTime between '"+StarDate+"' and '"+endDate+"' ";
            object count = connectDB_68server.getTable(sqlStr).Rows[0].ItemArray[0];
            FileCount = connectDB_68server.getTable(sqlStr).Rows[0].ItemArray[0] == null ? 0 : (int)count;
            return FileCount;
        }

        private void getRepullChartData( string startDate, string endDate,List<Repull> LsRepull)
        {
            string connStr = ConfigurationManager.ConnectionStrings["68Server"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            //string sqlStr = "select distinct vendor,schedulename,status,eventstarttime,DownloadingStatus,FormattingStatus,UploadingStatus,configname,eventid,IRID" + 
            //                 " from v$RSI_TOOLS_TargetConn_EventStatus"+
            //                 " where eventstarttime >= '" + startDate + "' and eventstarttime <= '"+ endDate + "'";//SQL语句  

            //string sqlStr = "select repulldate,COUNT(*) from "
            //               + " (select ReportName,Vendor,CONVERT(VARCHAR(10),dateadd(hour,13,EndFormattingTime) ,120) repulldate from"
            //               + " View_PullingStatus"
            //               + " where EndFormattingTime between '"+startDate+"' and '"+endDate+"'"

            //               + " group by ReportName,Vendor,CONVERT(VARCHAR(10),dateadd(hour,13,EndFormattingTime) ,120) "
            //               + " having COUNT(ReportName)>1) t"
            //               + " group by repulldate";
            string sqlStr = "SELECT CONVERT(VARCHAR(10),createdate ,120) repulldate,COUNT(id) " +
                                     " FROM [TargetPullingStatus].[dbo].[RepullList] where createdate between '" + startDate + "' and '" + endDate + "' " +
                                      " group by CONVERT(VARCHAR(10),createdate ,120)";
                        


            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    if (sdr[0] == null)
                        continue;
                    Repull repull = new Repull(Convert.ToDateTime(sdr[0].ToString()).ToString("yyyy-MM-dd") + " " + Convert.ToDateTime(sdr[0].ToString()).DayOfWeek.ToString(), int.Parse(sdr[1].ToString()) < 0 ? "0" : sdr[1].ToString(), "Chart");
                    bool flag = true;
                    foreach (Repull data in LsRepull)
                    {
                        if (Convert.ToDateTime(data.c_repulldate.Split(' ')[0]) == Convert.ToDateTime(repull.c_repulldate.Split(' ')[0]))
                        {
                            data.c_ffilecount += repull.c_filecount;
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


        }


        private void getNoTargetpullingStatus(string date)
        {
            string dailyDate = Convert.ToDateTime(date).ToString("yyyyMMdd");
          //  string period = "dateadd(day,7,cast(20030520 as datetime))";
            string sql = "SELECT "
                              + " a.Retailer,"
                              + " a.Vendor,"
                              + " a.FileType,"
                              + " COUNT(distinct FileName) filenumber,"
                              + " max(uploadtime),"
                              + " a.comments"
                              + " FROM [TargetPullingStatus].[dbo].[FileUploadRecord] a join TargetPullingStatus.dbo.FileUploadSet b on"
                              + " a.Retailer=b.Retailer and a.Vendor=b.Vendor and a.FileType=b.FileType"
                              + " where (isStatusbyFileName = 'true' and  ((a.Comments='Daily' and a.FileName like '%'+convert(char(8),dateadd(day,0-Datalag,'" + date + "'),112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'"+ date +"'),  0-Datalag*7) ,112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  5-Datalag*7) ,112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  3-Datalag*7) ,112)+'%' ) or"
                               + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  4-Datalag*7) ,112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  2-Datalag*7) ,112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  1-Datalag*7) ,112)+'%' ) or"
                             // + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'" + date + "'),  7-Datalag*7) ,112)+'%' ) or"
                              + " (a.Comments='Weekly' and a.FileName like  '%'+convert(char(8),DATEADD(wk,  DATEDIFF(wk,0,'"+ date +"'),  6-Datalag*7) ,112)+'%' ) ) )  "
                            + " or (isStatusbyFileName ='false' and convert(char(10),UploadTime,121) = '" + date + "')"
                              + " group by "
                              + " a.Retailer,"
                              + " a.Vendor,"
                              + " a.Comments,"
                 
                              + " a.FileType"
                              + " order by max(uploadtime) desc,Retailer,Vendor,FileType";
  

                   string connStr = ConfigurationManager.ConnectionStrings["68Server"].ConnectionString;
                SqlConnection mySqlConnection = new SqlConnection();
                mySqlConnection.ConnectionString = connStr;
                try
                {
                    mySqlConnection.Open();//打开连接  
                    SqlCommand mycmd = new SqlCommand(sql, mySqlConnection);//新建SqlCommand对象  
                    SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                    while (sdr.Read())
                    {
                     
                            DataPullingFileCountStatus fileCount = new DataPullingFileCountStatus();
                            fileCount.c_retailer =sdr[0].ToString();
                            fileCount.c_vendor=sdr[1].ToString();
                            fileCount.c_dataType=sdr[2].ToString();
                            fileCount.c_filecount=sdr[3].ToString();
                            fileCount.c_finishTime=sdr[4].ToString();
                            fileCount.c_freqency=sdr[5].ToString();
                            ListPullFileStatus.Add(fileCount);
                        
                    }
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
        }
        public void getPullingFileCountStatus_view(string dayTime, string period, string restatementDate, bool attribute, bool isMonday)
        {

            string sql = isMonday ? getMondayStatusSQL(period) : getFileCountStatusSQL(dayTime, period, restatementDate, attribute);

            if (sql != "")
            {
                string connStr = ConfigurationManager.ConnectionStrings["68Server"].ConnectionString;
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
                            DataPullingFileCountStatus fileCount = new DataPullingFileCountStatus(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[6].ToString(), sdr[5].ToString());
                            ListPullFileStatus.Add(fileCount);
                        }
                    }
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

            }



        }
 

        /*2014-12-04 */
        public bool insertNewFileExpect(string dayofwk,string vendor, string datatype, string subgroup, string fileExpect,string delay,string retailer)
        {
            string sqlStr = string.Format("insert into ReportDataType (dayofweek,vendor,datatype,subgroup,fileExpect,delayreason,retailer) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", dayofwk, vendor.Replace("'", "''"), datatype, subgroup, fileExpect, delay, retailer.Replace("'", "''"));
            return connectDB_68server.submit(sqlStr);
        }
        public bool editFileExpect(ReportExpect fileExpect)
        {

            string vendor = fileExpect.c_vendor;
            string dataType = fileExpect.c_datatype;
            string subGroup = fileExpect.c_subgroup;
            string fileCount = fileExpect.c_filexpectuploaded;
            string id = fileExpect.c_expfileid;
            string dayofweek = fileExpect.c_dayofweek;
            string delay = fileExpect.c_delayreason;
            string retailer = fileExpect.c_retailer;
            string sqlStr = "update reportdatatype set "
                            + " dayofweek ='" + dayofweek + "',"
                            + " vendor='" + vendor.Replace("'", "''") + "',"
                            + " datatype='" + dataType + "',"
                            + " subgroup ='" + subGroup.Replace("'", "''") + "',"
                            + " fileexpect='" + fileCount + "',"
                              + " retailer='" + retailer.Replace("'", "''") + "',"
                            + " delayreason='" + delay + "' "
                            + " where id = "+id;
          return  connectDB_68server.submit(sqlStr);

        }

        public bool deleteFileExpect(string  id)
        {
            string sqlStr = "delete from  reportdatatype where id= " + id;
           return  connectDB_68server.submit(sqlStr);
        }
        private DataTable getReportExpectDataTable(string retailer)
        {
            string sqlStr = "select vendor c_vendor,datatype c_datatype,subgroup c_subgroup ,fileexpect c_fileexpect ,id c_id ,dayofweek c_dayofweek,delayreason c_delayreason,retailer c_retailer from ReportDataType"
                            + " where " + retailer
                            + " order by retailer, vendor, datatype,subgroup";

            return connectDB_68server.getTable(sqlStr);
        
        }

        private void getReportExpectData(string retailer)
        {
            string connStr = ConfigurationManager.ConnectionStrings["68Server"].ConnectionString;
            SqlConnection mySqlConnection = new SqlConnection();
            mySqlConnection.ConnectionString = connStr;
            string sqlStr = "select vendor,datatype,subgroup,fileexpect,id,dayofweek,delayreason,retailer from ReportDataType"
                                    + " where " + retailer
                                    + " order by retailer, vendor, datatype,subgroup";

        

            try
            {
                mySqlConnection.Open();//打开连接  
                SqlCommand mycmd = new SqlCommand(sqlStr, mySqlConnection);//新建SqlCommand对象  
                SqlDataReader sdr = mycmd.ExecuteReader();//ExecuteReader方法将 CommandText 发送到 Connection 并生成一个 SqlDataReader  
                while (sdr.Read())
                {
                    ReportExpect reportExpect = new ReportExpect(sdr[4].ToString(), sdr[5].ToString(), sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(),sdr[6].ToString(),"",sdr[7].ToString());

                    ListReportExpect.Add(reportExpect);
                }
                sdr.Close();//读取完毕即关闭  

            }
            catch (SqlException ex)
            {
               ShowMessage( ex.Message);
            }
            catch (Exception ex)
            {
               ShowMessage(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();//关闭连接  


            }


        }
        public DataTable getTescoUKPullingStatus(string stDate)
        {
            return getTescoUKPullingStatusData(stDate);
        }

        public DataTable getUploadRecord(string STtime, string EDtime, string ongoing, string SLA)
        {
            return getUploadRecordData(STtime, EDtime, SLA, ongoing);
         
        }

        public DataTable getUploadPath(string FileSetid)
        {
            return getUploadPathByIDData(FileSetid);
           
        }

        public DataTable getFileSet()
        {
            return getFileSetData();
            
        }

        public List<ReportExpect> getReportExpect(string retailer)
        {
            getReportExpectData(retailer);
            return ListReportExpect;
        }



        public void clearRePullList()
        {
            ListRePullChart.Clear();
        
        }

        public DataTable getNoPerfomances(string startDate, string endDate)
        {
            return getNoTargetSLAChartDatas(startDate, endDate);
        }
        public DataTable getNoPerfomancesByRegionByMonth()
        {
            return getNoTargetSLAChartByRegionDatas();
        }

        public DataTable getNoPerfomancesByRegionPeriod(string stdate, string eddate)
        {
            return getNoTargetSLAChartByRegionPeriodDatas(stdate, eddate);
        }
        public List<Repull> getRePullChart( string startDate, string endDate,List<Repull> LTRepull)
        {
            getRepullChartData(startDate, endDate, LTRepull); 
            return ListRePullChart;
        }
        public List<Repull> getSLAChart(string startDate, string endDate)
        {
            getSLAChartData(startDate, endDate);
            return ListRePullChart;
        }

        public List<DataPullingFileCountStatus> getNoTargetFileCount(string date)
        {
             getNoTargetpullingStatus(date);
            return ListPullFileStatus;
        }

        public DataTable  getAllAccount()
        {
            return getAllAccountData();
        
        }
        public bool editAccount(ConnectorAccount account)
        {
            return editAccountData(account);
        }

        public bool addAccount(ConnectorAccount account)
        {
          return  addAccountData(account);
        }

        public bool addRepullList( List<TargetRepullList> RepullList)
        {

            return addNewRepullData(RepullList);
        }
        public bool editRepull(List<TargetRepullList> RepullList)
        {
            return editRepullData(RepullList);
        }
        public List<DataPullingFileCountStatus> getPullingFileCount(string dayTime, string period, string restatementDate, bool attribute, bool isMonday)
        {
            getPullingFileCountStatus_view(dayTime, period, restatementDate, true, isMonday);
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

        public bool deleteRepullList(string id)
        {
            return deleteRepullListData(id);
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

               ShowMessage(ex.Message);
                
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

                ShowMessage(ex.Message);

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
                        sql += " (retailer = 'Target' and ((reportname not like '%r7%' and ReportName like '" + date + "') or ReportName like '" + period + "' ";//查询daily或者weekly的时间条件     
                        sql +=resdate==""?")": " or ReportName like '" + resdate + "'))";//如果查询R7的数据就把条件附上
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

               ShowMessage(ex.Message);
                
            }
            return query;
        }
    }

   
}
