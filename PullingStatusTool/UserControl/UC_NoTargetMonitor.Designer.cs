namespace PullingStatusTool.UserControl
{
    partial class UC_NoTargetMonitor
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
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.drp_DailyDate = new DevExpress.XtraEditors.DateEdit();
            this.GC_ManUplStas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.retailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uploadStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DelayReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.finishtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.freqency = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ManUplStas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(234, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(84, 23);
            this.btn_refresh.TabIndex = 31;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Choose Date";
            // 
            // drp_DailyDate
            // 
            this.drp_DailyDate.EditValue = null;
            this.drp_DailyDate.Location = new System.Drawing.Point(81, 10);
            this.drp_DailyDate.Name = "drp_DailyDate";
            this.drp_DailyDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.drp_DailyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drp_DailyDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.drp_DailyDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.drp_DailyDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.drp_DailyDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.drp_DailyDate.Size = new System.Drawing.Size(147, 20);
            this.drp_DailyDate.TabIndex = 29;
            // 
            // GC_ManUplStas
            // 
            this.GC_ManUplStas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_ManUplStas.Location = new System.Drawing.Point(13, 36);
            this.GC_ManUplStas.MainView = this.gridView1;
            this.GC_ManUplStas.Name = "GC_ManUplStas";
            this.GC_ManUplStas.Size = new System.Drawing.Size(1001, 464);
            this.GC_ManUplStas.TabIndex = 28;
            this.GC_ManUplStas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.retailer,
            this.dataType,
            this.uploadfile,
            this.uploadStatus,
            this.DelayReason,
            this.finishtime,
            this.freqency});
            this.gridView1.GridControl = this.GC_ManUplStas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            this.vendor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 1;
            this.vendor.Width = 93;
            // 
            // retailer
            // 
            this.retailer.Caption = "Retailer";
            this.retailer.FieldName = "c_retailer";
            this.retailer.Name = "retailer";
            this.retailer.OptionsColumn.AllowEdit = false;
            this.retailer.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.retailer.Visible = true;
            this.retailer.VisibleIndex = 0;
            this.retailer.Width = 85;
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
            this.dataType.Width = 96;
            // 
            // uploadfile
            // 
            this.uploadfile.Caption = "UploadFile";
            this.uploadfile.FieldName = "c_filexpectuploaded";
            this.uploadfile.Name = "uploadfile";
            this.uploadfile.OptionsColumn.AllowEdit = false;
            this.uploadfile.Visible = true;
            this.uploadfile.VisibleIndex = 3;
            this.uploadfile.Width = 88;
            // 
            // uploadStatus
            // 
            this.uploadStatus.Caption = "UploadStatus";
            this.uploadStatus.FieldName = "c_finishuploaded";
            this.uploadStatus.Name = "uploadStatus";
            this.uploadStatus.OptionsColumn.AllowEdit = false;
            this.uploadStatus.Visible = true;
            this.uploadStatus.VisibleIndex = 4;
            this.uploadStatus.Width = 87;
            // 
            // DelayReason
            // 
            this.DelayReason.Caption = "DelayReason";
            this.DelayReason.FieldName = "c_delayreason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.OptionsColumn.AllowEdit = false;
            this.DelayReason.Visible = true;
            this.DelayReason.VisibleIndex = 7;
            this.DelayReason.Width = 250;
            // 
            // finishtime
            // 
            this.finishtime.Caption = "LastUploaded";
            this.finishtime.FieldName = "c_finishtime";
            this.finishtime.Name = "finishtime";
            this.finishtime.OptionsColumn.AllowEdit = false;
            this.finishtime.OptionsColumn.AllowSize = false;
            this.finishtime.OptionsColumn.ReadOnly = true;
            this.finishtime.Visible = true;
            this.finishtime.VisibleIndex = 6;
            this.finishtime.Width = 153;
            // 
            // freqency
            // 
            this.freqency.Caption = "Freqency";
            this.freqency.FieldName = "c_subgroup";
            this.freqency.Name = "freqency";
            this.freqency.OptionsColumn.AllowEdit = false;
            this.freqency.Visible = true;
            this.freqency.VisibleIndex = 5;
            this.freqency.Width = 64;
            // 
            // UC_NoTargetMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.drp_DailyDate);
            this.Controls.Add(this.GC_ManUplStas);
            this.Name = "UC_NoTargetMonitor";
            this.Size = new System.Drawing.Size(1027, 503);
            this.Tag = "None Target Data Pulling Status";
            this.Load += new System.EventHandler(this.Frm_ManuUplStas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drp_DailyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ManUplStas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit drp_DailyDate;
        private DevExpress.XtraGrid.GridControl GC_ManUplStas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn retailer;
        private DevExpress.XtraGrid.Columns.GridColumn dataType;
        private DevExpress.XtraGrid.Columns.GridColumn uploadfile;
        private DevExpress.XtraGrid.Columns.GridColumn uploadStatus;
        private DevExpress.XtraGrid.Columns.GridColumn DelayReason;
        private DevExpress.XtraGrid.Columns.GridColumn finishtime;
        private DevExpress.XtraGrid.Columns.GridColumn freqency;

    }
}
