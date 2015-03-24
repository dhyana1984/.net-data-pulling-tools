using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PullingStatusTool.RestfulAPI
{
    class WCFRestfulAPI
    {
      string URL = "http://192.168.10.68:8002/";//WCF Restful api的地址，但是调用不同的api要加不同参数
  //    string URL = "http://localhost:8002/";//WCF Restful api的地址，但是调用不同的api要加不同参数
        /*GET的API, 需要传入参数condition去获取目标资源*/
        private string GetAPIJsonResult(string condition)
        {
            string address = URL + condition;
            string result = "";
            Uri uri = new Uri(address,UriKind.Absolute);
            WebClient client = new WebClient();
            try
            {
                if (!client.IsBusy)
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    result = client.DownloadString(uri);
                }

            }
            catch (Exception e)
            {

            }
            return result;
        }

        /*获得TescoUK pulling status html 代码的api*/
        /*days 和 cbxdate 2个参数，days是显示多少天，cbxdate是开始日期*/
        public string GetTescoUKStatusHtm(string days,string cbxdate)
        {
            string html = "";
            html = GetAPIJsonResult("PullingStatusAPI/TescoUKPullingStatus/cbxdate/"+cbxdate+"/days/"+days);
                return html;
        }

        public string GetTargetPullingStatus(string isMonday, string dailyDate, string year, string month, string week)
        {
      
            string result = "";
            string URL = string.Format("PullingStatusAPI/TargetPullingStatus/isMonday/{0}/dailyDate/{1}/year/{2}/month/{3}/week/{4}", isMonday, dailyDate, year, month, week);
            result = GetAPIJsonResult(URL);
            return result;
        }


    }
}
