﻿using System;
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
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}