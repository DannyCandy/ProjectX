using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSuApp
{
    public partial class FormQuanLyNhanSu : Form
    {
        private Font defaultFont = null;
        public FormQuanLyNhanSu()
        {
            InitializeComponent();
            defaultFont = menuStripQuanLyNhanSu.Font;
            menuStripQuanLyNhanSu.Items[0].Select();
            menuStripQuanLyNhanSu.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyNhanSu.Items[1].Font = defaultFont;
            menuStripQuanLyNhanSu.Items[2].Font = defaultFont;

        }

        
        private void FormQuanLyNhanSu_Load(object sender, EventArgs e)
        {
                

            FormQuanLyNhanSu_BangCong fbangcong = new FormQuanLyNhanSu_BangCong();
            panelQuanLyNhanSu.Show();
            panelQuanLyNhanSu.Controls.Clear();
            fbangcong.TopLevel = false;
            fbangcong.FormBorderStyle = FormBorderStyle.None;
            fbangcong.WindowState = FormWindowState.Maximized;
            fbangcong.Dock = DockStyle.Fill;
            panelQuanLyNhanSu.Controls.Add(fbangcong);
            fbangcong.Show();


        }

        private void bangCongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripQuanLyNhanSu.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyNhanSu.Items[1].Font = defaultFont;
            menuStripQuanLyNhanSu.Items[2].Font = defaultFont;

            FormQuanLyNhanSu_BangCong fbangcong = new FormQuanLyNhanSu_BangCong();
            panelQuanLyNhanSu.Show();
            panelQuanLyNhanSu.Controls.Clear();
            fbangcong.TopLevel = false;
            fbangcong.FormBorderStyle = FormBorderStyle.None;
            fbangcong.WindowState = FormWindowState.Maximized;
            fbangcong.Dock = DockStyle.Fill;
            panelQuanLyNhanSu.Controls.Add(fbangcong);
            fbangcong.Show();

        }

        private void thongTinNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripQuanLyNhanSu.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyNhanSu.Items[0].Font = defaultFont;
            menuStripQuanLyNhanSu.Items[2].Font = defaultFont;

            FormThongTinNV fthongtin = new FormThongTinNV();
            panelQuanLyNhanSu.Show();
            panelQuanLyNhanSu.Controls.Clear();
            fthongtin.TopLevel = false;
            fthongtin.FormBorderStyle = FormBorderStyle.None;
            fthongtin.WindowState = FormWindowState.Maximized;
            fthongtin.Dock = DockStyle.Fill;
            panelQuanLyNhanSu.Controls.Add(fthongtin);
            fthongtin.Show();

        }

        private void nhanVienRoiToChucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripQuanLyNhanSu.Items[2].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyNhanSu.Items[0].Font = defaultFont;
            menuStripQuanLyNhanSu.Items[1].Font = defaultFont;

            FormQuanLyNhanSu_RoiDi fnvroidi = new FormQuanLyNhanSu_RoiDi();
            panelQuanLyNhanSu.Show();
            panelQuanLyNhanSu.Controls.Clear();
            fnvroidi.TopLevel = false;
            fnvroidi.FormBorderStyle = FormBorderStyle.None;
            fnvroidi.WindowState = FormWindowState.Maximized;
            fnvroidi.Dock = DockStyle.Fill;
            panelQuanLyNhanSu.Controls.Add(fnvroidi);
            fnvroidi.Show();

        }

        
    }
}
