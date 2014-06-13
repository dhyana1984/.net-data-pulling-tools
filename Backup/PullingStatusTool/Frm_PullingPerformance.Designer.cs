namespace PullingStatusTool
{
    partial class Frm_PullingPerformance
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PullingPerformance));
            this.drp_DailyDate = new DevExpress.XtraEditors.DateEdit();
            this.ckbx_78 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_77 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_72 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_71 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_70 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_68 = new DevExpress.XtraEditors.CheckEdit();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Performance = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datatype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ontimeupload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lateupload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ontimeformat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lateformat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstformattime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastformattime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Performance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // drp_DailyDate
            // 
            this.drp_DailyDate.EditValue = null;
            this.drp_DailyDate.Location = new System.Drawing.Point(12, 37);
            this.drp_DailyDate.Name = "drp_DailyDate";
            this.drp_DailyDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.drp_DailyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drp_DailyDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.drp_DailyDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.drp_DailyDate.Size = new System.Drawing.Size(100, 20);
            this.drp_DailyDate.TabIndex = 0;
            // 
            // ckbx_78
            // 
            this.ckbx_78.EditValue = true;
            this.ckbx_78.Location = new System.Drawing.Point(358, 39);
            this.ckbx_78.Name = "ckbx_78";
            this.ckbx_78.Properties.Caption = "192.168.10.78";
            this.ckbx_78.Size = new System.Drawing.Size(100, 19);
            this.ckbx_78.TabIndex = 27;
            // 
            // ckbx_77
            // 
            this.ckbx_77.EditValue = true;
            this.ckbx_77.Location = new System.Drawing.Point(248, 39);
            this.ckbx_77.Name = "ckbx_77";
            this.ckbx_77.Properties.Caption = "192.168.10.77";
            this.ckbx_77.Size = new System.Drawing.Size(97, 19);
            this.ckbx_77.TabIndex = 26;
            // 
            // ckbx_72
            // 
            this.ckbx_72.EditValue = true;
            this.ckbx_72.Location = new System.Drawing.Point(142, 39);
            this.ckbx_72.Name = "ckbx_72";
            this.ckbx_72.Properties.Caption = "192.168.10.72";
            this.ckbx_72.Size = new System.Drawing.Size(100, 19);
            this.ckbx_72.TabIndex = 25;
            // 
            // ckbx_71
            // 
            this.ckbx_71.EditValue = true;
            this.ckbx_71.Location = new System.Drawing.Point(358, 13);
            this.ckbx_71.Name = "ckbx_71";
            this.ckbx_71.Properties.Caption = "192.168.10.71";
            this.ckbx_71.Size = new System.Drawing.Size(100, 19);
            this.ckbx_71.TabIndex = 24;
            // 
            // ckbx_70
            // 
            this.ckbx_70.EditValue = true;
            this.ckbx_70.Location = new System.Drawing.Point(248, 12);
            this.ckbx_70.Name = "ckbx_70";
            this.ckbx_70.Properties.Caption = "192.168.28.70";
            this.ckbx_70.Size = new System.Drawing.Size(101, 19);
            this.ckbx_70.TabIndex = 23;
            // 
            // ckbx_68
            // 
            this.ckbx_68.Location = new System.Drawing.Point(142, 14);
            this.ckbx_68.Name = "ckbx_68";
            this.ckbx_68.Properties.Caption = "192.168.10.68";
            this.ckbx_68.Size = new System.Drawing.Size(100, 19);
            this.ckbx_68.TabIndex = 22;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(723, 34);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // GC_Performance
            // 
            this.GC_Performance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_Performance.Location = new System.Drawing.Point(12, 64);
            this.GC_Performance.MainView = this.gridView1;
            this.GC_Performance.Name = "GC_Performance";
            this.GC_Performance.Size = new System.Drawing.Size(786, 331);
            this.GC_Performance.TabIndex = 29;
            this.GC_Performance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.datatype,
            this.ontimeupload,
            this.lateupload,
            this.ontimeformat,
            this.lateformat,
            this.firstformattime,
            this.lastformattime});
            this.gridView1.GridControl = this.GC_Performance;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 0;
            // 
            // datatype
            // 
            this.datatype.Caption = "DataType";
            this.datatype.FieldName = "c_datatype";
            this.datatype.Name = "datatype";
            this.datatype.OptionsColumn.AllowEdit = false;
            this.datatype.Visible = true;
            this.datatype.VisibleIndex = 1;
            // 
            // ontimeupload
            // 
            this.ontimeupload.Caption = "OnTimeLoad";
            this.ontimeupload.FieldName = "c_ontimeupload";
            this.ontimeupload.Name = "ontimeupload";
            this.ontimeupload.OptionsColumn.AllowEdit = false;
            this.ontimeupload.Visible = true;
            this.ontimeupload.VisibleIndex = 2;
            // 
            // lateupload
            // 
            this.lateupload.Caption = "LateLoad";
            this.lateupload.FieldName = "c_lateupload";
            this.lateupload.Name = "lateupload";
            this.lateupload.OptionsColumn.AllowEdit = false;
            this.lateupload.Visible = true;
            this.lateupload.VisibleIndex = 3;
            // 
            // ontimeformat
            // 
            this.ontimeformat.Caption = "OnTimeFormat";
            this.ontimeformat.FieldName = "c_ontimeformat";
            this.ontimeformat.Name = "ontimeformat";
            this.ontimeformat.OptionsColumn.AllowEdit = false;
            this.ontimeformat.Visible = true;
            this.ontimeformat.VisibleIndex = 4;
            // 
            // lateformat
            // 
            this.lateformat.Caption = "LateFormat";
            this.lateformat.FieldName = "c_lateformat";
            this.lateformat.Name = "lateformat";
            this.lateformat.OptionsColumn.AllowEdit = false;
            this.lateformat.Visible = true;
            this.lateformat.VisibleIndex = 5;
            // 
            // firstformattime
            // 
            this.firstformattime.Caption = "FstFormatTime";
            this.firstformattime.FieldName = "c_firstformattime";
            this.firstformattime.Name = "firstformattime";
            this.firstformattime.OptionsColumn.AllowEdit = false;
            this.firstformattime.Visible = true;
            this.firstformattime.VisibleIndex = 6;
            // 
            // lastformattime
            // 
            this.lastformattime.Caption = "LstFormatTime";
            this.lastformattime.FieldName = "c_lastformattime";
            this.lastformattime.Name = "lastformattime";
            this.lastformattime.OptionsColumn.AllowEdit = false;
            this.lastformattime.Visible = true;
            this.lastformattime.VisibleIndex = 7;
            // 
            // Frm_PullingPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 407);
            this.Controls.Add(this.GC_Performance);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.ckbx_78);
            this.Controls.Add(this.ckbx_77);
            this.Controls.Add(this.ckbx_72);
            this.Controls.Add(this.ckbx_71);
            this.Controls.Add(this.ckbx_70);
            this.Controls.Add(this.ckbx_68);
            this.Controls.Add(this.drp_DailyDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PullingPerformance";
            this.Text = "Frm_PullingPerformance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PullingPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Performance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit drp_DailyDate;
        private DevExpress.XtraEditors.CheckEdit ckbx_78;
        private DevExpress.XtraEditors.CheckEdit ckbx_77;
        private DevExpress.XtraEditors.CheckEdit ckbx_72;
        private DevExpress.XtraEditors.CheckEdit ckbx_71;
        private DevExpress.XtraEditors.CheckEdit ckbx_70;
        private DevExpress.XtraEditors.CheckEdit ckbx_68;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraGrid.GridControl GC_Performance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn datatype;
        private DevExpress.XtraGrid.Columns.GridColumn ontimeupload;
        private DevExpress.XtraGrid.Columns.GridColumn lateupload;
        private DevExpress.XtraGrid.Columns.GridColumn ontimeformat;
        private DevExpress.XtraGrid.Columns.GridColumn lateformat;
        private DevExpress.XtraGrid.Columns.GridColumn firstformattime;
        private DevExpress.XtraGrid.Columns.GridColumn lastformattime;
    }
}