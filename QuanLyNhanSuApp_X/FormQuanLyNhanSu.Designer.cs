namespace QuanLyNhanSuApp
{
    partial class FormQuanLyNhanSu
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
            this.menuStripQuanLyNhanSu = new System.Windows.Forms.MenuStrip();
            this.bangCongNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienRoiToChucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuanLyNhanSu = new System.Windows.Forms.Panel();
            this.menuStripQuanLyNhanSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripQuanLyNhanSu
            // 
            this.menuStripQuanLyNhanSu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripQuanLyNhanSu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripQuanLyNhanSu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bangCongNhanVienToolStripMenuItem,
            this.thongTinNhanVienToolStripMenuItem,
            this.nhanVienRoiToChucToolStripMenuItem});
            this.menuStripQuanLyNhanSu.Location = new System.Drawing.Point(0, 0);
            this.menuStripQuanLyNhanSu.Name = "menuStripQuanLyNhanSu";
            this.menuStripQuanLyNhanSu.Size = new System.Drawing.Size(1244, 33);
            this.menuStripQuanLyNhanSu.TabIndex = 3;
            this.menuStripQuanLyNhanSu.Text = "menuStrip1";
            // 
            // bangCongNhanVienToolStripMenuItem
            // 
            this.bangCongNhanVienToolStripMenuItem.Name = "bangCongNhanVienToolStripMenuItem";
            this.bangCongNhanVienToolStripMenuItem.Size = new System.Drawing.Size(199, 27);
            this.bangCongNhanVienToolStripMenuItem.Text = "Bảng Công Nhân Viên";
            this.bangCongNhanVienToolStripMenuItem.Click += new System.EventHandler(this.bangCongNhanVienToolStripMenuItem_Click);
            // 
            // thongTinNhanVienToolStripMenuItem
            // 
            this.thongTinNhanVienToolStripMenuItem.Name = "thongTinNhanVienToolStripMenuItem";
            this.thongTinNhanVienToolStripMenuItem.Size = new System.Drawing.Size(192, 27);
            this.thongTinNhanVienToolStripMenuItem.Text = "Thông Tin Nhân Viên";
            this.thongTinNhanVienToolStripMenuItem.Click += new System.EventHandler(this.thongTinNhanVienToolStripMenuItem_Click);
            // 
            // nhanVienRoiToChucToolStripMenuItem
            // 
            this.nhanVienRoiToChucToolStripMenuItem.Name = "nhanVienRoiToChucToolStripMenuItem";
            this.nhanVienRoiToChucToolStripMenuItem.Size = new System.Drawing.Size(208, 27);
            this.nhanVienRoiToChucToolStripMenuItem.Text = "Nhân Viên Rời Tổ Chức";
            this.nhanVienRoiToChucToolStripMenuItem.Click += new System.EventHandler(this.nhanVienRoiToChucToolStripMenuItem_Click);
            // 
            // panelQuanLyNhanSu
            // 
            this.panelQuanLyNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLyNhanSu.Location = new System.Drawing.Point(0, 33);
            this.panelQuanLyNhanSu.Name = "panelQuanLyNhanSu";
            this.panelQuanLyNhanSu.Size = new System.Drawing.Size(1244, 642);
            this.panelQuanLyNhanSu.TabIndex = 4;
            // 
            // FormQuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.panelQuanLyNhanSu);
            this.Controls.Add(this.menuStripQuanLyNhanSu);
            this.Location = new System.Drawing.Point(0, 31);
            this.MainMenuStrip = this.menuStripQuanLyNhanSu;
            this.Name = "FormQuanLyNhanSu";
            this.Text = "FormQuanLyNhanSu";
            this.Load += new System.EventHandler(this.FormQuanLyNhanSu_Load);
            this.menuStripQuanLyNhanSu.ResumeLayout(false);
            this.menuStripQuanLyNhanSu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripQuanLyNhanSu;
        private System.Windows.Forms.ToolStripMenuItem bangCongNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienRoiToChucToolStripMenuItem;
        private System.Windows.Forms.Panel panelQuanLyNhanSu;
    }
}