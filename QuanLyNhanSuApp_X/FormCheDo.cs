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
    public partial class FormCheDo : Form
    {
        private Font defaultFont = null;
        public FormCheDo()
        {
            InitializeComponent();
        }

        

        private void FormCheDo_Load(object sender, EventArgs e)
        {
            defaultFont = menuStripCheDo.Font;
            menuStripCheDo.Items[0].Select();
            menuStripCheDo.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);

            FormCheDo_BaoHiem fbaohiem = new FormCheDo_BaoHiem();
            panelCheDo.Show();
            panelCheDo.Controls.Clear();
            fbaohiem.TopLevel = false;
            fbaohiem.FormBorderStyle = FormBorderStyle.None;
            fbaohiem.WindowState = FormWindowState.Maximized;
            fbaohiem.Dock = DockStyle.Fill;
            panelCheDo.Controls.Add(fbaohiem);
            fbaohiem.Show();
        }

        private void baoHiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCheDo.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCheDo.Items[1].Font = defaultFont;

            FormCheDo_BaoHiem fbaohiem = new FormCheDo_BaoHiem();
            panelCheDo.Show();
            panelCheDo.Controls.Clear();
            fbaohiem.TopLevel = false;
            fbaohiem.FormBorderStyle = FormBorderStyle.None;
            fbaohiem.WindowState = FormWindowState.Maximized;
            fbaohiem.Dock = DockStyle.Fill;
            panelCheDo.Controls.Add(fbaohiem);
            fbaohiem.Show();

        }

        private void thaiSanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCheDo.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCheDo.Items[0].Font = defaultFont;

            FormCheDo_ThaiSan fthaisan = new FormCheDo_ThaiSan();
            panelCheDo.Show();
            panelCheDo.Controls.Clear();
            fthaisan.TopLevel = false;
            fthaisan.FormBorderStyle = FormBorderStyle.None;
            fthaisan.WindowState = FormWindowState.Maximized;
            fthaisan.Dock = DockStyle.Fill;
            panelCheDo.Controls.Add(fthaisan);
            fthaisan.Show();

        }
    }
}
