using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSuApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private Connect connector = new Connect();


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = connector.GetConnection();
            try
            {
                string query = "SELECT maQuyen,hoTen,idUser,maNV FROM USER WHERE userName='" + txtUserName.Text + "' and pass ='" + txtPassword.Text+"'";
                connection.Open();
                Console.WriteLine("Connection opened!");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    string valueQuery = reader.GetString(0);
                    if (valueQuery == "mq1")
                    {
                        MessageBox.Show("Đăng nhập vào hệ thống thành công (Quyền Admin) !", "Thông báo !");
                        /*FormGiaoDienChinh.quyen = "ADMIN";*/
                        FormTTTK.nameOfUser = reader.GetString(1);
                        FormTTTK.role = "ADMIN";
                        FormTTTK.idUser = reader.GetString(2);
                        FormTTTK.maNV = reader.GetString(3);
                        this.Hide();
                    }
                    else if(valueQuery == "mq2")
                    {
                        MessageBox.Show("Đăng nhập vào hệ thống thành công (Quyền User) !", "Thông báo !");
                        /*FormGiaoDienChinh.quyen = "USER";*/
                        FormTTTK.nameOfUser = reader.GetString(1);
                        FormTTTK.role = "USER";
                        FormTTTK.idUser = reader.GetString(2);
                        FormTTTK.maNV = reader.GetString(3);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập vào hệ thống thành công (Quyền Manager) !", "Thông báo !");
                        /*FormGiaoDienChinh.quyen = "MANAGER";*/
                        FormTTTK.nameOfUser = reader.GetString(1);
                        FormTTTK.role = "MANAGER";
                        FormTTTK.idUser = reader.GetString(2);
                        FormTTTK.maNV = reader.GetString(3);
                        this.Hide();
                    }
                    FormGiaoDienChinh frmGDC = new FormGiaoDienChinh();
                    frmGDC.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ !", "Thông báo !");
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: "+ex.ToString(), "Lỗi");
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

