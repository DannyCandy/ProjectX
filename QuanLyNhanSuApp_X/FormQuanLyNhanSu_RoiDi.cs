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
    public partial class FormQuanLyNhanSu_RoiDi : Form
    {
        public FormQuanLyNhanSu_RoiDi()
        {
            InitializeComponent();
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM nvroitochuc";
            dgvFormQuanLyNVRoiTC.DataSource = dataAccess.GetData(query);
        }

        private void ResetTextBox()
        {

            txtCMND.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            dateTimePickerNgayRoi.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtMaPhong.Text = string.Empty;
        }

        private void FormQuanLyNhanSu_RoiDi_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();

                dateTimePickerNgayRoi.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayRoi.CustomFormat = "yyyy-MM-dd";
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
            if (currentRow.Cells[2] != null)
            {
                return false;
            }
            return true;
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
            if (txtCMND.Text == string.Empty)
            {
                txtCMND.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtCMND.BackColor = SystemColors.Window;
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
            if (txtLyDo.Text == string.Empty)
            {
                txtLyDo.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtLyDo.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {

                try
                {
                    string timeRoiDiString = dateTimePickerNgayRoi.Value.ToString("yyyy-MM-dd");

                    DataAccess dataAccess = new DataAccess();
                    string query = "INSERT INTO `employeems`.`nvroitochuc` (`hoTen`, `CMND`, `ngayRoi`, `lyDo`, `maPhong`) " +
                        "VALUES ('"+txtHoTen.Text+"', '"+txtCMND.Text+"', '"+timeRoiDiString+"', '"+txtLyDo.Text+"', '"+txtMaPhong.Text+"');";
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

        private void dgvFormQuanLyNVRoiTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyNVRoiTC.Rows.Count > 0 && checkDateIsEmpty(dgvFormQuanLyNVRoiTC.SelectedRows[0]))
            {
                txtMaPhong.Text = dgvFormQuanLyNVRoiTC.SelectedRows[0].Cells[4].Value.ToString();

                DateTime parsedDateTimeRoiDi;
                string timeRoiDiString = dgvFormQuanLyNVRoiTC.SelectedRows[0].Cells[2].Value.ToString();
                DateTime.TryParse(timeRoiDiString, out parsedDateTimeRoiDi);
                string formattedRoiDiString = parsedDateTimeRoiDi.ToString("yyyy-MM-dd");
                dateTimePickerNgayRoi.Value = DateTime.ParseExact(formattedRoiDiString, "yyyy-MM-dd", CultureInfo.InvariantCulture);


                txtCMND.Text = dgvFormQuanLyNVRoiTC.SelectedRows[0].Cells[1].Value.ToString();

                txtLyDo.Text = dgvFormQuanLyNVRoiTC.SelectedRows[0].Cells[3].Value.ToString();

                txtHoTen.Text = dgvFormQuanLyNVRoiTC.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == String.Empty)
            {
                txtCMND.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường CMND", "Thông báo");
            }
            else
            {
                try
                {
                    txtCMND.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`nvroitochuc` WHERE (`CMND` = '" + txtCMND.Text + "');";
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
                    string timeRoiDiString = dateTimePickerNgayRoi.Value.ToString("yyyy-MM-dd");


                    DataAccess dataAccess = new DataAccess();
                    string query = "UPDATE `employeems`.`nvroitochuc` SET " +
                        "`hoTen` = '"+txtHoTen.Text+"', " +
                        "`CMND` = '"+txtCMND.Text+"', " +
                        "`ngayRoi` = '"+timeRoiDiString+"', " +
                        "`lyDo` = '"+txtLyDo.Text+"', " +
                        "`maPhong` = '"+txtMaPhong.Text+"' WHERE (`CMND` = '"+txtCMND.Text+"');";
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
}
