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
            this.btnTraCuu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(885, 93);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(229, 34);
            this.txtMaNhanVien.TabIndex = 27;
            this.txtMaNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhanVien_KeyPress);
            // 
            // txtCaLamViec
            // 
            this.txtCaLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaLamViec.Location = new System.Drawing.Point(885, 34);
            this.txtCaLamViec.Name = "txtCaLamViec";
            this.txtCaLamViec.Size = new System.Drawing.Size(229, 34);
            this.txtCaLamViec.TabIndex = 26;
            this.txtCaLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaLamViec_KeyPress);
            // 
            // txtNam
            // 
            this.txtNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(348, 331);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(292, 34);
            this.txtNam.TabIndex = 25;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // txtThang
            // 
            this.txtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(348, 272);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(292, 34);
            this.txtThang.TabIndex = 31;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtNgayLamViec
            // 
            this.txtNgayLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLamViec.Location = new System.Drawing.Point(348, 95);
            this.txtNgayLamViec.Name = "txtNgayLamViec";
            this.txtNgayLamViec.Size = new System.Drawing.Size(292, 34);
            this.txtNgayLamViec.TabIndex = 22;
            this.txtNgayLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayLamViec_KeyPress);
            // 
            // lblMaNV
            // 
            this.lblMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblCaLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblGioRa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblGioVao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblNgayLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtMaLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLichLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichLamViec.Location = new System.Drawing.Point(348, 36);
            this.txtMaLichLamViec.Name = "txtMaLichLamViec";
            this.txtMaLichLamViec.Size = new System.Drawing.Size(292, 34);
            this.txtMaLichLamViec.TabIndex = 21;
            this.txtMaLichLamViec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLichLamViec_KeyPress);
            // 
            // lblMaLichLamViec
            // 
            this.lblMaLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvFormQuanLyLichLamViec.AllowUserToAddRows = false;
            this.dgvFormQuanLyLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormQuanLyLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dateTimePickerGioVao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dateTimePickerGioRa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerGioRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGioRa.Location = new System.Drawing.Point(348, 211);
            this.dateTimePickerGioRa.Name = "dateTimePickerGioRa";
            this.dateTimePickerGioRa.ShowUpDown = true;
            this.dateTimePickerGioRa.Size = new System.Drawing.Size(292, 34);
            this.dateTimePickerGioRa.TabIndex = 36;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(884, 386);
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
            this.btnTraCuu.TabIndex = 84;
            this.btnTraCuu.Values.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(652, 384);
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
            this.btnSua.TabIndex = 83;
            this.btnSua.Values.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(420, 384);
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
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(188, 384);
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
            this.btnThem.TabIndex = 81;
            this.btnThem.Values.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQuanLyLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateTimePickerGioRa);
            this.Controls.Add(this.dateTimePickerGioVao);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý lịch làm việc";
            this.Load += new System.EventHandler(this.FormQuanLyLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormQuanLyLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTraCuu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
    }
}