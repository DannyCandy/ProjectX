using System;
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
    public partial class FormQuanLyDonVi_PhongBan : Form
    {
        public FormQuanLyDonVi_PhongBan()
        {
            InitializeComponent();
        }


        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM phongban";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyDonVi_PhongBan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyDonVi_PhongBan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void ResetTextBox()
        {
            txtMaPhong.Text = string.Empty;
            txtMaBoPhan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            dateTimePickerNgayThanhLap.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtTenPhong.Text = string.Empty;
        }

        private void QuanLyDonVi_PhongBan_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();

                dateTimePickerNgayThanhLap.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayThanhLap.CustomFormat = "yyyy-MM-dd";
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

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[3].Value.ToString().Equals(string.Empty))
            {
                return true;
            }
            return false;
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaPhong.Text == string.Empty)
            {
                txtMaPhong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaPhong.BackColor = SystemColors.Window;
            }
            if (txtMaBoPhan.Text == string.Empty)
            {
                txtMaBoPhan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaBoPhan.BackColor = SystemColors.Window;
            }
            if (txtTenPhong.Text == string.Empty)
            {
                txtTenPhong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtTenPhong.BackColor = SystemColors.Window;
            }
            return isRequire;
        }
        private string isValid()
        {
            string message = string.Empty;
            if (txtMaBoPhan.Text.Length > 10)
            {
                message += "Mã bộ phận chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtMaPhong.Text.Length > 10)
            {
                message += "Mã phòng chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtGhiChu.Text.Length > 50)
            {
                message += "Ghi chú quá dài\n";
            }
            if (txtTenPhong.Text.Length > 50)
            {
                message += "Tên phòng quá dài\n";
            }
            return message;
        }
        private void btnThem_Click(object sender, EventArgs e)
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
                    DataTable dataTable = dataAccess.GetData("SELECT maPhong FROM phongban WHERE maPhong = '" + txtMaPhong.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");

                            dataAccess = new DataAccess();
                            string query = "INSERT INTO `employeems`.`phongban` (`maPhong`, `maBoPhan`, `tenPhong`, `ngayThanhLap`, `ghiChu`) " +
                            "VALUES ('" + txtMaPhong.Text + "', '" + txtMaBoPhan.Text + "', '" + txtTenPhong.Text + "', '" + timeThanhLapString + "', '" + txtGhiChu.Text + "');";
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

        private void dgvFormQuanLyDonVi_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyDonVi_PhongBan.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyDonVi_PhongBan.SelectedRows[0]))
            {
                txtMaPhong.Text = dgvFormQuanLyDonVi_PhongBan.SelectedRows[0].Cells[0].Value.ToString();

                DateTime parsedDateTimeTroLaiLam;
                string timeTroLaiLamString = dgvFormQuanLyDonVi_PhongBan.SelectedRows[0].Cells[3].Value.ToString();
                DateTime.TryParse(timeTroLaiLamString, out parsedDateTimeTroLaiLam);
                string formattedTroLaiLamString = parsedDateTimeTroLaiLam.ToString("yyyy-MM-dd");
                dateTimePickerNgayThanhLap.Value = DateTime.ParseExact(formattedTroLaiLamString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                txtMaBoPhan.Text = dgvFormQuanLyDonVi_PhongBan.SelectedRows[0].Cells[1].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyDonVi_PhongBan.SelectedRows[0].Cells[4].Value.ToString();

                txtTenPhong.Text = dgvFormQuanLyDonVi_PhongBan.SelectedRows[0].Cells[2].Value.ToString();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == String.Empty)
            {
                txtMaPhong.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã phòng ban", "Thông báo");
            }
            else
            {
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT maPhong FROM phongban WHERE maPhong = '" + txtMaPhong.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã phòng không tồn tại!", "Cảnh báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            txtMaPhong.BackColor = SystemColors.Window;
                            dataAccess = new DataAccess();
                            string query = "DELETE FROM `employeems`.`phongban` WHERE (`maPhong` = '" + txtMaPhong.Text + "');";
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
                    DataTable dataTable = dataAccess.GetData("SELECT maPhong FROM phongban WHERE maPhong = '" + txtMaPhong.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã phòng không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");


                                dataAccess = new DataAccess();
                                string query = "UPDATE `employeems`.`phongban` SET `maPhong` = '" + txtMaPhong.Text + "', `maBoPhan` = '" + txtMaBoPhan.Text + "', `tenPhong` = '" + txtTenPhong.Text + "', `ngayThanhLap` = '" + timeThanhLapString + "', `ghiChu` = '" + txtGhiChu.Text + "' WHERE (`maPhong` = '" + txtMaPhong.Text + "');";
                                dataAccess.UpdateData(query);
                                MessageBox.Show("Cập nhật thành công!", "Thông báo");
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
            string query = "SELECT * FROM phongban WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyDonVi_PhongBan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyDonVi_PhongBan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='phongban'";
            FormSearching fsearch = new FormSearching(query, 3);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }

        private void txtMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }

        private void txtMaBoPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }
    }
}
