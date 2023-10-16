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
    public partial class FormChonBaoCao : Form
    {
        public FormChonBaoCao()
        {
            InitializeComponent();
        }

        private string queryParam = string.Empty;
        private string queryDBToCbb = string.Empty;

        public FormChonBaoCao(string query)
        {
            InitializeComponent();
            queryDBToCbb = query;
        }

        private void BindToComboboxField(string query)
        {
            DataAccess dataAccess = new DataAccess();
            cbbNam.DataSource = dataAccess.GetData(query);
            cbbNam.DisplayMember = "nam";
            cbbNam.ValueMember = "nam";
        }
        private void FormChonBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                BindToComboboxField(queryDBToCbb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể tải dữ liệu vào combobox năm: " + ex.ToString(), "Thông báo");
            }
        }
        private bool isRequire()
        {
            bool isRequire = true;
            if (cbbThang.SelectedIndex == -1)
            {
                cbbThang.BackColor = Color.Red;
                isRequire = false;
            }
            else
            {
                cbbThang.BackColor = SystemColors.Window;
            }
            if (cbbNam.SelectedIndex == -1)
            {
                cbbNam.BackColor = Color.Red;
                isRequire = false;
            }
            else
            {
                cbbNam.BackColor = SystemColors.Window;
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
                queryParam = " thang = '"+cbbThang.SelectedItem.ToString()+"' AND nam = '"+cbbNam.SelectedValue.ToString()+"'";
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
