namespace PullingStatusTool
{
    partial class Frm_RepullChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RepullChart));
            this.GC_FileExpect = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subgroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCountExpect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dayOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DelayReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_Vendor = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_FileExpect
            // 
            this.GC_FileExpect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_FileExpect.Location = new System.Drawing.Point(12, 53);
            this.GC_FileExpect.MainView = this.gridView1;
            this.GC_FileExpect.Name = "GC_FileExpect";
            this.GC_FileExpect.Size = new System.Drawing.Size(784, 567);
            this.GC_FileExpect.TabIndex = 3;
            this.GC_FileExpect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
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
            this.vendor.VisibleIndex = 1;
            this.vendor.Width = 170;
            // 
            // dataType
            // 
            this.dataType.Caption = "DataType";
            this.dataType.FieldName = "c_datatype";
            this.dataType.Name = "dataType";
            this.dataType.OptionsColumn.AllowEdit = false;
            this.dataType.OptionsColumn.AllowSize = false;
            this.dataType.OptionsColumn.ReadOnly = true;
            this.dataType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.dataType.Visible = true;
            this.dataType.VisibleIndex = 2;
            this.dataType.Width = 176;
            // 
            // subgroup
            // 
            this.subgroup.Caption = "Sub Group";
            this.subgroup.FieldName = "c_subgroup";
            this.subgroup.Name = "subgroup";
            this.subgroup.OptionsColumn.AllowEdit = false;
            this.subgroup.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.subgroup.Visible = true;
            this.subgroup.VisibleIndex = 3;
            this.subgroup.Width = 157;
            // 
            // fileCountExpect
            // 
            this.fileCountExpect.Caption = "FileCountExpect";
            this.fileCountExpect.FieldName = "c_filexpectuploaded";
            this.fileCountExpect.Name = "fileCountExpect";
            this.fileCountExpect.OptionsColumn.AllowEdit = false;
            this.fileCountExpect.Visible = true;
            this.fileCountExpect.VisibleIndex = 4;
            this.fileCountExpect.Width = 162;
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
            this.dayOfWeek.Width = 159;
            // 
            // DelayReason
            // 
            this.DelayReason.Caption = "DelayReason";
            this.DelayReason.FieldName = "c_delayreason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.OptionsColumn.AllowEdit = false;
            this.DelayReason.Visible = true;
            this.DelayReason.VisibleIndex = 5;
            this.DelayReason.Width = 495;
            // 
            // txt_Vendor
            // 
            this.txt_Vendor.Location = new System.Drawing.Point(12, 12);
            this.txt_Vendor.Name = "txt_Vendor";
            this.txt_Vendor.Properties.MaxLength = 50;
            this.txt_Vendor.Size = new System.Drawing.Size(95, 20);
            this.txt_Vendor.TabIndex = 4;
            this.txt_Vendor.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txt_Vendor_EditValueChanging);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(113, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 50;
            this.textEdit1.Size = new System.Drawing.Size(95, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // Frm_RepullChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.txt_Vendor);
            this.Controls.Add(this.GC_FileExpect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RepullChart";
            this.Text = "RepullChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_RepullChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_FileExpect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountExpect;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn dayOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraEditors.TextEdit txt_Vendor;
        private DevExpress.XtraEditors.TextEdit textEdit1;



    }
}