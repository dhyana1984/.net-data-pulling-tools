namespace PullingStatusTool
{
    partial class Frm_RepullMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RepullMonitor));
            this.txt_StartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Repull = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filecount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckbx_78 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_77 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_72 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_71 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_70 = new DevExpress.XtraEditors.CheckEdit();
            this.ckbx_68 = new DevExpress.XtraEditors.CheckEdit();
            this.brn_Chart = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Repull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.EditValue = null;
            this.txt_StartDate.Location = new System.Drawing.Point(42, 9);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_StartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_StartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_StartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_StartDate.Size = new System.Drawing.Size(100, 20);
            this.txt_StartDate.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "To ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "From";
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.EditValue = null;
            this.txt_EndDate.Location = new System.Drawing.Point(42, 37);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_EndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_EndDate.Size = new System.Drawing.Size(100, 20);
            this.txt_EndDate.TabIndex = 3;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Location = new System.Drawing.Point(776, 34);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // GC_Repull
            // 
            this.GC_Repull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_Repull.Location = new System.Drawing.Point(12, 63);
            this.GC_Repull.MainView = this.gridView1;
            this.GC_Repull.Name = "GC_Repull";
            this.GC_Repull.Size = new System.Drawing.Size(839, 338);
            this.GC_Repull.TabIndex = 5;
            this.GC_Repull.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendor,
            this.filecount});
            this.gridView1.GridControl = this.GC_Repull;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // vendor
            // 
            this.vendor.Caption = "Vendor";
            this.vendor.FieldName = "c_vendor";
            this.vendor.Name = "vendor";
            this.vendor.OptionsColumn.AllowEdit = false;
            this.vendor.SummaryItem.DisplayFormat = "In All:{0:0}";
            this.vendor.SummaryItem.FieldName = "c_filecount";
            this.vendor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.vendor.Visible = true;
            this.vendor.VisibleIndex = 0;
            // 
            // filecount
            // 
            this.filecount.Caption = "FileCount";
            this.filecount.FieldName = "c_filecount";
            this.filecount.Name = "filecount";
            this.filecount.OptionsColumn.AllowEdit = false;
            this.filecount.Visible = true;
            this.filecount.VisibleIndex = 1;
            // 
            // ckbx_78
            // 
            this.ckbx_78.EditValue = true;
            this.ckbx_78.Location = new System.Drawing.Point(364, 37);
            this.ckbx_78.Name = "ckbx_78";
            this.ckbx_78.Properties.Caption = "192.168.10.78";
            this.ckbx_78.Size = new System.Drawing.Size(100, 19);
            this.ckbx_78.TabIndex = 27;
            // 
            // ckbx_77
            // 
            this.ckbx_77.EditValue = true;
            this.ckbx_77.Location = new System.Drawing.Point(254, 37);
            this.ckbx_77.Name = "ckbx_77";
            this.ckbx_77.Properties.Caption = "192.168.10.77";
            this.ckbx_77.Size = new System.Drawing.Size(97, 19);
            this.ckbx_77.TabIndex = 26;
            // 
            // ckbx_72
            // 
            this.ckbx_72.EditValue = true;
            this.ckbx_72.Location = new System.Drawing.Point(148, 37);
            this.ckbx_72.Name = "ckbx_72";
            this.ckbx_72.Properties.Caption = "192.168.10.72";
            this.ckbx_72.Size = new System.Drawing.Size(100, 19);
            this.ckbx_72.TabIndex = 25;
            // 
            // ckbx_71
            // 
            this.ckbx_71.EditValue = true;
            this.ckbx_71.Location = new System.Drawing.Point(364, 11);
            this.ckbx_71.Name = "ckbx_71";
            this.ckbx_71.Properties.Caption = "192.168.10.71";
            this.ckbx_71.Size = new System.Drawing.Size(100, 19);
            this.ckbx_71.TabIndex = 24;
            // 
            // ckbx_70
            // 
            this.ckbx_70.EditValue = true;
            this.ckbx_70.Location = new System.Drawing.Point(254, 10);
            this.ckbx_70.Name = "ckbx_70";
            this.ckbx_70.Properties.Caption = "192.168.28.70";
            this.ckbx_70.Size = new System.Drawing.Size(101, 19);
            this.ckbx_70.TabIndex = 23;
            // 
            // ckbx_68
            // 
            this.ckbx_68.Location = new System.Drawing.Point(148, 12);
            this.ckbx_68.Name = "ckbx_68";
            this.ckbx_68.Properties.Caption = "192.168.10.68";
            this.ckbx_68.Size = new System.Drawing.Size(100, 19);
            this.ckbx_68.TabIndex = 22;
            // 
            // brn_Chart
            // 
            this.brn_Chart.Location = new System.Drawing.Point(470, 33);
            this.brn_Chart.Name = "brn_Chart";
            this.brn_Chart.Size = new System.Drawing.Size(75, 23);
            this.brn_Chart.TabIndex = 28;
            this.brn_Chart.Text = "Chart";
            this.brn_Chart.Click += new System.EventHandler(this.brn_Chart_Click);
            // 
            // Frm_RepullMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 413);
            this.Controls.Add(this.brn_Chart);
            this.Controls.Add(this.ckbx_78);
            this.Controls.Add(this.ckbx_77);
            this.Controls.Add(this.ckbx_72);
            this.Controls.Add(this.ckbx_71);
            this.Controls.Add(this.ckbx_70);
            this.Controls.Add(this.ckbx_68);
            this.Controls.Add(this.GC_Repull);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txt_EndDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_StartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RepullMonitor";
            this.Text = "Frm_RepullMonitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_RepullMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Repull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_78.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_77.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_72.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_71.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_70.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbx_68.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txt_StartDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txt_EndDate;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraGrid.GridControl GC_Repull;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit ckbx_78;
        private DevExpress.XtraEditors.CheckEdit ckbx_77;
        private DevExpress.XtraEditors.CheckEdit ckbx_72;
        private DevExpress.XtraEditors.CheckEdit ckbx_71;
        private DevExpress.XtraEditors.CheckEdit ckbx_70;
        private DevExpress.XtraEditors.CheckEdit ckbx_68;
        private DevExpress.XtraGrid.Columns.GridColumn vendor;
        private DevExpress.XtraGrid.Columns.GridColumn filecount;
        private DevExpress.XtraEditors.SimpleButton brn_Chart;

    }
}