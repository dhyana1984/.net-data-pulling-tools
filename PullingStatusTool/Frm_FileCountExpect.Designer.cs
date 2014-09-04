namespace PullingStatusTool
{
    partial class Frm_FileCountExpect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FileCountExpect));
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DataType = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Subgroup = new DevExpress.XtraEditors.LabelControl();
            this.txt_SubGrp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FileExpect = new DevExpress.XtraEditors.TextEdit();
            this.btn_AddFileExpect = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dayofwk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_delay = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SubGrp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExpect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dayofwk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_delay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_FileExpect
            // 
            this.GC_FileExpect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_FileExpect.Location = new System.Drawing.Point(12, 73);
            this.GC_FileExpect.MainView = this.gridView1;
            this.GC_FileExpect.Name = "GC_FileExpect";
            this.GC_FileExpect.Size = new System.Drawing.Size(1338, 657);
            this.GC_FileExpect.TabIndex = 2;
            this.GC_FileExpect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GC_FileExpect.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GC_FileExpect_MouseDoubleClick);
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
            this.txt_Vendor.Location = new System.Drawing.Point(445, 21);
            this.txt_Vendor.Name = "txt_Vendor";
            this.txt_Vendor.Properties.MaxLength = 50;
            this.txt_Vendor.Size = new System.Drawing.Size(95, 20);
            this.txt_Vendor.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(405, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Vendor";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(546, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "DataType";
            // 
            // txt_DataType
            // 
            this.txt_DataType.Location = new System.Drawing.Point(599, 21);
            this.txt_DataType.Name = "txt_DataType";
            this.txt_DataType.Properties.MaxLength = 50;
            this.txt_DataType.Size = new System.Drawing.Size(100, 20);
            this.txt_DataType.TabIndex = 5;
            // 
            // lbl_Subgroup
            // 
            this.lbl_Subgroup.Location = new System.Drawing.Point(705, 24);
            this.lbl_Subgroup.Name = "lbl_Subgroup";
            this.lbl_Subgroup.Size = new System.Drawing.Size(47, 13);
            this.lbl_Subgroup.TabIndex = 8;
            this.lbl_Subgroup.Text = "SubGroup";
            // 
            // txt_SubGrp
            // 
            this.txt_SubGrp.Location = new System.Drawing.Point(758, 21);
            this.txt_SubGrp.Name = "txt_SubGrp";
            this.txt_SubGrp.Properties.MaxLength = 20;
            this.txt_SubGrp.Size = new System.Drawing.Size(100, 20);
            this.txt_SubGrp.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(864, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "FileExpect";
            // 
            // txt_FileExpect
            // 
            this.txt_FileExpect.Location = new System.Drawing.Point(919, 21);
            this.txt_FileExpect.Name = "txt_FileExpect";
            this.txt_FileExpect.Properties.Mask.EditMask = "####";
            this.txt_FileExpect.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_FileExpect.Properties.MaxLength = 4;
            this.txt_FileExpect.Properties.ValidateOnEnterKey = true;
            this.txt_FileExpect.Size = new System.Drawing.Size(94, 20);
            this.txt_FileExpect.TabIndex = 9;
            // 
            // btn_AddFileExpect
            // 
            this.btn_AddFileExpect.Location = new System.Drawing.Point(1019, 44);
            this.btn_AddFileExpect.Name = "btn_AddFileExpect";
            this.btn_AddFileExpect.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFileExpect.TabIndex = 11;
            this.btn_AddFileExpect.Text = "Add";
            this.btn_AddFileExpect.Click += new System.EventHandler(this.btn_AddFileExpect_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(1100, 44);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1181, 44);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "DayOfWeek";
            // 
            // txt_dayofwk
            // 
            this.txt_dayofwk.Location = new System.Drawing.Point(81, 21);
            this.txt_dayofwk.Name = "txt_dayofwk";
            this.txt_dayofwk.Properties.MaxLength = 100;
            this.txt_dayofwk.Size = new System.Drawing.Size(318, 20);
            this.txt_dayofwk.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "DelayReason";
            // 
            // txt_delay
            // 
            this.txt_delay.Location = new System.Drawing.Point(81, 47);
            this.txt_delay.Name = "txt_delay";
            this.txt_delay.Properties.MaxLength = 200;
            this.txt_delay.Size = new System.Drawing.Size(932, 20);
            this.txt_delay.TabIndex = 16;
            // 
            // Frm_FileCountExpect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FileCountExpect";
            this.Text = "FileCountExpect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_FileCountExpect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_FileExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Vendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SubGrp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FileExpect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dayofwk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_delay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_FileExpect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn subgroup;
        private DevExpress.XtraGrid.Columns.GridColumn fileCountExpect;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.TextEdit txt_Vendor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_DataType;
        private DevExpress.XtraEditors.LabelControl lbl_Subgroup;
        private DevExpress.XtraEditors.TextEdit txt_SubGrp;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_FileExpect;
        private DevExpress.XtraEditors.SimpleButton btn_AddFileExpect;
        private DevExpress.XtraGrid.Columns.GridColumn dayOfWeek;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_dayofwk;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_delay;
    }
}