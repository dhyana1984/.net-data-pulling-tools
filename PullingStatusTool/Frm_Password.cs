using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PullingStatusTool
{
    public partial class Frm_Password : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Password()
        {
            InitializeComponent();
        }




        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "T3ci94043")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sorry, you don't have access to this form");
                txt_password.SelectAll();
                txt_password.Focus();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)     //检测是否按Enter键
            {
                if (txt_password.Text == "T3ci94043")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sorry, you don't have access to this form");
                }
            
            }
        }



    }
}