namespace QuanLyNhanSuApp
{
    partial class FormSearching
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtGiaTriTK = new System.Windows.Forms.TextBox();
            this.lblValueSearch = new System.Windows.Forms.Label();
            this.cbbTruongTimKiem = new System.Windows.Forms.ComboBox();
            this.lblFieldSearch = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(146, 241);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(202, 48);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtGiaTriTK
            // 
            this.txtGiaTriTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriTK.Location = new System.Drawing.Point(294, 31);
            this.txtGiaTriTK.Name = "txtGiaTriTK";
            this.txtGiaTriTK.Size = new System.Drawing.Size(352, 34);
            this.txtGiaTriTK.TabIndex = 1;
            // 
            // lblValueSearch
            // 
            this.lblValueSearch.AutoSize = true;
            this.lblValueSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSearch.Location = new System.Drawing.Point(86, 36);
            this.lblValueSearch.Name = "lblValueSearch";
            this.lblValueSearch.Size = new System.Drawing.Size(172, 29);
            this.lblValueSearch.TabIndex = 2;
            this.lblValueSearch.Text = "Giá trị tìm kiếm";
            // 
            // cbbTruongTimKiem
            // 
            this.cbbTruongTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTruongTimKiem.FormattingEnabled = true;
            this.cbbTruongTimKiem.Location = new System.Drawing.Point(294, 78);
            this.cbbTruongTimKiem.Name = "cbbTruongTimKiem";
            this.cbbTruongTimKiem.Size = new System.Drawing.Size(351, 37);
            this.cbbTruongTimKiem.TabIndex = 3;
            this.cbbTruongTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTruongTimKiem_SelectedIndexChanged);
            // 
            // lblFieldSearch
            // 
            this.lblFieldSearch.AutoSize = true;
            this.lblFieldSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldSearch.Location = new System.Drawing.Point(86, 84);
            this.lblFieldSearch.Name = "lblFieldSearch";
            this.lblFieldSearch.Size = new System.Drawing.Size(187, 29);
            this.lblFieldSearch.TabIndex = 2;
            this.lblFieldSearch.Text = "Trường tìm kiếm";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(385, 241);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(202, 48);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(86, 132);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(99, 29);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Từ ngày";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(86, 180);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(114, 29);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Đến ngày";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(294, 128);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(351, 34);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(294, 175);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(351, 34);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // FormSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 313);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.cbbTruongTimKiem);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblFieldSearch);
            this.Controls.Add(this.lblValueSearch);
            this.Controls.Add(this.txtGiaTriTK);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "FormSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSearching";
            this.Load += new System.EventHandler(this.FormSearching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtGiaTriTK;
        private System.Windows.Forms.Label lblValueSearch;
        private System.Windows.Forms.ComboBox cbbTruongTimKiem;
        private System.Windows.Forms.Label lblFieldSearch;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}