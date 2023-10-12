namespace QuanLyNhanSuApp
{
    partial class FormThongTinNV
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
            this.menuStripThongTin = new System.Windows.Forms.MenuStrip();
            this.TTCBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTCNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.menuStripThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripThongTin
            // 
            this.menuStripThongTin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripThongTin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripThongTin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTCBToolStripMenuItem,
            this.TTCNToolStripMenuItem});
            this.menuStripThongTin.Location = new System.Drawing.Point(0, 0);
            this.menuStripThongTin.Name = "menuStripThongTin";
            this.menuStripThongTin.Size = new System.Drawing.Size(1224, 33);
            this.menuStripThongTin.TabIndex = 1;
            this.menuStripThongTin.Text = "menuStrip1";
            // 
            // TTCBToolStripMenuItem
            // 
            this.TTCBToolStripMenuItem.Name = "TTCBToolStripMenuItem";
            this.TTCBToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.TTCBToolStripMenuItem.Text = "Thông tin cơ bản";
            this.TTCBToolStripMenuItem.Click += new System.EventHandler(this.TTCBToolStripMenuItem_Click);
            // 
            // TTCNToolStripMenuItem
            // 
            this.TTCNToolStripMenuItem.Name = "TTCNToolStripMenuItem";
            this.TTCNToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.TTCNToolStripMenuItem.Text = "Thông tin cá nhân";
            this.TTCNToolStripMenuItem.Click += new System.EventHandler(this.TTCNToolStripMenuItem_Click);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(0, 33);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1224, 562);
            this.panelThongTin.TabIndex = 2;
            // 
            // FormThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 595);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.menuStripThongTin);
            this.Location = new System.Drawing.Point(0, 33);
            this.Name = "FormThongTinNV";
            this.Text = "FormThongTinNV";
            this.Load += new System.EventHandler(this.FormThongTinNV_Load);
            this.menuStripThongTin.ResumeLayout(false);
            this.menuStripThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripThongTin;
        private System.Windows.Forms.ToolStripMenuItem TTCBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTCNToolStripMenuItem;
        private System.Windows.Forms.Panel panelThongTin;
    }
}