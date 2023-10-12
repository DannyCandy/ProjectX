using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSuApp
{
    public partial class FormSearching : Form
    {
        private string queryDBToCbb = string.Empty;
        private string queryParam = string.Empty;
        public FormSearching()
        {
            InitializeComponent();
        }

        public FormSearching(string query)
        {
            InitializeComponent();
            queryDBToCbb = query;
        }

        private void BindToComboboxField()
        {
            DataAccess dataAccess = new DataAccess();
            cbbTruongTimKiem.DataSource = dataAccess.GetData(queryDBToCbb);
            cbbTruongTimKiem.DisplayMember = "COLUMN_NAME";
            cbbTruongTimKiem.ValueMember = "COLUMN_NAME";
        }

        private void FormSearching_Load(object sender, EventArgs e)
        {
            try
            {
                BindToComboboxField();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi không thể tải dữ liệu vào Trường tìm kiếm: "+ex.ToString(), "Thông báo");
            }
        }
        
        private bool isRequire()
        {
            bool isRequire = true;
            if (txtGiaTriTK.Text == string.Empty)
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                queryParam = "`" + cbbTruongTimKiem.Text + "` LIKE '%" + txtGiaTriTK.Text + "%'";
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
