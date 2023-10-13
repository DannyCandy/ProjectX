using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormCheDo_ThaiSan : Form
    {
        private bool isSelf = false;
        private string selfQuery = string.Empty;
        public FormCheDo_ThaiSan()
        {
            InitializeComponent();
        }

        public FormCheDo_ThaiSan(string query)
        {
            InitializeComponent();
            isSelf = true;
            selfQuery = query;
        }


        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM thaisan";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyCheDo_ThaiSan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyCheDo_ThaiSan.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtTroCapCty.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            dateTimePickerNgayNghiSinh.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dateTimePickerNgayVeSom.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dateTimePickerNgayTroLaiLam.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            txtNgayTaoYeuCau.Text = string.Empty;
            txtMaThaiSan.Text = string.Empty;
        }

        private void FormCheDo_ThaiSan_Load(object sender, EventArgs e)
        {
            if (isSelf)
            {
                try
                {
                    BindToDataGridView(selfQuery);

                    // Thiết lập định dạng hiển thị thành 24 giờ
                    dateTimePickerNgayNghiSinh.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayNghiSinh.CustomFormat = "yyyy-MM-dd";

                    dateTimePickerNgayVeSom.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayVeSom.CustomFormat = "yyyy-MM-dd";

                    dateTimePickerNgayTroLaiLam.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayTroLaiLam.CustomFormat = "yyyy-MM-dd";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
                }
                finally
                {
                    ResetTextBox();
                    txtMaNV.ReadOnly = true;
                    txtTroCapCty.ReadOnly = true;
                    txtGhiChu.ReadOnly = true;
                    txtMaThaiSan.ReadOnly = true;

                    dateTimePickerNgayNghiSinh.Enabled = false;
                    dateTimePickerNgayVeSom.Enabled = false;
                    dateTimePickerNgayTroLaiLam.Enabled = false;

                    btnThem.Visible = false;
                    btnSua.Visible = false;
                    btnTraCuu.Visible = false;
                    btnXoa.Visible = false;
                }
            }
            else
            {
                try
                {
                    BindToDataGridView();

                    // Thiết lập định dạng hiển thị thành 24 giờ
                    dateTimePickerNgayNghiSinh.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayNghiSinh.CustomFormat = "yyyy-MM-dd";

                    dateTimePickerNgayVeSom.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayVeSom.CustomFormat = "yyyy-MM-dd";

                    dateTimePickerNgayTroLaiLam.Format = DateTimePickerFormat.Custom;
                    dateTimePickerNgayTroLaiLam.CustomFormat = "yyyy-MM-dd";
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

        private bool checkDateIsEmpty(DataGridViewRow currentRow)
        {
            if (currentRow.Cells[1].Value.ToString().Equals(string.Empty) 
                && currentRow.Cells[2].Value.ToString().Equals(string.Empty)
                && currentRow.Cells[3].Value.ToString().Equals(string.Empty))
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
            if (txtTroCapCty.Text == string.Empty)
            {
                txtTroCapCty.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtTroCapCty.BackColor = SystemColors.Window;
            }
            if (txtMaThaiSan.Text == string.Empty)
            {
                txtMaThaiSan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaThaiSan.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private void SetDefault()
        {
            if (txtTroCapCty.Text == string.Empty)
            {
                txtTroCapCty.Text = 0.ToString();
            }
            txtNgayTaoYeuCau.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void txtTroCapCty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string isValid()
        {
            string message = "";
            if (dateTimePickerNgayTroLaiLam.Value <= dateTimePickerNgayNghiSinh.Value)
            {
                
                message += "Ngày trở lại làm không thể tồn tại trước ngày nghỉ sinh!\n";
                
            }

            if (dateTimePickerNgayVeSom.Value <= dateTimePickerNgayNghiSinh.Value)
            {

                message += "Ngày về sớm làm không thể tồn tại trước ngày nghỉ sinh!\n";

            }

            if (dateTimePickerNgayVeSom.Value >= dateTimePickerNgayTroLaiLam.Value)
            {

                message += "Ngày về sớm phải tồn tại trước ngày trở lại làm!\n";

            }

            return message;
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
                    try
                    {


                        string timeNghiSinhString = dateTimePickerNgayNghiSinh.Value.ToString("yyyy-MM-dd");

                        string timeVeSomString = dateTimePickerNgayVeSom.Value.ToString("yyyy-MM-dd");

                        string timeTroLaiLamString = dateTimePickerNgayTroLaiLam.Value.ToString("yyyy-MM-dd");

                        DataAccess dataAccess = new DataAccess();
                        string query = "INSERT INTO `employeems`.`thaisan` (`maNV`, `ngayVeSom`, `ngayNghiSinh`, `ngayTroLaiLam`, `troCapCongTy`, `ghiChu`, `maThaiSan`, `ngayTaoYeuCau`) " +
                            "VALUES ('"+txtMaNV.Text+"', '"+timeVeSomString+"', '"+timeNghiSinhString+"', '"+timeTroLaiLamString+"', '"+txtTroCapCty.Text+"', '"+txtGhiChu.Text+"', '"+txtMaThaiSan.Text+"', '"+txtNgayTaoYeuCau.Text+"');";
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

        private void dgvFormQuanLyCheDo_ThaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormQuanLyCheDo_ThaiSan.Rows.Count > 0 && !checkDateIsEmpty(dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0]))
            {
                txtMaNV.Text = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[0].Value.ToString();

                DateTime parsedDateTimeNghiSinh;
                string timeNghiSinhString = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[2].Value.ToString();
                DateTime.TryParse(timeNghiSinhString, out parsedDateTimeNghiSinh);
                string formattedNghiSinhString = parsedDateTimeNghiSinh.ToString("yyyy-MM-dd");
                dateTimePickerNgayNghiSinh.Value = DateTime.ParseExact(formattedNghiSinhString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                DateTime parsedDateTimeVeSom;
                string timeVeSomString = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[1].Value.ToString();
                DateTime.TryParse(timeVeSomString, out parsedDateTimeVeSom);
                string formattedVeSomString = parsedDateTimeVeSom.ToString("yyyy-MM-dd");
                dateTimePickerNgayVeSom.Value = DateTime.ParseExact(formattedVeSomString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                DateTime parsedDateTimeTroLaiLam;
                string timeTroLaiLamString = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[3].Value.ToString();
                DateTime.TryParse(timeTroLaiLamString, out parsedDateTimeTroLaiLam);
                string formattedTroLaiLamString = parsedDateTimeTroLaiLam.ToString("yyyy-MM-dd");
                dateTimePickerNgayTroLaiLam.Value = DateTime.ParseExact(formattedTroLaiLamString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                txtTroCapCty.Text = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[4].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[5].Value.ToString();

                txtMaThaiSan.Text = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[6].Value.ToString();
                txtNgayTaoYeuCau.Text = dgvFormQuanLyCheDo_ThaiSan.SelectedRows[0].Cells[7].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThaiSan.Text == String.Empty)
            {
                txtMaThaiSan.BackColor = Color.Red;
                MessageBox.Show("Thao tác xóa cần ít nhất 1 trường Mã thai sản", "Thông báo");
            }
            else
            {
                try
                {
                    txtMaThaiSan.BackColor = SystemColors.Window;
                    DataAccess dataAccess = new DataAccess();
                    string query = "DELETE FROM `employeems`.`thaisan` WHERE (`maThaiSan` = '" + txtMaThaiSan.Text + "');";
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

                        string timeNghiSinhString = dateTimePickerNgayNghiSinh.Value.ToString("yyyy-MM-dd");

                        string timeVeSomString = dateTimePickerNgayVeSom.Value.ToString("yyyy-MM-dd");

                        string timeTroLaiLamString = dateTimePickerNgayTroLaiLam.Value.ToString("yyyy-MM-dd");


                        DataAccess dataAccess = new DataAccess();
                        string query = "UPDATE `employeems`.`thaisan` SET " +
                            "`maNV` = '"+txtMaNV.Text+"', " +
                            "`ngayVeSom` = '"+timeVeSomString+"', " +
                            "`ngayNghiSinh` = '"+timeNghiSinhString+"', " +
                            "`ngayTroLaiLam` = '"+timeTroLaiLamString+"', " +
                            "`troCapCongTy` = '"+txtTroCapCty.Text+"', " +
                            "`ghiChu` = '"+txtGhiChu.Text+"', " +
                            "`maThaiSan` = '"+txtMaThaiSan.Text+"', " +
                            "`ngayTaoYeuCau` = '"+txtNgayTaoYeuCau.Text+"' WHERE (`maThaiSan` = '"+txtMaThaiSan.Text+"');";
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

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM thaisan WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyCheDo_ThaiSan.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dgvFormQuanLyCheDo_ThaiSan.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvFormQuanLyCheDo_ThaiSan.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='thaisan'";
            FormSearching fsearch = new FormSearching(query, 3, 4, 5, 6);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }
    }
}
