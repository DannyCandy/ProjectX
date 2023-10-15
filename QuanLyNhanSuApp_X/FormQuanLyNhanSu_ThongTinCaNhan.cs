using MySql.Data.MySqlClient;
using QuanLyNhanSuApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyNhanSu_ThongTinCaNhan : Form
    {
        private string ImageSrc = "";
        private bool viewMode = false;
        public FormQuanLyNhanSu_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanSu_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();
                pictureBoxAvt.Image = Resources.DefaultAvt;
                
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
            string query = "SELECT * FROM ttcanhan";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTTCaNhan.DataSource = dataTable;
                // Đặt độ cao của mỗi dòng là 100
                dgvFormQuanLyTTCaNhan.RowTemplate.Height = 50;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol = (DataGridViewImageColumn)dgvFormQuanLyTTCaNhan.Columns[12];
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void ResetTextBox()
        {
            txtMaNV.Text = string.Empty;
            txtHoTen.Text = string.Empty;

            txtTonGiao.Text = string.Empty;
            txtQuocTich.Text = string.Empty;
            txtNoiSinh.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDanToc.Text = string.Empty;

            txtDcThuongTru.Text = string.Empty;
            txtDcTamTru.Text = string.Empty;
            txtHocVan.Text = string.Empty;
            txtNguyenQuan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            pictureBoxAvt.Image = Resources.DefaultAvt;
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (pictureBoxAvt == null)
            {
                pictureBoxAvt.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                pictureBoxAvt.BackColor = SystemColors.Window;
            }
            if (txtMaNV.Text == string.Empty)
            {
                txtMaNV.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtMaNV.BackColor = SystemColors.Window;
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
            if (txtDanToc.Text == string.Empty)
            {
                txtDanToc.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtDanToc.BackColor = SystemColors.Window;
            }
            if (txtQuocTich.Text == string.Empty)
            {
                txtQuocTich.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtQuocTich.BackColor = SystemColors.Window;
            }
            if (txtNoiSinh.Text == string.Empty)
            {
                txtNoiSinh.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtNoiSinh.BackColor = SystemColors.Window;
            }
            if (txtSDT.Text == string.Empty)
            {
                txtSDT.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtSDT.BackColor = SystemColors.Window;
            }

            if (txtDcTamTru.Text == string.Empty)
            {
                txtDcTamTru.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtDcTamTru.BackColor = SystemColors.Window;
            }
            if (txtDcThuongTru.Text == string.Empty)
            {
                txtDcThuongTru.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtDcThuongTru.BackColor = SystemColors.Window;
            }
            if (txtHocVan.Text == string.Empty)
            {
                txtHocVan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtHocVan.BackColor = SystemColors.Window;
            }
            if (txtNguyenQuan.Text == string.Empty)
            {
                txtNguyenQuan.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtNguyenQuan.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        private string isValid()
        {
            string message = string.Empty;
            if (txtMaNV.Text.Length > 10)
            {
                message += "Mã nhân viên chỉ chứa tối đa 10 chữ số\n";
            }
            if (txtHoTen.Text.Length > 50)
            {
                message += "Họ tên nhân viên quá dài\n";
            }
            if (txtTonGiao.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox tôn giáo\n";
            }
            if (txtQuocTich.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox quốc tịch\n";
            }
            if (txtNoiSinh.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox nơi sinh\n";
            }
            if (txtSDT.Text.Length != 10)
            {
                message += "Số điện thoại không hợp lệ\n";
            }
            if (txtDanToc.Text.Length > 20)
            {
                message += "Quá nhiều ký tự trong textbox dân tộc\n";
            }
            if (txtDcThuongTru.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox DC thường trú\n";
            }
            if (txtDcTamTru.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox DC tạm trú\n";
            }
            if (txtHocVan.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox học vấn\n";
            }
            if (txtNguyenQuan.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox nguyên quán\n";
            }
            if (txtGhiChu.Text.Length > 50)
            {
                message += "Quá nhiều ký tự trong textbox ghi chú\n";
            }
            return message;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                    DataAccess dataAccess = new DataAccess();
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttcanhan WHERE maNV = '" + txtMaNV.Text + "'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        try
                        {
                            if (ImageSrc == string.Empty)
                            {
                                if (viewMode)
                                {
                                    MessageBox.Show("Bạn đang xử dụng lại ảnh của đối tượng khác!", "Cảnh báo");
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn ảnh đại diện!", "Cảnh báo");
                                }

                            }
                            else
                            {
                                pictureBoxAvt.ImageLocation = ImageSrc;
                                /*byte[] img = null;
                                FileStream stream = new FileStream(ImageSrc, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(stream);
                                img = br.ReadBytes((int)stream.Length);*/
                                byte[] img;
                                using (FileStream stream = new FileStream(ImageSrc, FileMode.Open, FileAccess.Read))
                                {
                                    using (MemoryStream memoryStream = new MemoryStream())
                                    {
                                        stream.CopyTo(memoryStream);
                                        img = memoryStream.ToArray();
                                    }
                                }
                                string query = "INSERT INTO `employeems`.`ttcanhan` (`maNV`, `hoTen`, `noiSinh`, `nguyenQuan`, `dCThuongTru`, `dcTamTru`, `sdt`, `danToc`, `tonGiao`, `quocTich`, `hocVan`, `ghiChu`,`anhDaiDien`) " +
                                    "VALUES ('" + txtMaNV.Text + "', " +
                                    "'" + txtHoTen.Text + "', '" + txtNoiSinh.Text + "', " +
                                    "'" + txtNguyenQuan.Text + "', '" + txtDcThuongTru.Text + "', " +
                                    "'" + txtDcTamTru.Text + "', '" + txtSDT.Text + "', " +
                                    "'" + txtDanToc.Text + "', '" + txtTonGiao.Text + "', " +
                                    "'" + txtQuocTich.Text + "', '" + txtHocVan.Text + "', '" + txtGhiChu.Text + "',@pic);";


                                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=employeems;Uid=root;Pwd=123;");
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                connection.Open();
                                cmd.Parameters.AddWithValue("@pic", img);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Thêm thành công!", "Thông báo");
                                BindToDataGridView();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex, "Thông báo");

                        }
                        finally
                        {
                            ImageSrc = string.Empty;
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
                DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttcanhan WHERE maNV = '" + txtMaNV.Text + "'");
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
                            string query = "DELETE FROM `employeems`.`ttcanhan` WHERE (`maNV` = '" + txtMaNV.Text + "');";
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
                    DataTable dataTable = dataAccess.GetData("SELECT maNV FROM ttcanhan WHERE maNV = '" + txtMaNV.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Cảnh báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (ImageSrc == string.Empty)
                            {
                                try
                                {
                                        string query = "UPDATE `employeems`.`ttcanhan` SET " +
                                            "`maNV` = '" + txtMaNV.Text + "', " +
                                            "`hoTen` = '" + txtHoTen.Text + "', " +
                                            "`noiSinh` = '" + txtNoiSinh.Text + "', " +
                                            "`nguyenQuan` = '" + txtNguyenQuan.Text + "', " +
                                            "`dCThuongTru` = '" + txtDcThuongTru.Text + "', " +
                                            "`dcTamTru` = '" + txtDcTamTru.Text + "', " +
                                            "`sdt` = '" + txtSDT.Text + "', " +
                                            "`danToc` = '" + txtDanToc.Text + "', " +
                                            "`tonGiao` = '" + txtTonGiao.Text + "', " +
                                            "`quocTich` = '" + txtQuocTich.Text + "', " +
                                            "`hocVan` = '" + txtHocVan.Text + "', " +
                                            "`ghiChu` = '" + txtGhiChu.Text + "' " +
                                            "WHERE (`maNV` = '" + txtMaNV.Text + "');";

                                        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=employeems;Uid=root;Pwd=123;");
                                        connection.Open();
                                        MySqlCommand cmd = new MySqlCommand(query, connection);
                                        cmd.ExecuteNonQuery();
                                        connection.Close();
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
                                try
                                {
                                    DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật thông tin chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        pictureBoxAvt.ImageLocation = ImageSrc;
                                        /*byte[] img = null;
                                        FileStream stream = new FileStream(ImageSrc, FileMode.Open, FileAccess.Read);
                                        BinaryReader br = new BinaryReader(stream);
                                        img = br.ReadBytes((int)stream.Length);*/
                                        byte[] img;
                                        using (FileStream stream = new FileStream(ImageSrc, FileMode.Open, FileAccess.Read))
                                        {
                                            using (MemoryStream memoryStream = new MemoryStream())
                                            {
                                                stream.CopyTo(memoryStream);
                                                img = memoryStream.ToArray();
                                            }
                                        }

                                        string query = "UPDATE `employeems`.`ttcanhan` SET " +
                                            "`maNV` = '" + txtMaNV.Text + "', " +
                                            "`hoTen` = '" + txtHoTen.Text + "', " +
                                            "`noiSinh` = '" + txtNoiSinh.Text + "', " +
                                            "`nguyenQuan` = '" + txtNguyenQuan.Text + "', " +
                                            "`dCThuongTru` = '" + txtDcThuongTru.Text + "', " +
                                            "`dcTamTru` = '" + txtDcTamTru.Text + "', " +
                                            "`sdt` = '" + txtSDT.Text + "', " +
                                            "`danToc` = '" + txtDanToc.Text + "', " +
                                            "`tonGiao` = '" + txtTonGiao.Text + "', " +
                                            "`quocTich` = '" + txtQuocTich.Text + "', " +
                                            "`hocVan` = '" + txtHocVan.Text + "', " +
                                            "`ghiChu` = '" + txtGhiChu.Text + "', " +
                                            "`anhDaiDien` = @pic " +
                                            "WHERE (`maNV` = '" + txtMaNV.Text + "');";

                                        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=employeems;Uid=root;Pwd=123;");
                                        connection.Open();
                                        MySqlCommand cmd = new MySqlCommand(query, connection);

                                        cmd.Parameters.AddWithValue("@pic", img);
                                        cmd.ExecuteNonQuery();
                                        connection.Close();
                                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                                        BindToDataGridView();

                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi: " + ex, "Thông báo");

                                }
                                finally
                                {
                                    ImageSrc = string.Empty;
                                }
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

        private void dgvFormQuanLyTTCaNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewMode = true;
            //Chưa có blob image
            if (dgvFormQuanLyTTCaNhan.Rows.Count > 0)
            {
                txtMaNV.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[0].Value.ToString();
                txtHoTen.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[1].Value.ToString();

                txtTonGiao.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[8].Value.ToString();
                txtQuocTich.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[9].Value.ToString();
                txtNoiSinh.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[2].Value.ToString();
                txtSDT.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[6].Value.ToString();
                txtDanToc.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[7].Value.ToString();

                txtDcThuongTru.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[4].Value.ToString();
                txtDcTamTru.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[5].Value.ToString();
                txtHocVan.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[10].Value.ToString();
                txtGhiChu.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[11].Value.ToString();
                txtNguyenQuan.Text = dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[3].Value.ToString();

                // Lấy giá trị từ ô cột BLOB
                byte[] imageData = (byte[])dgvFormQuanLyTTCaNhan.SelectedRows[0].Cells[12].Value;
                // Tạo đối tượng MemoryStream từ dữ liệu BLOB
                MemoryStream stream = new MemoryStream(imageData);
                // Tải hình ảnh từ MemoryStream lên PictureBox
                pictureBoxAvt.Image = Image.FromStream(stream);
            }
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ImageSrc = ofd.FileName;
                pictureBoxAvt.ImageLocation = ofd.FileName;
            }
        }

        //Chuc nang tra cuu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM ttcanhan WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dgvFormQuanLyTTCaNhan.DataSource = dataTable;
                // Đặt độ cao của mỗi dòng là 100
                dgvFormQuanLyTTCaNhan.RowTemplate.Height = 50;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol = (DataGridViewImageColumn)dgvFormQuanLyTTCaNhan.Columns[12];
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
                "WHERE `TABLE_SCHEMA`='employeems' " +
                "AND `TABLE_NAME`='ttcanhan' " +
                "AND `COLUMN_NAME` <> 'anhDaiDien'";
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
