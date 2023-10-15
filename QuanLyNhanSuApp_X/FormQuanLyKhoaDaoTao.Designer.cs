namespace QuanLyNhanSuApp
{
    partial class FormQuanLyKhoaDaoTao
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
            this.txtDaHoanThanh = new System.Windows.Forms.TextBox();
            this.txtTienDo = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.lblSoGioLamThem = new System.Windows.Forms.Label();
            this.txtTenKhoaDaoTao = new System.Windows.Forms.TextBox();
            this.lblSoNgayNghi = new System.Windows.Forms.Label();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.lblKyLuat = new System.Windows.Forms.Label();
            this.lblThuong = new System.Windows.Forms.Label();
            this.lblPhuCapKhac = new System.Windows.Forms.Label();
            this.txtMaKhoaDaoTao = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvFormQuanLyKhoaDaoTao = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyKhoaDaoTao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(861, 394);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(168, 43);
            this.btnTraCuu.TabIndex = 35;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(646, 394);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 43);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(431, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 43);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(216, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 43);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDaHoanThanh
            // 
            this.txtDaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaHoanThanh.Location = new System.Drawing.Point(899, 188);
            this.txtDaHoanThanh.Name = "txtDaHoanThanh";
            this.txtDaHoanThanh.ReadOnly = true;
            this.txtDaHoanThanh.Size = new System.Drawing.Size(245, 34);
            this.txtDaHoanThanh.TabIndex = 28;
            // 
            // txtTienDo
            // 
            this.txtTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDo.Location = new System.Drawing.Point(899, 129);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.Size = new System.Drawing.Size(245, 34);
            this.txtTienDo.TabIndex = 27;
            this.txtTienDo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienDo_KeyPress);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(899, 70);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(245, 34);
            this.txtMaNhanVien.TabIndex = 26;
            this.txtMaNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhanVien_KeyPress);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(324, 249);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(274, 34);
            this.txtThoiGian.TabIndex = 24;
            this.txtThoiGian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThoiGian_KeyPress);
            // 
            // lblSoGioLamThem
            // 
            this.lblSoGioLamThem.AutoSize = true;
            this.lblSoGioLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGioLamThem.Location = new System.Drawing.Point(702, 193);
            this.lblSoGioLamThem.Name = "lblSoGioLamThem";
            this.lblSoGioLamThem.Size = new System.Drawing.Size(166, 29);
            this.lblSoGioLamThem.TabIndex = 16;
            this.lblSoGioLamThem.Text = "Đã hoàn thành";
            // 
            // txtTenKhoaDaoTao
            // 
            this.txtTenKhoaDaoTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaDaoTao.Location = new System.Drawing.Point(324, 131);
            this.txtTenKhoaDaoTao.Name = "txtTenKhoaDaoTao";
            this.txtTenKhoaDaoTao.Size = new System.Drawing.Size(274, 34);
            this.txtTenKhoaDaoTao.TabIndex = 22;
            // 
            // lblSoNgayNghi
            // 
            this.lblSoNgayNghi.AutoSize = true;
            this.lblSoNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayNghi.Location = new System.Drawing.Point(702, 134);
            this.lblSoNgayNghi.Name = "lblSoNgayNghi";
            this.lblSoNgayNghi.Size = new System.Drawing.Size(96, 29);
            this.lblSoNgayNghi.TabIndex = 15;
            this.lblSoNgayNghi.Text = "Tiến độ";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayCong.Location = new System.Drawing.Point(702, 75);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(154, 29);
            this.lblSoNgayCong.TabIndex = 14;
            this.lblSoNgayCong.Text = "Mã nhân viên";
            // 
            // lblKyLuat
            // 
            this.lblKyLuat.AutoSize = true;
            this.lblKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKyLuat.Location = new System.Drawing.Point(101, 252);
            this.lblKyLuat.Name = "lblKyLuat";
            this.lblKyLuat.Size = new System.Drawing.Size(114, 29);
            this.lblKyLuat.TabIndex = 11;
            this.lblKyLuat.Text = "Thời gian";
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuong.Location = new System.Drawing.Point(101, 193);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(154, 29);
            this.lblThuong.TabIndex = 10;
            this.lblThuong.Text = "Ngày bắt đầu";
            // 
            // lblPhuCapKhac
            // 
            this.lblPhuCapKhac.AutoSize = true;
            this.lblPhuCapKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuCapKhac.Location = new System.Drawing.Point(101, 134);
            this.lblPhuCapKhac.Name = "lblPhuCapKhac";
            this.lblPhuCapKhac.Size = new System.Drawing.Size(200, 29);
            this.lblPhuCapKhac.TabIndex = 9;
            this.lblPhuCapKhac.Text = "Tên khóa đào tạo";
            // 
            // txtMaKhoaDaoTao
            // 
            this.txtMaKhoaDaoTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoaDaoTao.Location = new System.Drawing.Point(324, 72);
            this.txtMaKhoaDaoTao.Name = "txtMaKhoaDaoTao";
            this.txtMaKhoaDaoTao.Size = new System.Drawing.Size(274, 34);
            this.txtMaKhoaDaoTao.TabIndex = 21;
            this.txtMaKhoaDaoTao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhoaDaoTao_KeyPress);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(101, 75);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(190, 29);
            this.lblMaNV.TabIndex = 19;
            this.lblMaNV.Text = "Mã khóa đào tạo";
            // 
            // dgvFormQuanLyKhoaDaoTao
            // 
            this.dgvFormQuanLyKhoaDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyKhoaDaoTao.Location = new System.Drawing.Point(32, 459);
            this.dgvFormQuanLyKhoaDaoTao.Name = "dgvFormQuanLyKhoaDaoTao";
            this.dgvFormQuanLyKhoaDaoTao.ReadOnly = true;
            this.dgvFormQuanLyKhoaDaoTao.RowHeadersWidth = 51;
            this.dgvFormQuanLyKhoaDaoTao.RowTemplate.Height = 24;
            this.dgvFormQuanLyKhoaDaoTao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyKhoaDaoTao.Size = new System.Drawing.Size(1180, 182);
            this.dgvFormQuanLyKhoaDaoTao.TabIndex = 8;
            this.dgvFormQuanLyKhoaDaoTao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyKhoaDaoTao_CellClick);
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(324, 193);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(273, 34);
            this.dateTimePickerNgayBatDau.TabIndex = 36;
            // 
            // FormQuanLyKhoaDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.dateTimePickerNgayBatDau);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDaHoanThanh);
            this.Controls.Add(this.txtTienDo);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.lblSoGioLamThem);
            this.Controls.Add(this.txtTenKhoaDaoTao);
            this.Controls.Add(this.lblSoNgayNghi);
            this.Controls.Add(this.lblSoNgayCong);
            this.Controls.Add(this.lblKyLuat);
            this.Controls.Add(this.lblThuong);
            this.Controls.Add(this.lblPhuCapKhac);
            this.Controls.Add(this.txtMaKhoaDaoTao);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.dgvFormQuanLyKhoaDaoTao);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormQuanLyKhoaDaoTao";
            this.Text = "FormQuanLyKhoaDaoTao";
            this.Load += new System.EventHandler(this.FormQuanLyKhoaDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyKhoaDaoTao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDaHoanThanh;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label lblSoGioLamThem;
        private System.Windows.Forms.TextBox txtTenKhoaDaoTao;
        private System.Windows.Forms.Label lblSoNgayNghi;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.Label lblKyLuat;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.Label lblPhuCapKhac;
        private System.Windows.Forms.TextBox txtMaKhoaDaoTao;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dgvFormQuanLyKhoaDaoTao;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
    }
}