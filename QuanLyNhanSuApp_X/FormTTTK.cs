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
    public partial class FormTTTK : Form
    {
        public static string nameOfUser;
        public static string role;
        public static string idUser;
        public static string maNV;
        public FormTTTK()
        {
            InitializeComponent();
            txtTenTaiKhoan.Text = nameOfUser;
            txtQuyen.Text = role;
        }


    }
}
