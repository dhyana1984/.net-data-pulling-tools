namespace PullingStatusTool
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.grp_dpmonitor = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_target = new DevExpress.XtraNavBar.NavBarItem();
            this.item_RepullList = new DevExpress.XtraNavBar.NavBarItem();
            this.item_notarget = new DevExpress.XtraNavBar.NavBarItem();
            this.item_TescoStatus = new DevExpress.XtraNavBar.NavBarItem();
            this.item_uploadrecord = new DevExpress.XtraNavBar.NavBarItem();
            this.grp_connector = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_morrison = new DevExpress.XtraNavBar.NavBarItem();
            this.item_wmbasket = new DevExpress.XtraNavBar.NavBarItem();
            this.item_tescoUK = new DevExpress.XtraNavBar.NavBarItem();
            this.grp_performancechart = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_notargetchart = new DevExpress.XtraNavBar.NavBarItem();
            this.item_targetchart = new DevExpress.XtraNavBar.NavBarItem();
            this.grp_systemsetting = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_fileset = new DevExpress.XtraNavBar.NavBarItem();
            this.item_expectfile = new DevExpress.XtraNavBar.NavBarItem();
            this.item_AccountMgr = new DevExpress.XtraNavBar.NavBarItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.grp_dpmonitor;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.grp_dpmonitor,
            this.grp_connector,
            this.grp_performancechart,
            this.grp_systemsetting});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.item_target,
            this.item_notarget,
            this.item_expectfile,
            this.item_fileset,
            this.item_targetchart,
            this.item_uploadrecord,
            this.item_notargetchart,
            this.item_morrison,
            this.item_AccountMgr,
            this.item_wmbasket,
            this.item_TescoStatus,
            this.item_tescoUK,
            this.item_RepullList});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.Size = new System.Drawing.Size(158, 457);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Black");
            // 
            // grp_dpmonitor
            // 
            this.grp_dpmonitor.Caption = "Data Pulling Monitor";
            this.grp_dpmonitor.Expanded = true;
            this.grp_dpmonitor.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_target),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_RepullList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_notarget),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_TescoStatus),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_uploadrecord)});
            this.grp_dpmonitor.Name = "grp_dpmonitor";
            // 
            // item_target
            // 
            this.item_target.Caption = "Target";
            this.item_target.Name = "item_target";
            this.item_target.SmallImage = ((System.Drawing.Image)(resources.GetObject("item_target.SmallImage")));
            this.item_target.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_target_LinkClicked);
            // 
            // item_RepullList
            // 
            this.item_RepullList.Caption = "Repull List";
            this.item_RepullList.Name = "item_RepullList";
            this.item_RepullList.SmallImage = global::PullingStatusTool.Properties.Resources.RepullList;
            this.item_RepullList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_RepullList_LinkClicked);
            // 
            // item_notarget
            // 
            this.item_notarget.Caption = "NoTarget";
            this.item_notarget.Name = "item_notarget";
            this.item_notarget.SmallImage = global::PullingStatusTool.Properties.Resources.NoTarget;
            this.item_notarget.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_notarget_LinkClicked);
            // 
            // item_TescoStatus
            // 
            this.item_TescoStatus.Caption = "Tesco Status";
            this.item_TescoStatus.Name = "item_TescoStatus";
            this.item_TescoStatus.SmallImage = global::PullingStatusTool.Properties.Resources.Tesco;
            this.item_TescoStatus.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_TescoStatus_LinkClicked);
            // 
            // item_uploadrecord
            // 
            this.item_uploadrecord.Caption = "Upload Record";
            this.item_uploadrecord.Name = "item_uploadrecord";
            this.item_uploadrecord.SmallImage = global::PullingStatusTool.Properties.Resources.UploadRecord;
            this.item_uploadrecord.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_uploadrecord_LinkClicked);
            // 
            // grp_connector
            // 
            this.grp_connector.Caption = "Connector";
            this.grp_connector.Expanded = true;
            this.grp_connector.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_morrison),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_wmbasket),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_tescoUK)});
            this.grp_connector.Name = "grp_connector";
            // 
            // item_morrison
            // 
            this.item_morrison.Caption = "Morrison";
            this.item_morrison.Name = "item_morrison";
            this.item_morrison.SmallImage = global::PullingStatusTool.Properties.Resources.Morrisons;
            this.item_morrison.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_morrison_LinkClicked);
            // 
            // item_wmbasket
            // 
            this.item_wmbasket.Caption = "WMBasket";
            this.item_wmbasket.Name = "item_wmbasket";
            this.item_wmbasket.SmallImage = global::PullingStatusTool.Properties.Resources.Walmart;
            this.item_wmbasket.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_wmbasket_LinkClicked);
            // 
            // item_tescoUK
            // 
            this.item_tescoUK.Caption = "TescoUK";
            this.item_tescoUK.Name = "item_tescoUK";
            this.item_tescoUK.SmallImage = ((System.Drawing.Image)(resources.GetObject("item_tescoUK.SmallImage")));
            this.item_tescoUK.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_tescoUK_LinkClicked);
            // 
            // grp_performancechart
            // 
            this.grp_performancechart.Caption = "Performance Chart";
            this.grp_performancechart.Expanded = true;
            this.grp_performancechart.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_notargetchart),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_targetchart)});
            this.grp_performancechart.Name = "grp_performancechart";
            // 
            // item_notargetchart
            // 
            this.item_notargetchart.Caption = "NoTarget Chart";
            this.item_notargetchart.Name = "item_notargetchart";
            this.item_notargetchart.SmallImage = global::PullingStatusTool.Properties.Resources.NoTargetChart;
            this.item_notargetchart.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_notargetchart_LinkClicked);
            // 
            // item_targetchart
            // 
            this.item_targetchart.Caption = "Target Chart";
            this.item_targetchart.Name = "item_targetchart";
            this.item_targetchart.SmallImage = global::PullingStatusTool.Properties.Resources.TargetChart;
            this.item_targetchart.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_targetchart_LinkClicked);
            // 
            // grp_systemsetting
            // 
            this.grp_systemsetting.Caption = "System Setting";
            this.grp_systemsetting.Expanded = true;
            this.grp_systemsetting.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_fileset),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_expectfile),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_AccountMgr)});
            this.grp_systemsetting.Name = "grp_systemsetting";
            // 
            // item_fileset
            // 
            this.item_fileset.Caption = "FileSet";
            this.item_fileset.Name = "item_fileset";
            this.item_fileset.SmallImage = global::PullingStatusTool.Properties.Resources.fileset;
            this.item_fileset.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_fileset_LinkClicked);
            // 
            // item_expectfile
            // 
            this.item_expectfile.Caption = "ExpectFile";
            this.item_expectfile.Name = "item_expectfile";
            this.item_expectfile.SmallImage = global::PullingStatusTool.Properties.Resources.expectfile;
            this.item_expectfile.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_expectfile_LinkClicked);
            // 
            // item_AccountMgr
            // 
            this.item_AccountMgr.Caption = "AccountManagement";
            this.item_AccountMgr.Name = "item_AccountMgr";
            this.item_AccountMgr.SmallImage = global::PullingStatusTool.Properties.Resources.Account;
            this.item_AccountMgr.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_AccountMgr_LinkClicked);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(863, 463);
            this.splitContainerControl1.SplitterPosition = 165;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(560, 78);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "RSi Data Pulling Tool ";
            this.labelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelControl1_Paint);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 463);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.Text = "DataPulling Tool V3.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup grp_dpmonitor;
        private DevExpress.XtraNavBar.NavBarGroup grp_systemsetting;
        private DevExpress.XtraNavBar.NavBarGroup grp_performancechart;
        private DevExpress.XtraNavBar.NavBarItem item_target;
        private DevExpress.XtraNavBar.NavBarItem item_notarget;
        private DevExpress.XtraNavBar.NavBarItem item_expectfile;
        private DevExpress.XtraNavBar.NavBarItem item_fileset;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarItem item_targetchart;
        private DevExpress.XtraNavBar.NavBarItem item_uploadrecord;
        private DevExpress.XtraNavBar.NavBarItem item_notargetchart;
        private DevExpress.XtraNavBar.NavBarGroup grp_connector;
        private DevExpress.XtraNavBar.NavBarItem item_morrison;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraNavBar.NavBarItem item_AccountMgr;
        private DevExpress.XtraNavBar.NavBarItem item_wmbasket;
        private DevExpress.XtraNavBar.NavBarItem item_TescoStatus;
        private DevExpress.XtraNavBar.NavBarItem item_tescoUK;
        private DevExpress.XtraNavBar.NavBarItem item_RepullList;




    }
}