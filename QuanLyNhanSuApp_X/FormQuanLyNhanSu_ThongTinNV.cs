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
    public partial class FormQuanLyNhanSu_ThongTinNV : Form
    {
        public FormQuanLyNhanSu_ThongTinNV()
        {
            InitializeComponent();
        }

        private void BindToComboboxBoPhan()
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                string query = "SELECT maBoPhan,tenBoPhan FROM bophan";
                DataTable dataTable = dataAccess.GetData(query);
                if (dataTable != null)
                {
                    cbbBoPhan.DataSource = dataAccess.GetData(query);
                    cbbBoPhan.DisplayMember = "tenBoPhan"; // Cột hiển thị
                    cbbBoPhan.ValueMember = "maBoPhan"; // Cột giá trị
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Combobox Bộ phận. Error: " + ex.Message);
            }

        }

        private void BindToComboboxPhongBan()
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                string query = "SELECT maPhong,tenPhong FROM phongban";
                DataTable dataTable = dataAccess.GetData(query);
                if (dataTable != null)
                {
                    cbbPhongBan.DataSource = dataAccess.GetData(query);
                    cbbPhongBan.DisplayMember = "tenPhong"; // Cột hiển thị
                    cbbPhongBan.ValueMember = "maPhong"; // Cột giá trị
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Combobox Phòng ban. Error: " + ex.Message);
            }

        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM ttnvcoban";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTTNVCoBan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyTTNVCoBan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            
            cbbBoPhan.SelectedIndex = -1;
            cbbPhongBan.SelectedIndex = -1;

            txtChucVu.Text = string.Empty;
            cbbGioiTinh.SelectedIndex = -1;

            txtTTHonNhan.Text = string.Empty;

            dateTimePickerNgaySinh.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            txtCMND.Text = string.Empty;
            txtNoiCap.Text = string.Empty;
            
        }

        private void FormQuanLyNhanSu_ThongTinNV_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();
                BindToComboboxBoPhan();
                BindToComboboxPhongBan();
                // Thiết lập định dạng hiển thị thành 24 giờ
                dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgaySinh.CustomFormat = "yyyy-MM-dd";
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
            if (txtTTHonNhan.Text == string.Empty)
            {
                txtTTHonNhan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtTTHonNhan.BackColor = SystemColors.Window;
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
            if (txtCMND.Text == string.Empty)
            {
                txtCMND.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtCMND.BackColor = SystemColors.Window;
            }
            if (txtNoiCap.Text == string.Empty)
            {
                txtNoiCap.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtNoiCap.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid() { 
            string message = string.Empty;
            if (txtMaNV.Text.Length > 10)
            {
                message += "Mã nhân viên chỉ chứa tối đa 10 chữ số\n";
            }
            if (txtHoTen.Text.Length > 50)
            {
                message += "Họ tên nhân viên quá dài\n";
            }
            if (txtChucVu.Text.Length > 50)
            {
                message += "Chức vụ quá dài\n";
            }
            if (txtTTHonNhan.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox tình trạng hôn nhân\n";
            }
            if(txtCMND.Text.Length != 9)
            {
                message += "CMND phải có 9 chữ số\n";
            }
            if(txtNoiCap.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox nơi cấp\n";
            }
            return message;
        }

        private void SetDefault()
        {
            cbbGioiTinh.SelectedIndex = 0;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
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
                if (isValid() == "")
                {
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttnvcoban WHERE maNV = '" + txtMaNV.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {

                            string timeNgaySinhString = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");

                            dataAccess = new DataAccess();
                            string query = "INSERT INTO `employeems`.`ttnvcoban` (`maNV`, `hoTen`, `maPhong`, `ngaySinh`, `gioiTinh`, `ttHonNhan`, `CMND`, `noiCap`, `chucVu`)" +
                            " VALUES ('" + txtMaNV.Text + "', '" + txtHoTen.Text + "', '" + cbbPhongBan.SelectedValue.ToString() + "', '" + timeNgaySinhString + "', '" + cbbGioiTinh.SelectedIndex.ToString() + "', '" + txtTTHonNhan.Text + "', '" + txtCMND.Text + "', '" + txtNoiCap.Text + "', '" + txtChucVu.Text + "');";
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
            if (txtMaNV.Text == String.Empty)
            {
                txtMaNV.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã nhân viên", "Thông báo");
            }
            else
            {
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttnvcoban WHERE maNV = '" + txtMaNV.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Cảnh báo");
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
                            string query = "DELETE FROM `employeems`.`ttnvcoban` WHERE (`maNV` = '" + txtMaNV.Text + "');";
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
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttnvcoban WHERE maNV = '" + txtMaNV.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                string timeNgaySinhString = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");


                                dataAccess = new DataAccess();
                                string query = "UPDATE `employeems`.`ttnvcoban` SET " +
                                "`maNV` = '" + txtMaNV.Text + "', " +
                                "`hoTen` = '" + txtHoTen.Text + "', " +
                                "`maPhong` = '" + cbbPhongBan.SelectedValue.ToString() + "', " +
                                "`ngaySinh` = '" + timeNgaySinhString + "', " +
                                "`gioiTinh` = '" + cbbGioiTinh.SelectedIndex.ToString() + "', " +
                                "`ttHonNhan` = '" + txtTTHonNhan.Text + "', " +
                                "`CMND` = '" + txtCMND.Text + "', " +
                                "`noiCap` = '" + txtNoiCap.Text + "', " +
                                "`chucVu` = '" + txtChucVu.Text + "'" +
                                " WHERE (`maNV` = '" + txtMaNV.Text + "');";
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

        private void dgvFormQuanLyTTNVCoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyTTNVCoBan.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyTTNVCoBan.SelectedRows[0]))
            {
                txtMaNV.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[0].Value.ToString();

                DateTime parsedDateTimeNgaySinh;
                string timeNgaySinhString = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[3].Value.ToString();
                DateTime.TryParse(timeNgaySinhString, out parsedDateTimeNgaySinh);
                string formattedNgaySinhString = parsedDateTimeNgaySinh.ToString("yyyy-MM-dd");
                dateTimePickerNgaySinh.Value = DateTime.ParseExact(formattedNgaySinhString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                txtHoTen.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[1].Value.ToString();
                txtTTHonNhan.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[5].Value.ToString();

                txtChucVu.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[8].Value.ToString();
                txtCMND.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[6].Value.ToString();
                txtNoiCap.Text = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[7].Value.ToString();

                string selectedPhongban = dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[2].Value.ToString();
                try
                {
                    
                    DataAccess dataAccess = new DataAccess();
                    DataTable dttb = dataAccess.GetData("SELECT maBoPhan FROM phongban WHERE maPhong = '" + selectedPhongban + "'");
                    cbbBoPhan.SelectedValue = dttb.Rows[0]["maBoPhan"].ToString();
                }
                catch
                {
                    MessageBox.Show("Không thể tải dữ liệu lên Combobox Bộ phận.", "Lỗi");
                }
                
                cbbPhongBan.SelectedItem = cbbPhongBan.Items.Cast<DataRowView>().FirstOrDefault(item => item["maPhong"].ToString() == selectedPhongban);
                int selectedGioiTinh = int.Parse( dgvFormQuanLyTTNVCoBan.SelectedRows[0].Cells[4].Value.ToString());
                
                cbbGioiTinh.SelectedIndex = selectedGioiTinh;
            }
        }

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM ttnvcoban WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTTNVCoBan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyTTNVCoBan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='ttnvcoban'";
            FormSearching fsearch = new FormSearching(query, 6);
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
    }
}
