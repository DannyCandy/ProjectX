namespace QuanLyNhanSuApp
{
    partial class FormQuanLyNhanSu_RoiDi
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
            this.dateTimePickerNgayRoi = new System.Windows.Forms.DateTimePicker();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblNgayRoi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.dgvFormQuanLyNVRoiTC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyNVRoiTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerNgayRoi
            // 
            this.dateTimePickerNgayRoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayRoi.Location = new System.Drawing.Point(243, 186);
            this.dateTimePickerNgayRoi.Name = "dateTimePickerNgayRoi";
            this.dateTimePickerNgayRoi.Size = new System.Drawing.Size(328, 34);
            this.dateTimePickerNgayRoi.TabIndex = 55;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(852, 310);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(168, 43);
            this.btnTraCuu.TabIndex = 54;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(637, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 43);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(422, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 43);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(207, 310);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 43);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(806, 183);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(309, 34);
            this.txtMaPhong.TabIndex = 49;
            this.txtMaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPhong_KeyPress);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(806, 65);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(309, 93);
            this.txtLyDo.TabIndex = 48;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(243, 124);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(329, 34);
            this.txtHoTen.TabIndex = 46;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(666, 188);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(120, 29);
            this.lblMaPhong.TabIndex = 42;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyDo.Location = new System.Drawing.Point(666, 70);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(71, 29);
            this.lblLyDo.TabIndex = 41;
            this.lblLyDo.Text = "Lý do";
            // 
            // lblNgayRoi
            // 
            this.lblNgayRoi.AutoSize = true;
            this.lblNgayRoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayRoi.Location = new System.Drawing.Point(112, 186);
            this.lblNgayRoi.Name = "lblNgayRoi";
            this.lblNgayRoi.Size = new System.Drawing.Size(103, 29);
            this.lblNgayRoi.TabIndex = 39;
            this.lblNgayRoi.Text = "Ngày rời";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(112, 127);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 29);
            this.lblHoTen.TabIndex = 38;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(243, 65);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(329, 34);
            this.txtCMND.TabIndex = 45;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(112, 68);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(85, 29);
            this.lblCMND.TabIndex = 44;
            this.lblCMND.Text = "CMND";
            // 
            // dgvFormQuanLyNVRoiTC
            // 
            this.dgvFormQuanLyNVRoiTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormQuanLyNVRoiTC.Location = new System.Drawing.Point(23, 375);
            this.dgvFormQuanLyNVRoiTC.Name = "dgvFormQuanLyNVRoiTC";
            this.dgvFormQuanLyNVRoiTC.ReadOnly = true;
            this.dgvFormQuanLyNVRoiTC.RowHeadersWidth = 51;
            this.dgvFormQuanLyNVRoiTC.RowTemplate.Height = 24;
            this.dgvFormQuanLyNVRoiTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormQuanLyNVRoiTC.Size = new System.Drawing.Size(1180, 182);
            this.dgvFormQuanLyNVRoiTC.TabIndex = 37;
            this.dgvFormQuanLyNVRoiTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormQuanLyNVRoiTC_CellClick);
            // 
            // FormQuanLyNhanSu_RoiDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 595);
            this.Controls.Add(this.dateTimePickerNgayRoi);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblLyDo);
            this.Controls.Add(this.lblNgayRoi);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.dgvFormQuanLyNVRoiTC);
            this.Location = new System.Drawing.Point(0, 33);
            this.Name = "FormQuanLyNhanSu_RoiDi";
            this.Text = "FormQuanLyNhanSu_RoiDi";
            this.Load += new System.EventHandler(this.FormQuanLyNhanSu_RoiDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyNVRoiTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNgayRoi;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblNgayRoi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.DataGridView dgvFormQuanLyNVRoiTC;
    }
}