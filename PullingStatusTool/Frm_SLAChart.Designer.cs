namespace PullingStatusTool
{
    partial class Frm_SLAChart
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SLAChart));
            this.ChartSLA = new DevExpress.XtraCharts.ChartControl();
            this.txt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_StartDate = new DevExpress.XtraEditors.DateEdit();
            this.btn_Fresh = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartSLA
            // 
            this.ChartSLA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartSLA.AppearanceName = "Dark Flat";
            xyDiagram1.AxisX.Range.Auto = false;
            xyDiagram1.AxisX.Range.MaxValueInternal = 4.8390232979852525;
            xyDiagram1.AxisX.Range.MinValueInternal = -0.5;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            this.ChartSLA.Diagram = xyDiagram1;
            this.ChartSLA.Location = new System.Drawing.Point(12, 66);
            this.ChartSLA.Name = "ChartSLA";
            this.ChartSLA.PaletteBaseColorNumber = 5;
            this.ChartSLA.PaletteName = "Nature Colors";
            series1.ArgumentDataMember = "c_repulldate";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Miss SLA";
            series1.ValueDataMembersSerializable = "c_filecount";
            splineSeriesView1.LineStyle.Thickness = 3;
            series1.View = splineSeriesView1;
            series2.ArgumentDataMember = "c_repulldate";
            pointSeriesLabel2.LineVisible = true;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Repull";
            series2.ValueDataMembersSerializable = "c_ffilecount";
            splineSeriesView2.Color = System.Drawing.Color.SteelBlue;
            splineSeriesView2.LineStyle.Thickness = 3;
            series2.View = splineSeriesView2;
            this.ChartSLA.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            this.ChartSLA.SeriesTemplate.Label = pointSeriesLabel3;
            splineSeriesView3.LineStyle.Thickness = 1;
            this.ChartSLA.SeriesTemplate.View = splineSeriesView3;
            this.ChartSLA.Size = new System.Drawing.Size(666, 376);
            this.ChartSLA.TabIndex = 0;
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.EditValue = null;
            this.txt_EndDate.Location = new System.Drawing.Point(46, 40);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_EndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_EndDate.Size = new System.Drawing.Size(100, 20);
            this.txt_EndDate.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "From";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "To ";
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.EditValue = null;
            this.txt_StartDate.Location = new System.Drawing.Point(46, 12);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_StartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_StartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_StartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_StartDate.Size = new System.Drawing.Size(100, 20);
            this.txt_StartDate.TabIndex = 4;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(153, 37);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Fresh.TabIndex = 8;
            this.btn_Fresh.Text = "Fresh";
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.Location = new System.Drawing.Point(603, 37);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 9;
            this.Btn_Save.Text = "Save to PNG";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Frm_SLAChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 454);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.txt_EndDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_StartDate);
            this.Controls.Add(this.ChartSLA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SLAChart";
            this.Text = "Frm_SLAChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_SLAChart_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ChartSLA;
        private DevExpress.XtraEditors.DateEdit txt_EndDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txt_StartDate;
        private DevExpress.XtraEditors.SimpleButton btn_Fresh;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}