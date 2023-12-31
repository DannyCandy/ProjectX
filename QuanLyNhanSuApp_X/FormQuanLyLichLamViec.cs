﻿using System;
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
    public partial class FormQuanLyLichLamViec : Form
    {
        private bool isSelf = false;
        private string selfQuery = string.Empty;
        public FormQuanLyLichLamViec()
        {
            InitializeComponent();
        }

        public FormQuanLyLichLamViec(string query)
        {
            InitializeComponent();
            isSelf = true;
            selfQuery = query;
        }

        private void FormQuanLyLichLamViec_Load(object sender, EventArgs e)
        {
            if (isSelf)
            {
                try
                {
                    BindToDataGridView(selfQuery);

                    // Thiết lập định dạng hiển thị thành 24 giờ
                    dateTimePickerGioVao.Format = DateTimePickerFormat.Custom;
                    dateTimePickerGioVao.CustomFormat = "HH:mm:ss";

                    dateTimePickerGioRa.Format = DateTimePickerFormat.Custom;
                    dateTimePickerGioRa.CustomFormat = "HH:mm:ss";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
                }
                finally
                {
                    ResetTextBox();
                    txtMaLichLamViec.ReadOnly = true;
                    txtNgayLamViec.ReadOnly = true;
                    txtThang.ReadOnly = true;
                    txtNam.ReadOnly = true;
                    txtCaLamViec.ReadOnly = true;
                    txtMaNhanVien.ReadOnly = true;

                    dateTimePickerGioRa.Enabled = false;
                    dateTimePickerGioVao.Enabled = false;

                    btnThem.Visible = false;
                    btnSua.Visible = false;
                    btnXoa.Visible = false;
                    btnTraCuu.Visible = false;  
                }
            }
            else
            {
                try
                {
                    BindToDataGridView();

                    // Thiết lập định dạng hiển thị thành 24 giờ
                    dateTimePickerGioVao.Format = DateTimePickerFormat.Custom;
                    dateTimePickerGioVao.CustomFormat = "HH:mm:ss";

                    dateTimePickerGioRa.Format = DateTimePickerFormat.Custom;
                    dateTimePickerGioRa.CustomFormat = "HH:mm:ss";


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

        }

        private void ResetTextBox()
        {
            txtMaNhanVien.Text = string.Empty;
            txtCaLamViec.Text = string.Empty;
            
           
            txtNam.Text = string.Empty;
            dateTimePickerGioVao.Value = DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);

            dateTimePickerGioRa.Value = DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);

            txtMaLichLamViec.Text = string.Empty;
            txtNgayLamViec.Text = string.Empty;
            
            txtThang.Text = string.Empty;
            
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM lichlamviec";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyLichLamViec.DataSource = dataTable;
            }

        }

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[4].Value.ToString().Equals(string.Empty) && currentRow.Cells[5].Value.ToString().Equals(string.Empty))
            {
                return true;
            }
            return false;
        }
        private void dgvFormQuanLyLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyLichLamViec.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyLichLamViec.SelectedRows[0]))
            {
                txtMaLichLamViec.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[0].Value.ToString();
                txtThang.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[1].Value.ToString();
                txtNam.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[2].Value.ToString();
                txtNgayLamViec.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[3].Value.ToString();
                
                DateTime parsedDateTimeIn;
                string timeInString = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[4].Value.ToString();
                DateTime.TryParseExact(timeInString, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDateTimeIn);
                dateTimePickerGioVao.Value = parsedDateTimeIn;
                
                DateTime parsedDateTimeOut;
                string timeOutString = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[5].Value.ToString();
                DateTime.TryParseExact(timeOutString, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDateTimeOut);
                dateTimePickerGioRa.Value = parsedDateTimeOut;
                
                txtCaLamViec.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[6].Value.ToString();
                txtMaNhanVien.Text = dgvFormQuanLyLichLamViec.SelectedRows[0].Cells[7].Value.ToString();
                
            }
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaNhanVien.Text == string.Empty)
            {
                txtMaNhanVien.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaNhanVien.BackColor = SystemColors.Window;
            }
            if (txtMaLichLamViec.Text == string.Empty)
            {
                txtMaLichLamViec.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaLichLamViec.BackColor = SystemColors.Window;
            }
            if (txtNam.Text == string.Empty)
            {
                txtNam.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtNam.BackColor = SystemColors.Window;
            }
            if (txtThang.Text == string.Empty)
            {
                txtThang.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtThang.BackColor = SystemColors.Window;
            }
            if (dateTimePickerGioVao.Value == DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture))
            {
                dateTimePickerGioVao.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                dateTimePickerGioVao.BackColor = SystemColors.Window;
            }
            if (dateTimePickerGioRa.Value == DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture))
            {
                dateTimePickerGioRa.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                dateTimePickerGioRa.BackColor = SystemColors.Window;
            }
            if (txtNgayLamViec.Text == string.Empty)
            {
                txtNgayLamViec.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtNgayLamViec.BackColor = SystemColors.Window;
            }
            if (txtCaLamViec.Text == string.Empty)
            {
                txtCaLamViec.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtCaLamViec.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid()
        {
            string message = "";
            TimeSpan timeDiff = dateTimePickerGioRa.Value - dateTimePickerGioVao.Value;
            double hoursDiff = timeDiff.TotalHours;
            if(hoursDiff < 4)
            {
                message += "Thời gian làm việc tối thiểu của 1 ca làm việc không thể nhỏ hơn 4 giờ!\n";
            }

            int thangValue = int.Parse(txtThang.Text);
            Console.WriteLine(thangValue);
            if (thangValue > 12 || thangValue < 1)
            {
                message += "Giá trị của tháng không hợp lệ!\n";
            }
            if (txtNam.Text.Length != 4)
            {
                message += "Giá trị của năm chưa phù hợp!\n";
            }
            if (txtMaLichLamViec.Text.Length > 10)
            {
                message += "Mã lịch làm việc chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtMaNhanVien.Text.Length > 10)
            {
                message += "Mã nhân viên chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtNgayLamViec.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox ngày làm việc\n";
            }
            if (txtCaLamViec.Text.Length > 20)
            {
                message += "Quá nhiều ký tự trong textbox ca làm việc\n";
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
                    DataTable dataTable = dataAccess.GetData("SELECT maLichLamViec FROM lichlamviec WHERE maLichLamViec = '" + txtMaLichLamViec.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã lịch làm việc đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            // Lấy giá trị ngày giờ không chứa AM/PM

                            string timeInString = dateTimePickerGioVao.Value.ToString("HH:mm:ss");

                            string timeOutString = dateTimePickerGioRa.Value.ToString("HH:mm:ss");

                            dataAccess = new DataAccess();
                            string query = "INSERT INTO `employeems`.`lichlamviec` (`maLichLamViec`, `thang`, `nam`, `gioVao`, `gioRa`,`ngayLamViec`, `caLamViec`, `maNV`) " +
                                "VALUES ('" + txtMaLichLamViec.Text + "', '" + txtThang.Text + "', '" + txtNam.Text + "', '" + timeInString + "', '" + timeOutString + "', '"+txtNgayLamViec.Text+"', '" + txtCaLamViec.Text + "', '" + txtMaNhanVien.Text + "');";
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
            if (txtMaLichLamViec.Text == String.Empty)
            {
                txtMaLichLamViec.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã lịch làm việc", "Thông báo");
            }
            else
            {
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT maLichLamViec FROM lichlamviec WHERE maLichLamViec = '" + txtMaLichLamViec.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã lịch làm việc không tồn tại!", "Cảnh báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            txtMaLichLamViec.BackColor = SystemColors.Window;
                            dataAccess = new DataAccess();
                            string query = "DELETE FROM `employeems`.`lichlamviec` WHERE (`maLichLamViec` = '" + txtMaLichLamViec.Text + "');";
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
                    DataTable dataTable = dataAccess.GetData("SELECT maLichLamViec FROM lichlamviec WHERE maLichLamViec = '" + txtMaLichLamViec.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã lịch làm việc không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // Lấy giá trị ngày giờ không chứa AM/PM

                                string timeInString = dateTimePickerGioVao.Value.ToString("HH:mm:ss");

                                string timeOutString = dateTimePickerGioRa.Value.ToString("HH:mm:ss");

                                dataAccess = new DataAccess();
                                string query = "UPDATE `employeems`.`lichlamviec` SET `maLichLamViec` = '" + txtMaLichLamViec.Text + "', `thang` = '" + txtThang.Text + "', `nam` = '" + txtNam.Text + "', `ngayLamViec` = '" +
                                    txtNgayLamViec.Text + "', `gioVao` = '" + timeInString + "', `gioRa` = '" + timeOutString + "', `caLamViec` = '" + txtCaLamViec.Text + "', `maNV` = '" + txtMaNhanVien.Text + "' WHERE (`maLichLamViec` = '" + txtMaLichLamViec.Text + "');";
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

        private void txtCaLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Nếu không phải chữ số hoặc dấu phẩy, hủy sự kiện KeyPress
                e.Handled = true;
            }
        }

        private void txtNgayLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Nếu không phải chữ số hoặc dấu phẩy, hủy sự kiện KeyPress
                e.Handled = true;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;
        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM lichlamviec WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyLichLamViec.DataSource = dataTable;
            }
        }
        private void FormSearchClosed(object sender, FormClosedEventArgs e)
        {
            FormSearching_LichLamViec fsearch = sender as FormSearching_LichLamViec;
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='lichlamviec'";
            FormSearching_LichLamViec fsearch = new FormSearching_LichLamViec(query, 1,2);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }

        private void txtMaLichLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }
    }
}
