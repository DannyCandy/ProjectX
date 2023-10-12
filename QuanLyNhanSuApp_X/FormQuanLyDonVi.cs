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
    public partial class FormQuanLyDonVi : Form
    {

        private Font defaultFont = null;
        public FormQuanLyDonVi()
        {
            InitializeComponent();
        }

        private void FormQuanLyDonVi_Load(object sender, EventArgs e)
        {
            defaultFont = menuStripQuanLyDonVi.Font;
            menuStripQuanLyDonVi.Items[0].Select();
            menuStripQuanLyDonVi.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);

            FormQuanLyDonVi_PhongBan fphongban = new FormQuanLyDonVi_PhongBan();
            panelQuanLyDonVi.Show();
            panelQuanLyDonVi.Controls.Clear();
            fphongban.TopLevel = false;
            fphongban.FormBorderStyle = FormBorderStyle.None;
            fphongban.WindowState = FormWindowState.Maximized;
            fphongban.Dock = DockStyle.Fill;
            panelQuanLyDonVi.Controls.Add(fphongban);
            fphongban.Show();
        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            menuStripQuanLyDonVi.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyDonVi.Items[1].Font = defaultFont;

            FormQuanLyDonVi_PhongBan fphongban = new FormQuanLyDonVi_PhongBan();
            panelQuanLyDonVi.Show();
            panelQuanLyDonVi.Controls.Clear();
            fphongban.TopLevel = false;
            fphongban.FormBorderStyle = FormBorderStyle.None;
            fphongban.WindowState = FormWindowState.Maximized;
            fphongban.Dock = DockStyle.Fill;
            panelQuanLyDonVi.Controls.Add(fphongban);
            fphongban.Show();
        }

        private void boPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripQuanLyDonVi.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripQuanLyDonVi.Items[0].Font = defaultFont;

            FormQuanLyDonVi_BoPhan fbophan = new FormQuanLyDonVi_BoPhan();
            panelQuanLyDonVi.Show();
            panelQuanLyDonVi.Controls.Clear();
            fbophan.TopLevel = false;
            fbophan.FormBorderStyle = FormBorderStyle.None;
            fbophan.WindowState = FormWindowState.Maximized;
            fbophan.Dock = DockStyle.Fill;
            panelQuanLyDonVi.Controls.Add(fbophan);
            fbophan.Show();

        }
    }
}
