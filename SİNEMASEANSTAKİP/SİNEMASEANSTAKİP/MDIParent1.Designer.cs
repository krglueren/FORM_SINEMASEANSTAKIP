namespace SİNEMASEANSTAKİP
{
    partial class MDIParent1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fİLMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLETİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİLMLERToolStripMenuItem,
            this.bİLETİMToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fİLMLERToolStripMenuItem
            // 
            this.fİLMLERToolStripMenuItem.Name = "fİLMLERToolStripMenuItem";
            this.fİLMLERToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fİLMLERToolStripMenuItem.Text = "FİLMLER";
            this.fİLMLERToolStripMenuItem.Click += new System.EventHandler(this.fİLMLERToolStripMenuItem_Click);
            // 
            // bİLETİMToolStripMenuItem
            // 
            this.bİLETİMToolStripMenuItem.Name = "bİLETİMToolStripMenuItem";
            this.bİLETİMToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bİLETİMToolStripMenuItem.Text = "MÜŞTERİLER";
            this.bİLETİMToolStripMenuItem.Click += new System.EventHandler(this.bİLETİMToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 717);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel.Text = "EREN KÖROĞLU";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 739);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİNEMA SEANS TAKİP";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fİLMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLETİMToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}



