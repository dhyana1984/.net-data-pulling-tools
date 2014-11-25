using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PullingStatusTool.UserControl
{
    public partial class UC_WMBasket : UC_Functions
    {
        public UC_WMBasket()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string stores =txt_Stores.Text;
            txt_Stores.Text = getRidOfSpace(stores);
        }

        private string getRidOfSpace(string str)
        {
            return str.Replace(" ", "");
        
        }
    }
}
