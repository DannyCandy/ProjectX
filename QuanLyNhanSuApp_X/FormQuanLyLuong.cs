using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyLuong : Form
    {
        private string fieldValue = string.Empty;
        public FormQuanLyLuong()
        {
            InitializeComponent();
        }

        private void FormQuanLyLuong_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
                
            }
            finally
            {
                ResetTextBox();
            }
        }

        private void ResetTextBox()
        {
            txtMaLuong.Text = string.Empty;
            txtLuongCoBan.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            txtPhuCapChucVu.Text = string.Empty;
            txtNgayNhap.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM bangluongcty";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyLuong.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyLuong.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaLuong.Text == string.Empty)
            {
                txtMaLuong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaLuong.BackColor = SystemColors.Window;
            }
            if (txtChucVu.Text == string.Empty)
            {
                txtChucVu.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtChucVu.BackColor = SystemColors.Window;
            }
            if (txtLuongCoBan.Text == string.Empty)
            {
                txtLuongCoBan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtLuongCoBan.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private void SetDefault()
        {
            if (txtPhuCapChucVu.Text == string.Empty)
            {
                txtPhuCapChucVu.Text = 0.ToString();
            }
            txtNgayNhap.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhuCapChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetDefault();

            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                 try
                    {
                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`bangluongcty` (`maLuong`, `luongCoBan`, `ngayNhap`, `ghiChu`, `chucVu`, `phuCapChucVu`) " +
                        "VALUES ('"+txtMaLuong.Text+"', '"+txtLuongCoBan.Text+"', '"+txtNgayNhap.Text+"', '"+txtGhiChu.Text+"', '"+txtChucVu.Text+"', '"+txtPhuCapChucVu.Text+"');";
                        dataAccess.InsertData(query);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                 catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");
                    }
               
            }

            if (fieldValue.Equals(string.Empty))
            {
                BindToDataGridView();
            }
            else
            {
                BindToDataGridView(fieldValue);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLuong.Text == String.Empty)
            {
                txtMaLuong.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã lương", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaLuong.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`bangluongcty` WHERE(`maLuong` = '" + txtMaLuong.Text + "')";
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

            if (fieldValue.Equals(string.Empty))
            {
                BindToDataGridView();
            }
            else
            {
                BindToDataGridView(fieldValue);
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
                        string query = "UPDATE `employeems`.`bangluongcty` SET `maLuong` = '"+txtMaLuong.Text+"', `luongCoBan` = '"+txtLuongCoBan.Text+"'," +
                        " `ghiChu` = '"+txtGhiChu.Text+"', `chucVu` = '"+txtChucVu.Text+"', `phuCapChucVu` = '"+txtPhuCapChucVu.Text+"' WHERE (`maLuong` = '"+txtMaLuong.Text+"');";
                        dataAccess.UpdateData(query);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        BindToDataGridView();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");

                    }
            }

            if (fieldValue.Equals(string.Empty))
            {
                BindToDataGridView();
            }
            else
            {
                BindToDataGridView(fieldValue);
            }

        }

        private void dgvFormQuanLyLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyLuong.Rows.Count > 0)
            {
                txtMaLuong.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[0].Value.ToString();
                txtLuongCoBan.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[1].Value.ToString();
                txtNgayNhap.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[2].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[3].Value.ToString();
                txtChucVu.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[4].Value.ToString();
                txtPhuCapChucVu.Text = dgvFormQuanLyLuong.SelectedRows[0].Cells[5].Value.ToString();
                
            }
        }
        //Chuc nang tra cuu
        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM bangluongcty WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyLuong.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyLuong.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='bangluongcty'";
            FormSearching fsearch = new FormSearching(query,4);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }
    }
}

