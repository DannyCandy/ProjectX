using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyTaiKhoan : Form
    {
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

        private string isValid()
        {
            string message = string.Empty;
            if (txtUsername.Text.Length > 50)
            {
                message += "Username quá dài\n";
            }
            if (txtHoTen.Text.Length > 10)
            {
                message += "Họ tên quá dài\n";
            }
            if (txtIDUser.Text.Length > 10)
            {
                message += "IDUser chí chứa tối đa 10 ký tự\n";
            }
            if (txtMaNV.Text.Length > 10)
            {
                message += "Mã nhân viên chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtPassword.Text.Length > 20)
            {
                message += "Mật khẩu quá dài\n";
            }
            return message;
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
                if (isValid() == "")
                {
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT idUser FROM user WHERE idUser = '" + txtIDUser.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("IdUser đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            dataAccess = new DataAccess();
                            string query = "INSERT INTO `employeems`.`user` (`userName`, `pass`, `hoTen`, `maQuyen`, `idUser`, `maNV`) " +
                            "VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtHoTen.Text + "', '" + cbbMaQuyen.SelectedValue.ToString() + "', '" + txtIDUser.Text + "', '" + txtMaNV.Text + "');";
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
                else
                {
                    MessageBox.Show(isValid(), "Cảnh báo");
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
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT idUser FROM user WHERE idUser = '" + txtIDUser.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("IdUser không tồn tại!", "Cảnh báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            txtMaNV.BackColor = SystemColors.Window;
                            dataAccess = new DataAccess();
                            string query = "DELETE FROM `employeems`.`user` WHERE(`idUser` = '" + txtIDUser.Text + "')";
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
                if (isValid() == "")
                {
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT idUser FROM user WHERE idUser = '" + txtIDUser.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("IdUser không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                dataAccess = new DataAccess();

                                string query = "UPDATE `employeems`.`user` SET `userName` = '" + txtUsername.Text + "', `pass` = '" + txtPassword.Text + "', `hoTen` = '" + txtHoTen.Text + "', `maQuyen` = '" + cbbMaQuyen.SelectedValue.ToString() + "', `idUser` = '" + txtIDUser.Text + "', `maNV` = '" + txtMaNV.Text + "' WHERE (`idUser` = '" + txtIDUser.Text + "');";
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
                }
                else
                {
                    MessageBox.Show(isValid(), "Cảnh báo");
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='user' AND `COLUMN_NAME` <> 'pass'";
            FormSearching fsearch = new FormSearching(query);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }

        private void txtIDUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }
    }
}
