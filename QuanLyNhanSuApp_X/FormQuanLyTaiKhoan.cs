using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        private string primary = string.Empty;
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();
                BindToCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
            }
            finally
            {
                ResetTextBox();
            }
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM employeems.user";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTaiKhoan.DataSource = dataTable;
            }

        }

        private void BindToCombobox()
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                string query = "SELECT maQuyen,tenQuyen FROM quyen";
                cbbMaQuyen.DataSource = dataAccess.GetData(query);
                cbbMaQuyen.DisplayMember = "tenQuyen"; // Cột hiển thị
                cbbMaQuyen.ValueMember = "maQuyen"; // Cột giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Combobox. Error: " + ex.Message);
            }
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtIDUser.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            cbbMaQuyen.SelectedIndex = -1;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void dgvFormQuanLyTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyTaiKhoan.Rows.Count > 0)
            {
                txtUsername.Text = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
                txtPassword.Text = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[1].Value.ToString();
                txtHoTen.Text = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[2].Value.ToString();

                
                string selectedValue = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
                cbbMaQuyen.SelectedItem = cbbMaQuyen.Items.Cast<DataRowView>().FirstOrDefault(item => item["maQuyen"].ToString() == selectedValue);
                
                txtIDUser.Text = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[4].Value.ToString();
                txtMaNV.Text = dgvFormQuanLyTaiKhoan.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void setDefault()
        {

            if (cbbMaQuyen.SelectedIndex == -1)
            {
                cbbMaQuyen.SelectedIndex = 1;
            }
            
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaNV.Text == string.Empty)
            {
                txtMaNV.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaNV.BackColor = SystemColors.Window;
            }
            if (txtHoTen.Text == string.Empty)
            {
                txtHoTen.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtHoTen.BackColor = SystemColors.Window;
            }
            if (txtIDUser.Text == string.Empty)
            {
                txtIDUser.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtIDUser.BackColor = SystemColors.Window;
            }
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtUsername.BackColor = SystemColors.Window;
            }
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtPassword.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setDefault();

            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                
                    try
                    {
                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`user` (`userName`, `pass`, `hoTen`, `maQuyen`, `idUser`, `maNV`) " +
                        "VALUES ('"+txtUsername.Text+"', '"+txtPassword.Text+"', '"+txtHoTen.Text+"', '"+cbbMaQuyen.SelectedValue.ToString()+"', '"+txtIDUser.Text+"', '"+txtMaNV.Text+"');";
                        dataAccess.InsertData(query);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        BindToDataGridView();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");

                    }
                
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDUser.Text == String.Empty)
            {
                txtMaNV.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường ID User", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaNV.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`user` WHERE(`maNV` = '" + txtIDUser.Text + "')";
                    dataAccess.DeleteData(query);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    BindToDataGridView();
                    ResetTextBox();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex, "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                
                    try
                    {
                        DataAccess dataAccess = new DataAccess();
                        
                        string query = "UPDATE `employeems`.`user` SET `userName` = '"+txtUsername.Text+"', `pass` = '"+txtPassword.Text+"', `hoTen` = '"+txtHoTen.Text+"', `maQuyen` = '"+cbbMaQuyen.SelectedValue.ToString()+"', `idUser` = '"+txtIDUser.Text+"', `maNV` = '"+txtMaNV.Text+"' WHERE (`idUser` = '"+txtIDUser.Text+"');";
                        dataAccess.UpdateData(query);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        Console.WriteLine(query);
                        BindToDataGridView();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");

                    }
                
            }
        }

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM user WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTaiKhoan.DataSource = dataTable;
            }
        }
        private void FormSearchClosed(object sender, FormClosedEventArgs e)
        {
            FormSearching fsearch = sender as FormSearching;
            if (fsearch != null)
            {
                fieldValue = fsearch.ResultSearching();
            }

            if (fieldValue.Equals(string.Empty))
            {
                BindToDataGridView();
            }
            else
            {
                Console.WriteLine(fieldValue.ToString());
                BindToDataGridView(fieldValue);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string query = "SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS` " +
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='user'";
            FormSearching fsearch = new FormSearching(query);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }
    }
}
