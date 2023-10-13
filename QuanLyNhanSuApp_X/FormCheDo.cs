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
        private string selfQuery = string.Empty;
        private bool isSelf = false;
        public FormCheDo()
        {
            InitializeComponent();
        }

        public FormCheDo(string query)
        {
            InitializeComponent();
            selfQuery = query;
            isSelf = true;
        }

        private void FormCheDo_Load(object sender, EventArgs e)
        {
            defaultFont = menuStripCheDo.Font;
            menuStripCheDo.Items[0].Select();
            menuStripCheDo.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);

            if (isSelf)
            {
                FormCheDo_BaoHiem fbaohiem = new FormCheDo_BaoHiem(selfQuery);
                panelCheDo.Show();
                panelCheDo.Controls.Clear();
                fbaohiem.TopLevel = false;
                fbaohiem.FormBorderStyle = FormBorderStyle.None;
                fbaohiem.WindowState = FormWindowState.Maximized;
                fbaohiem.Dock = DockStyle.Fill;
                panelCheDo.Controls.Add(fbaohiem);
                fbaohiem.Show();
            }
            else
            {
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
        }

        private void baoHiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCheDo.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCheDo.Items[1].Font = defaultFont;

            if (isSelf)
            {
                FormCheDo_BaoHiem fbaohiem = new FormCheDo_BaoHiem(selfQuery);
                panelCheDo.Show();
                panelCheDo.Controls.Clear();
                fbaohiem.TopLevel = false;
                fbaohiem.FormBorderStyle = FormBorderStyle.None;
                fbaohiem.WindowState = FormWindowState.Maximized;
                fbaohiem.Dock = DockStyle.Fill;
                panelCheDo.Controls.Add(fbaohiem);
                fbaohiem.Show();
            }
            else
            {
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
        }

        private void thaiSanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripCheDo.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCheDo.Items[0].Font = defaultFont;

            if (isSelf)
            {
                FormCheDo_ThaiSan fthaisan = new FormCheDo_ThaiSan(selfQuery);
                panelCheDo.Show();
                panelCheDo.Controls.Clear();
                fthaisan.TopLevel = false;
                fthaisan.FormBorderStyle = FormBorderStyle.None;
                fthaisan.WindowState = FormWindowState.Maximized;
                fthaisan.Dock = DockStyle.Fill;
                panelCheDo.Controls.Add(fthaisan);
                fthaisan.Show();
            }
            else
            {
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
}
