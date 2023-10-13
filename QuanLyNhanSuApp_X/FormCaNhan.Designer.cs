namespace QuanLyNhanSuApp
{
    partial class FormCaNhan
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
            this.menuStripCaNhan = new System.Windows.Forms.MenuStrip();
            this.lichLamViecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaDaoTaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormCaNhan = new System.Windows.Forms.Panel();
            this.menuStripCaNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCaNhan
            // 
            this.menuStripCaNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripCaNhan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCaNhan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lichLamViecToolStripMenuItem,
            this.cheDoToolStripMenuItem,
            this.luongToolStripMenuItem,
            this.thongTinCaNhanToolStripMenuItem,
            this.khoaDaoTaoToolStripMenuItem});
            this.menuStripCaNhan.Location = new System.Drawing.Point(0, 0);
            this.menuStripCaNhan.Name = "menuStripCaNhan";
            this.menuStripCaNhan.Size = new System.Drawing.Size(1244, 33);
            this.menuStripCaNhan.TabIndex = 0;
            this.menuStripCaNhan.Text = "menuStrip1";
            // 
            // lichLamViecToolStripMenuItem
            // 
            this.lichLamViecToolStripMenuItem.Name = "lichLamViecToolStripMenuItem";
            this.lichLamViecToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.lichLamViecToolStripMenuItem.Text = "Lịch làm việc";
            this.lichLamViecToolStripMenuItem.Click += new System.EventHandler(this.lichLamViecToolStripMenuItem_Click);
            // 
            // cheDoToolStripMenuItem
            // 
            this.cheDoToolStripMenuItem.Name = "cheDoToolStripMenuItem";
            this.cheDoToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.cheDoToolStripMenuItem.Text = "Chế độ";
            this.cheDoToolStripMenuItem.Click += new System.EventHandler(this.cheDoToolStripMenuItem_Click);
            // 
            // luongToolStripMenuItem
            // 
            this.luongToolStripMenuItem.Name = "luongToolStripMenuItem";
            this.luongToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.luongToolStripMenuItem.Text = "Lương";
            this.luongToolStripMenuItem.Click += new System.EventHandler(this.luongToolStripMenuItem_Click);
            // 
            // thongTinCaNhanToolStripMenuItem
            // 
            this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
            this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.thongTinCaNhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanToolStripMenuItem_Click);
            // 
            // khoaDaoTaoToolStripMenuItem
            // 
            this.khoaDaoTaoToolStripMenuItem.Name = "khoaDaoTaoToolStripMenuItem";
            this.khoaDaoTaoToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.khoaDaoTaoToolStripMenuItem.Text = "Khóa đào tạo";
            this.khoaDaoTaoToolStripMenuItem.Click += new System.EventHandler(this.khoaDaoTaoToolStripMenuItem_Click);
            // 
            // panelFormCaNhan
            // 
            this.panelFormCaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCaNhan.Location = new System.Drawing.Point(0, 33);
            this.panelFormCaNhan.Name = "panelFormCaNhan";
            this.panelFormCaNhan.Size = new System.Drawing.Size(1244, 642);
            this.panelFormCaNhan.TabIndex = 1;
            // 
            // FormCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.panelFormCaNhan);
            this.Controls.Add(this.menuStripCaNhan);
            this.Location = new System.Drawing.Point(0, 31);
            this.MainMenuStrip = this.menuStripCaNhan;
            this.Name = "FormCaNhan";
            this.Text = "FormCaNhan";
            this.Load += new System.EventHandler(this.FormCaNhan_Load);
            this.menuStripCaNhan.ResumeLayout(false);
            this.menuStripCaNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCaNhan;
        private System.Windows.Forms.ToolStripMenuItem lichLamViecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaDaoTaoToolStripMenuItem;
        private System.Windows.Forms.Panel panelFormCaNhan;
    }
}