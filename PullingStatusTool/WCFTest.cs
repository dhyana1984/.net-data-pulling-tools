using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using PullingStatusTool.App;


namespace PullingStatusTool
{
    public partial class WCFTest : DevExpress.XtraEditors.XtraForm
    {
        public WCFTest()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         //   string url = "http://localhost:54784/test/PostTestAPI";
        string url = "http://localhost:8002/test/1";
            WebClient WC = new WebClient();
            UploadFilePath patha = new UploadFilePath("aa", "aa", "aa", "aa");
            UploadFilePath pathb = new UploadFilePath("bb", "bb", "bb", "bb");
            List<UploadFilePath> listPath = new List<UploadFilePath>();
            listPath.Add(patha);
            listPath.Add(pathb);
            string json = JsonHelper.JsonSerializer<List<UploadFilePath>>(listPath);
            WC.Headers[HttpRequestHeader.ContentType] = "application/json";
            NetworkCredential myCred = new NetworkCredential();
            myCred.UserName = "chris";
            myCred.Password = "123";      
          WC.Credentials = myCred;
     //       string isSucess = WC.UploadString(url, "POST", json);
            //UploadFilePath path = new UploadFilePath();
            string result = WC.DownloadString(url);
        }
    }
}