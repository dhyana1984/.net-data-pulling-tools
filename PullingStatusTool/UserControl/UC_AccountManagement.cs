using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PullingStatusTool.Model;

namespace PullingStatusTool.UserControl
{
    public partial class UC_AccountManagement : UC_Functions
    {
        public UC_AccountManagement()
        {
            InitializeComponent();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {

            getDS();
        }

        private void getDS()
        {
            DB_Helper dbhelper = new DB_Helper();
            gc_Account.DataSource = dbhelper.getAllAccount();
        
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                DB_Helper dbhelper = new DB_Helper();
                ConnectorAccount account = new ConnectorAccount();
                account.c_owner = txt_Owner.Text;
                account.c_accountname = txt_Account.Text;
                account.c_password = txt_Password.Text;
                account.c_retailer = txt_Retailer.Text;
                account.c_vendor = txt_Vendor.Text;
                account.c_subvendor = txt_Subvendor.Text;
                account.c_category = txt_Category.Text;
                account.c_id = id;
                if(dbhelper.editAccount(account))
                getDS();
            }
        }
        string id = "";
        private void gc_Account_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("c_id") != null)
            {
               txt_Account.Text = gridView1.GetFocusedRowCellValue("c_accountname").ToString().Trim();
               txt_Category.Text = gridView1.GetFocusedRowCellValue("c_category").ToString();
              txt_Password.Text = gridView1.GetFocusedRowCellValue("c_password").ToString().Trim();
                txt_Retailer.Text = gridView1.GetFocusedRowCellValue("c_retailer").ToString().Trim();
                id = gridView1.GetFocusedRowCellValue("c_id").ToString().Trim();
                txt_Owner.Text = gridView1.GetFocusedRowCellValue("c_owner").ToString().Trim();
                txt_Vendor.Text = gridView1.GetFocusedRowCellValue("c_vendor").ToString().Trim();
                txt_Subvendor.Text = gridView1.GetFocusedRowCellValue("c_subvendor").ToString().Trim();

            }
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            DB_Helper dbhelper = new DB_Helper();
            ConnectorAccount account = new ConnectorAccount();
            account.c_accountname = txt_Account.Text;
            account.c_category = txt_Category.Text;
            account.c_password = txt_Password.Text;
            account.c_retailer = txt_Retailer.Text;
            account.c_owner = txt_Owner.Text;
            account.c_subvendor = txt_Subvendor.Text;
            account.c_vendor = txt_Vendor.Text;
            if(dbhelper.addAccount(account))
            getDS();
        }
    }
}
