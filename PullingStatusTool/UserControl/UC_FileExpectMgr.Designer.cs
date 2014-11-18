namespace PullingStatusTool.UserControl
{
    partial class UC_FileExpectMgr
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Retailer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_delay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dayofwk = new DevExpress.XtraEditors.TextEdit();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddFileExpect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FileExpect = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Subgroup = new DevExpress.XtraEditors.LabelControl();
            this.txt_SubGrp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DataType = new DevExpress.XtraEditors.TextEdit();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.retailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.subgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountExpect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dayOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DelayReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GC_FileExpect = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Vendor = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Retailer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_delay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dayofwk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExpect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SubGrp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(511, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "Retailer";
            // 
            // txt_Retailer
            // 
            this.txt_Retailer.Location = new System.Drawing.Point(554, 12);
            this.txt_Retailer.Name = "txt_Retailer";
            this.txt_Retailer.Properties.MaxLength = 50;
            this.txt_Retailer.Size = new System.Drawing.Size(86, 20);
            this.txt_Retailer.TabIndex = 36;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "DelayReason";
            // 
            // txt_delay
            // 
            this.txt_delay.Location = new System.Drawing.Point(106, 38);
            this.txt_delay.Name = "txt_delay";
            this.txt_delay.Properties.MaxLength = 200;
            this.txt_delay.Size = new System.Drawing.Size(736, 20);
            this.txt_delay.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "DayOfWeek";
            // 
            // txt_dayofwk
            // 
            this.txt_dayofwk.Location = new System.Drawing.Point(107, 12);
            this.txt_dayofwk.Name = "txt_dayofwk";
            this.txt_dayofwk.Properties.MaxLength = 100;
            this.txt_dayofwk.Size = new System.Drawing.Size(250, 20);
            this.txt_dayofwk.TabIndex = 32;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(974, 38);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(57, 20);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(911, 38);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(57, 20);
            this.btn_Edit.TabIndex = 30;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddFileExpect
            // 
            this.btn_AddFileExpect.Location = new System.Drawing.Point(848, 38);
            this.btn_AddFileExpect.Name = "btn_AddFileExpect";
            this.btn_AddFileExpect.Size = new System.Drawing.Size(57, 20);
            this.btn_AddFileExpect.TabIndex = 29;
            this.btn_AddFileExpect.Text = "Add";
            this.btn_AddFileExpect.Click += new System.EventHandler(this.btn_AddFileExpect_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(938, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "FileExpect";
            // 
            // txt_FileExpect
            // 
            this.txt_FileExpect.Location = new System.Drawing.Point(993, 12);
            this.txt_FileExpect.Name = "txt_FileExpect";
            this.txt_FileExpect.Properties.Mask.EditMask = "####";
            this.txt_FileExpect.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_FileExpect.Properties.MaxLength = 4;
            this.txt_FileExpect.Properties.ValidateOnEnterKey = true;
            this.txt_FileExpect.Size = new System.Drawing.Size(38, 20);
            this.txt_FileExpect.TabIndex = 27;
            // 
            // lbl_Subgroup
            // 
            this.lbl_Subgroup.Location = new System.Drawing.Point(802, 15);
            this.lbl_Subgroup.Name = "lbl_Subgroup";
            this.lbl_Subgroup.Size = new System.Drawing.Size(47, 13);
            this.lbl_Subgroup.TabIndex = 26;
            this.lbl_Subgroup.Text = "SubGroup";
            // 
            // txt_SubGrp
            // 
            this.txt_SubGrp.Location = new System.Drawing.Point(855, 12);
            this.txt_SubGrp.Name = "txt_SubGrp";
            this.txt_SubGrp.Properties.MaxLength = 20;
            this.txt_SubGrp.Size = new System.Drawing.Size(77, 20);
            this.txt_SubGrp.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(646, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "DataType";
            // 
            // txt_DataType
            // 
            this.txt_DataType.Location = new System.Drawing.Point(708, 12);
            this.txt_DataType.Name = "txt_DataType";
            this.txt_DataType.Properties.MaxLength = 50;
            this.txt_DataType.Size = new System.Drawing.Size(88, 20);
            this.txt_DataType.TabIndex = 23;
            // 
            // dataType
            // 
            this.dataType.Caption = "DataType";
            this.dataType.FieldName = "c_datatype";
            this.dataType.Name = "dataType";
            this.dataType.OptionsColumn.AllowEdit = false;
            this.dataType.OptionsColumn.AllowSize = false;
            this.dataType.OptionsColumn.ReadOnly = true;
            this.dataType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.dataType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.dataType.Visible = true;
            this.dataType.VisibleIndex = 3;
            this.dataType.Width = 158;
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
            this.vendor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 2;
            this.vendor.Width = 121;
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
            this.retailer.VisibleIndex = 1;
            this.retailer.Width = 142;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.retailer,
            this.vendor,
            this.dataType,
            this.subgroup,
            this.fileCountExpect,
            this.ID,
            this.dayOfWeek,
            this.DelayReason});
            this.gridView1.GridControl = this.GC_FileExpect;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // subgroup
            // 
            this.subgroup.Caption = "Sub Group";
            this.subgroup.FieldName = "c_subgroup";
            this.subgroup.Name = "subgroup";
            this.subgroup.OptionsColumn.AllowEdit = false;
            this.subgroup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.subgroup.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.subgroup.Visible = true;
            this.subgroup.VisibleIndex = 4;
            this.subgroup.Width = 140;
            // 
            // fileCountExpect
            // 
            this.fileCountExpect.Caption = "FileCountExpect";
            this.fileCountExpect.FieldName = "c_filexpectuploaded";
            this.fileCountExpect.Name = "fileCountExpect";
            this.fileCountExpect.OptionsColumn.AllowEdit = false;
            this.fileCountExpect.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.fileCountExpect.Visible = true;
            this.fileCountExpect.VisibleIndex = 5;
            this.fileCountExpect.Width = 145;
            // 
            // ID
            // 
            this.ID.Caption = "FileID";
            this.ID.FieldName = "c_expfileid";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowSize = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 153;
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.Caption = "DayOfWeek";
            this.dayOfWeek.FieldName = "c_dayofweek";
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.OptionsColumn.AllowEdit = false;
            this.dayOfWeek.Visible = true;
            this.dayOfWeek.VisibleIndex = 0;
            this.dayOfWeek.Width = 150;
            // 
            // DelayReason
            // 
            this.DelayReason.Caption = "DelayReason";
            this.DelayReason.FieldName = "c_delayreason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.OptionsColumn.AllowEdit = false;
            this.DelayReason.Visible = true;
            this.DelayReason.VisibleIndex = 6;
            this.DelayReason.Width = 461;
            // 
            // GC_FileExpect
            // 
            this.GC_FileExpect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_FileExpect.Location = new System.Drawing.Point(6, 64);
            this.GC_FileExpect.MainView = this.gridView1;
            this.GC_FileExpect.Name = "GC_FileExpect";
            this.GC_FileExpect.Size = new System.Drawing.Size(939, 436);
            this.GC_FileExpect.TabIndex = 20;
            this.GC_FileExpect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GC_FileExpect.DoubleClick += new System.EventHandler(this.GC_FileExpect_DoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(363, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Vendor";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txt_Vendor
            // 
            this.txt_Vendor.Location = new System.Drawing.Point(403, 12);
            this.txt_Vendor.Name = "txt_Vendor";
            this.txt_Vendor.Properties.MaxLength = 50;
            this.txt_Vendor.Size = new System.Drawing.Size(102, 20);
            this.txt_Vendor.TabIndex = 21;
            // 
            // UC_FileExpectMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_Retailer);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_delay);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_dayofwk);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddFileExpect);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_FileExpect);
            this.Controls.Add(this.lbl_Subgroup);
            this.Controls.Add(this.txt_SubGrp);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_DataType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Vendor);
            this.Controls.Add(this.GC_FileExpect);
            this.Name = "UC_FileExpectMgr";
            this.Size = new System.Drawing.Size(948, 503);
            this.Tag = "Expect File Management";
            this.Load += new System.EventHandler(this.UC_FileExpectMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Retailer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_delay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dayofwk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExpect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SubGrp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Retailer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_delay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_dayofwk;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_AddFileExpect;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_FileExpect;
        private DevExpress.XtraEditors.LabelControl lbl_Subgroup;
        private DevExpress.XtraEditors.TextEdit txt_SubGrp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_DataType;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn retailer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountExpect;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn dayOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraGrid.GridControl GC_FileExpect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Vendor;
    }
}
