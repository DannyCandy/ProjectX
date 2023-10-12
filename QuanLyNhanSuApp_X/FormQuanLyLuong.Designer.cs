namespace QuanLyNhanSuApp
{
    partial class FormQuanLyLuong
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
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtPhuCapChucVu = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblPhuCapChucVu = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.lblMaLuong = new System.Windows.Forms.Label();
            this.dgvFormQuanLyLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLuong)).BeginInit();
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
            // txtNgayNhap
            // 
            this.txtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhap.Location = new System.Drawing.Point(870, 261);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.ReadOnly = true;
            this.txtNgayNhap.Size = new System.Drawing.Size(268, 34);
            this.txtNgayNhap.TabIndex = 27;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(870, 84);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(268, 152);
            this.txtGhiChu.TabIndex = 26;
            // 
            // txtPhuCapChucVu
            // 
            this.txtPhuCapChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuCapChucVu.Location = new System.Drawing.Point(356, 263);
            this.txtPhuCapChucVu.Name = "txtPhuCapChucVu";
            this.txtPhuCapChucVu.Size = new System.Drawing.Size(253, 34);
            this.txtPhuCapChucVu.TabIndex = 24;
            this.txtPhuCapChucVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhuCapChucVu_KeyPress);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(356, 204);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(253, 34);
            this.txtLuongCoBan.TabIndex = 23;
            this.txtLuongCoBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongCoBan_KeyPress);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(356, 145);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(253, 34);
            this.txtChucVu.TabIndex = 22;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(707, 266);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(128, 29);
            this.lblNgayNhap.TabIndex = 15;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(707, 89);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(94, 29);
            this.lblGhiChu.TabIndex = 14;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblPhuCapChucVu
            // 
            this.lblPhuCapChucVu.AutoSize = true;
            this.lblPhuCapChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuCapChucVu.Location = new System.Drawing.Point(106, 266);
            this.lblPhuCapChucVu.Name = "lblPhuCapChucVu";
            this.lblPhuCapChucVu.Size = new System.Drawing.Size(186, 29);
            this.lblPhuCapChucVu.TabIndex = 11;
            this.lblPhuCapChucVu.Text = "Phụ cấp chức vụ";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongCoBan.Location = new System.Drawing.Point(106, 207);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(158, 29);
            this.lblLuongCoBan.TabIndex = 10;
            this.lblLuongCoBan.Text = "Lương cơ bản";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(106, 148);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(98, 29);
            this.lblChucVu.TabIndex = 9;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLuong.Location = new System.Drawing.Point(356, 86);
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.ReadOnly = true;
            this.txtMaLuong.Size = new System.Drawing.Size(253, 34);
            this.txtMaLuong.TabIndex = 21;
            // 
            // lblMaLuong
            // 
            this.lblMaLuong.AutoSize = true;
            this.lblMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLuong.Location = new System.Drawing.Point(106, 89);
            this.lblMaLuong.Name = "lblMaLuong";
            this.lblMaLuong.Size = new System.Drawing.Size(112, 29);
            this.lblMaLuong.TabIndex = 19;
            this.lblMaLuong.Text = "Mã lương";
            // 
            // dgvFormQuanLyLuong
            // 
            this.dgvFormQuanLyLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyLuong.Location = new System.Drawing.Point(32, 459);
            this.dgvFormQuanLyLuong.Name = "dgvFormQuanLyLuong";
            this.dgvFormQuanLyLuong.ReadOnly = true;
            this.dgvFormQuanLyLuong.RowHeadersWidth = 51;
            this.dgvFormQuanLyLuong.RowTemplate.Height = 24;
            this.dgvFormQuanLyLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyLuong.Size = new System.Drawing.Size(1180, 182);
            this.dgvFormQuanLyLuong.TabIndex = 8;
            this.dgvFormQuanLyLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyLuong_CellClick);
            // 
            // FormQuanLyLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtPhuCapChucVu);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblPhuCapChucVu);
            this.Controls.Add(this.lblLuongCoBan);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtMaLuong);
            this.Controls.Add(this.lblMaLuong);
            this.Controls.Add(this.dgvFormQuanLyLuong);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormQuanLyLuong";
            this.Text = "FormQuanLyLuong";
            this.Load += new System.EventHandler(this.FormQuanLyLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtPhuCapChucVu;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblPhuCapChucVu;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.Label lblMaLuong;
        private System.Windows.Forms.DataGridView dgvFormQuanLyLuong;
    }
}