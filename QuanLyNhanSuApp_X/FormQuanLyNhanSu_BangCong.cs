using System;
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
        private bool isSelf = false;
        private string selfQuery = string.Empty;
        public FormQuanLyNhanSu_BangCong()
        {
            InitializeComponent();
        }

        public FormQuanLyNhanSu_BangCong(string query)
        {
            InitializeComponent();
            isSelf = true;
            selfQuery = query;
        }
        private void BindToCombobox()
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                string query = "SELECT maLuong FROM bangluongcty";
                DataTable dataTable = dataAccess.GetData(query);
                if(dataTable != null )
                {
                    cbbMaLuong.DataSource = dataAccess.GetData(query);
                    cbbMaLuong.DisplayMember = "maLuong"; // Cột hiển thị
                    cbbMaLuong.ValueMember = "maLuong"; // Cột giá trị
                }
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
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyNhanSu.DataSource = dataTable;
            }
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
            if (txtMaNV.Text.Length > 10)
            {
                message += "Mã nhân viên chỉ chứa tối đa 10 ký tự\n";
            }
            if (txtPhuCapKhac.Text.Length > 9)
            {
                message += "Phụ cấp không hợp lệ\n";
            }
            if (txtThuong.Text.Length > 9)
            {
                message += "Thưởng không hợp lệ\n";
            }
            if (txtKyLuat.Text.Length > 9)
            {
                message += "Kỷ luật không hợp lệ\n";
            }
            if (txtSoNgayCong.Text.Length > 2)
            {
                message += "Số ngày công không hợp lệ\n";
            }
            if (txtSoNgayNghi.Text.Length > 2)
            {
                message += "Số ngày nghỉ không hợp lệ\n";
            }
            if( txtGhiChu.Text.Length > 50)
            {
                message += "Ghi chú quá dài\n";
            }
            return message;
        }

       
        private void FormQuanLyNhanSu_BangCong_Load(object sender, EventArgs e)
        {
            if (isSelf)
            {
                try
                {
                    BindToDataGridView(selfQuery);
                    BindToCombobox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
                }
                finally
                {
                    ResetTextBox();
                    txtMaNV.ReadOnly = true;
                    txtPhuCapKhac.ReadOnly = true;
                    txtThuong.ReadOnly = true;
                    txtKyLuat.ReadOnly = true;
                    txtThang.ReadOnly = true;
                    txtNam.ReadOnly = true;
                    txtSoNgayCong.ReadOnly = true;
                    txtSoNgayNghi.ReadOnly = true;
                    txtSoGioLamThem.ReadOnly = true;
                    txtGhiChu.ReadOnly = true;
                    txtLuong.ReadOnly = true;

                    cbbMaLuong.Enabled = false;

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
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM bangcongnhanviencoban WHERE maNV = '" + txtMaNV.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            dataAccess = new DataAccess();
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
                DataTable dataTable = dataAccess.GetData("SELECT maNV FROM bangcongnhanviencoban WHERE maNV = '" + txtMaNV.Text + "'");
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
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM bangcongnhanviencoban WHERE maNV = '" + txtMaNV.Text + "'");
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
                                dataAccess = new DataAccess();
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

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM bangcongnhanviencoban WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyNhanSu.DataSource = dataTable;
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='bangcongnhanviencoban'";
            FormSearching fsearch = new FormSearching(query);
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
