namespace PullingStatusTool.UserControl
{
    partial class UC_TescoUKStatus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wb_Status = new System.Windows.Forms.WebBrowser();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ReportDate = new DevExpress.XtraEditors.LabelControl();
            this.cbx_Date = new DevExpress.XtraEditors.DateEdit();
            this.txt_days = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Date.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_days.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wb_Status
            // 
            this.wb_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb_Status.Location = new System.Drawing.Point(0, 35);
            this.wb_Status.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Status.Name = "wb_Status";
            this.wb_Status.Size = new System.Drawing.Size(887, 469);
            this.wb_Status.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(259, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(170, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Days";
            // 
            // lbl_ReportDate
            // 
            this.lbl_ReportDate.Location = new System.Drawing.Point(3, 12);
            this.lbl_ReportDate.Name = "lbl_ReportDate";
            this.lbl_ReportDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_ReportDate.TabIndex = 7;
            this.lbl_ReportDate.Text = "Select Date";
            // 
            // cbx_Date
            // 
            this.cbx_Date.EditValue = null;
            this.cbx_Date.Location = new System.Drawing.Point(64, 9);
            this.cbx_Date.Name = "cbx_Date";
            this.cbx_Date.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbx_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_Date.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbx_Date.Size = new System.Drawing.Size(100, 20);
            this.cbx_Date.TabIndex = 6;
            // 
            // txt_days
            // 
            this.txt_days.EditValue = "3";
            this.txt_days.Location = new System.Drawing.Point(200, 9);
            this.txt_days.Name = "txt_days";
            this.txt_days.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_days.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txt_days.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_days.Size = new System.Drawing.Size(53, 20);
            this.txt_days.TabIndex = 11;
            // 
            // UC_TescoUKStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbl_ReportDate);
            this.Controls.Add(this.cbx_Date);
            this.Controls.Add(this.wb_Status);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.Name = "UC_TescoUKStatus";
            this.Size = new System.Drawing.Size(890, 507);
            this.Tag = "TescoUK Pulling Status";
            this.Load += new System.EventHandler(this.UC_TescoUKStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Date.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_days.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_Status;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_ReportDate;
        private DevExpress.XtraEditors.DateEdit cbx_Date;
        private DevExpress.XtraEditors.ComboBoxEdit txt_days;
    }
}
