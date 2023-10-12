namespace QuanLyNhanSuApp
{
    partial class FormQuanLyDonVi
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
            this.menuStripQuanLyDonVi = new System.Windows.Forms.MenuStrip();
            this.phongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuanLyDonVi = new System.Windows.Forms.Panel();
            this.menuStripQuanLyDonVi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripQuanLyDonVi
            // 
            this.menuStripQuanLyDonVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripQuanLyDonVi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripQuanLyDonVi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongBanToolStripMenuItem,
            this.boPhanToolStripMenuItem});
            this.menuStripQuanLyDonVi.Location = new System.Drawing.Point(0, 0);
            this.menuStripQuanLyDonVi.Name = "menuStripQuanLyDonVi";
            this.menuStripQuanLyDonVi.Size = new System.Drawing.Size(1244, 33);
            this.menuStripQuanLyDonVi.TabIndex = 4;
            this.menuStripQuanLyDonVi.Text = "menuStrip1";
            // 
            // phongBanToolStripMenuItem
            // 
            this.phongBanToolStripMenuItem.Name = "phongBanToolStripMenuItem";
            this.phongBanToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.phongBanToolStripMenuItem.Text = "Phòng ban";
            this.phongBanToolStripMenuItem.Click += new System.EventHandler(this.phongBanToolStripMenuItem_Click);
            // 
            // boPhanToolStripMenuItem
            // 
            this.boPhanToolStripMenuItem.Name = "boPhanToolStripMenuItem";
            this.boPhanToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.boPhanToolStripMenuItem.Text = "Bộ phận";
            this.boPhanToolStripMenuItem.Click += new System.EventHandler(this.boPhanToolStripMenuItem_Click);
            // 
            // panelQuanLyDonVi
            // 
            this.panelQuanLyDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLyDonVi.Location = new System.Drawing.Point(0, 33);
            this.panelQuanLyDonVi.Name = "panelQuanLyDonVi";
            this.panelQuanLyDonVi.Size = new System.Drawing.Size(1244, 642);
            this.panelQuanLyDonVi.TabIndex = 5;
            // 
            // FormQuanLyDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.panelQuanLyDonVi);
            this.Controls.Add(this.menuStripQuanLyDonVi);
            this.Location = new System.Drawing.Point(0, 31);
            this.MainMenuStrip = this.menuStripQuanLyDonVi;
            this.Name = "FormQuanLyDonVi";
            this.Text = "FormQuanLyDonVi";
            this.Load += new System.EventHandler(this.FormQuanLyDonVi_Load);
            this.menuStripQuanLyDonVi.ResumeLayout(false);
            this.menuStripQuanLyDonVi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripQuanLyDonVi;
        private System.Windows.Forms.ToolStripMenuItem phongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boPhanToolStripMenuItem;
        private System.Windows.Forms.Panel panelQuanLyDonVi;
    }
}