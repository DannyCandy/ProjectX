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
    public partial class FormCheDo_BaoHiem : Form
    {
        public FormCheDo_BaoHiem()
        {
            InitializeComponent();
        }


        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM baohiem";
            dgvFormQuanLyCheDo_BaoHiem.DataSource = dataAccess.GetData(query);
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;    
            txtGhiChu.Text = string.Empty;
            txtLoaiBaoHiem.Text = string.Empty;
            txtMaBaoHiem.Text= string.Empty;
            txtMaSoBaoHiem.Text = string.Empty;
            txtNoiCap.Text = string.Empty;

            dateTimePickerNgayCap.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dateTimePickerNgayKetThuc.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        private void FormCheDo_BaoHiem_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();

                dateTimePickerNgayCap.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayCap.CustomFormat = "yyyy-MM-dd";

                dateTimePickerNgayKetThuc.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayKetThuc.CustomFormat = "yyyy-MM-dd";
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
            if (currentRow.Cells[3] != null && currentRow.Cells[6] != null)
            {
                return false;
            }
            return true;
        }

        private void dgvFormQuanLyNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyCheDo_BaoHiem.Rows.Count > 0 && checkDateIsEmpty(dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0]))
            {
                txtMaNV.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[0].Value.ToString();
                txtLoaiBaoHiem.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[1].Value.ToString();
                txtMaBaoHiem.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[2].Value.ToString();

                DateTime parsedDateTimeCap;
                string timeCapString = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[3].Value.ToString();
                DateTime.TryParse(timeCapString, out parsedDateTimeCap);
                string formattedCapString = parsedDateTimeCap.ToString("yyyy-MM-dd");
                dateTimePickerNgayCap.Value = DateTime.ParseExact(formattedCapString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                txtNoiCap.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[4].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[5].Value.ToString();

                DateTime parsedDateTimeKetThuc;
                string timeKetThucString = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[6].Value.ToString();
                DateTime.TryParse(timeKetThucString, out parsedDateTimeKetThuc);
                string formattedKetThucString = parsedDateTimeKetThuc.ToString("yyyy-MM-dd");
                dateTimePickerNgayKetThuc.Value = DateTime.ParseExact(formattedKetThucString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                
                txtMaSoBaoHiem.Text = dgvFormQuanLyCheDo_BaoHiem.SelectedRows[0].Cells[6].Value.ToString();

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
            if (txtLoaiBaoHiem.Text == string.Empty)
            {
                txtLoaiBaoHiem.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtLoaiBaoHiem.BackColor = SystemColors.Window;
            }
            if (txtMaBaoHiem.Text == string.Empty)
            {
                txtMaBaoHiem.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaBaoHiem.BackColor = SystemColors.Window;
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
            if (txtMaSoBaoHiem.Text == string.Empty)
            {
                txtMaSoBaoHiem.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaSoBaoHiem.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid()
        {
            string message = "";
            if (dateTimePickerNgayKetThuc.Value < dateTimePickerNgayCap.Value)
            {
                message += "Thời gian hiệu lực của bảo hiểm không hợp lệ!\n";
                
            }
            else
            {
                message += "Ngày kết thúc phải lớn hơn ngày cấp phát!\n";
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
                    try
                    {


                        string timeInString = dateTimePickerNgayCap.Value.ToString("yyyy-MM-dd");

                        string timeOutString = dateTimePickerNgayKetThuc.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`baohiem` (`maNV`, `loaiBaoHiem`, `maBaoHiem`, `ngayCap`, `noiCap`, `ghiChu`, `ngayKetThuc`, `maSoBH`) " +
                            "VALUES ('"+txtMaNV.Text+"', '"+txtLoaiBaoHiem.Text+"', '"+txtMaBaoHiem.Text+"', '"+timeInString+"', '"+txtNoiCap.Text+"', '"+txtGhiChu.Text+"', '"+timeOutString+"', '"+txtMaSoBaoHiem.Text+"');";
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
            if (txtMaBaoHiem.Text == String.Empty)
            {
                txtMaBaoHiem.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã bảo hiểm", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaBaoHiem.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`baohiem` WHERE (`maBaoHiem` = '" + txtMaBaoHiem.Text + "');";
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


                        string timeInString = dateTimePickerNgayCap.Value.ToString("yyyy-MM-dd");

                        string timeOutString = dateTimePickerNgayKetThuc.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`baohiem` " +
                            "SET `maNV` = '"+txtMaNV.Text+"', " +
                            "`loaiBaoHiem` = '"+txtLoaiBaoHiem.Text+"', " +
                            "`maBaoHiem` = '"+txtMaBaoHiem.Text+"', " +
                            "`ngayCap` = '"+timeInString+"', " +
                            "`noiCap` = '"+txtNoiCap.Text+"', " +
                            "`ghiChu` = '"+txtGhiChu.Text+"', " +
                            "`ngayKetThuc` = '"+timeOutString+"', " +
                            "`maSoBH` = '"+txtMaSoBaoHiem.Text+"' WHERE (`maBaoHiem` = '"+txtMaBaoHiem.Text+"');";
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
