using MySql.Data.MySqlClient;
using QuanLyNhanSuApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormCaNhan_TTCaNhan : Form
    {
        private bool isFirstClick = false;
        private string querySelf = string.Empty;
        public FormCaNhan_TTCaNhan()
        {
            InitializeComponent();
        }

        public FormCaNhan_TTCaNhan(string query)
        {
            InitializeComponent();
            querySelf = query; 
        }

        private string ImageSrc = "";
        private void FormCaNhan_TTCaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView(querySelf);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
            }
            finally 
            {
                txtMaNV.ReadOnly = true;
                txtHoTen.ReadOnly = true;
                txtTonGiao.ReadOnly = true;
                txtQuocTich.ReadOnly = true;
                txtNoiSinh.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDanToc.ReadOnly = true;
                txtDcThuongTru.ReadOnly = true;
                txtDcTamTru.ReadOnly = true;
                txtHocVan.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                txtNguyenQuan.ReadOnly = true;

                btnUpdateImage.Visible = false;
            }
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            isFirstClick = !isFirstClick;
            if(!isFirstClick)
            {
                //Logic update
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
                                        DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật thông tin chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dialogResult == DialogResult.Yes)
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
                                        }
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
            }
                //Lock form

                btnSua.Text = "Chỉnh sửa";

                txtMaNV.ReadOnly = true;
                txtHoTen.ReadOnly = true;
                txtTonGiao.ReadOnly = true;
                txtQuocTich.ReadOnly = true;
                txtNoiSinh.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDanToc.ReadOnly = true;
                txtDcThuongTru.ReadOnly = true;
                txtDcTamTru.ReadOnly = true;
                txtHocVan.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                txtNguyenQuan.ReadOnly = true;

                btnUpdateImage.Visible = false;
            }
            else
            {
                btnSua.Text = "Cập nhật";

                //Open form
                txtMaNV.ReadOnly = false;
                txtHoTen.ReadOnly = false;
                txtTonGiao.ReadOnly = false;
                txtQuocTich.ReadOnly = false;
                txtNoiSinh.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtDanToc.ReadOnly = false;
                txtDcThuongTru.ReadOnly = false;
                txtDcTamTru.ReadOnly = false;
                txtHocVan.ReadOnly = false;
                txtGhiChu.ReadOnly = false;
                txtNguyenQuan.ReadOnly = false;

                btnUpdateImage.Visible = true;
            }
        }

        

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageSrc = ofd.FileName;
                pictureBoxAvt.ImageLocation = ofd.FileName;
            }
        }
        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM ttcanhan WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                txtMaNV.Text = dataTable.Rows[0]["maNV"].ToString();
                txtHoTen.Text = dataTable.Rows[0]["hoTen"].ToString();

                txtTonGiao.Text = dataTable.Rows[0]["tonGiao"].ToString();
                txtQuocTich.Text = dataTable.Rows[0]["quocTich"].ToString();
                txtNoiSinh.Text = dataTable.Rows[0]["noiSinh"].ToString();
                txtSDT.Text = dataTable.Rows[0]["sdt"].ToString();
                txtDanToc.Text = dataTable.Rows[0]["danToc"].ToString();

                txtDcThuongTru.Text = dataTable.Rows[0]["dCThuongTru"].ToString();
                txtDcTamTru.Text = dataTable.Rows[0]["dCTamTru"].ToString();
                txtHocVan.Text = dataTable.Rows[0]["hocVan"].ToString();
                txtGhiChu.Text = dataTable.Rows[0]["ghiChu"].ToString();
                txtNguyenQuan.Text = dataTable.Rows[0]["nguyenQuan"].ToString();

                // Lấy giá trị từ ô cột BLOB
                byte[] imageData = (byte[])dataTable.Rows[0]["anhDaiDien"];
                // Tạo đối tượng MemoryStream từ dữ liệu BLOB
                MemoryStream stream = new MemoryStream(imageData);
                // Tải hình ảnh từ MemoryStream lên PictureBox
                pictureBoxAvt.Image = Image.FromStream(stream);

            }
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
