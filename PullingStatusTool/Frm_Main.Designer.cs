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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.grp_dpmonitor = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_target = new DevExpress.XtraNavBar.NavBarItem();
            this.item_notarget = new DevExpress.XtraNavBar.NavBarItem();
            this.item_uploadrecord = new DevExpress.XtraNavBar.NavBarItem();
            this.grp_systemsetting = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_fileset = new DevExpress.XtraNavBar.NavBarItem();
            this.item_expectfile = new DevExpress.XtraNavBar.NavBarItem();
            this.grp_performancechart = new DevExpress.XtraNavBar.NavBarGroup();
            this.item_targetchart = new DevExpress.XtraNavBar.NavBarItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
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
            this.grp_systemsetting,
            this.grp_performancechart});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.item_target,
            this.item_notarget,
            this.item_expectfile,
            this.item_fileset,
            this.item_targetchart,
            this.item_uploadrecord});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.Size = new System.Drawing.Size(158, 324);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Caramel");
            // 
            // grp_dpmonitor
            // 
            this.grp_dpmonitor.Caption = "Data Pulling Monitor";
            this.grp_dpmonitor.Expanded = true;
            this.grp_dpmonitor.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_target),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_notarget),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_uploadrecord)});
            this.grp_dpmonitor.Name = "grp_dpmonitor";
            // 
            // item_target
            // 
            this.item_target.Caption = "Target";
            this.item_target.Name = "item_target";
            this.item_target.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_target_LinkClicked);
            // 
            // item_notarget
            // 
            this.item_notarget.Caption = "NoTarget";
            this.item_notarget.Name = "item_notarget";
            this.item_notarget.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_notarget_LinkClicked);
            // 
            // item_uploadrecord
            // 
            this.item_uploadrecord.Caption = "Upload Record";
            this.item_uploadrecord.Name = "item_uploadrecord";
            this.item_uploadrecord.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_uploadrecord_LinkClicked);
            // 
            // grp_systemsetting
            // 
            this.grp_systemsetting.Caption = "System Setting";
            this.grp_systemsetting.Expanded = true;
            this.grp_systemsetting.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_fileset),
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_expectfile)});
            this.grp_systemsetting.Name = "grp_systemsetting";
            // 
            // item_fileset
            // 
            this.item_fileset.Caption = "FileSet";
            this.item_fileset.Name = "item_fileset";
            this.item_fileset.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_fileset_LinkClicked);
            // 
            // item_expectfile
            // 
            this.item_expectfile.Caption = "ExpectFile";
            this.item_expectfile.Name = "item_expectfile";
            this.item_expectfile.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_expectfile_LinkClicked);
            // 
            // grp_performancechart
            // 
            this.grp_performancechart.Caption = "Performance Chart";
            this.grp_performancechart.Expanded = true;
            this.grp_performancechart.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.item_targetchart)});
            this.grp_performancechart.Name = "grp_performancechart";
            // 
            // item_targetchart
            // 
            this.item_targetchart.Caption = "Target Chart";
            this.item_targetchart.Name = "item_targetchart";
            this.item_targetchart.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.item_targetchart_LinkClicked);
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
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(863, 413);
            this.splitContainerControl1.SplitterPosition = 165;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 413);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.Text = "DataPulling Tool V2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
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




    }
}