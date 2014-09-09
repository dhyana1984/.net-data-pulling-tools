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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem_TCGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.rePullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repullSLAChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCoutExpectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_MondayStatus = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uploadRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_PullingFileStatus
            // 
            this.GC_PullingFileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_PullingFileStatus.Location = new System.Drawing.Point(12, 57);
            this.GC_PullingFileStatus.MainView = this.gridView1;
            this.GC_PullingFileStatus.Name = "GC_PullingFileStatus";
            this.GC_PullingFileStatus.Size = new System.Drawing.Size(840, 542);
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
            this.vendor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.drp_DailyDate.Location = new System.Drawing.Point(81, 31);
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
            this.txt_year.Location = new System.Drawing.Point(215, 31);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(48, 20);
            this.txt_year.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(187, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "year";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(269, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "month";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(305, 31);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(27, 20);
            this.txt_month.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(338, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "week";
            // 
            // txt_Week
            // 
            this.txt_Week.Location = new System.Drawing.Point(371, 31);
            this.txt_Week.Name = "txt_Week";
            this.txt_Week.Size = new System.Drawing.Size(27, 20);
            this.txt_Week.TabIndex = 10;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(485, 28);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            this.rePullToolStripMenuItem,
            this.uploadRecordToolStripMenuItem});
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
            this.repullSLAChartToolStripMenuItem});
            this.rePullToolStripMenuItem.Name = "rePullToolStripMenuItem";
            this.rePullToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rePullToolStripMenuItem.Text = "Pulling Performance";
            // 
            // repullSLAChartToolStripMenuItem
            // 
            this.repullSLAChartToolStripMenuItem.Name = "repullSLAChartToolStripMenuItem";
            this.repullSLAChartToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.repullSLAChartToolStripMenuItem.Text = "Repull/SLA Chart";
            this.repullSLAChartToolStripMenuItem.Click += new System.EventHandler(this.repullSLAChartToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCoutExpectToolStripMenuItem,
            this.uploadFileSetToolStripMenuItem});
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
            // uploadFileSetToolStripMenuItem
            // 
            this.uploadFileSetToolStripMenuItem.Name = "uploadFileSetToolStripMenuItem";
            this.uploadFileSetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.uploadFileSetToolStripMenuItem.Text = "Upload File Set";
            this.uploadFileSetToolStripMenuItem.Click += new System.EventHandler(this.uploadFileSetToolStripMenuItem_Click);
            // 
            // Btn_MondayStatus
            // 
            this.Btn_MondayStatus.Location = new System.Drawing.Point(404, 28);
            this.Btn_MondayStatus.Name = "Btn_MondayStatus";
            this.Btn_MondayStatus.Size = new System.Drawing.Size(75, 23);
            this.Btn_MondayStatus.TabIndex = 23;
            this.Btn_MondayStatus.Text = "Monday";
            this.Btn_MondayStatus.Click += new System.EventHandler(this.Btn_MondayStatus_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Choose Date";
            // 
            // uploadRecordToolStripMenuItem
            // 
            this.uploadRecordToolStripMenuItem.Name = "uploadRecordToolStripMenuItem";
            this.uploadRecordToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.uploadRecordToolStripMenuItem.Text = "Upload Record";
            this.uploadRecordToolStripMenuItem.Click += new System.EventHandler(this.uploadRecordToolStripMenuItem_Click);
            // 
            // Frm_PullingStatusService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Btn_MondayStatus);
            this.Controls.Add(this.btn_refresh);
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
            this.Text = "PullingStatusTool v1.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PullingStatusService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_PullingFileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Week.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem_TCGUI;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileCoutExpectToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn FinishFormatted;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraGrid.Columns.GridColumn finishTm;
        private System.Windows.Forms.ToolStripMenuItem rePullToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton Btn_MondayStatus;
        private System.Windows.Forms.ToolStripMenuItem repullSLAChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFileSetToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripMenuItem uploadRecordToolStripMenuItem;
    }
}