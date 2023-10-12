namespace QuanLyNhanSuApp
{
    partial class FormQuanLyNhanSu_ThongTinNV
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
            this.dgvFormQuanLyTTNVCoBan = new System.Windows.Forms.DataGridView();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblPhuCapKhac = new System.Windows.Forms.Label();
            this.lblThuong = new System.Windows.Forms.Label();
            this.lblKyLuat = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.lblSoNgayNghi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoGioLamThem = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTTHonNhan = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.cbbBoPhan = new System.Windows.Forms.ComboBox();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyTTNVCoBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(843, 302);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(168, 43);
            this.btnTraCuu.TabIndex = 64;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(628, 302);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 43);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(413, 302);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 43);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(198, 302);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 43);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvFormQuanLyTTNVCoBan
            // 
            this.dgvFormQuanLyTTNVCoBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyTTNVCoBan.Location = new System.Drawing.Point(14, 369);
            this.dgvFormQuanLyTTNVCoBan.Name = "dgvFormQuanLyTTNVCoBan";
            this.dgvFormQuanLyTTNVCoBan.ReadOnly = true;
            this.dgvFormQuanLyTTNVCoBan.RowHeadersWidth = 51;
            this.dgvFormQuanLyTTNVCoBan.RowTemplate.Height = 24;
            this.dgvFormQuanLyTTNVCoBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyTTNVCoBan.Size = new System.Drawing.Size(1180, 134);
            this.dgvFormQuanLyTTNVCoBan.TabIndex = 37;
            this.dgvFormQuanLyTTNVCoBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyTTNVCoBan_CellClick);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(84, 17);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(85, 29);
            this.lblMaNV.TabIndex = 48;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(250, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(310, 34);
            this.txtMaNV.TabIndex = 50;
            // 
            // lblPhuCapKhac
            // 
            this.lblPhuCapKhac.AutoSize = true;
            this.lblPhuCapKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuCapKhac.Location = new System.Drawing.Point(84, 76);
            this.lblPhuCapKhac.Name = "lblPhuCapKhac";
            this.lblPhuCapKhac.Size = new System.Drawing.Size(83, 29);
            this.lblPhuCapKhac.TabIndex = 38;
            this.lblPhuCapKhac.Text = "Họ tên";
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuong.Location = new System.Drawing.Point(84, 135);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(102, 29);
            this.lblThuong.TabIndex = 39;
            this.lblThuong.Text = "Bộ phận";
            // 
            // lblKyLuat
            // 
            this.lblKyLuat.AutoSize = true;
            this.lblKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKyLuat.Location = new System.Drawing.Point(84, 194);
            this.lblKyLuat.Name = "lblKyLuat";
            this.lblKyLuat.Size = new System.Drawing.Size(129, 29);
            this.lblKyLuat.TabIndex = 40;
            this.lblKyLuat.Text = "Phòng ban";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(84, 253);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(98, 29);
            this.lblThang.TabIndex = 41;
            this.lblThang.Text = "Chức vụ";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(607, 133);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(119, 29);
            this.lblNam.TabIndex = 42;
            this.lblNam.Text = "Ngày sinh";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayCong.Location = new System.Drawing.Point(607, 15);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(101, 29);
            this.lblSoNgayCong.TabIndex = 43;
            this.lblSoNgayCong.Text = "Giới tính";
            // 
            // lblSoNgayNghi
            // 
            this.lblSoNgayNghi.AutoSize = true;
            this.lblSoNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayNghi.Location = new System.Drawing.Point(607, 74);
            this.lblSoNgayNghi.Name = "lblSoNgayNghi";
            this.lblSoNgayNghi.Size = new System.Drawing.Size(149, 29);
            this.lblSoNgayNghi.TabIndex = 44;
            this.lblSoNgayNghi.Text = "TT hôn nhân";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(250, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(310, 34);
            this.txtHoTen.TabIndex = 51;
            // 
            // lblSoGioLamThem
            // 
            this.lblSoGioLamThem.AutoSize = true;
            this.lblSoGioLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGioLamThem.Location = new System.Drawing.Point(607, 194);
            this.lblSoGioLamThem.Name = "lblSoGioLamThem";
            this.lblSoGioLamThem.Size = new System.Drawing.Size(85, 29);
            this.lblSoGioLamThem.TabIndex = 45;
            this.lblSoGioLamThem.Text = "CMND";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(607, 253);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(96, 29);
            this.lblLuong.TabIndex = 49;
            this.lblLuong.Text = "Nơi cấp";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(250, 248);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(310, 34);
            this.txtChucVu.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1471, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nơi cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1473, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "Ghi chú";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(1583, 201);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(222, 152);
            this.textBox8.TabIndex = 78;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1583, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 152);
            this.textBox3.TabIndex = 78;
            // 
            // txtTTHonNhan
            // 
            this.txtTTHonNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTHonNhan.Location = new System.Drawing.Point(789, 71);
            this.txtTTHonNhan.Name = "txtTTHonNhan";
            this.txtTTHonNhan.Size = new System.Drawing.Size(336, 34);
            this.txtTTHonNhan.TabIndex = 56;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(789, 191);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(336, 34);
            this.txtCMND.TabIndex = 57;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiCap.Location = new System.Drawing.Point(789, 250);
            this.txtNoiCap.Multiline = true;
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(336, 32);
            this.txtNoiCap.TabIndex = 58;
            // 
            // cbbBoPhan
            // 
            this.cbbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBoPhan.FormattingEnabled = true;
            this.cbbBoPhan.Location = new System.Drawing.Point(250, 127);
            this.cbbBoPhan.Name = "cbbBoPhan";
            this.cbbBoPhan.Size = new System.Drawing.Size(310, 37);
            this.cbbBoPhan.TabIndex = 79;
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(250, 191);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(310, 37);
            this.cbbPhongBan.TabIndex = 80;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(789, 130);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(336, 34);
            this.dateTimePickerNgaySinh.TabIndex = 81;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Giới tính khác",
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(789, 14);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(336, 37);
            this.cbbGioiTinh.TabIndex = 80;
            // 
            // FormQuanLyNhanSu_ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 515);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.cbbPhongBan);
            this.Controls.Add(this.cbbBoPhan);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTTHonNhan);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblSoGioLamThem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSoNgayNghi);
            this.Controls.Add(this.lblSoNgayCong);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblKyLuat);
            this.Controls.Add(this.lblThuong);
            this.Controls.Add(this.lblPhuCapKhac);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.dgvFormQuanLyTTNVCoBan);
            this.Location = new System.Drawing.Point(0, 33);
            this.Name = "FormQuanLyNhanSu_ThongTinNV";
            this.Text = "FormQuanLyNhanSu_ThongTinNV_CoBan";
            this.Load += new System.EventHandler(this.FormQuanLyNhanSu_ThongTinNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyTTNVCoBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvFormQuanLyTTNVCoBan;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblPhuCapKhac;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.Label lblKyLuat;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.Label lblSoNgayNghi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoGioLamThem;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTTHonNhan;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.ComboBox cbbBoPhan;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
    }
}