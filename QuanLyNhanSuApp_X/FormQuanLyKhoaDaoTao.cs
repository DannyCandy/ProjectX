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
    public partial class FormQuanLyKhoaDaoTao : Form
    {
        public FormQuanLyKhoaDaoTao()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhoaDaoTao_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerNgayBatDau.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgayBatDau.CustomFormat = "yyyy-MM-dd";
                BindToDataGridView();
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
            string query = "SELECT * FROM khoadaotao";
            dgvFormQuanLyKhoaDaoTao.DataSource = dataAccess.GetData(query);
        }

        private void ResetTextBox()
        {
            txtMaKhoaDaoTao.Text = string.Empty;
            txtTenKhoaDaoTao.Text = string.Empty;
            dateTimePickerNgayBatDau.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            txtThoiGian.Text = string.Empty;
            txtMaNhanVien.Text = string.Empty;


            txtTienDo.Text = string.Empty;
            txtMaKhoaDaoTao.Text = string.Empty;
        }

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[2] != null)
            {
                return false;
            }
            return true;
        }
        

        private void dgvFormQuanLyKhoaDaoTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvFormQuanLyKhoaDaoTao.Rows.Count > 0 && checkDateIsEmpty(dgvFormQuanLyKhoaDaoTao.SelectedRows[0]))
            {
                {
                    txtMaKhoaDaoTao.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenKhoaDaoTao.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[1].Value.ToString();

                    DateTime parsedDateTimeBegin;
                    string timeBeginString = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[2].Value.ToString();
                    DateTime.TryParse(timeBeginString, out parsedDateTimeBegin);
                    string formattedBeginString = parsedDateTimeBegin.ToString("yyyy-MM-dd");
                    dateTimePickerNgayBatDau.Value = DateTime.ParseExact(formattedBeginString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    txtThoiGian.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[3].Value.ToString();
                    txtMaNhanVien.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[4].Value.ToString();
                    txtTienDo.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[5].Value.ToString();
                    txtDaHoanThanh.Text = dgvFormQuanLyKhoaDaoTao.SelectedRows[0].Cells[6].Value.ToString();
                }
            }
        }

        private void setDefault()
        {

            
            if (txtTienDo.Text == string.Empty)
            {
                txtTienDo.Text = 0.ToString();
            }
            
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaKhoaDaoTao.Text == string.Empty)
            {
                txtMaKhoaDaoTao.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaKhoaDaoTao.BackColor = SystemColors.Window;
            }
            if (txtTenKhoaDaoTao.Text == string.Empty)
            {
                txtTenKhoaDaoTao.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtTenKhoaDaoTao.BackColor = SystemColors.Window;
            }
            if (txtMaNhanVien.Text == string.Empty)
            {
                txtMaNhanVien.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaNhanVien.BackColor = SystemColors.Window;
            }
            if (txtThoiGian.Text == string.Empty)
            {
                txtThoiGian.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtThoiGian.BackColor = SystemColors.Window;
            }
            return isRequire;
        }


        private string isValid()
        {
            string message = "";

            int TienDo;
            int.TryParse(txtTienDo.Text, out TienDo);
            int ThoiGian;
            int.TryParse(txtThoiGian.Text, out ThoiGian);
            if(TienDo < 0)
            {
                MessageBox.Show("Tiến độ không hợp lệ!", "Thông báo");
                txtTienDo.BackColor = Color.Red;
            }else if(TienDo > ThoiGian) {
                MessageBox.Show("Tiến độ không thể lớn hơn tổng thời gian khóa học!", "Thông báo");
                txtTienDo.BackColor = Color.Red;
            }
            else
            {
                txtTienDo.BackColor = SystemColors.Window;
            }
            return message;
        }

        private void txtThoiGian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                    try
                    {
                        string timeBeginString = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");
                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`khoadaotao` (`maKhoaDT`, `tenKhoaDT`, `ngayBatDau`, `thoiGian`, `maNV`, `tienDo`) VALUES ('"+txtMaKhoaDaoTao+"', '"+txtTenKhoaDaoTao+"', '"+timeBeginString+"', '"+txtThoiGian.Text+"', '"+txtMaNhanVien.Text+"', '"+txtTienDo+"');";
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
            if (txtMaKhoaDaoTao.Text == String.Empty)
            {
                txtMaKhoaDaoTao.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã khóa đào tạo", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaKhoaDaoTao.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`khoadaotao` WHERE (`maKhoaDT` = '" + txtMaKhoaDaoTao.Text + "');";
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

                        string timeBeginString = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`khoadaotao` SET `maKhoaDT` = '"+txtMaKhoaDaoTao.Text+"', `tenKhoaDT` = '"+txtTenKhoaDaoTao.Text+"', `ngayBatDau` = '"+timeBeginString+"', `thoiGian` = '"+txtThoiGian.Text+"', `maNV` = '"+txtMaNhanVien.Text+"', `tienDo` = '"+txtTienDo.Text+"' WHERE (`maKhoaDT` = '"+txtMaKhoaDaoTao.Text+"');";
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
