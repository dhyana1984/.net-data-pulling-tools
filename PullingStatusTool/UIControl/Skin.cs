using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using PullingStatusTool;

namespace PullingStatusTool.UIControl
{
  public  class XtaFrm_Skin : DevExpress.XtraEditors.XtraForm
    {
   　 public static DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel=new DevExpress.LookAndFeel.DefaultLookAndFeel();

     private void InitializeComponent()
     {
            this.SuspendLayout();
            // 
            // XtaFrm_Skin
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.LookAndFeel.SkinName = "Black";
            this.Name = "XtaFrm_Skin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

     }
 
    }
}
