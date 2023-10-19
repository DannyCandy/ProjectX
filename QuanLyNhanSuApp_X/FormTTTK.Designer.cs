namespace QuanLyNhanSuApp
{
    partial class FormTTTK
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
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuyen
            // 
            this.txtQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.Location = new System.Drawing.Point(545, 354);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.ReadOnly = true;
            this.txtQuyen.Size = new System.Drawing.Size(323, 30);
            this.txtQuyen.TabIndex = 5;
            this.txtQuyen.TabStop = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(545, 290);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(323, 30);
            this.txtTenTaiKhoan.TabIndex = 6;
            this.txtTenTaiKhoan.TabStop = false;
            // 
            // lblQuyen
            // 
            this.lblQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(377, 357);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(71, 25);
            this.lblQuyen.TabIndex = 3;
            this.lblQuyen.Text = "Quyền";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(377, 293);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(131, 25);
            this.lblTenTaiKhoan.TabIndex = 4;
            this.lblTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // FormTTTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormTTTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblTenTaiKhoan;
    }
}