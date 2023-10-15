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
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyDonVi_BoPhan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyDonVi_BoPhan.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
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
            if (currentRow.Cells[2].Value.ToString().Equals(string.Empty))
            {
                return true;
            }
            return false;
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

        private string isValid()
        {
            string message = string.Empty;
            if (txtMaBoPhan.Text.Length > 10)
            {
                message += "Mã bộ phận chỉ chứa tối đa 10 chữ số\n";
            }
            if (txtTenBoPhan.Text.Length > 50)
            {
                message += "Tên bộ phận quá dài\n";
            }
            if (txtGhiChu.Text.Length > 50)
            {
                message += "Ghi chú quá dài\n";
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
                if(isValid() == "")
                {
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT maBoPhan FROM bophan WHERE maBoPhan = '" + txtMaBoPhan.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã bộ phận đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");

                            dataAccess = new DataAccess();
                            string query = "INSERT INTO `employeems`.`bophan` (`maBoPhan`, `tenBoPhan`, `ngayThanhLap`, `ghiChu`)" +
                                " VALUES ('" + txtMaBoPhan.Text + "', '" + txtTenBoPhan.Text + "', '" + timeThanhLapString + "', '" + txtGhiChu.Text + "');";
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
                else {
                    MessageBox.Show(isValid(), "Cảnh báo");
                }
                

            }
        }
        private void dgvFormQuanLyDonVi_BoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyDonVi_BoPhan.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyDonVi_BoPhan.SelectedRows[0]))
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
                DataAccess dataAccess = new DataAccess();
                DataTable dataTable = dataAccess.GetData("SELECT maBoPhan FROM bophan WHERE maBoPhan = '" + txtMaBoPhan.Text + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Mã bộ phận không tồn tại!", "Cảnh báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            txtMaBoPhan.BackColor = SystemColors.Window;
                            dataAccess = new DataAccess();
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
                    DataTable dataTable = dataAccess.GetData("SELECT maBoPhan FROM bophan WHERE maBoPhan = '" + txtMaBoPhan.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã bộ phận không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                string timeThanhLapString = dateTimePickerNgayThanhLap.Value.ToString("yyyy-MM-dd");


                                dataAccess = new DataAccess();
                                string query = "UPDATE `employeems`.`bophan` " +
                                    "SET `maBoPhan` = '" + txtMaBoPhan.Text + "', `tenBoPhan` = '" + txtTenBoPhan.Text + "', `ngayThanhLap` = '" + timeThanhLapString + "', `ghiChu` = '" + txtGhiChu.Text + "' WHERE (`maBoPhan` = '" + txtMaBoPhan.Text + "');";
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
            string query = "SELECT * FROM bophan WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyDonVi_BoPhan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyDonVi_BoPhan.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='bophan'";
            FormSearching fsearch = new FormSearching(query, 2);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }

        private void txtMaBoPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự được nhập vào
            }
        }
    }
}
