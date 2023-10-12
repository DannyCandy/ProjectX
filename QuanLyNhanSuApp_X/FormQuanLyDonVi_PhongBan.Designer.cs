namespace QuanLyNhanSuApp
{
    partial class FormQuanLyDonVi_PhongBan
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
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblMaBoPhan = new System.Windows.Forms.Label();
            this.lblNgayThanhLap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.dgvFormQuanLyDonVi_PhongBan = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNgayThanhLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyDonVi_PhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(852, 339);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(168, 43);
            this.btnTraCuu.TabIndex = 56;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(637, 339);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 43);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(422, 339);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 43);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(207, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 43);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBoPhan.Location = new System.Drawing.Point(856, 27);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(297, 34);
            this.txtMaBoPhan.TabIndex = 50;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(265, 145);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(284, 151);
            this.txtGhiChu.TabIndex = 49;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(265, 86);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(284, 34);
            this.txtTenPhong.TabIndex = 48;
            // 
            // lblMaBoPhan
            // 
            this.lblMaBoPhan.AutoSize = true;
            this.lblMaBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBoPhan.Location = new System.Drawing.Point(643, 32);
            this.lblMaBoPhan.Name = "lblMaBoPhan";
            this.lblMaBoPhan.Size = new System.Drawing.Size(139, 29);
            this.lblMaBoPhan.TabIndex = 42;
            this.lblMaBoPhan.Text = "Mã bộ phận";
            // 
            // lblNgayThanhLap
            // 
            this.lblNgayThanhLap.AutoSize = true;
            this.lblNgayThanhLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhLap.Location = new System.Drawing.Point(643, 89);
            this.lblNgayThanhLap.Name = "lblNgayThanhLap";
            this.lblNgayThanhLap.Size = new System.Drawing.Size(172, 29);
            this.lblNgayThanhLap.TabIndex = 41;
            this.lblNgayThanhLap.Text = "Ngày thành lập";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(74, 148);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(94, 29);
            this.lblGhiChu.TabIndex = 40;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(74, 89);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(130, 29);
            this.lblTenPhong.TabIndex = 39;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(265, 27);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(284, 34);
            this.txtMaPhong.TabIndex = 47;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(74, 30);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(120, 29);
            this.lblMaPhong.TabIndex = 45;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // dgvFormQuanLyDonVi_PhongBan
            // 
            this.dgvFormQuanLyDonVi_PhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyDonVi_PhongBan.Location = new System.Drawing.Point(23, 404);
            this.dgvFormQuanLyDonVi_PhongBan.Name = "dgvFormQuanLyDonVi_PhongBan";
            this.dgvFormQuanLyDonVi_PhongBan.ReadOnly = true;
            this.dgvFormQuanLyDonVi_PhongBan.RowHeadersWidth = 51;
            this.dgvFormQuanLyDonVi_PhongBan.RowTemplate.Height = 24;
            this.dgvFormQuanLyDonVi_PhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyDonVi_PhongBan.Size = new System.Drawing.Size(1180, 164);
            this.dgvFormQuanLyDonVi_PhongBan.TabIndex = 38;
            this.dgvFormQuanLyDonVi_PhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyDonVi_PhongBan_CellClick);
            // 
            // dateTimePickerNgayThanhLap
            // 
            this.dateTimePickerNgayThanhLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayThanhLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayThanhLap.Location = new System.Drawing.Point(856, 84);
            this.dateTimePickerNgayThanhLap.Name = "dateTimePickerNgayThanhLap";
            this.dateTimePickerNgayThanhLap.Size = new System.Drawing.Size(296, 34);
            this.dateTimePickerNgayThanhLap.TabIndex = 57;
            // 
            // QuanLyDonVi_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 595);
            this.Controls.Add(this.dateTimePickerNgayThanhLap);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.lblMaBoPhan);
            this.Controls.Add(this.lblNgayThanhLap);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.dgvFormQuanLyDonVi_PhongBan);
            this.Location = new System.Drawing.Point(0, 33);
            this.Name = "QuanLyDonVi_PhongBan";
            this.Text = "QuanLyDonVi_PhongBan";
            this.Load += new System.EventHandler(this.QuanLyDonVi_PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyDonVi_PhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaBoPhan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblMaBoPhan;
        private System.Windows.Forms.Label lblNgayThanhLap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.DataGridView dgvFormQuanLyDonVi_PhongBan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThanhLap;
    }
}