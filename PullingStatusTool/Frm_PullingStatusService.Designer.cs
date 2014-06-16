namespace PullingStatusTool
{
    partial class Frm_PullingStatusService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PullingStatusService));
            this.GC_PullingFileStatus = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountUpload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountFormatted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DelayReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinishUploaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinishFormatted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.serverIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.finishTm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drp_DailyDate = new DevExpress.XtraEditors.DateEdit();
            this.txt_year = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_month = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Week = new DevExpress.XtraEditors.TextEdit();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_daily = new DevExpress.XtraEditors.CheckEdit();
            this.cbx_weekly = new DevExpress.XtraEditors.CheckEdit();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem_TCGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.rePullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rePullToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sLAMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCoutExpectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbx_78 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_77 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_72 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_71 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_70 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_68 = new DevExpress.XtraEditors.CheckEdit();
            this.cbx_Attrib = new DevExpress.XtraEditors.CheckEdit();
            this.Btn_MondayStatus = new DevExpress.XtraEditors.SimpleButton();
            this.repullSLAChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_daily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_weekly.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Attrib.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_PullingFileStatus
            // 
            this.GC_PullingFileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_PullingFileStatus.Location = new System.Drawing.Point(12, 78);
            this.GC_PullingFileStatus.MainView = this.gridView1;
            this.GC_PullingFileStatus.Name = "GC_PullingFileStatus";
            this.GC_PullingFileStatus.Size = new System.Drawing.Size(840, 521);
            this.GC_PullingFileStatus.TabIndex = 1;
            this.GC_PullingFileStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.dataType,
            this.subgroup,
            this.fileCountUpload,
            this.fileCountFormatted,
            this.DelayReason,
            this.FinishUploaded,
            this.FinishFormatted,
            this.serverIP,
            this.password,
            this.finishTm});
            this.gridView1.GridControl = this.GC_PullingFileStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
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
            this.vendor.Width = 94;
            // 
            // dataType
            // 
            this.dataType.Caption = "DataType";
            this.dataType.FieldName = "c_datatype";
            this.dataType.Name = "dataType";
            this.dataType.OptionsColumn.AllowEdit = false;
            this.dataType.OptionsColumn.AllowSize = false;
            this.dataType.OptionsColumn.ReadOnly = true;
            this.dataType.Visible = true;
            this.dataType.VisibleIndex = 1;
            this.dataType.Width = 85;
            // 
            // subgroup
            // 
            this.subgroup.Caption = "Sub Group";
            this.subgroup.FieldName = "c_subgroup";
            this.subgroup.Name = "subgroup";
            this.subgroup.OptionsColumn.AllowEdit = false;
            this.subgroup.Visible = true;
            this.subgroup.VisibleIndex = 2;
            this.subgroup.Width = 56;
            // 
            // fileCountUpload
            // 
            this.fileCountUpload.Caption = "FileCountUpload";
            this.fileCountUpload.FieldName = "c_filexpectuploaded";
            this.fileCountUpload.Name = "fileCountUpload";
            this.fileCountUpload.OptionsColumn.AllowEdit = false;
            this.fileCountUpload.Visible = true;
            this.fileCountUpload.VisibleIndex = 3;
            this.fileCountUpload.Width = 46;
            // 
            // fileCountFormatted
            // 
            this.fileCountFormatted.Caption = "FileCountFormatted";
            this.fileCountFormatted.FieldName = "c_filexpectformatted";
            this.fileCountFormatted.Name = "fileCountFormatted";
            this.fileCountFormatted.OptionsColumn.AllowEdit = false;
            this.fileCountFormatted.Visible = true;
            this.fileCountFormatted.VisibleIndex = 4;
            this.fileCountFormatted.Width = 53;
            // 
            // DelayReason
            // 
            this.DelayReason.Caption = "delayreason";
            this.DelayReason.FieldName = "c_delayreason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.Visible = true;
            this.DelayReason.VisibleIndex = 5;
            this.DelayReason.Width = 150;
            // 
            // FinishUploaded
            // 
            this.FinishUploaded.Caption = "FinishUploaded";
            this.FinishUploaded.FieldName = "c_finishuploaded";
            this.FinishUploaded.Name = "FinishUploaded";
            this.FinishUploaded.OptionsColumn.AllowEdit = false;
            this.FinishUploaded.OptionsColumn.AllowSize = false;
            this.FinishUploaded.OptionsColumn.ReadOnly = true;
            this.FinishUploaded.Visible = true;
            this.FinishUploaded.VisibleIndex = 6;
            this.FinishUploaded.Width = 59;
            // 
            // FinishFormatted
            // 
            this.FinishFormatted.Caption = "FinishFormatted";
            this.FinishFormatted.FieldName = "c_finishformatted";
            this.FinishFormatted.Name = "FinishFormatted";
            this.FinishFormatted.OptionsColumn.AllowEdit = false;
            this.FinishFormatted.Visible = true;
            this.FinishFormatted.VisibleIndex = 7;
            this.FinishFormatted.Width = 57;
            // 
            // serverIP
            // 
            this.serverIP.Caption = "ServerIP";
            this.serverIP.FieldName = "c_serverIP";
            this.serverIP.Name = "serverIP";
            this.serverIP.Visible = true;
            this.serverIP.VisibleIndex = 8;
            this.serverIP.Width = 79;
            // 
            // password
            // 
            this.password.Caption = "PSW";
            this.password.FieldName = "c_password";
            this.password.Name = "password";
            this.password.OptionsColumn.AllowEdit = false;
            // 
            // finishTm
            // 
            this.finishTm.Caption = "FinishTime";
            this.finishTm.FieldName = "c_finishtime";
            this.finishTm.Name = "finishTm";
            this.finishTm.OptionsColumn.AllowEdit = false;
            this.finishTm.Visible = true;
            this.finishTm.VisibleIndex = 9;
            this.finishTm.Width = 140;
            // 
            // drp_DailyDate
            // 
            this.drp_DailyDate.EditValue = null;
            this.drp_DailyDate.Location = new System.Drawing.Point(12, 52);
            this.drp_DailyDate.Name = "drp_DailyDate";
            this.drp_DailyDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.drp_DailyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drp_DailyDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.drp_DailyDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.drp_DailyDate.Size = new System.Drawing.Size(100, 20);
            this.drp_DailyDate.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(164, 52);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(48, 20);
            this.txt_year.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(136, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "year";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(218, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "month";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(254, 52);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(27, 20);
            this.txt_month.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(287, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "week";
            // 
            // txt_Week
            // 
            this.txt_Week.Location = new System.Drawing.Point(320, 52);
            this.txt_Week.Name = "txt_Week";
            this.txt_Week.Size = new System.Drawing.Size(27, 20);
            this.txt_Week.TabIndex = 10;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(777, 48);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cbx_daily
            // 
            this.cbx_daily.EditValue = true;
            this.cbx_daily.Location = new System.Drawing.Point(10, 27);
            this.cbx_daily.Name = "cbx_daily";
            this.cbx_daily.Properties.Caption = "daily report";
            this.cbx_daily.Size = new System.Drawing.Size(102, 19);
            this.cbx_daily.TabIndex = 12;
            this.cbx_daily.Visible = false;
            this.cbx_daily.CheckedChanged += new System.EventHandler(this.cbx_daily_CheckedChanged);
            // 
            // cbx_weekly
            // 
            this.cbx_weekly.EditValue = true;
            this.cbx_weekly.Location = new System.Drawing.Point(134, 27);
            this.cbx_weekly.Name = "cbx_weekly";
            this.cbx_weekly.Properties.Caption = "weekly report";
            this.cbx_weekly.Size = new System.Drawing.Size(102, 19);
            this.cbx_weekly.TabIndex = 13;
            this.cbx_weekly.Visible = false;
            this.cbx_weekly.CheckedChanged += new System.EventHandler(this.cbx_weekly_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.fToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem_TCGUI,
            this.rePullToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // rToolStripMenuItem_TCGUI
            // 
            this.rToolStripMenuItem_TCGUI.Name = "rToolStripMenuItem_TCGUI";
            this.rToolStripMenuItem_TCGUI.Size = new System.Drawing.Size(182, 22);
            this.rToolStripMenuItem_TCGUI.Text = "TC GUI";
            this.rToolStripMenuItem_TCGUI.Click += new System.EventHandler(this.rToolStripMenuItem_TCGUI_Click);
            // 
            // rePullToolStripMenuItem
            // 
            this.rePullToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rePullToolStripMenuItem1,
            this.sLAMonitorToolStripMenuItem,
            this.repullSLAChartToolStripMenuItem});
            this.rePullToolStripMenuItem.Name = "rePullToolStripMenuItem";
            this.rePullToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rePullToolStripMenuItem.Text = "Pulling Performance";
            // 
            // rePullToolStripMenuItem1
            // 
            this.rePullToolStripMenuItem1.Name = "rePullToolStripMenuItem1";
            this.rePullToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.rePullToolStripMenuItem1.Text = "Re-Pull Monitor";
            this.rePullToolStripMenuItem1.Click += new System.EventHandler(this.rePullToolStripMenuItem1_Click);
            // 
            // sLAMonitorToolStripMenuItem
            // 
            this.sLAMonitorToolStripMenuItem.Name = "sLAMonitorToolStripMenuItem";
            this.sLAMonitorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sLAMonitorToolStripMenuItem.Text = "SLA Monitor";
            this.sLAMonitorToolStripMenuItem.Click += new System.EventHandler(this.sLAMonitorToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCoutExpectToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fToolStripMenuItem.Text = "Settings";
            // 
            // fileCoutExpectToolStripMenuItem
            // 
            this.fileCoutExpectToolStripMenuItem.Name = "fileCoutExpectToolStripMenuItem";
            this.fileCoutExpectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.fileCoutExpectToolStripMenuItem.Text = "File Cout Expect";
            this.fileCoutExpectToolStripMenuItem.Click += new System.EventHandler(this.fileCoutExpectToolStripMenuItem_Click);
            // 
            // ckbx_78
            // 
            this.ckbx_78.EditValue = true;
            this.ckbx_78.Location = new System.Drawing.Point(569, 52);
            this.ckbx_78.Name = "ckbx_78";
            this.ckbx_78.Properties.Caption = "192.168.10.78";
            this.ckbx_78.Size = new System.Drawing.Size(100, 19);
            this.ckbx_78.TabIndex = 21;
            // 
            // ckbx_77
            // 
            this.ckbx_77.EditValue = true;
            this.ckbx_77.Location = new System.Drawing.Point(459, 52);
            this.ckbx_77.Name = "ckbx_77";
            this.ckbx_77.Properties.Caption = "192.168.10.77";
            this.ckbx_77.Size = new System.Drawing.Size(97, 19);
            this.ckbx_77.TabIndex = 20;
            // 
            // ckbx_72
            // 
            this.ckbx_72.EditValue = true;
            this.ckbx_72.Location = new System.Drawing.Point(353, 52);
            this.ckbx_72.Name = "ckbx_72";
            this.ckbx_72.Properties.Caption = "192.168.10.72";
            this.ckbx_72.Size = new System.Drawing.Size(100, 19);
            this.ckbx_72.TabIndex = 19;
            // 
            // ckbx_71
            // 
            this.ckbx_71.EditValue = true;
            this.ckbx_71.Location = new System.Drawing.Point(569, 26);
            this.ckbx_71.Name = "ckbx_71";
            this.ckbx_71.Properties.Caption = "192.168.10.71";
            this.ckbx_71.Size = new System.Drawing.Size(100, 19);
            this.ckbx_71.TabIndex = 18;
            // 
            // ckbx_70
            // 
            this.ckbx_70.EditValue = true;
            this.ckbx_70.Location = new System.Drawing.Point(459, 25);
            this.ckbx_70.Name = "ckbx_70";
            this.ckbx_70.Properties.Caption = "192.168.28.70";
            this.ckbx_70.Size = new System.Drawing.Size(101, 19);
            this.ckbx_70.TabIndex = 17;
            // 
            // ckbx_68
            // 
            this.ckbx_68.Location = new System.Drawing.Point(353, 27);
            this.ckbx_68.Name = "ckbx_68";
            this.ckbx_68.Properties.Caption = "192.168.10.68";
            this.ckbx_68.Size = new System.Drawing.Size(100, 19);
            this.ckbx_68.TabIndex = 16;
            // 
            // cbx_Attrib
            // 
            this.cbx_Attrib.EditValue = true;
            this.cbx_Attrib.Location = new System.Drawing.Point(242, 26);
            this.cbx_Attrib.Name = "cbx_Attrib";
            this.cbx_Attrib.Properties.Caption = "attrib";
            this.cbx_Attrib.Size = new System.Drawing.Size(102, 19);
            this.cbx_Attrib.TabIndex = 22;
            this.cbx_Attrib.Visible = false;
            this.cbx_Attrib.CheckedChanged += new System.EventHandler(this.cbx_Attrib_CheckedChanged);
            // 
            // Btn_MondayStatus
            // 
            this.Btn_MondayStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MondayStatus.Location = new System.Drawing.Point(696, 48);
            this.Btn_MondayStatus.Name = "Btn_MondayStatus";
            this.Btn_MondayStatus.Size = new System.Drawing.Size(75, 23);
            this.Btn_MondayStatus.TabIndex = 23;
            this.Btn_MondayStatus.Text = "Monday";
            this.Btn_MondayStatus.Click += new System.EventHandler(this.Btn_MondayStatus_Click);
            // 
            // repullSLAChartToolStripMenuItem
            // 
            this.repullSLAChartToolStripMenuItem.Name = "repullSLAChartToolStripMenuItem";
            this.repullSLAChartToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.repullSLAChartToolStripMenuItem.Text = "Repull/SLA Chart";
            this.repullSLAChartToolStripMenuItem.Click += new System.EventHandler(this.repullSLAChartToolStripMenuItem_Click);
            // 
            // Frm_PullingStatusService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.Btn_MondayStatus);
            this.Controls.Add(this.cbx_Attrib);
            this.Controls.Add(this.ckbx_78);
            this.Controls.Add(this.ckbx_77);
            this.Controls.Add(this.ckbx_72);
            this.Controls.Add(this.ckbx_71);
            this.Controls.Add(this.ckbx_70);
            this.Controls.Add(this.ckbx_68);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cbx_weekly);
            this.Controls.Add(this.cbx_daily);
            this.Controls.Add(this.txt_Week);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.drp_DailyDate);
            this.Controls.Add(this.GC_PullingFileStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PullingStatusService";
            this.Text = "PullingStatusTool v1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PullingStatusService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_daily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_weekly.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Attrib.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_PullingFileStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn FinishUploaded;
        private DevExpress.XtraGrid.Columns.GridColumn serverIP;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountUpload;
        private DevExpress.XtraEditors.DateEdit drp_DailyDate;
        private DevExpress.XtraEditors.TextEdit txt_year;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_month;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Week;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.CheckEdit cbx_daily;
        private DevExpress.XtraEditors.CheckEdit cbx_weekly;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem_TCGUI;
        private DevExpress.XtraEditors.CheckEdit ckbx_78;
        private DevExpress.XtraEditors.CheckEdit ckbx_77;
        private DevExpress.XtraEditors.CheckEdit ckbx_72;
        private DevExpress.XtraEditors.CheckEdit ckbx_71;
        private DevExpress.XtraEditors.CheckEdit ckbx_70;
        private DevExpress.XtraEditors.CheckEdit ckbx_68;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private DevExpress.XtraEditors.CheckEdit cbx_Attrib;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileCoutExpectToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn FinishFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraGrid.Columns.GridColumn finishTm;
        private System.Windows.Forms.ToolStripMenuItem rePullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rePullToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sLAMonitorToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton Btn_MondayStatus;
        private System.Windows.Forms.ToolStripMenuItem repullSLAChartToolStripMenuItem;
    }
}