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
    public partial class FormQuanLyHopDong : Form
    {
        private string fieldValue = string.Empty;
        public FormQuanLyHopDong()
        {
            InitializeComponent();
        }

        private void FormQuanLyHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();

                // Thiết lập định dạng hiển thị thành 24 giờ
                dateTimePickerNgayKiKet.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayKiKet.CustomFormat = "yyyy-MM-dd";

                dateTimePickerNgayHetHan.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayHetHan.CustomFormat = "yyyy-MM-dd";
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
            string query = "SELECT * FROM hopdong";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyHopDong.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyHopDong.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyHopDong.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            txtMaHopDong.Text = string.Empty;
            dateTimePickerNgayKiKet.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dateTimePickerNgayHetHan.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtThoiHanLamViec.Text = string.Empty;
            txtLoaiHopDong.Text = string.Empty;
        }

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[3].Value.ToString().Equals(string.Empty) && currentRow.Cells[4].Value.ToString().Equals(string.Empty))
            {
                return true;
            }
            return false;
        }
        private void dgvFormQuanLyHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyHopDong.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyHopDong.SelectedRows[0]))
            {
                txtMaNV.Text = dgvFormQuanLyHopDong.SelectedRows[0].Cells[0].Value.ToString();
                txtChucVu.Text = dgvFormQuanLyHopDong.SelectedRows[0].Cells[1].Value.ToString();
                txtThoiHanLamViec.Text = dgvFormQuanLyHopDong.SelectedRows[0].Cells[2].Value.ToString();

                DateTime parsedDateTimeKiKet;
                string timeKiKetString = dgvFormQuanLyHopDong.SelectedRows[0].Cells[3].Value.ToString();
                DateTime.TryParse(timeKiKetString, out parsedDateTimeKiKet);
                string formattedKiKetString = parsedDateTimeKiKet.ToString("yyyy-MM-dd");
                dateTimePickerNgayKiKet.Value = DateTime.ParseExact(formattedKiKetString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                 
                DateTime parsedDateTimeHetHan;
                string timeHetHanString = dgvFormQuanLyHopDong.SelectedRows[0].Cells[4].Value.ToString();
                DateTime.TryParse(timeHetHanString, out parsedDateTimeHetHan);
                string formattedHetHanString = parsedDateTimeHetHan.ToString("yyyy-MM-dd");
                dateTimePickerNgayHetHan.Value = DateTime.ParseExact(formattedHetHanString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                txtMaHopDong.Text = dgvFormQuanLyHopDong.SelectedRows[0].Cells[5].Value.ToString();
                txtLoaiHopDong.Text = dgvFormQuanLyHopDong.SelectedRows[0].Cells[6].Value.ToString();
                
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
            if (txtChucVu.Text == string.Empty)
            {
                txtChucVu.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtChucVu.BackColor = SystemColors.Window;
            }
            if (txtThoiHanLamViec.Text == string.Empty)
            {
                txtThoiHanLamViec.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtThoiHanLamViec.BackColor = SystemColors.Window;
            }
            
            if (txtMaHopDong.Text == string.Empty)
            {
                txtMaHopDong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaHopDong.BackColor = SystemColors.Window;
            }
            if (txtLoaiHopDong.Text == string.Empty)
            {
                txtLoaiHopDong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtLoaiHopDong.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid()
        {
            string message = "";
            if (dateTimePickerNgayHetHan.Value >= dateTimePickerNgayKiKet.Value)
            {
                TimeSpan timeDiff = dateTimePickerNgayHetHan.Value - dateTimePickerNgayKiKet.Value;
                double daysDiff = timeDiff.TotalDays/365;
                int conditionDaysDiff = (int)Math.Floor(daysDiff);
                double thoiGianLamViec;
                double.TryParse(txtThoiHanLamViec.Text, out thoiGianLamViec);
                if (daysDiff >= thoiGianLamViec && thoiGianLamViec >= conditionDaysDiff)
                {
                    message += "Thời gian làm việc không hợp lệ!\n";
                }
            }
            else
            {
                message += "Ngày hết hạn phải lớn hơn ngày kí kết!\n";
            }
            return message;
        }

        private void txtThoiHanLamViec_KeyPress(object sender, KeyPressEventArgs e)
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
                        

                        string timeInString = dateTimePickerNgayKiKet.Value.ToString("yyyy-MM-dd");

                        string timeOutString = dateTimePickerNgayHetHan.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`hopdong` (`maNV`, `chucVu`, `thoiHanLamViec`, `ngayKiKet`, `ngayHetHan`, `maHopDong`, `loaiHopDong`) " +
                            "VALUES ('"+txtMaNV.Text+"', '"+txtChucVu.Text+"', '"+txtThoiHanLamViec.Text+"', '"+timeInString+"', '"+timeOutString+"', '"+txtMaHopDong.Text+"', '"+txtLoaiHopDong.Text+"');";
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
            if (txtMaHopDong.Text == String.Empty)
            {
                txtMaHopDong.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã hợp đồng", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaHopDong.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`hopdong` WHERE (`maHopDong` = '"+txtMaHopDong.Text+"');";
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
                       

                        string timeInString = dateTimePickerNgayKiKet.Value.ToString("yyyy-MM-dd");

                        string timeOutString = dateTimePickerNgayHetHan.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`hopdong` SET `maNV` = '"+txtMaNV.Text+"', `chucVu` = '"+txtChucVu.Text+"', `thoiHanLamViec` = '"+txtThoiHanLamViec.Text+"', `ngayKiKet` = '"+timeInString+"', `ngayHetHan` = '"+timeOutString+"', `maHopDong` = '"+txtMaHopDong.Text+"', `loaiHopDong` = '"+txtLoaiHopDong.Text+"' WHERE (`maHopDong` = '"+txtMaHopDong.Text+"');";
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

        //Chuc nang tra cuu
        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM hopdong WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyHopDong.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyHopDong.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyHopDong.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='hopdong'";
            FormSearching fsearch = new FormSearching(query, 4, 5);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }
    }
}
