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
            this.btnTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyDonVi_PhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBoPhan.Location = new System.Drawing.Point(856, 27);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(297, 34);
            this.txtMaBoPhan.TabIndex = 50;
            this.txtMaBoPhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaBoPhan_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(265, 145);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(284, 151);
            this.txtGhiChu.TabIndex = 49;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(265, 86);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(284, 34);
            this.txtTenPhong.TabIndex = 48;
            // 
            // lblMaBoPhan
            // 
            this.lblMaBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblNgayThanhLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblTenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(265, 27);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(284, 34);
            this.txtMaPhong.TabIndex = 47;
            this.txtMaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPhong_KeyPress);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvFormQuanLyDonVi_PhongBan.AllowUserToAddRows = false;
            this.dgvFormQuanLyDonVi_PhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormQuanLyDonVi_PhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dateTimePickerNgayThanhLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayThanhLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayThanhLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayThanhLap.Location = new System.Drawing.Point(856, 84);
            this.dateTimePickerNgayThanhLap.Name = "dateTimePickerNgayThanhLap";
            this.dateTimePickerNgayThanhLap.Size = new System.Drawing.Size(296, 34);
            this.dateTimePickerNgayThanhLap.TabIndex = 57;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(875, 326);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTraCuu.OverrideDefault.Back.ColorAngle = 45F;
            this.btnTraCuu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTraCuu.OverrideDefault.Border.ColorAngle = 45F;
            this.btnTraCuu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTraCuu.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTraCuu.OverrideDefault.Border.Rounding = 18;
            this.btnTraCuu.OverrideDefault.Border.Width = 1;
            this.btnTraCuu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTraCuu.Size = new System.Drawing.Size(172, 57);
            this.btnTraCuu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateCommon.Back.ColorAngle = 45F;
            this.btnTraCuu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTraCuu.StateCommon.Border.ColorAngle = 45F;
            this.btnTraCuu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTraCuu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTraCuu.StateCommon.Border.Rounding = 18;
            this.btnTraCuu.StateCommon.Border.Width = 1;
            this.btnTraCuu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTraCuu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTraCuu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnTraCuu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnTraCuu.StatePressed.Back.ColorAngle = 130F;
            this.btnTraCuu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnTraCuu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnTraCuu.StatePressed.Border.ColorAngle = 130F;
            this.btnTraCuu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTraCuu.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateTracking.Back.ColorAngle = 45F;
            this.btnTraCuu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnTraCuu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTraCuu.StateTracking.Border.ColorAngle = 45F;
            this.btnTraCuu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTraCuu.StateTracking.Border.Rounding = 18;
            this.btnTraCuu.StateTracking.Border.Width = 1;
            this.btnTraCuu.TabIndex = 80;
            this.btnTraCuu.Values.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(643, 324);
            this.btnSua.Name = "btnSua";
            this.btnSua.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(221)))));
            this.btnSua.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(221)))));
            this.btnSua.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.OverrideDefault.Border.Rounding = 18;
            this.btnSua.OverrideDefault.Border.Width = 1;
            this.btnSua.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSua.Size = new System.Drawing.Size(172, 57);
            this.btnSua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateCommon.Back.ColorAngle = 45F;
            this.btnSua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(221)))));
            this.btnSua.StateCommon.Border.ColorAngle = 45F;
            this.btnSua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.StateCommon.Border.Rounding = 18;
            this.btnSua.StateCommon.Border.Width = 1;
            this.btnSua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.btnSua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(141)))));
            this.btnSua.StatePressed.Back.ColorAngle = 130F;
            this.btnSua.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.btnSua.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(141)))));
            this.btnSua.StatePressed.Border.ColorAngle = 130F;
            this.btnSua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateTracking.Back.ColorAngle = 45F;
            this.btnSua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnSua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(221)))));
            this.btnSua.StateTracking.Border.ColorAngle = 45F;
            this.btnSua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Border.Rounding = 18;
            this.btnSua.StateTracking.Border.Width = 1;
            this.btnSua.TabIndex = 79;
            this.btnSua.Values.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(411, 324);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnXoa.OverrideDefault.Back.ColorAngle = 45F;
            this.btnXoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnXoa.OverrideDefault.Border.ColorAngle = 45F;
            this.btnXoa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.OverrideDefault.Border.Rounding = 18;
            this.btnXoa.OverrideDefault.Border.Width = 1;
            this.btnXoa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXoa.Size = new System.Drawing.Size(172, 57);
            this.btnXoa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateCommon.Back.ColorAngle = 45F;
            this.btnXoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnXoa.StateCommon.Border.ColorAngle = 45F;
            this.btnXoa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StateCommon.Border.Rounding = 18;
            this.btnXoa.StateCommon.Border.Width = 1;
            this.btnXoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(12)))), ((int)(((byte)(159)))));
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(11)))), ((int)(((byte)(146)))));
            this.btnXoa.StatePressed.Back.ColorAngle = 130F;
            this.btnXoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(12)))), ((int)(((byte)(159)))));
            this.btnXoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(11)))), ((int)(((byte)(146)))));
            this.btnXoa.StatePressed.Border.ColorAngle = 130F;
            this.btnXoa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateTracking.Back.ColorAngle = 45F;
            this.btnXoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnXoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnXoa.StateTracking.Border.ColorAngle = 45F;
            this.btnXoa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Border.Rounding = 18;
            this.btnXoa.StateTracking.Border.Width = 1;
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnThem.OverrideDefault.Back.ColorAngle = 45F;
            this.btnThem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnThem.OverrideDefault.Border.ColorAngle = 45F;
            this.btnThem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThem.OverrideDefault.Border.Rounding = 18;
            this.btnThem.OverrideDefault.Border.Width = 1;
            this.btnThem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnThem.Size = new System.Drawing.Size(172, 57);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateCommon.Back.ColorAngle = 45F;
            this.btnThem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnThem.StateCommon.Border.ColorAngle = 45F;
            this.btnThem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThem.StateCommon.Border.Rounding = 18;
            this.btnThem.StateCommon.Border.Width = 1;
            this.btnThem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.btnThem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.btnThem.StatePressed.Back.ColorAngle = 130F;
            this.btnThem.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.btnThem.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.btnThem.StatePressed.Border.ColorAngle = 130F;
            this.btnThem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateTracking.Back.ColorAngle = 45F;
            this.btnThem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnThem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnThem.StateTracking.Border.ColorAngle = 45F;
            this.btnThem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Border.Rounding = 18;
            this.btnThem.StateTracking.Border.Width = 1;
            this.btnThem.TabIndex = 77;
            this.btnThem.Values.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQuanLyDonVi_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 595);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateTimePickerNgayThanhLap);
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
            this.Name = "FormQuanLyDonVi_PhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phòng ban";
            this.Load += new System.EventHandler(this.QuanLyDonVi_PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyDonVi_PhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTraCuu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
    }
}