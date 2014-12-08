namespace PullingStatusTool.UserControl
{
    partial class UC_NoTargetDPChart
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
            this.lblTotalSLA = new DevExpress.XtraEditors.LabelControl();
            this.btn_Fresh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.txt_StartDate = new DevExpress.XtraEditors.DateEdit();
            this.ChartSLA = new DevExpress.XtraCharts.ChartControl();
            this.cbx_Retailer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Retailer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSLA
            // 
            this.lblTotalSLA.Location = new System.Drawing.Point(126, 8);
            this.lblTotalSLA.Name = "lblTotalSLA";
            this.lblTotalSLA.Size = new System.Drawing.Size(42, 13);
            this.lblTotalSLA.TabIndex = 23;
            this.lblTotalSLA.Text = "TotalSLA";
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(307, 28);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Fresh.TabIndex = 22;
            this.btn_Fresh.Text = "Fresh";
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.EditValue = null;
            this.txt_EndDate.Location = new System.Drawing.Point(20, 31);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_EndDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.txt_EndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_EndDate.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.txt_EndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_EndDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.txt_EndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_EndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_EndDate.Size = new System.Drawing.Size(100, 20);
            this.txt_EndDate.TabIndex = 21;
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.EditValue = null;
            this.txt_StartDate.Location = new System.Drawing.Point(20, 5);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_StartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_StartDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.txt_StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_StartDate.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.txt_StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_StartDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.txt_StartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txt_StartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_StartDate.Size = new System.Drawing.Size(100, 20);
            this.txt_StartDate.TabIndex = 20;
            // 
            // ChartSLA
            // 
            this.ChartSLA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartSLA.AppearanceName = "Dark";
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.ChartSLA.Diagram = xyDiagram1;
            this.ChartSLA.Location = new System.Drawing.Point(20, 57);
            this.ChartSLA.Name = "ChartSLA";
            this.ChartSLA.PaletteBaseColorNumber = 1;
            this.ChartSLA.PaletteName = "Palette 1";
            this.ChartSLA.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Silver, System.Drawing.Color.Silver)}));
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.View = splineSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.View = splineSeriesView2;
            this.ChartSLA.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            this.ChartSLA.SeriesTemplate.Label = pointSeriesLabel3;
            this.ChartSLA.SeriesTemplate.View = splineSeriesView3;
            this.ChartSLA.Size = new System.Drawing.Size(926, 443);
            this.ChartSLA.TabIndex = 24;
            // 
            // cbx_Retailer
            // 
            this.cbx_Retailer.Location = new System.Drawing.Point(201, 31);
            this.cbx_Retailer.Name = "cbx_Retailer";
            this.cbx_Retailer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Retailer.Size = new System.Drawing.Size(100, 20);
            this.cbx_Retailer.TabIndex = 25;
            this.cbx_Retailer.SelectedIndexChanged += new System.EventHandler(this.cbx_Retailer_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(126, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Select Retailer";
            // 
            // UC_NoTargetDPChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbx_Retailer);
            this.Controls.Add(this.ChartSLA);
            this.Controls.Add(this.lblTotalSLA);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.txt_EndDate);
            this.Controls.Add(this.txt_StartDate);
            this.Name = "UC_NoTargetDPChart";
            this.Size = new System.Drawing.Size(958, 503);
            this.Tag = "None Target Data Pulling Chart";
            this.Load += new System.EventHandler(this.UC_NoTargetDPChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StartDate.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Retailer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTotalSLA;
        private DevExpress.XtraEditors.SimpleButton btn_Fresh;
        private DevExpress.XtraEditors.DateEdit txt_EndDate;
        private DevExpress.XtraEditors.DateEdit txt_StartDate;
        private DevExpress.XtraCharts.ChartControl ChartSLA;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Retailer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
