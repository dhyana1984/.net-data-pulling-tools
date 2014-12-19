using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace PullingStatusTool.UserControl
{
    public partial class UC_Functions : DevExpress.XtraEditors.XtraUserControl
    {
        public static DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        public UC_Functions()
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            defaultLookAndFeel.LookAndFeel.SkinName = "Black";
 
        }
    }
}
