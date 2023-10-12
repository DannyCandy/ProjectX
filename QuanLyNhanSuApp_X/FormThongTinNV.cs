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
    public partial class FormThongTinNV : Form
    {

        private Font defaultFont = null;
        public FormThongTinNV()
        {
            InitializeComponent();
        }

        private void FormThongTinNV_Load(object sender, EventArgs e)
        {

            defaultFont = menuStripThongTin.Font;
            menuStripThongTin.Items[0].Select();
            menuStripThongTin.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);

            FormQuanLyNhanSu_ThongTinNV fttnv = new FormQuanLyNhanSu_ThongTinNV();
            panelThongTin.Show();
            panelThongTin.Controls.Clear();
            fttnv.TopLevel = false;
            fttnv.FormBorderStyle = FormBorderStyle.None;
            fttnv.WindowState = FormWindowState.Maximized;
            fttnv.Dock = DockStyle.Fill;
            panelThongTin.Controls.Add(fttnv);
            fttnv.Show();
        }

        private void TTCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripThongTin.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripThongTin.Items[1].Font = defaultFont;

            FormQuanLyNhanSu_ThongTinNV fttnv = new FormQuanLyNhanSu_ThongTinNV();
            panelThongTin.Show();
            panelThongTin.Controls.Clear();
            fttnv.TopLevel = false;
            fttnv.FormBorderStyle = FormBorderStyle.None;
            fttnv.WindowState = FormWindowState.Maximized;
            fttnv   .Dock = DockStyle.Fill;
            panelThongTin.Controls.Add(fttnv);
            fttnv.Show();
        }

        private void TTCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripThongTin.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripThongTin.Items[0].Font = defaultFont;

            FormQuanLyNhanSu_ThongTinCaNhan fttcn = new FormQuanLyNhanSu_ThongTinCaNhan();
            panelThongTin.Show();
            panelThongTin.Controls.Clear();
            fttcn.TopLevel = false;
            fttcn.FormBorderStyle = FormBorderStyle.None;
            fttcn.WindowState = FormWindowState.Maximized;
            fttcn.Dock = DockStyle.Fill;
            panelThongTin.Controls.Add(fttcn);
            fttcn.Show();
        }
    }
}
