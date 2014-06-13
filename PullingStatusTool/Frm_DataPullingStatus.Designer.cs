namespace PullingStatusTool
{
    partial class Frm_DataPullingStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DataPullingStatus));
            this.GC_PullingStatus = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.starttime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.downloadingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formattingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.configname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.eventid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.serverIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IRaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataperiod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_StartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.ckbx_68 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_70 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_71 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_72 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_77 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_78 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_PullingStatus
            // 
            this.GC_PullingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_PullingStatus.Location = new System.Drawing.Point(12, 67);
            this.GC_PullingStatus.MainView = this.gridView1;
            this.GC_PullingStatus.Name = "GC_PullingStatus";
            this.GC_PullingStatus.Size = new System.Drawing.Size(682, 438);
            this.GC_PullingStatus.TabIndex = 0;
            this.GC_PullingStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GC_PullingStatus.DoubleClick += new System.EventHandler(this.GC_PullingStatus_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.dataType,
            this.status,
            this.starttime,
            this.downloadingStatus,
            this.formattingStatus,
            this.uploadingStatus,
            this.configname,
            this.eventid,
            this.serverIP,
            this.password,
            this.IRaccount,
            this.dataperiod});
            this.gridView1.GridControl = this.GC_PullingStatus;
            this.gridView1.Name = "gridView1";
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.OptionsColumn.AllowSize = false;
            this.vendor.OptionsColumn.ReadOnly = true;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 0;
            // 
            // dataType
            // 
            this.dataType.Caption = "ScheduleName";
            this.dataType.FieldName = "c_dataType";
            this.dataType.Name = "dataType";
            this.dataType.OptionsColumn.AllowEdit = false;
            this.dataType.OptionsColumn.AllowSize = false;
            this.dataType.OptionsColumn.ReadOnly = true;
            this.dataType.Visible = true;
            this.dataType.VisibleIndex = 2;
            // 
            // status
            // 
            this.status.Caption = "Status";
            this.status.FieldName = "c_status";
            this.status.Name = "status";
            this.status.OptionsColumn.AllowEdit = false;
            this.status.OptionsColumn.AllowSize = false;
            this.status.OptionsColumn.ReadOnly = true;
            this.status.Visible = true;
            this.status.VisibleIndex = 4;
            // 
            // starttime
            // 
            this.starttime.Caption = "Starttime";
            this.starttime.FieldName = "c_starttime";
            this.starttime.Name = "starttime";
            this.starttime.OptionsColumn.AllowEdit = false;
            this.starttime.OptionsColumn.AllowSize = false;
            this.starttime.OptionsColumn.ReadOnly = true;
            this.starttime.Visible = true;
            this.starttime.VisibleIndex = 5;
            // 
            // downloadingStatus
            // 
            this.downloadingStatus.Caption = "DownloadingStatus";
            this.downloadingStatus.FieldName = "c_downloadingStatus";
            this.downloadingStatus.Name = "downloadingStatus";
            this.downloadingStatus.OptionsColumn.AllowEdit = false;
            this.downloadingStatus.OptionsColumn.AllowSize = false;
            this.downloadingStatus.OptionsColumn.ReadOnly = true;
            this.downloadingStatus.Visible = true;
            this.downloadingStatus.VisibleIndex = 6;
            // 
            // formattingStatus
            // 
            this.formattingStatus.Caption = "FormattingStatus";
            this.formattingStatus.FieldName = "c_formattingStatus";
            this.formattingStatus.Name = "formattingStatus";
            this.formattingStatus.OptionsColumn.AllowEdit = false;
            this.formattingStatus.OptionsColumn.AllowSize = false;
            this.formattingStatus.OptionsColumn.ReadOnly = true;
            this.formattingStatus.Visible = true;
            this.formattingStatus.VisibleIndex = 7;
            // 
            // uploadingStatus
            // 
            this.uploadingStatus.Caption = "UploadingStatus";
            this.uploadingStatus.FieldName = "c_uploadingStatus";
            this.uploadingStatus.Name = "uploadingStatus";
            this.uploadingStatus.OptionsColumn.AllowEdit = false;
            this.uploadingStatus.OptionsColumn.AllowSize = false;
            this.uploadingStatus.OptionsColumn.ReadOnly = true;
            this.uploadingStatus.Visible = true;
            this.uploadingStatus.VisibleIndex = 8;
            // 
            // configname
            // 
            this.configname.Caption = "ConfigName";
            this.configname.FieldName = "c_configName";
            this.configname.Name = "configname";
            this.configname.OptionsColumn.AllowEdit = false;
            this.configname.Visible = true;
            this.configname.VisibleIndex = 1;
            // 
            // eventid
            // 
            this.eventid.Caption = "EventID";
            this.eventid.FieldName = "c_eventid";
            this.eventid.Name = "eventid";
            // 
            // serverIP
            // 
            this.serverIP.Caption = "ServerIP";
            this.serverIP.FieldName = "c_serverIP";
            this.serverIP.Name = "serverIP";
            this.serverIP.OptionsColumn.AllowEdit = false;
            this.serverIP.Visible = true;
            this.serverIP.VisibleIndex = 9;
            // 
            // password
            // 
            this.password.Caption = "PSW";
            this.password.FieldName = "c_password";
            this.password.Name = "password";
            this.password.OptionsColumn.AllowEdit = false;
            // 
            // IRaccount
            // 
            this.IRaccount.Caption = "IRAccount";
            this.IRaccount.FieldName = "c_IRaccount";
            this.IRaccount.Name = "IRaccount";
            this.IRaccount.OptionsColumn.AllowEdit = false;
            this.IRaccount.Visible = true;
            this.IRaccount.VisibleIndex = 3;
            // 
            // dataperiod
            // 
            this.dataperiod.Caption = "DataPeriod";
            this.dataperiod.FieldName = "c_dataperiod";
            this.dataperiod.Name = "dataperiod";
            this.dataperiod.OptionsColumn.AllowEdit = false;
            this.dataperiod.Visible = true;
            this.dataperiod.VisibleIndex = 10;
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.EditValue = null;
            this.txt_StartDate.Location = new System.Drawing.Point(66, 12);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_StartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_StartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_StartDate.Size = new System.Drawing.Size(127, 20);
            this.txt_StartDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "StartDate";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "EndDate";
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.EditValue = null;
            this.txt_EndDate.Location = new System.Drawing.Point(66, 41);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_EndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_EndDate.Size = new System.Drawing.Size(127, 20);
            this.txt_EndDate.TabIndex = 3;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Location = new System.Drawing.Point(619, 38);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // ckbx_68
            // 
            this.ckbx_68.Location = new System.Drawing.Point(199, 17);
            this.ckbx_68.Name = "ckbx_68";
            this.ckbx_68.Properties.Caption = "192.168.10.68";
            this.ckbx_68.Size = new System.Drawing.Size(100, 19);
            this.ckbx_68.TabIndex = 6;
            // 
            // ckbx_70
            // 
            this.ckbx_70.EditValue = true;
            this.ckbx_70.Location = new System.Drawing.Point(305, 15);
            this.ckbx_70.Name = "ckbx_70";
            this.ckbx_70.Properties.Caption = "192.168.28.70";
            this.ckbx_70.Size = new System.Drawing.Size(101, 19);
            this.ckbx_70.TabIndex = 7;
            // 
            // ckbx_71
            // 
            this.ckbx_71.EditValue = true;
            this.ckbx_71.Location = new System.Drawing.Point(415, 16);
            this.ckbx_71.Name = "ckbx_71";
            this.ckbx_71.Properties.Caption = "192.168.10.71";
            this.ckbx_71.Size = new System.Drawing.Size(100, 19);
            this.ckbx_71.TabIndex = 8;
            // 
            // ckbx_72
            // 
            this.ckbx_72.EditValue = true;
            this.ckbx_72.Location = new System.Drawing.Point(199, 42);
            this.ckbx_72.Name = "ckbx_72";
            this.ckbx_72.Properties.Caption = "192.168.10.72";
            this.ckbx_72.Size = new System.Drawing.Size(100, 19);
            this.ckbx_72.TabIndex = 9;
            // 
            // ckbx_77
            // 
            this.ckbx_77.EditValue = true;
            this.ckbx_77.Location = new System.Drawing.Point(305, 42);
            this.ckbx_77.Name = "ckbx_77";
            this.ckbx_77.Properties.Caption = "192.168.10.77";
            this.ckbx_77.Size = new System.Drawing.Size(97, 19);
            this.ckbx_77.TabIndex = 10;
            // 
            // ckbx_78
            // 
            this.ckbx_78.EditValue = true;
            this.ckbx_78.Location = new System.Drawing.Point(415, 42);
            this.ckbx_78.Name = "ckbx_78";
            this.ckbx_78.Properties.Caption = "192.168.10.78";
            this.ckbx_78.Size = new System.Drawing.Size(100, 19);
            this.ckbx_78.TabIndex = 11;
            // 
            // Frm_DataPullingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 517);
            this.Controls.Add(this.ckbx_78);
            this.Controls.Add(this.ckbx_77);
            this.Controls.Add(this.ckbx_72);
            this.Controls.Add(this.ckbx_71);
            this.Controls.Add(this.ckbx_70);
            this.Controls.Add(this.ckbx_68);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_EndDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_StartDate);
            this.Controls.Add(this.GC_PullingStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DataPullingStatus";
            this.Text = "PullingStatusTool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_DataPullingStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_PullingStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn starttime;
        private DevExpress.XtraGrid.Columns.GridColumn downloadingStatus;
        private DevExpress.XtraGrid.Columns.GridColumn formattingStatus;
        private DevExpress.XtraGrid.Columns.GridColumn uploadingStatus;
        private DevExpress.XtraEditors.DateEdit txt_StartDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txt_EndDate;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn configname;
        private DevExpress.XtraGrid.Columns.GridColumn eventid;
        private DevExpress.XtraGrid.Columns.GridColumn serverIP;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraEditors.CheckEdit ckbx_68;
        private DevExpress.XtraEditors.CheckEdit ckbx_70;
        private DevExpress.XtraEditors.CheckEdit ckbx_71;
        private DevExpress.XtraEditors.CheckEdit ckbx_72;
        private DevExpress.XtraEditors.CheckEdit ckbx_77;
        private DevExpress.XtraEditors.CheckEdit ckbx_78;
        private DevExpress.XtraGrid.Columns.GridColumn IRaccount;
        private DevExpress.XtraGrid.Columns.GridColumn dataperiod;

    }
}

