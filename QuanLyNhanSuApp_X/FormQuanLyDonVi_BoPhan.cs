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
    public partial class FormQuanLyDonVi_BoPhan : Form
    {
        public FormQuanLyDonVi_BoPhan()
        {
            InitializeComponent();
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM bophan";
            dgvFormQuanLyDonVi_BoPhan.DataSource = dataAccess.GetData(query);
        }

        private void ResetTextBox()
        {
            
            txtMaBoPhan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dateTimePickerNgayThanhLap.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtTenBoPhan.Text = string.Empty;
        }

        private void FormQuanLyDonVi_BoPhan_Load(object sender, EventArgs e)
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
            if (currentRow.Cells[2] != null)
            {
                return false;
            }
            return true;
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtMaBoPhan.Text == string.Empty)
            {
                txtMaBoPhan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaBoPhan.BackColor = SystemColors.Window;
            }
            if (txtTenBoPhan.Text == string.Empty)
            {
                txtTenBoPhan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtTenBoPhan.BackColor = SystemColors.Window;
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
                    string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");

                    DataAccess dataAccess = new DataAccess();
                    string query = "INSERT INTO `employeems`.`bophan` (`maBoPhan`, `tenBoPhan`, `ngayThanhLap`, `ghiChu`)" +
                        " VALUES ('"+txtMaBoPhan.Text+"', '"+txtTenBoPhan.Text+"', '"+timeThanhLapString+"', '"+txtGhiChu.Text+"');";
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
        private void dgvFormQuanLyDonVi_BoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyDonVi_BoPhan.Rows.Count > 0 && checkDateIsEmpty(dgvFormQuanLyDonVi_BoPhan.SelectedRows[0]))
            {
                txtMaBoPhan.Text = dgvFormQuanLyDonVi_BoPhan.SelectedRows[0].Cells[0].Value.ToString();

                DateTime parsedDateTimeTroLaiLam;
                string timeTroLaiLamString = dgvFormQuanLyDonVi_BoPhan.SelectedRows[0].Cells[2].Value.ToString();
                DateTime.TryParse(timeTroLaiLamString, out parsedDateTimeTroLaiLam);
                string formattedTroLaiLamString = parsedDateTimeTroLaiLam.ToString("yyyy-MM-dd");
                dateTimePickerNgayThanhLap.Value = DateTime.ParseExact(formattedTroLaiLamString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

               
                txtGhiChu.Text = dgvFormQuanLyDonVi_BoPhan.SelectedRows[0].Cells[3].Value.ToString();

                txtTenBoPhan.Text = dgvFormQuanLyDonVi_BoPhan.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text == String.Empty)
            {
                txtMaBoPhan.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã bộ phận", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaBoPhan.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`bophan` WHERE (`maBoPhan` = '" + txtMaBoPhan.Text + "');";
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
                    string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");


                    DataAccess dataAccess = new DataAccess();
                    string query = "UPDATE `employeems`.`bophan` " +
                        "SET `maBoPhan` = '"+txtMaBoPhan.Text+"', `tenBoPhan` = '"+txtTenBoPhan.Text+"', `ngayThanhLap` = '"+timeThanhLapString+"', `ghiChu` = '"+txtGhiChu.Text+"' WHERE (`maBoPhan` = '"+txtMaBoPhan.Text+"');";
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
