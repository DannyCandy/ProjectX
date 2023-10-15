namespace QuanLyNhanSuApp
{
    partial class FormCheDo
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
            this.menuStripCheDo = new System.Windows.Forms.MenuStrip();
            this.baoHiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiSanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCheDo = new System.Windows.Forms.Panel();
            this.menuStripCheDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCheDo
            // 
            this.menuStripCheDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripCheDo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCheDo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoHiemToolStripMenuItem,
            this.thaiSanToolStripMenuItem});
            this.menuStripCheDo.Location = new System.Drawing.Point(0, 0);
            this.menuStripCheDo.Name = "menuStripCheDo";
            this.menuStripCheDo.Size = new System.Drawing.Size(1244, 28);
            this.menuStripCheDo.TabIndex = 0;
            this.menuStripCheDo.Text = "menuStrip1";
            // 
            // baoHiemToolStripMenuItem
            // 
            this.baoHiemToolStripMenuItem.Name = "baoHiemToolStripMenuItem";
            this.baoHiemToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.baoHiemToolStripMenuItem.Text = "Bảo Hiểm";
            this.baoHiemToolStripMenuItem.Click += new System.EventHandler(this.baoHiemToolStripMenuItem_Click);
            // 
            // thaiSanToolStripMenuItem
            // 
            this.thaiSanToolStripMenuItem.Name = "thaiSanToolStripMenuItem";
            this.thaiSanToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.thaiSanToolStripMenuItem.Text = "Thai sản";
            this.thaiSanToolStripMenuItem.Click += new System.EventHandler(this.thaiSanToolStripMenuItem_Click);
            // 
            // panelCheDo
            // 
            this.panelCheDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheDo.Location = new System.Drawing.Point(0, 28);
            this.panelCheDo.Name = "panelCheDo";
            this.panelCheDo.Size = new System.Drawing.Size(1244, 647);
            this.panelCheDo.TabIndex = 1;
            // 
            // FormCheDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.panelCheDo);
            this.Controls.Add(this.menuStripCheDo);
            this.Location = new System.Drawing.Point(0, 31);
            this.MainMenuStrip = this.menuStripCheDo;
            this.Name = "FormCheDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chế độ";
            this.Load += new System.EventHandler(this.FormCheDo_Load);
            this.menuStripCheDo.ResumeLayout(false);
            this.menuStripCheDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCheDo;
        private System.Windows.Forms.ToolStripMenuItem baoHiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaiSanToolStripMenuItem;
        private System.Windows.Forms.Panel panelCheDo;
    }
}