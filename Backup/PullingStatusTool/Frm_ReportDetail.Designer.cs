namespace PullingStatusTool
{
    partial class Frm_ReportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportDetail));
            this.GC_ReportDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.reportname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reportstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.downloadstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formatstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_Vendor = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ConcigName = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ScheduleName = new DevExpress.XtraEditors.LabelControl();
            this.lbl_downloadsatus = new DevExpress.XtraEditors.LabelControl();
            this.lbl_formatstatus = new DevExpress.XtraEditors.LabelControl();
            this.lbl_uploadstatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ReportDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_ReportDetail
            // 
            this.GC_ReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_ReportDetail.Location = new System.Drawing.Point(12, 69);
            this.GC_ReportDetail.MainView = this.gridView1;
            this.GC_ReportDetail.Name = "GC_ReportDetail";
            this.GC_ReportDetail.Size = new System.Drawing.Size(812, 369);
            this.GC_ReportDetail.TabIndex = 0;
            this.GC_ReportDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.reportname,
            this.reportstatus,
            this.downloadstatus,
            this.formatstatus,
            this.uploadstatus});
            this.gridView1.GridControl = this.GC_ReportDetail;
            this.gridView1.Name = "gridView1";
            // 
            // reportname
            // 
            this.reportname.Caption = "ReportName";
            this.reportname.FieldName = "c_reportname";
            this.reportname.Name = "reportname";
            this.reportname.OptionsColumn.AllowEdit = false;
            this.reportname.OptionsColumn.ReadOnly = true;
            this.reportname.Visible = true;
            this.reportname.VisibleIndex = 0;
            this.reportname.Width = 251;
            // 
            // reportstatus
            // 
            this.reportstatus.Caption = "ReportStatus";
            this.reportstatus.FieldName = "c_reportstatus";
            this.reportstatus.Name = "reportstatus";
            this.reportstatus.OptionsColumn.AllowEdit = false;
            this.reportstatus.OptionsColumn.ReadOnly = true;
            this.reportstatus.Visible = true;
            this.reportstatus.VisibleIndex = 1;
            this.reportstatus.Width = 135;
            // 
            // downloadstatus
            // 
            this.downloadstatus.Caption = "DownLoadStatus";
            this.downloadstatus.FieldName = "c_downloadstatus";
            this.downloadstatus.Name = "downloadstatus";
            this.downloadstatus.OptionsColumn.AllowEdit = false;
            this.downloadstatus.OptionsColumn.ReadOnly = true;
            this.downloadstatus.Visible = true;
            this.downloadstatus.VisibleIndex = 2;
            this.downloadstatus.Width = 132;
            // 
            // formatstatus
            // 
            this.formatstatus.Caption = "FormatStatus";
            this.formatstatus.FieldName = "c_formatstatus";
            this.formatstatus.Name = "formatstatus";
            this.formatstatus.OptionsColumn.AllowEdit = false;
            this.formatstatus.OptionsColumn.ReadOnly = true;
            this.formatstatus.Visible = true;
            this.formatstatus.VisibleIndex = 3;
            this.formatstatus.Width = 132;
            // 
            // uploadstatus
            // 
            this.uploadstatus.Caption = "UploadStatus";
            this.uploadstatus.FieldName = "c_uploadstatus";
            this.uploadstatus.Name = "uploadstatus";
            this.uploadstatus.OptionsColumn.AllowEdit = false;
            this.uploadstatus.OptionsColumn.ReadOnly = true;
            this.uploadstatus.Visible = true;
            this.uploadstatus.VisibleIndex = 4;
            this.uploadstatus.Width = 141;
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.Location = new System.Drawing.Point(48, 12);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(38, 13);
            this.lbl_Vendor.TabIndex = 1;
            this.lbl_Vendor.Text = "Vendor:";
            // 
            // lbl_ConcigName
            // 
            this.lbl_ConcigName.Location = new System.Drawing.Point(24, 31);
            this.lbl_ConcigName.Name = "lbl_ConcigName";
            this.lbl_ConcigName.Size = new System.Drawing.Size(62, 13);
            this.lbl_ConcigName.TabIndex = 2;
            this.lbl_ConcigName.Text = "ConfigName:";
            // 
            // lbl_ScheduleName
            // 
            this.lbl_ScheduleName.Location = new System.Drawing.Point(12, 50);
            this.lbl_ScheduleName.Name = "lbl_ScheduleName";
            this.lbl_ScheduleName.Size = new System.Drawing.Size(74, 13);
            this.lbl_ScheduleName.TabIndex = 3;
            this.lbl_ScheduleName.Text = "ScheduleName:";
            // 
            // lbl_downloadsatus
            // 
            this.lbl_downloadsatus.Location = new System.Drawing.Point(217, 12);
            this.lbl_downloadsatus.Name = "lbl_downloadsatus";
            this.lbl_downloadsatus.Size = new System.Drawing.Size(85, 13);
            this.lbl_downloadsatus.TabIndex = 4;
            this.lbl_downloadsatus.Text = "DownLoadStatus:";
            // 
            // lbl_formatstatus
            // 
            this.lbl_formatstatus.Location = new System.Drawing.Point(233, 31);
            this.lbl_formatstatus.Name = "lbl_formatstatus";
            this.lbl_formatstatus.Size = new System.Drawing.Size(69, 13);
            this.lbl_formatstatus.TabIndex = 5;
            this.lbl_formatstatus.Text = "FormatStatus:";
            // 
            // lbl_uploadstatus
            // 
            this.lbl_uploadstatus.Location = new System.Drawing.Point(231, 50);
            this.lbl_uploadstatus.Name = "lbl_uploadstatus";
            this.lbl_uploadstatus.Size = new System.Drawing.Size(71, 13);
            this.lbl_uploadstatus.TabIndex = 6;
            this.lbl_uploadstatus.Text = "UpLoadStatus:";
            // 
            // Frm_ReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.lbl_uploadstatus);
            this.Controls.Add(this.lbl_formatstatus);
            this.Controls.Add(this.lbl_downloadsatus);
            this.Controls.Add(this.lbl_ScheduleName);
            this.Controls.Add(this.lbl_ConcigName);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.GC_ReportDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ReportDetail";
            this.Text = "Frm_ReportDetail";
            this.Load += new System.EventHandler(this.Frm_ReportDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_ReportDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_ReportDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn reportname;
        private DevExpress.XtraGrid.Columns.GridColumn reportstatus;
        private DevExpress.XtraGrid.Columns.GridColumn downloadstatus;
        private DevExpress.XtraGrid.Columns.GridColumn formatstatus;
        private DevExpress.XtraGrid.Columns.GridColumn uploadstatus;
        private DevExpress.XtraEditors.LabelControl lbl_Vendor;
        private DevExpress.XtraEditors.LabelControl lbl_ConcigName;
        private DevExpress.XtraEditors.LabelControl lbl_ScheduleName;
        private DevExpress.XtraEditors.LabelControl lbl_downloadsatus;
        private DevExpress.XtraEditors.LabelControl lbl_formatstatus;
        private DevExpress.XtraEditors.LabelControl lbl_uploadstatus;
    }
}