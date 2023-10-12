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
            this.dgvFormCaNhan = new System.Windows.Forms.DataGridView();
            this.dataGridViewBaoHiem = new System.Windows.Forms.DataGridView();
            this.dataGridViewThaiSan = new System.Windows.Forms.DataGridView();
            this.lblBaoHiem = new System.Windows.Forms.Label();
            this.lblThaiSan = new System.Windows.Forms.Label();
            this.menuStripCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormCaNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoHiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThaiSan)).BeginInit();
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
            // dgvFormCaNhan
            // 
            this.dgvFormCaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormCaNhan.Location = new System.Drawing.Point(29, 50);
            this.dgvFormCaNhan.Name = "dgvFormCaNhan";
            this.dgvFormCaNhan.RowHeadersWidth = 51;
            this.dgvFormCaNhan.RowTemplate.Height = 24;
            this.dgvFormCaNhan.Size = new System.Drawing.Size(1187, 574);
            this.dgvFormCaNhan.TabIndex = 1;
            // 
            // dataGridViewBaoHiem
            // 
            this.dataGridViewBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoHiem.Location = new System.Drawing.Point(29, 144);
            this.dataGridViewBaoHiem.Name = "dataGridViewBaoHiem";
            this.dataGridViewBaoHiem.RowHeadersWidth = 51;
            this.dataGridViewBaoHiem.RowTemplate.Height = 24;
            this.dataGridViewBaoHiem.Size = new System.Drawing.Size(1187, 182);
            this.dataGridViewBaoHiem.TabIndex = 2;
            // 
            // dataGridViewThaiSan
            // 
            this.dataGridViewThaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThaiSan.Location = new System.Drawing.Point(29, 442);
            this.dataGridViewThaiSan.Name = "dataGridViewThaiSan";
            this.dataGridViewThaiSan.RowHeadersWidth = 51;
            this.dataGridViewThaiSan.RowTemplate.Height = 24;
            this.dataGridViewThaiSan.Size = new System.Drawing.Size(1187, 182);
            this.dataGridViewThaiSan.TabIndex = 2;
            // 
            // lblBaoHiem
            // 
            this.lblBaoHiem.AutoSize = true;
            this.lblBaoHiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoHiem.Location = new System.Drawing.Point(24, 80);
            this.lblBaoHiem.Name = "lblBaoHiem";
            this.lblBaoHiem.Size = new System.Drawing.Size(123, 29);
            this.lblBaoHiem.TabIndex = 3;
            this.lblBaoHiem.Text = "Bảo hiểm";
            // 
            // lblThaiSan
            // 
            this.lblThaiSan.AutoSize = true;
            this.lblThaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThaiSan.Location = new System.Drawing.Point(24, 371);
            this.lblThaiSan.Name = "lblThaiSan";
            this.lblThaiSan.Size = new System.Drawing.Size(113, 29);
            this.lblThaiSan.TabIndex = 3;
            this.lblThaiSan.Text = "Thai sản";
            // 
            // FormCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.lblThaiSan);
            this.Controls.Add(this.lblBaoHiem);
            this.Controls.Add(this.dataGridViewThaiSan);
            this.Controls.Add(this.dataGridViewBaoHiem);
            this.Controls.Add(this.dgvFormCaNhan);
            this.Controls.Add(this.menuStripCaNhan);
            this.Location = new System.Drawing.Point(0, 31);
            this.MainMenuStrip = this.menuStripCaNhan;
            this.Name = "FormCaNhan";
            this.Text = "FormCaNhan";
            this.Load += new System.EventHandler(this.FormCaNhan_Load);
            this.menuStripCaNhan.ResumeLayout(false);
            this.menuStripCaNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormCaNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoHiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThaiSan)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFormCaNhan;
        private System.Windows.Forms.DataGridView dataGridViewBaoHiem;
        private System.Windows.Forms.DataGridView dataGridViewThaiSan;
        private System.Windows.Forms.Label lblBaoHiem;
        private System.Windows.Forms.Label lblThaiSan;
    }
}