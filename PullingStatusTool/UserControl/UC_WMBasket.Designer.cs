namespace PullingStatusTool.UserControl
{
    partial class UC_WMBasket
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
            this.txt_Stores = new DevExpress.XtraEditors.TextEdit();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stores.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Stores
            // 
            this.txt_Stores.Location = new System.Drawing.Point(12, 14);
            this.txt_Stores.Name = "txt_Stores";
            this.txt_Stores.Size = new System.Drawing.Size(403, 20);
            this.txt_Stores.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(421, 11);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // UC_WMBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txt_Stores);
            this.Name = "UC_WMBasket";
            this.Size = new System.Drawing.Size(962, 503);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stores.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Stores;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
    }
}
