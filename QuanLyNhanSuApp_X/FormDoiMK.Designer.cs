namespace QuanLyNhanSuApp
{
    partial class FormDoiMK
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
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblPasswordOld = new System.Windows.Forms.Label();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(554, 212);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(323, 30);
            this.txtNewPass.TabIndex = 4;
            // 
            // lblPasswordOld
            // 
            this.lblPasswordOld.AutoSize = true;
            this.lblPasswordOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordOld.Location = new System.Drawing.Point(367, 215);
            this.lblPasswordOld.Name = "lblPasswordOld";
            this.lblPasswordOld.Size = new System.Drawing.Size(129, 25);
            this.lblPasswordOld.TabIndex = 3;
            this.lblPasswordOld.Text = "Mật khẩu mới";
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(367, 265);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(168, 25);
            this.lblRepeatPassword.TabIndex = 3;
            this.lblRepeatPassword.Text = "Nhập lại mật khẩu";
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPass.Location = new System.Drawing.Point(554, 262);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(323, 30);
            this.txtRepeatPass.TabIndex = 4;
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(656, 406);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(172, 57);
            this.btnHoanTac.TabIndex = 5;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(420, 406);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(172, 57);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 675);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblPasswordOld);
            this.Location = new System.Drawing.Point(0, 31);
            this.Name = "FormDoiMK";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblPasswordOld;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnXacNhan;
    }
}