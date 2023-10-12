using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRepeatPass.Text == string.Empty || txtNewPass.Text == string.Empty)
                {
                    
                    MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo");
                }
                else if(txtRepeatPass.Text != txtNewPass.Text)
                {

                    MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
                }
                else
                {
                    DataAccess dataAccess = new DataAccess();
                    string query = "UPDATE `employeems`.`user` SET `pass` = '" + txtNewPass.Text + "' WHERE (`idUser` = '" + FormTTTK.idUser + "');";
                    dataAccess.UpdateData(query);
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật mật khẩu! Lỗi: "+ex, "Thông báo");
            }
            
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtNewPass.Text = string.Empty;
            txtRepeatPass.Text = string.Empty;
            txtNewPass.Focus();
        }
    }
}
