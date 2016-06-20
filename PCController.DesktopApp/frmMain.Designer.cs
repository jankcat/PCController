namespace PCController.DesktopApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPCLEDs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.monitorLEDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsNotifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PCController";
            this.notifyIcon1.Visible = true;
            // 
            // cmsNotifyMenu
            // 
            this.cmsNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPCLEDs,
            this.monitorLEDsToolStripMenuItem,
            this.toolStripSeparator1,
            this.cmiExit});
            this.cmsNotifyMenu.Name = "cmsNotifyMenu";
            this.cmsNotifyMenu.Size = new System.Drawing.Size(146, 76);
            // 
            // cmiPCLEDs
            // 
            this.cmiPCLEDs.CheckOnClick = true;
            this.cmiPCLEDs.Name = "cmiPCLEDs";
            this.cmiPCLEDs.Size = new System.Drawing.Size(152, 22);
            this.cmiPCLEDs.Text = "PC LEDs";
            this.cmiPCLEDs.Click += new System.EventHandler(this.cmiPCLEDs_Click);
            // 
            // cmiExit
            // 
            this.cmiExit.Name = "cmiExit";
            this.cmiExit.Size = new System.Drawing.Size(152, 22);
            this.cmiExit.Text = "E&xit";
            this.cmiExit.Click += new System.EventHandler(this.cmiExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // monitorLEDsToolStripMenuItem
            // 
            this.monitorLEDsToolStripMenuItem.CheckOnClick = true;
            this.monitorLEDsToolStripMenuItem.Name = "monitorLEDsToolStripMenuItem";
            this.monitorLEDsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monitorLEDsToolStripMenuItem.Text = "Monitor LEDs";
            this.monitorLEDsToolStripMenuItem.Click += new System.EventHandler(this.monitorLEDsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Text = "PCController";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsNotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem cmiPCLEDs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmiExit;
        private System.Windows.Forms.ToolStripMenuItem monitorLEDsToolStripMenuItem;
    }
}