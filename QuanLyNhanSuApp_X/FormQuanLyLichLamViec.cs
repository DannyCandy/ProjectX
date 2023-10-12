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
    public partial class FormQuanLyLichLamViec : Form
    {
        public FormQuanLyLichLamViec()
        {
            InitializeComponent();
        }

        private void FormQuanLyLichLamViec_Load(object sender, EventArgs e)
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
            dgvFormQuanLyLichLamViec.DataSource = dataAccess.GetData(query);

        }

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[4] != null && currentRow.Cells[5] != null)
            {
                return false;
            }
            return true;
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
                message += "Thời gian làm việc không hợp lệ!";
            }
            return message;
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
                    try
                    {
                        // Lấy giá trị ngày giờ không chứa AM/PM

                        string timeInString = dateTimePickerGioVao.Value.ToString("HH:mm:ss");
             
                        string timeOutString = dateTimePickerGioRa.Value.ToString("HH:mm:ss");

                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`lichlamviec` (`maLichLamViec`, `thang`, `nam`, `gioVao`, `gioRa`, `caLamViec`, `maNV`) " +
                            "VALUES ('"+txtMaLichLamViec.Text+"', '"+txtThang.Text+"', '"+txtNam.Text+"', '"+timeInString+"', '"+timeOutString+"', '"+txtCaLamViec.Text+"', '"+txtMaNhanVien.Text+"');";
                        dataAccess.InsertData(query);
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        BindToDataGridView();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");

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
                try
                {
                    txtMaLichLamViec.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`lichlamviec` WHERE (`maLichLamViec` = '"+txtMaLichLamViec.Text+"');";
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
                if (isValid() == "")
                {
                    try
                    {
                        // Lấy giá trị ngày giờ không chứa AM/PM

                        string timeInString = dateTimePickerGioVao.Value.ToString("HH:mm:ss");

                        string timeOutString = dateTimePickerGioRa.Value.ToString("HH:mm:ss");

                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`lichlamviec` SET `maLichLamViec` = '"+txtMaLichLamViec.Text+"', `thang` = '"+txtThang.Text+"', `nam` = '"+txtNam.Text+"', `ngayLamViec` = '"+
                            txtNgayLamViec.Text+"', `gioVao` = '"+timeInString+"', `gioRa` = '"+timeOutString+"', `caLamViec` = '"+txtCaLamViec.Text+"', `maNV` = '"+txtMaNhanVien.Text+"' WHERE (`maLichLamViec` = '"+txtMaLichLamViec.Text+"');";
                        dataAccess.UpdateData(query);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        BindToDataGridView();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông báo");

                    }
                }
                else
                {
                    MessageBox.Show(isValid(), "Cảnh báo");
                }
            }
        }
    }
}
