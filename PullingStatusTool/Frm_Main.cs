using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.UserControl;
using System.Reflection;

namespace PullingStatusTool
{
    public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void labelControl1_Paint(object sender, PaintEventArgs e)
        {
            labelControl1.Text = "RSi " + this.Text;//显示主页面的欢迎信息
        }
        //======先实例化所有的功能，由于是用split container加载，所以全部是用户控件
        UC_FileExpectMgr UC_ExpectFile = new UC_FileExpectMgr();
        UC_FileSetMgr UC_filesetMgr = new UC_FileSetMgr();
        UC_NoTargetMonitor UC_noTargetStatus = new UC_NoTargetMonitor();
        UC_TargetDPChart UC_TargetChart = new UC_TargetDPChart();
        UC_TargetMonitor UC_TargetStatus = new UC_TargetMonitor();
        UC_UploadRecord UC_UploadRecord = new UC_UploadRecord();
        UC_NoTargetDPChart UC_NoTargetChart = new UC_NoTargetDPChart();
        UC_MRSConnector UC_MorrisonConnector = new UC_MRSConnector();
        UC_AccountManagement UC_AccountMgr = new UC_AccountManagement();
        UC_WMBasket UC_Basket = new UC_WMBasket();
        UC_TescoUKStatus UC_TscUKStatus = new UC_TescoUKStatus();
        UC_TescoUKConnector UC_TescoUKConn = new UC_TescoUKConnector();
        private void showFunctions(UC_Functions function,bool valid)//加载功能用户控件的统一方法
        {
       
            bool flag = false;
            if (!valid)//需不需要密码
            {
                flag = true;
            }
            else
            {
                Frm_Password password = new Frm_Password();
                if (!Users.Flag)
                {
                    if (password.ShowDialog() == DialogResult.OK)
                    {
                        Users.Flag = true;
                        flag = true;
                    }
                }
                else
                {
                    flag = true;
                }
            }
            if (flag)
            {
                splitContainerControl1.Panel2.Controls.Clear();
                splitContainerControl1.Panel2.Controls.Add(function);
                function.Show();
                this.Text = this.Text.Split('-')[0].TrimEnd() + " - " + function.Tag;//在主界面上显示界面功能名称
            }

        }


        private void item_expectfile_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            showFunctions(UC_ExpectFile, true);

        }

        private void item_fileset_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {


            showFunctions(UC_filesetMgr, true);
        }

        private void item_target_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            showFunctions(UC_TargetStatus,false);
        }

        private void item_notarget_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_noTargetStatus,false);

        }

        private void item_uploadrecord_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_UploadRecord, false);
        }

        private void item_targetchart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_TargetChart,true);
        }

        private void item_notargetchart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_NoTargetChart,true);
        }

        private void item_morrison_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            showFunctions(UC_MorrisonConnector,true);
        }



        private void item_AccountMgr_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            showFunctions(UC_AccountMgr,true);
        }

        private void item_wmbasket_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_Basket,true);
        }

        private void item_TescoStatus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_TscUKStatus, false);
        }

        private void item_tescoUK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showFunctions(UC_TescoUKConn, true);
        }


  
    }
}