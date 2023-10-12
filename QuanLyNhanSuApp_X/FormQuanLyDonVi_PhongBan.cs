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
            dgvFormQuanLyDonVi_PhongBan.DataSource = dataAccess.GetData(query);
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
            if (currentRow.Cells[3] != null)
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
                        string query = "INSERT INTO `employeems`.`phongban` (`maPhong`, `maBoPhan`, `tenPhong`, `ngayThanhLap`, `ghiChu`) " +
                        "VALUES ('"+txtMaPhong.Text+"', '"+txtMaBoPhan.Text+"', '"+txtTenPhong.Text+"', '"+timeThanhLapString+"', '"+txtGhiChu.Text+"');";
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

        private void dgvFormQuanLyDonVi_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyDonVi_PhongBan.Rows.Count > 0 && checkDateIsEmpty(dgvFormQuanLyDonVi_PhongBan.SelectedRows[0]))
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
                try
                {
                    txtMaPhong.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
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
                        string query = "UPDATE `employeems`.`phongban` SET `maPhong` = '"+txtMaPhong.Text+"', `maBoPhan` = '"+txtMaBoPhan.Text+"', `tenPhong` = '"+txtTenPhong.Text+"', `ngayThanhLap` = '"+timeThanhLapString+"', `ghiChu` = '"+txtGhiChu.Text+"' WHERE (`maPhong` = '"+txtMaPhong.Text+"');";
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
