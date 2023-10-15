namespace QuanLyNhanSuApp
{
    partial class FormQuanLyHopDong
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
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.txtThoiHanLamViec = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblNgayKiKet = new System.Windows.Forms.Label();
            this.lblThoiHanLamViec = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvFormQuanLyHopDong = new System.Windows.Forms.DataGridView();
            this.txtLoaiHopDong = new System.Windows.Forms.TextBox();
            this.lblLoaiHopDong = new System.Windows.Forms.Label();
            this.dateTimePickerNgayKiKet = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayHetHan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyHopDong)).BeginInit();
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
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(873, 34);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(294, 34);
            this.txtMaHopDong.TabIndex = 26;
            this.txtMaHopDong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHopDong_KeyPress);
            // 
            // txtThoiHanLamViec
            // 
            this.txtThoiHanLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiHanLamViec.Location = new System.Drawing.Point(299, 154);
            this.txtThoiHanLamViec.Name = "txtThoiHanLamViec";
            this.txtThoiHanLamViec.Size = new System.Drawing.Size(328, 34);
            this.txtThoiHanLamViec.TabIndex = 23;
            this.txtThoiHanLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThoiHanLamViec_KeyPress);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(299, 95);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(328, 34);
            this.txtChucVu.TabIndex = 22;
            // 
            // lblMaHopDong
            // 
            this.lblMaHopDong.AutoSize = true;
            this.lblMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHopDong.Location = new System.Drawing.Point(692, 39);
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.Size = new System.Drawing.Size(154, 29);
            this.lblMaHopDong.TabIndex = 14;
            this.lblMaHopDong.Text = "Mã hợp đồng";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHetHan.Location = new System.Drawing.Point(77, 275);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(153, 29);
            this.lblNgayHetHan.TabIndex = 12;
            this.lblNgayHetHan.Text = "Ngày hết hạn";
            // 
            // lblNgayKiKet
            // 
            this.lblNgayKiKet.AutoSize = true;
            this.lblNgayKiKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKiKet.Location = new System.Drawing.Point(77, 216);
            this.lblNgayKiKet.Name = "lblNgayKiKet";
            this.lblNgayKiKet.Size = new System.Drawing.Size(131, 29);
            this.lblNgayKiKet.TabIndex = 11;
            this.lblNgayKiKet.Text = "Ngày kí kết";
            // 
            // lblThoiHanLamViec
            // 
            this.lblThoiHanLamViec.AutoSize = true;
            this.lblThoiHanLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHanLamViec.Location = new System.Drawing.Point(77, 157);
            this.lblThoiHanLamViec.Name = "lblThoiHanLamViec";
            this.lblThoiHanLamViec.Size = new System.Drawing.Size(201, 29);
            this.lblThoiHanLamViec.TabIndex = 10;
            this.lblThoiHanLamViec.Text = "Thời hạn làm việc";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(77, 98);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(98, 29);
            this.lblChucVu.TabIndex = 9;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(299, 36);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(328, 34);
            this.txtMaNV.TabIndex = 21;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(77, 39);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(154, 29);
            this.lblMaNV.TabIndex = 19;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // dgvFormQuanLyHopDong
            // 
            this.dgvFormQuanLyHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyHopDong.Location = new System.Drawing.Point(32, 459);
            this.dgvFormQuanLyHopDong.Name = "dgvFormQuanLyHopDong";
            this.dgvFormQuanLyHopDong.ReadOnly = true;
            this.dgvFormQuanLyHopDong.RowHeadersWidth = 51;
            this.dgvFormQuanLyHopDong.RowTemplate.Height = 24;
            this.dgvFormQuanLyHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyHopDong.Size = new System.Drawing.Size(1180, 182);
            this.dgvFormQuanLyHopDong.TabIndex = 8;
            this.dgvFormQuanLyHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyHopDong_CellClick);
            // 
            // txtLoaiHopDong
            // 
            this.txtLoaiHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiHopDong.Location = new System.Drawing.Point(873, 93);
            this.txtLoaiHopDong.Name = "txtLoaiHopDong";
            this.txtLoaiHopDong.Size = new System.Drawing.Size(294, 34);
            this.txtLoaiHopDong.TabIndex = 27;
            // 
            // lblLoaiHopDong
            // 
            this.lblLoaiHopDong.AutoSize = true;
            this.lblLoaiHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHopDong.Location = new System.Drawing.Point(692, 98);
            this.lblLoaiHopDong.Name = "lblLoaiHopDong";
            this.lblLoaiHopDong.Size = new System.Drawing.Size(167, 29);
            this.lblLoaiHopDong.TabIndex = 15;
            this.lblLoaiHopDong.Text = "Loại hợp đồng";
            // 
            // dateTimePickerNgayKiKet
            // 
            this.dateTimePickerNgayKiKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayKiKet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayKiKet.Location = new System.Drawing.Point(299, 211);
            this.dateTimePickerNgayKiKet.Name = "dateTimePickerNgayKiKet";
            this.dateTimePickerNgayKiKet.ShowUpDown = true;
            this.dateTimePickerNgayKiKet.Size = new System.Drawing.Size(328, 34);
            this.dateTimePickerNgayKiKet.TabIndex = 37;
            // 
            // dateTimePickerNgayHetHan
            // 
            this.dateTimePickerNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayHetHan.Location = new System.Drawing.Point(299, 270);
            this.dateTimePickerNgayHetHan.Name = "dateTimePickerNgayHetHan";
            this.dateTimePickerNgayHetHan.ShowUpDown = true;
            this.dateTimePickerNgayHetHan.Size = new System.Drawing.Size(328, 34);
            this.dateTimePickerNgayHetHan.TabIndex = 37;
            // 
            // FormQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.dateTimePickerNgayHetHan);
            this.Controls.Add(this.dateTimePickerNgayKiKet);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLoaiHopDong);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.txtThoiHanLamViec);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.lblLoaiHopDong);
            this.Controls.Add(this.lblMaHopDong);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblNgayKiKet);
            this.Controls.Add(this.lblThoiHanLamViec);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.dgvFormQuanLyHopDong);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormQuanLyHopDong";
            this.Text = "FormQuanLyHopDong";
            this.Load += new System.EventHandler(this.FormQuanLyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.TextBox txtThoiHanLamViec;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblNgayKiKet;
        private System.Windows.Forms.Label lblThoiHanLamViec;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dgvFormQuanLyHopDong;
        private System.Windows.Forms.TextBox txtLoaiHopDong;
        private System.Windows.Forms.Label lblLoaiHopDong;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKiKet;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayHetHan;
    }
}