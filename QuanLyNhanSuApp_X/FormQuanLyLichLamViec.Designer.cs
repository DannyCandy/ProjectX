namespace QuanLyNhanSuApp
{
    partial class FormQuanLyLichLamViec
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
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtCaLamViec = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNgayLamViec = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblCaLamViec = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblGioRa = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblNgayLamViec = new System.Windows.Forms.Label();
            this.txtMaLichLamViec = new System.Windows.Forms.TextBox();
            this.lblMaLichLamViec = new System.Windows.Forms.Label();
            this.dgvFormQuanLyLichLamViec = new System.Windows.Forms.DataGridView();
            this.dateTimePickerGioVao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGioRa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLichLamViec)).BeginInit();
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
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(885, 93);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(229, 34);
            this.txtMaNhanVien.TabIndex = 27;
            // 
            // txtCaLamViec
            // 
            this.txtCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaLamViec.Location = new System.Drawing.Point(885, 34);
            this.txtCaLamViec.Name = "txtCaLamViec";
            this.txtCaLamViec.Size = new System.Drawing.Size(229, 34);
            this.txtCaLamViec.TabIndex = 26;
            this.txtCaLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaLamViec_KeyPress);
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(348, 331);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(292, 34);
            this.txtNam.TabIndex = 25;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(348, 272);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(292, 34);
            this.txtThang.TabIndex = 31;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtNgayLamViec
            // 
            this.txtNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.Location = new System.Drawing.Point(348, 95);
            this.txtNgayLamViec.Name = "txtNgayLamViec";
            this.txtNgayLamViec.Size = new System.Drawing.Size(292, 34);
            this.txtNgayLamViec.TabIndex = 22;
            this.txtNgayLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayLamViec_KeyPress);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(666, 98);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(154, 29);
            this.lblMaNV.TabIndex = 15;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblCaLamViec
            // 
            this.lblCaLamViec.AutoSize = true;
            this.lblCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaLamViec.Location = new System.Drawing.Point(666, 39);
            this.lblCaLamViec.Name = "lblCaLamViec";
            this.lblCaLamViec.Size = new System.Drawing.Size(137, 29);
            this.lblCaLamViec.TabIndex = 14;
            this.lblCaLamViec.Text = "Ca làm việc";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(130, 334);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(64, 29);
            this.lblNam.TabIndex = 13;
            this.lblNam.Text = "Năm";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(130, 275);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(82, 29);
            this.lblThang.TabIndex = 12;
            this.lblThang.Text = "Tháng";
            // 
            // lblGioRa
            // 
            this.lblGioRa.AutoSize = true;
            this.lblGioRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioRa.Location = new System.Drawing.Point(130, 216);
            this.lblGioRa.Name = "lblGioRa";
            this.lblGioRa.Size = new System.Drawing.Size(78, 29);
            this.lblGioRa.TabIndex = 11;
            this.lblGioRa.Text = "Giờ ra";
            // 
            // lblGioVao
            // 
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioVao.Location = new System.Drawing.Point(130, 157);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(95, 29);
            this.lblGioVao.TabIndex = 10;
            this.lblGioVao.Text = "Giờ vào";
            // 
            // lblNgayLamViec
            // 
            this.lblNgayLamViec.AutoSize = true;
            this.lblNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLamViec.Location = new System.Drawing.Point(130, 98);
            this.lblNgayLamViec.Name = "lblNgayLamViec";
            this.lblNgayLamViec.Size = new System.Drawing.Size(163, 29);
            this.lblNgayLamViec.TabIndex = 9;
            this.lblNgayLamViec.Text = "Ngày làm việc";
            // 
            // txtMaLichLamViec
            // 
            this.txtMaLichLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichLamViec.Location = new System.Drawing.Point(348, 36);
            this.txtMaLichLamViec.Name = "txtMaLichLamViec";
            this.txtMaLichLamViec.Size = new System.Drawing.Size(292, 34);
            this.txtMaLichLamViec.TabIndex = 21;
            // 
            // lblMaLichLamViec
            // 
            this.lblMaLichLamViec.AutoSize = true;
            this.lblMaLichLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLichLamViec.Location = new System.Drawing.Point(130, 39);
            this.lblMaLichLamViec.Name = "lblMaLichLamViec";
            this.lblMaLichLamViec.Size = new System.Drawing.Size(190, 29);
            this.lblMaLichLamViec.TabIndex = 19;
            this.lblMaLichLamViec.Text = "Mã Lịch làm việc";
            // 
            // dgvFormQuanLyLichLamViec
            // 
            this.dgvFormQuanLyLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyLichLamViec.Location = new System.Drawing.Point(32, 459);
            this.dgvFormQuanLyLichLamViec.Name = "dgvFormQuanLyLichLamViec";
            this.dgvFormQuanLyLichLamViec.ReadOnly = true;
            this.dgvFormQuanLyLichLamViec.RowHeadersWidth = 51;
            this.dgvFormQuanLyLichLamViec.RowTemplate.Height = 24;
            this.dgvFormQuanLyLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyLichLamViec.Size = new System.Drawing.Size(1180, 182);
            this.dgvFormQuanLyLichLamViec.TabIndex = 8;
            this.dgvFormQuanLyLichLamViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyLichLamViec_CellClick);
            // 
            // dateTimePickerGioVao
            // 
            this.dateTimePickerGioVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGioVao.Location = new System.Drawing.Point(348, 159);
            this.dateTimePickerGioVao.Name = "dateTimePickerGioVao";
            this.dateTimePickerGioVao.ShowUpDown = true;
            this.dateTimePickerGioVao.Size = new System.Drawing.Size(292, 34);
            this.dateTimePickerGioVao.TabIndex = 36;
            // 
            // dateTimePickerGioRa
            // 
            this.dateTimePickerGioRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGioRa.Location = new System.Drawing.Point(348, 211);
            this.dateTimePickerGioRa.Name = "dateTimePickerGioRa";
            this.dateTimePickerGioRa.ShowUpDown = true;
            this.dateTimePickerGioRa.Size = new System.Drawing.Size(292, 34);
            this.dateTimePickerGioRa.TabIndex = 36;
            // 
            // FormQuanLyLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.dateTimePickerGioRa);
            this.Controls.Add(this.dateTimePickerGioVao);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtCaLamViec);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgayLamViec);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblCaLamViec);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblGioRa);
            this.Controls.Add(this.lblGioVao);
            this.Controls.Add(this.lblNgayLamViec);
            this.Controls.Add(this.txtMaLichLamViec);
            this.Controls.Add(this.lblMaLichLamViec);
            this.Controls.Add(this.dgvFormQuanLyLichLamViec);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormQuanLyLichLamViec";
            this.Text = "FormQuanLyLichLamViec";
            this.Load += new System.EventHandler(this.FormQuanLyLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtCaLamViec;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNgayLamViec;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblCaLamViec;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblNgayLamViec;
        private System.Windows.Forms.TextBox txtMaLichLamViec;
        private System.Windows.Forms.Label lblMaLichLamViec;
        private System.Windows.Forms.DataGridView dgvFormQuanLyLichLamViec;
        private System.Windows.Forms.DateTimePicker dateTimePickerGioVao;
        private System.Windows.Forms.DateTimePicker dateTimePickerGioRa;
    }
}