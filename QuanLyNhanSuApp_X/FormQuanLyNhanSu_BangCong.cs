﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyNhanSu_BangCong : Form
    {
        public FormQuanLyNhanSu_BangCong()
        {
            InitializeComponent();
        }

        private void BindToCombobox()
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                string query = "SELECT maLuong FROM bangluongcty";
                cbbMaLuong.DataSource = dataAccess.GetData(query);
                cbbMaLuong.DisplayMember = "maLuong"; // Cột hiển thị
                cbbMaLuong.ValueMember = "maLuong"; // Cột giá trị

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Combobox. Error: " + ex.Message);
            }

        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtKyLuat.Text = string.Empty;
            txtLuong.Text = string.Empty;
            cbbMaLuong.SelectedIndex = -1;
            txtNam.Text = string.Empty;
            txtPhuCapKhac.Text = string.Empty;


            txtSoGioLamThem.Text = string.Empty;
            txtSoNgayCong.Text = string.Empty;
            txtSoNgayNghi.Text = string.Empty;
            txtThang.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtThuong.Text = string.Empty;
        }


        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM bangcongnhanviencoban";
            dgvFormQuanLyNhanSu.DataSource = dataAccess.GetData(query);
        }
        
        private void setDefault()
        {

            if (txtPhuCapKhac.Text == string.Empty)
            {
                txtPhuCapKhac.Text = 0.ToString();

            }
            if (txtThuong.Text == string.Empty)
            {
                txtThuong.Text = 0.ToString();
            }
            if (txtKyLuat.Text == string.Empty)
            {
                txtKyLuat.Text = 0.ToString();
            }
            if (txtSoNgayCong.Text == string.Empty)
            {
                txtSoNgayCong.Text = 0.ToString();
            }
            if (txtSoNgayNghi.Text == string.Empty)
            {
                txtSoNgayNghi.Text = 0.ToString();
            }
            if (txtSoGioLamThem.Text == string.Empty)
            {
                txtPhuCapKhac.Text = 0.ToString();
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
            if (txtThang.Text == string.Empty)
            {
                txtThang.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtThang.BackColor = SystemColors.Window;
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
            if (cbbMaLuong.SelectedIndex == -1)
            {
                cbbMaLuong.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                cbbMaLuong.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid()
        {
            string message = "";

            int soGioLamThem;
            int.TryParse(txtSoGioLamThem.Text, out soGioLamThem);
            int soNgayCong;
            int.TryParse(txtSoNgayCong.Text, out soNgayCong);
            int soNgayNghi;
            int.TryParse(txtSoNgayNghi.Text, out soNgayNghi);
            int year = int.Parse(txtNam.Text);
            int month = int.Parse(txtThang.Text);
            if (soNgayCong + soNgayNghi > DateTime.DaysInMonth(year, month))
            {
                message += "Tổng số ngày công và ngày nghỉ không được vượt quá số ngày trong tháng!\n";
            };
            if (soGioLamThem > 40)
            {
                message += "Số giờ làm thêm không vượt quá 40 giờ trong 1 tháng\n";
                txtSoGioLamThem.BackColor = Color.Red;
            }
            else
            {
                txtSoGioLamThem.BackColor = SystemColors.Window;
            }
            return message;
        }

       
        private void FormQuanLyNhanSu_BangCong_Load(object sender, EventArgs e)
        {
            try
            {

                BindToDataGridView();
                BindToCombobox();
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
        private void txtPhuCapKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
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

        private void txtKyLuat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoNgayCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoNgayNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoGioLamThem_KeyPress(object sender, KeyPressEventArgs e)
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
                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`bangcongnhanviencoban` (`maNV`, `phuCapKhac`, `thuong`, `kyLuat`, `thang`, `nam`, `soNgayCong`, `soNgayNghi`, `soGioLamThem`, `ghiChu`, `maLuong`) " +
                            "VALUES ('" + txtMaNV.Text + "', '" + txtPhuCapKhac.Text + "', '" + txtThuong.Text + "', '" + txtKyLuat.Text + "', '" + txtThang.Text + "', '" + txtNam.Text + "', '" + txtSoNgayCong.Text + "', '" + txtSoNgayNghi.Text + "', '" + txtSoGioLamThem.Text + "', '" + txtGhiChu.Text + "', '" + cbbMaLuong.Text + "');";
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
            if (txtMaNV.Text == String.Empty)
            {
                txtMaNV.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã nhân viên", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaNV.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`bangcongnhanviencoban` WHERE(`maNV` = '" + txtMaNV.Text + "')";
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
                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`bangcongnhanviencoban` " +
                            "SET `maNV` = '" + txtMaNV.Text + "', `phuCapKhac` = '" + txtPhuCapKhac.Text + "', `thuong` = '" + txtThuong.Text + "', `kyLuat` = '" + txtKyLuat.Text + "', `thang` = '" + txtThang.Text + "', `nam` = '" + txtNam.Text + "', `soNgayCong` = '" + txtSoNgayCong.Text
                            + "', `soNgayNghi` = '" + txtSoNgayNghi.Text + "', `soGioLamThem` = '" + txtSoGioLamThem.Text + "', `ghiChu` = '" + txtGhiChu.Text + "', `maLuong` = '" + cbbMaLuong.Text + "' WHERE (`maNV` = '" + txtMaNV.Text + "');";
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

        private void dgvFormQuanLyNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyNhanSu.Rows.Count > 0)
            {
                txtMaNV.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[0].Value.ToString();
                txtPhuCapKhac.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[1].Value.ToString();
                txtThuong.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[2].Value.ToString();
                txtKyLuat.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[3].Value.ToString();
                txtThang.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[4].Value.ToString();
                txtNam.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[5].Value.ToString();
                txtSoNgayCong.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[6].Value.ToString();
                txtSoNgayNghi.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[7].Value.ToString();
                txtSoGioLamThem.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[8].Value.ToString();
                txtLuong.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[9].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[10].Value.ToString();
                string selectedValue = dgvFormQuanLyNhanSu.SelectedRows[0].Cells[11].Value.ToString();
                cbbMaLuong.SelectedItem = cbbMaLuong.Items.Cast<DataRowView>().FirstOrDefault(item => item["maLuong"].ToString() == selectedValue);
            }
        }
    }
}
