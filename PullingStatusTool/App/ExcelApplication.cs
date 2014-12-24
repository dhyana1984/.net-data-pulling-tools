using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;

namespace PullingStatusTool
{
    class ExcelApplication
    {
        List<DataPullingFileCountStatus> ListFileStatus = new List<DataPullingFileCountStatus>();
        public ExcelApplication(List<DataPullingFileCountStatus>  Ls_FileCount)
        {
            this.ListFileStatus = Ls_FileCount;
    
        }

        private static void ShowMessage(string strSting)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(strSting, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        public static string getIRCalendarWeek(DateTime date)
        {

            Microsoft.Office.Interop.Excel.Application xApp = new ApplicationClass();
            string weekOfyear = "";
            string path = System.Windows.Forms.Application.StartupPath;
            path += @"\IRCalendar\Target IR Calendar.xlsx";
            try
            {
                Workbook xBook = xApp.Workbooks._Open(path, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                Worksheet xSheet = (Worksheet)xBook.Sheets["IR Calendar"];
                weekOfyear = getWeekOfYear(xSheet, date);
                KillSpecialExcel(xApp);
            }
            catch(Exception ex)
            {
                ShowMessage(path + ": " + ex.Message);
            }

            return weekOfyear;
        
        }
        private static string getWeekOfYear(Worksheet sheet,DateTime date)
        {
            DateTime Date = Convert.ToDateTime(date.ToShortDateString());
            string weekOfyear = "1";
            for (int i =3; i < sheet.Rows.Count; i++)
            {

                Range week = sheet.get_Range("D" + (i-1).ToString(), Type.Missing);
                Range month = sheet.get_Range("B" + (i - 1).ToString(), Type.Missing);
                Range startDate = sheet.get_Range("F" + i.ToString(), Type.Missing);
                Range endDate = sheet.get_Range("G" + i.ToString(), Type.Missing);

                if (startDate.Value2 != null)
                {
                    DateTime dtStart = DateTime.FromOADate(double.Parse(startDate.Value2.ToString()));
                    DateTime dtEnd = DateTime.FromOADate(double.Parse(endDate.Value2.ToString()));
                    if (Date >= dtStart && Date <= dtEnd)
                    {
                        weekOfyear = month.Value2.ToString()+"_"+week.Value2.ToString();
                    }


                }
                else
                {

                    break;
                }
            
            }

            return weekOfyear;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        //推荐这个方法，找了很久，不容易啊
        private static void KillSpecialExcel(Microsoft.Office.Interop.Excel.Application m_objExcel)
        {
            try
            {
                if (m_objExcel != null)
                {
                    int lpdwProcessId;
                    GetWindowThreadProcessId(new IntPtr(m_objExcel.Hwnd), out lpdwProcessId);

                    System.Diagnostics.Process.GetProcessById(lpdwProcessId).Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Excel Process Error:" + ex.Message);
            }
        }
        
    }
}

    

