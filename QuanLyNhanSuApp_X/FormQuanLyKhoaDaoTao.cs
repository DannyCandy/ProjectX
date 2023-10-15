using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyKhoaDaoTao : Form
    {
        private bool isSelf = false;
        private string selfQuery = string.Empty;
        public FormQuanLyKhoaDaoTao()
        {
            InitializeComponent();
        }

        public FormQuanLyKhoaDaoTao(string query)
        {
            InitializeComponent();
            isSelf = true;
            selfQuery = query;
        }
        private void FormQuanLyKhoaDaoTao_Load(object sender, EventArgs e)
        {
            if (isSelf)
            {
                try
                {
                    dateTimePickerNgayBatDau.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayBatDau.CustomFormat = "yyyy-MM-dd";
                    BindToDataGridView(selfQuery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
                }
                finally
                {
                    ResetTextBox();
                    txtMaKhoaDaoTao.ReadOnly = true;
                    txtTenKhoaDaoTao.ReadOnly = true;
                    txtThoiGian.ReadOnly = true;
                    txtMaNhanVien.ReadOnly = true;
                    txtTienDo.ReadOnly = true;

                    dateTimePickerNgayBatDau.Enabled = false;

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
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM khoadaotao";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyKhoaDaoTao.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyKhoaDaoTao.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
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
            if (currentRow.Cells[2].Value.ToString().Equals(string.Empty))
            {
                return true;
            }
            return false;
        }
        

        private void dgvFormQuanLyKhoaDaoTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvFormQuanLyKhoaDaoTao.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyKhoaDaoTao.SelectedRows[0]))
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
                message += "Tiến độ không hợp lệ!\n";  
                txtTienDo.BackColor = Color.Red;
            }else if(TienDo > ThoiGian) {
                message += "Tiến độ không thể lớn hơn tổng thời gian khóa học!\n";
                txtTienDo.BackColor = Color.Red;
            }
            else
            {
                txtTienDo.BackColor = SystemColors.Window;
            }
            if(txtMaKhoaDaoTao.Text.Length > 10)
            {
                message += "Mã khóa đào tạo chỉ chứa tối đa 10 chữ số\n";
            }
            if(txtMaNhanVien.Text.Length > 10)
            {
                message += "Mã khóa đào tạo chỉ chứa tối đa 10 chữ số\n";
            }
            if (txtThoiGian.Text.Length > 3)
            {
                message += "Thời gian đào tạo quá dài\n";
            }
            if (txtTienDo.Text.Length > 3)
            {
                message += "Thời gian tiến độ quá dài\n";
            }
            if (txtTenKhoaDaoTao.Text.Length > 50)
            {
                message += "Tên khóa đào tạo quá dài\n";
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
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT maKhoaDT FROM khoadaotao WHERE maKhoaDT = '" + txtMaKhoaDaoTao.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã khóa đào tạo đã tồn tại!","Cảnh báo");
                    }
                    else {
                        try
                        {
                            string timeBeginString = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");
                            string query = "INSERT INTO `employeems`.`khoadaotao` (`maKhoaDT`, `tenKhoaDT`, `ngayBatDau`, `thoiGian`, `maNV`, `tienDo`) VALUES ('" + txtMaKhoaDaoTao.Text + "', '" + txtTenKhoaDaoTao.Text + "', '" + timeBeginString + "', '" + txtThoiGian.Text + "', '" + txtMaNhanVien.Text + "', '" + txtTienDo.Text + "');";
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
            if (txtMaKhoaDaoTao.Text == String.Empty)
            {
                txtMaKhoaDaoTao.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã khóa đào tạo", "Thông báo");
            }
            else
            {
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT maKhoaDT FROM khoadaotao WHERE maKhoaDT = '" + txtMaKhoaDaoTao.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã khóa đào tạo không tồn tại!", "Cảnh báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            txtMaKhoaDaoTao.BackColor = SystemColors.Window;
                            dataAccess = new DataAccess();
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
                    DataTable dataTable = dataAccess.GetData("SELECT maKhoaDT FROM khoadaotao WHERE maKhoaDT = '" + txtMaKhoaDaoTao.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã khóa đào tạo không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {

                                string timeBeginString = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");

                                dataAccess = new DataAccess();
                                string query = "UPDATE `employeems`.`khoadaotao` SET `maKhoaDT` = '" + txtMaKhoaDaoTao.Text + "', `tenKhoaDT` = '" + txtTenKhoaDaoTao.Text + "', `ngayBatDau` = '" + timeBeginString + "', `thoiGian` = '" + txtThoiGian.Text + "', `maNV` = '" + txtMaNhanVien.Text + "', `tienDo` = '" + txtTienDo.Text + "' WHERE (`maKhoaDT` = '" + txtMaKhoaDaoTao.Text + "');";
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

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM khoadaotao WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyKhoaDaoTao.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyKhoaDaoTao.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='khoadaotao'";
            FormSearching fsearch = new FormSearching(query, 3);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }

        private void txtMaKhoaDaoTao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }
    }
}
