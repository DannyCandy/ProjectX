using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanSuApp
{
    public partial class FormGiaoDienChinh : KryptonForm
    {
        /*public static string quyen;*/
        private bool forceExit = false;
        public FormGiaoDienChinh()
        {
            InitializeComponent();
       
        }

        private void FormGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason == CloseReason.UserClosing && !forceExit)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy sự kiện đóng form
                }
                else
                {
                    // Đóng ứng dụng
                    Application.Exit();
                }
            }
        }

        private void thongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTTTK ftttk = new FormTTTK();
            panelMain.Show();
            panelMain.Controls.Clear();
            ftttk.TopLevel = false;
            ftttk.FormBorderStyle = FormBorderStyle.None;
            ftttk.WindowState = FormWindowState.Maximized;
            ftttk.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ftttk);
            ftttk.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMK fdmk = new FormDoiMK();
            panelMain.Show();
            panelMain.Controls.Clear();
            fdmk.TopLevel = false;
            fdmk.FormBorderStyle = FormBorderStyle.None;
            fdmk.WindowState = FormWindowState.Maximized;
            fdmk.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fdmk);
            fdmk.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forceExit = true;
            FormLogin flg = new FormLogin();
            flg.Show();
            this.Close();
        }

        private void vePhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVePM fvpm = new FormVePM();
            panelMain.Show();
            panelMain.Controls.Clear();
            fvpm.TopLevel = false;
            fvpm.FormBorderStyle = FormBorderStyle.None;
            fvpm.WindowState = FormWindowState.Maximized;
            fvpm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fvpm);
            fvpm.Show();
        }

        private void quanLyLichLamViecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLichLamViec fqlllv = new FormQuanLyLichLamViec();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlllv.TopLevel = false;
            fqlllv.FormBorderStyle = FormBorderStyle.None;
            fqlllv.WindowState = FormWindowState.Maximized;
            fqlllv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlllv);
            fqlllv.Show();
        }

        private void quanLyNhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanSu fqlns = new FormQuanLyNhanSu();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlns.TopLevel = false;
            fqlns.FormBorderStyle = FormBorderStyle.None;
            fqlns.WindowState = FormWindowState.Maximized;
            fqlns.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlns);
            fqlns.Show();
        }

        private void quanLyLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLuong fqll = new FormQuanLyLuong();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqll.TopLevel = false;
            fqll.FormBorderStyle = FormBorderStyle.None;
            fqll.WindowState = FormWindowState.Maximized;
            fqll.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqll);
            fqll.Show();
        }

        private void quanLyHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyHopDong fqlhd = new FormQuanLyHopDong();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlhd.TopLevel = false;
            fqlhd.FormBorderStyle = FormBorderStyle.None;
            fqlhd.WindowState = FormWindowState.Maximized;
            fqlhd.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlhd);
            fqlhd.Show();
        }

        private void quanLyCheDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheDo fqlcd = new FormCheDo();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlcd.TopLevel = false;
            fqlcd.FormBorderStyle = FormBorderStyle.None;
            fqlcd.WindowState = FormWindowState.Maximized;
            fqlcd.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlcd);
            fqlcd.Show();
        }

        private void quanLyKhoaDaoTaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhoaDaoTao fqlkdt = new FormQuanLyKhoaDaoTao();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlkdt.TopLevel = false;
            fqlkdt.FormBorderStyle = FormBorderStyle.None;
            fqlkdt.WindowState = FormWindowState.Maximized;
            fqlkdt.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlkdt);
            fqlkdt.Show();
        }

        private void quanLyDonViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyDonVi fqldv = new FormQuanLyDonVi();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqldv.TopLevel = false;
            fqldv.FormBorderStyle = FormBorderStyle.None;
            fqldv.WindowState = FormWindowState.Maximized;
            fqldv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqldv);
            fqldv.Show();
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan fqltk = new FormQuanLyTaiKhoan();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqltk.TopLevel = false;
            fqltk.FormBorderStyle = FormBorderStyle.None;
            fqltk.WindowState = FormWindowState.Maximized;
            fqltk.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqltk);
            fqltk.Show();
        }

        private void caNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaNhan fqlcn = new FormCaNhan();
            panelMain.Show();
            panelMain.Controls.Clear();
            fqlcn.TopLevel = false;
            fqlcn.FormBorderStyle = FormBorderStyle.None;
            fqlcn.WindowState = FormWindowState.Maximized;
            fqlcn.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fqlcn);
            fqlcn.Show();
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormBaoCao fbc = new FormBaoCao();
            panelMain.Show();
            panelMain.Controls.Clear();
            fbc.TopLevel = false;
            fbc.FormBorderStyle = FormBorderStyle.None;
            fbc.WindowState = FormWindowState.Maximized;
            fbc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fbc);
            fbc.Show();*/

            FormQuanLyBaoCao fbc = new FormQuanLyBaoCao();
            panelMain.Show();
            panelMain.Controls.Clear();
            fbc.TopLevel = false;
            fbc.FormBorderStyle = FormBorderStyle.None;
            fbc.WindowState = FormWindowState.Maximized;
            fbc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fbc);
            fbc.Show();
        }

        private void FormGiaoDienChinh_Load(object sender, EventArgs e)
        {
            if(FormTTTK.role == "MANAGER")
            {
                quanLyHopDongToolStripMenuItem.Enabled = false;
                quanLyHopDongToolStripMenuItem.Visible = false;

                quanLyTaiKhoanToolStripMenuItem.Enabled = false;
                quanLyTaiKhoanToolStripMenuItem.Visible = false;
            }

            if (FormTTTK.role == "USER")
            {
                quanLyToolStripMenuItem.Visible = false;
                quanLyToolStripMenuItem.Enabled = false;

                baoCaoToolStripMenuItem.Visible = false;
                baoCaoToolStripMenuItem.Enabled = false;
            }
        }
    }
}
