using ComponentFactory.Krypton.Toolkit;
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

namespace QuanLyNhanSuApp
{
    public partial class FormCaNhan : Form
    {
        private Font defaultFont = null;
        public FormCaNhan()
        {
            InitializeComponent();
            defaultFont = menuStripCaNhan.Font;
            menuStripCaNhan.Items[0].Select();
            menuStripCaNhan.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;
        }

        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormQuanLyLichLamViec fqlllv = new FormQuanLyLichLamViec(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fqlllv.TopLevel = false;
            fqlllv.FormBorderStyle = FormBorderStyle.None;
            fqlllv.WindowState = FormWindowState.Maximized;
            fqlllv.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fqlllv);
            fqlllv.Show();
        }

        private void lichLamViecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCaNhan.Items[0].Select();
            menuStripCaNhan.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;

            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormQuanLyLichLamViec fqlllv = new FormQuanLyLichLamViec(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fqlllv.TopLevel = false;
            fqlllv.FormBorderStyle = FormBorderStyle.None;
            fqlllv.WindowState = FormWindowState.Maximized;
            fqlllv.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fqlllv);
            fqlllv.Show();
        }

        private void cheDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Select();
            menuStripCaNhan.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;

            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormCheDo fchedo = new FormCheDo(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fchedo.TopLevel = false;
            fchedo.FormBorderStyle = FormBorderStyle.None;
            fchedo.WindowState = FormWindowState.Maximized;
            fchedo.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fchedo);
            fchedo.Show();
        }

        private void luongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Select();
            menuStripCaNhan.Items[2].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;

            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormQuanLyNhanSu_BangCong fcong = new FormQuanLyNhanSu_BangCong(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fcong.TopLevel = false;
            fcong.FormBorderStyle = FormBorderStyle.None;
            fcong.WindowState = FormWindowState.Maximized;
            fcong.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fcong);
            fcong.Show();
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Select();
            menuStripCaNhan.Items[3].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[4].Font = defaultFont;

            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormCaNhan_TTCaNhan fkdt = new FormCaNhan_TTCaNhan(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fkdt.TopLevel = false;
            fkdt.FormBorderStyle = FormBorderStyle.None;
            fkdt.WindowState = FormWindowState.Maximized;
            fkdt.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fkdt);
            fkdt.Show();
        }

        private void khoaDaoTaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Select();
            menuStripCaNhan.Items[4].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);

            string query = "`maNV` = '" + FormTTTK.maNV + "'";

            FormQuanLyKhoaDaoTao fkdt = new FormQuanLyKhoaDaoTao(query);
            panelFormCaNhan.Show();
            panelFormCaNhan.Controls.Clear();
            fkdt.TopLevel = false;
            fkdt.FormBorderStyle = FormBorderStyle.None;
            fkdt.WindowState = FormWindowState.Maximized;
            fkdt.Dock = DockStyle.Fill;
            panelFormCaNhan.Controls.Add(fkdt);
            fkdt.Show();
        }
    }
}
