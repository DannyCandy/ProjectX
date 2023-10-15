namespace QuanLyNhanSuApp
{
    partial class FormSearching_LichLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearching_LichLamViec));
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.cbbTruongTimKiem = new System.Windows.Forms.ComboBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFieldSearch = new System.Windows.Forms.Label();
            this.lblValueSearch = new System.Windows.Forms.Label();
            this.txtGiaTriTK = new System.Windows.Forms.TextBox();
            this.btnHuy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXacNhan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(307, 171);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(351, 34);
            this.dateTimePickerEnd.TabIndex = 13;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(307, 124);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(351, 34);
            this.dateTimePickerStart.TabIndex = 14;
            // 
            // cbbTruongTimKiem
            // 
            this.cbbTruongTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTruongTimKiem.FormattingEnabled = true;
            this.cbbTruongTimKiem.Location = new System.Drawing.Point(307, 74);
            this.cbbTruongTimKiem.Name = "cbbTruongTimKiem";
            this.cbbTruongTimKiem.Size = new System.Drawing.Size(351, 37);
            this.cbbTruongTimKiem.TabIndex = 12;
            this.cbbTruongTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTruongTimKiem_SelectedIndexChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(73, 176);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(202, 29);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "Thời gian kết thúc";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(73, 128);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(199, 29);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Thời gian bắt đầu";
            // 
            // lblFieldSearch
            // 
            this.lblFieldSearch.AutoSize = true;
            this.lblFieldSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldSearch.Location = new System.Drawing.Point(73, 80);
            this.lblFieldSearch.Name = "lblFieldSearch";
            this.lblFieldSearch.Size = new System.Drawing.Size(187, 29);
            this.lblFieldSearch.TabIndex = 10;
            this.lblFieldSearch.Text = "Trường tìm kiếm";
            // 
            // lblValueSearch
            // 
            this.lblValueSearch.AutoSize = true;
            this.lblValueSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSearch.Location = new System.Drawing.Point(73, 32);
            this.lblValueSearch.Name = "lblValueSearch";
            this.lblValueSearch.Size = new System.Drawing.Size(172, 29);
            this.lblValueSearch.TabIndex = 11;
            this.lblValueSearch.Text = "Giá trị tìm kiếm";
            // 
            // txtGiaTriTK
            // 
            this.txtGiaTriTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriTK.Location = new System.Drawing.Point(307, 27);
            this.txtGiaTriTK.Name = "txtGiaTriTK";
            this.txtGiaTriTK.Size = new System.Drawing.Size(352, 34);
            this.txtGiaTriTK.TabIndex = 7;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(405, 231);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnHuy.OverrideDefault.Back.ColorAngle = 45F;
            this.btnHuy.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnHuy.OverrideDefault.Border.ColorAngle = 45F;
            this.btnHuy.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuy.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHuy.OverrideDefault.Border.Rounding = 18;
            this.btnHuy.OverrideDefault.Border.Width = 1;
            this.btnHuy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHuy.Size = new System.Drawing.Size(172, 57);
            this.btnHuy.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateCommon.Back.ColorAngle = 45F;
            this.btnHuy.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnHuy.StateCommon.Border.ColorAngle = 45F;
            this.btnHuy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuy.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHuy.StateCommon.Border.Rounding = 18;
            this.btnHuy.StateCommon.Border.Width = 1;
            this.btnHuy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHuy.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHuy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(12)))), ((int)(((byte)(159)))));
            this.btnHuy.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(11)))), ((int)(((byte)(146)))));
            this.btnHuy.StatePressed.Back.ColorAngle = 130F;
            this.btnHuy.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(12)))), ((int)(((byte)(159)))));
            this.btnHuy.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(11)))), ((int)(((byte)(146)))));
            this.btnHuy.StatePressed.Border.ColorAngle = 130F;
            this.btnHuy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuy.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateTracking.Back.ColorAngle = 45F;
            this.btnHuy.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(12)))), ((int)(((byte)(129)))));
            this.btnHuy.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(147)))));
            this.btnHuy.StateTracking.Border.ColorAngle = 45F;
            this.btnHuy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuy.StateTracking.Border.Rounding = 18;
            this.btnHuy.StateTracking.Border.Width = 1;
            this.btnHuy.TabIndex = 88;
            this.btnHuy.Values.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(155, 231);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnXacNhan.OverrideDefault.Back.ColorAngle = 45F;
            this.btnXacNhan.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnXacNhan.OverrideDefault.Border.ColorAngle = 45F;
            this.btnXacNhan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXacNhan.OverrideDefault.Border.Rounding = 18;
            this.btnXacNhan.OverrideDefault.Border.Width = 1;
            this.btnXacNhan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXacNhan.Size = new System.Drawing.Size(172, 57);
            this.btnXacNhan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateCommon.Back.ColorAngle = 45F;
            this.btnXacNhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnXacNhan.StateCommon.Border.ColorAngle = 45F;
            this.btnXacNhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXacNhan.StateCommon.Border.Rounding = 18;
            this.btnXacNhan.StateCommon.Border.Width = 1;
            this.btnXacNhan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXacNhan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.btnXacNhan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.btnXacNhan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.btnXacNhan.StatePressed.Back.ColorAngle = 130F;
            this.btnXacNhan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.btnXacNhan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.btnXacNhan.StatePressed.Border.ColorAngle = 130F;
            this.btnXacNhan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateTracking.Back.ColorAngle = 45F;
            this.btnXacNhan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.btnXacNhan.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.btnXacNhan.StateTracking.Border.ColorAngle = 45F;
            this.btnXacNhan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StateTracking.Border.Rounding = 18;
            this.btnXacNhan.StateTracking.Border.Width = 1;
            this.btnXacNhan.TabIndex = 87;
            this.btnXacNhan.Values.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormSearching_LichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 313);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.cbbTruongTimKiem);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblFieldSearch);
            this.Controls.Add(this.lblValueSearch);
            this.Controls.Add(this.txtGiaTriTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearching_LichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu";
            this.Load += new System.EventHandler(this.FormSearching_LichLamViec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox cbbTruongTimKiem;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFieldSearch;
        private System.Windows.Forms.Label lblValueSearch;
        private System.Windows.Forms.TextBox txtGiaTriTK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHuy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXacNhan;
    }
}