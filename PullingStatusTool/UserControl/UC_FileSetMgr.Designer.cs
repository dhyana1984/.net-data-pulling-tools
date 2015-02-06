namespace PullingStatusTool.UserControl
{
    partial class UC_FileSetMgr
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatalag = new DevExpress.XtraEditors.TextEdit();
            this.cbx_Dayof = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_SLA = new DevExpress.XtraEditors.TimeEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_enable = new DevExpress.XtraEditors.CheckEdit();
            this.txt_downloadpath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_Freq = new DevExpress.XtraEditors.ComboBoxEdit();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.downloadpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_filetype = new DevExpress.XtraEditors.TextEdit();
            this.retailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_vendor = new DevExpress.XtraEditors.TextEdit();
            this.txt_retailer = new DevExpress.XtraEditors.TextEdit();
            this.enable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filetype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slatime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datalag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.frequency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dayof = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FileExtend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isreupload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FileExten = new DevExpress.XtraEditors.TextEdit();
            this.cbx_addExpectFile = new DevExpress.XtraEditors.CheckEdit();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.ckx_ReUploadLimit = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_isByFilename = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatalag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Dayof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_enable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_downloadpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Freq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_retailer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_addExpectFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckx_ReUploadLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_isByFilename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(512, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 13);
            this.labelControl8.TabIndex = 78;
            this.labelControl8.Text = "DataLag";
            // 
            // txtDatalag
            // 
            this.txtDatalag.EditValue = "1";
            this.txtDatalag.Location = new System.Drawing.Point(558, 12);
            this.txtDatalag.Name = "txtDatalag";
            this.txtDatalag.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDatalag.Properties.Mask.EditMask = "#0#";
            this.txtDatalag.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDatalag.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDatalag.Properties.MaxLength = 2;
            this.txtDatalag.Size = new System.Drawing.Size(100, 20);
            this.txtDatalag.TabIndex = 77;
            // 
            // cbx_Dayof
            // 
            this.cbx_Dayof.EditValue = "Monday";
            this.cbx_Dayof.Enabled = false;
            this.cbx_Dayof.Location = new System.Drawing.Point(406, 37);
            this.cbx_Dayof.Name = "cbx_Dayof";
            this.cbx_Dayof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Dayof.Properties.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbx_Dayof.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_Dayof.Size = new System.Drawing.Size(100, 20);
            this.cbx_Dayof.TabIndex = 76;
            // 
            // txt_SLA
            // 
            this.txt_SLA.EditValue = new System.DateTime(2014, 8, 27, 17, 0, 0, 0);
            this.txt_SLA.Location = new System.Drawing.Point(91, 38);
            this.txt_SLA.Name = "txt_SLA";
            this.txt_SLA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_SLA.Size = new System.Drawing.Size(100, 20);
            this.txt_SLA.TabIndex = 75;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(693, 63);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(70, 23);
            this.btn_Save.TabIndex = 74;
            this.btn_Save.Text = "Edit";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(617, 63);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(70, 23);
            this.btn_Add.TabIndex = 73;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(845, 63);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(87, 23);
            this.btn_Edit.TabIndex = 72;
            this.btn_Edit.Text = "UploadPath";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // cbx_enable
            // 
            this.cbx_enable.Location = new System.Drawing.Point(664, 12);
            this.cbx_enable.Name = "cbx_enable";
            this.cbx_enable.Properties.Caption = "Enable";
            this.cbx_enable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_enable.Size = new System.Drawing.Size(53, 18);
            this.cbx_enable.TabIndex = 71;
            // 
            // txt_downloadpath
            // 
            this.txt_downloadpath.Location = new System.Drawing.Point(91, 66);
            this.txt_downloadpath.Name = "txt_downloadpath";
            this.txt_downloadpath.Size = new System.Drawing.Size(520, 20);
            this.txt_downloadpath.TabIndex = 70;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 69;
            this.labelControl7.Text = "DownLoadPath";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(360, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 68;
            this.labelControl6.Text = "DayOf";
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "c_id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // cbx_Freq
            // 
            this.cbx_Freq.EditValue = "Daily";
            this.cbx_Freq.Location = new System.Drawing.Point(254, 38);
            this.cbx_Freq.Name = "cbx_Freq";
            this.cbx_Freq.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Freq.Properties.Items.AddRange(new object[] {
            "Daily",
            "Weekly"});
            this.cbx_Freq.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_Freq.Size = new System.Drawing.Size(100, 20);
            this.cbx_Freq.TabIndex = 67;
            this.cbx_Freq.SelectedIndexChanged += new System.EventHandler(this.cbx_Freq_SelectedIndexChanged);
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 1;
            this.vendor.Width = 121;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(197, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 66;
            this.labelControl5.Text = "Frequency";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 65;
            this.labelControl4.Text = "SLATime";
            // 
            // downloadpath
            // 
            this.downloadpath.Caption = "DownloadPath";
            this.downloadpath.FieldName = "c_downloadpath";
            this.downloadpath.Name = "downloadpath";
            this.downloadpath.OptionsColumn.AllowEdit = false;
            this.downloadpath.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.downloadpath.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.downloadpath.Visible = true;
            this.downloadpath.VisibleIndex = 4;
            this.downloadpath.Width = 452;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(360, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "FileType";
            // 
            // txt_filetype
            // 
            this.txt_filetype.Location = new System.Drawing.Point(406, 12);
            this.txt_filetype.Name = "txt_filetype";
            this.txt_filetype.Size = new System.Drawing.Size(100, 20);
            this.txt_filetype.TabIndex = 64;
            // 
            // retailer
            // 
            this.retailer.Caption = "Retailer";
            this.retailer.FieldName = "c_retailer";
            this.retailer.Name = "retailer";
            this.retailer.OptionsColumn.AllowEdit = false;
            this.retailer.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.retailer.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.retailer.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.retailer.Visible = true;
            this.retailer.VisibleIndex = 0;
            this.retailer.Width = 99;
            // 
            // txt_vendor
            // 
            this.txt_vendor.Location = new System.Drawing.Point(254, 12);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(100, 20);
            this.txt_vendor.TabIndex = 62;
            // 
            // txt_retailer
            // 
            this.txt_retailer.Location = new System.Drawing.Point(91, 12);
            this.txt_retailer.Name = "txt_retailer";
            this.txt_retailer.Size = new System.Drawing.Size(100, 20);
            this.txt_retailer.TabIndex = 61;
            // 
            // enable
            // 
            this.enable.Caption = "Enable";
            this.enable.FieldName = "c_flag";
            this.enable.Name = "enable";
            this.enable.OptionsColumn.AllowEdit = false;
            this.enable.Visible = true;
            this.enable.VisibleIndex = 9;
            this.enable.Width = 56;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Vendor";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.retailer,
            this.vendor,
            this.downloadpath,
            this.filetype,
            this.slatime,
            this.datalag,
            this.frequency,
            this.dayof,
            this.enable,
            this.id,
            this.FileExtend,
            this.isreupload,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // filetype
            // 
            this.filetype.Caption = "FileType";
            this.filetype.FieldName = "c_filetype";
            this.filetype.Name = "filetype";
            this.filetype.OptionsColumn.AllowEdit = false;
            this.filetype.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.filetype.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.filetype.Visible = true;
            this.filetype.VisibleIndex = 2;
            this.filetype.Width = 94;
            // 
            // slatime
            // 
            this.slatime.Caption = "SLATime";
            this.slatime.FieldName = "c_slatime";
            this.slatime.Name = "slatime";
            this.slatime.OptionsColumn.AllowEdit = false;
            this.slatime.Visible = true;
            this.slatime.VisibleIndex = 6;
            this.slatime.Width = 147;
            // 
            // datalag
            // 
            this.datalag.Caption = "Datalag";
            this.datalag.FieldName = "c_datalag";
            this.datalag.Name = "datalag";
            this.datalag.OptionsColumn.AllowEdit = false;
            this.datalag.Visible = true;
            this.datalag.VisibleIndex = 5;
            this.datalag.Width = 63;
            // 
            // frequency
            // 
            this.frequency.Caption = "Frequency";
            this.frequency.FieldName = "c_freqency";
            this.frequency.Name = "frequency";
            this.frequency.OptionsColumn.AllowEdit = false;
            this.frequency.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.frequency.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.frequency.Visible = true;
            this.frequency.VisibleIndex = 7;
            this.frequency.Width = 120;
            // 
            // dayof
            // 
            this.dayof.Caption = "DayOf";
            this.dayof.FieldName = "c_dayof";
            this.dayof.Name = "dayof";
            this.dayof.OptionsColumn.AllowEdit = false;
            this.dayof.Visible = true;
            this.dayof.VisibleIndex = 8;
            this.dayof.Width = 63;
            // 
            // FileExtend
            // 
            this.FileExtend.Caption = "File Extend";
            this.FileExtend.FieldName = "c_fileextend";
            this.FileExtend.Name = "FileExtend";
            this.FileExtend.OptionsColumn.AllowEdit = false;
            this.FileExtend.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.FileExtend.Visible = true;
            this.FileExtend.VisibleIndex = 3;
            this.FileExtend.Width = 86;
            // 
            // isreupload
            // 
            this.isreupload.Caption = "ReUpload Limit";
            this.isreupload.FieldName = "c_reupload";
            this.isreupload.Name = "isreupload";
            this.isreupload.OptionsColumn.AllowEdit = false;
            this.isreupload.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.isreupload.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.isreupload.Visible = true;
            this.isreupload.VisibleIndex = 10;
            this.isreupload.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "isByFileName";
            this.gridColumn1.FieldName = "c_isbyfilename";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 92);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(936, 407);
            this.gridControl1.TabIndex = 58;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "Retailer";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(512, 41);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 80;
            this.labelControl9.Text = "FileExten";
            // 
            // txt_FileExten
            // 
            this.txt_FileExten.Location = new System.Drawing.Point(558, 37);
            this.txt_FileExten.Name = "txt_FileExten";
            this.txt_FileExten.Size = new System.Drawing.Size(100, 20);
            this.txt_FileExten.TabIndex = 81;
            // 
            // cbx_addExpectFile
            // 
            this.cbx_addExpectFile.Location = new System.Drawing.Point(664, 39);
            this.cbx_addExpectFile.Name = "cbx_addExpectFile";
            this.cbx_addExpectFile.Properties.Caption = "AddExpectFile";
            this.cbx_addExpectFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_addExpectFile.Size = new System.Drawing.Size(93, 18);
            this.cbx_addExpectFile.TabIndex = 82;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(769, 63);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 23);
            this.btn_delete.TabIndex = 83;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ckx_ReUploadLimit
            // 
            this.ckx_ReUploadLimit.Location = new System.Drawing.Point(761, 15);
            this.ckx_ReUploadLimit.Name = "ckx_ReUploadLimit";
            this.ckx_ReUploadLimit.Properties.Caption = "ReUpload Now";
            this.ckx_ReUploadLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckx_ReUploadLimit.Size = new System.Drawing.Size(91, 18);
            this.ckx_ReUploadLimit.TabIndex = 84;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(938, 63);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
            this.btn_Refresh.TabIndex = 85;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbx_isByFilename
            // 
            this.cbx_isByFilename.Location = new System.Drawing.Point(761, 39);
            this.cbx_isByFilename.Name = "cbx_isByFilename";
            this.cbx_isByFilename.Properties.Caption = "StatusByFileName";
            this.cbx_isByFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_isByFilename.Size = new System.Drawing.Size(112, 18);
            this.cbx_isByFilename.TabIndex = 86;
            // 
            // UC_FileSetMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbx_isByFilename);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.ckx_ReUploadLimit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cbx_addExpectFile);
            this.Controls.Add(this.txt_FileExten);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtDatalag);
            this.Controls.Add(this.cbx_Dayof);
            this.Controls.Add(this.txt_SLA);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.cbx_enable);
            this.Controls.Add(this.txt_downloadpath);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cbx_Freq);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_filetype);
            this.Controls.Add(this.txt_vendor);
            this.Controls.Add(this.txt_retailer);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.LookAndFeel.SkinName = "Dark Side";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.Name = "UC_FileSetMgr";
            this.Size = new System.Drawing.Size(953, 502);
            this.Tag = "File Set Management";
            this.Load += new System.EventHandler(this.FileUploadManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDatalag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Dayof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_enable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_downloadpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Freq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_retailer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_addExpectFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckx_ReUploadLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_isByFilename.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDatalag;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Dayof;
        private DevExpress.XtraEditors.TimeEdit txt_SLA;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.CheckEdit cbx_enable;
        private DevExpress.XtraEditors.TextEdit txt_downloadpath;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Freq;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn downloadpath;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_filetype;
        private DevExpress.XtraGrid.Columns.GridColumn retailer;
        private DevExpress.XtraEditors.TextEdit txt_vendor;
        private DevExpress.XtraEditors.TextEdit txt_retailer;
        private DevExpress.XtraGrid.Columns.GridColumn enable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn filetype;
        private DevExpress.XtraGrid.Columns.GridColumn slatime;
        private DevExpress.XtraGrid.Columns.GridColumn datalag;
        private DevExpress.XtraGrid.Columns.GridColumn frequency;
        private DevExpress.XtraGrid.Columns.GridColumn dayof;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_FileExten;
        private DevExpress.XtraGrid.Columns.GridColumn FileExtend;
        private DevExpress.XtraEditors.CheckEdit cbx_addExpectFile;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.CheckEdit ckx_ReUploadLimit;
        private DevExpress.XtraGrid.Columns.GridColumn isreupload;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.CheckEdit cbx_isByFilename;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
