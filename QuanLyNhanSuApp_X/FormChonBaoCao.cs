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

        private string queryDBToCbbNam = string.Empty;
        private string queryDBToCbbThang = string.Empty;

        public FormChonBaoCao(string query1, string query2)
        {
            InitializeComponent();
            queryDBToCbbNam = query1;
            queryDBToCbbThang = query2;
        }

        private void BindToComboboxField(string queryNam,string queryThang)
        {
            DataAccess dataAccess = new DataAccess();
            cbbNam.DataSource = dataAccess.GetData(queryNam);
            cbbNam.DisplayMember = "nam";
            cbbNam.ValueMember = "nam";

            cbbThang.DataSource = dataAccess.GetData(queryThang);
            cbbThang.DisplayMember = "thang";
            cbbThang.ValueMember = "thang";
        }
        private void FormChonBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                BindToComboboxField(queryDBToCbbNam,queryDBToCbbThang);
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                string queryParam = " WHERE thang = '"+cbbThang.SelectedValue.ToString()+"' AND nam = '"+cbbNam.SelectedValue.ToString()+"'";
                string textHeader = "Báo cáo tổng quan tình hình nhân sự tháng "+ cbbThang.SelectedValue.ToString();
                FormBaoCao fbc = new FormBaoCao(queryParam,textHeader);
                fbc.ShowDialog();
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
