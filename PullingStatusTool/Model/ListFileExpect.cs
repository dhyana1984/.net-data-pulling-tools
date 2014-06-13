using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    class ListFileExpect
    {
        static public List<ReportExpect> LstReportExpect = new List<ReportExpect>();

       static public void getReportExpect()
        {
            DB_Helper db_helper = new DB_Helper();
            db_helper.getReportExpectData("192.168.10.68", "T3ci94043");
            LstReportExpect = db_helper.getReportExpect();

        }
    }
}
