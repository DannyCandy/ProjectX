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
    public partial class FormSearching_LichLamViec : Form
    {
        private string queryDBToCbb = string.Empty;
        private string queryParam = string.Empty;
        private List<int> listDateIndex = new List<int>();
        public FormSearching_LichLamViec()
        {
            InitializeComponent();
        }

        public FormSearching_LichLamViec(string query, params int[] dateIndex)
        {
            InitializeComponent();
            queryDBToCbb = query;
            foreach (int num in dateIndex)
            {
                listDateIndex.Add(num);
            }
        }

        private void BindToComboboxField()
        {
            DataAccess dataAccess = new DataAccess();
            cbbTruongTimKiem.DataSource = dataAccess.GetData(queryDBToCbb);
            cbbTruongTimKiem.DisplayMember = "COLUMN_NAME";
            cbbTruongTimKiem.ValueMember = "COLUMN_NAME";
        }

        private void FormSearching_LichLamViec_Load(object sender, EventArgs e)
        {
            try
            {
                BindToComboboxField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể tải dữ liệu vào Trường tìm kiếm: " + ex.ToString(), "Thông báo");
            }
        }

        private bool isRequire()
        {
            bool isRequire = true;
            if (txtGiaTriTK.Text == string.Empty && txtGiaTriTK.Visible)
            {
                txtGiaTriTK.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtGiaTriTK.BackColor = SystemColors.Window;
            }
            if (cbbTruongTimKiem.SelectedIndex == -1)
            {
                cbbTruongTimKiem.BackColor = Color.Red;
                isRequire = false;
            }
            else
            {
                cbbTruongTimKiem.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        public string ResultSearching()
        {
            return queryParam;
        }

        private string isValid()
        {
            string message = "";
            if (dateTimePickerStart.Value >= dateTimePickerEnd.Value)
            {
                message += "Khoảng thời gian không hợp lệ!\n";

            }
            return message;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                if (listDateIndex.Contains(cbbTruongTimKiem.SelectedIndex))
                {
                    if (isValid() == "")
                    {
                        string timeStartString = dateTimePickerStart.Value.ToString("HH:mm:ss");
                        string timeEndString = dateTimePickerEnd.Value.ToString("HH:mm:ss");

                        queryParam = "`" + cbbTruongTimKiem.Text + "` BETWEEN '" + timeStartString + "' AND '" + timeEndString + "'";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(isValid(), "Cảnh báo");
                    }

                }
                else
                {
                    queryParam = "`" + cbbTruongTimKiem.Text + "` LIKE '%" + txtGiaTriTK.Text + "%'";
                    this.Close();
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTruongTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDateIndex.Contains(cbbTruongTimKiem.SelectedIndex))
            {
                lblStart.Visible = true;
                lblEnd.Visible = true;

                dateTimePickerStart.Visible = true;
                dateTimePickerEnd.Visible = true;

                lblValueSearch.Visible = false;
                txtGiaTriTK.Visible = false;

                // Thiết lập định dạng hiển thị thành 24 giờ
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "HH:mm:ss";

                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "HH:mm:ss";

                /*dateTimePickerStart.Value = DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                dateTimePickerEnd.Value = DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);*/
            }
            else
            {
                lblStart.Visible = false;
                lblEnd.Visible = false;

                dateTimePickerStart.Visible = false;
                dateTimePickerEnd.Visible = false;

                lblValueSearch.Visible = true;
                txtGiaTriTK.Visible = true;
            }
        }
    }
}
