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
    public partial class FormCaNhan : Form
    {
        private Font defaultFont = null;
        public FormCaNhan()
        {
            InitializeComponent();
            /*panelCheDoCaNhan.Visible = false;*/
            
        }

        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            dgvFormCaNhan.Visible = true;

            lblBaoHiem.Visible = false;
            lblThaiSan.Visible = false;
            dataGridViewBaoHiem.Visible=false;
            dataGridViewThaiSan.Visible=false;

            defaultFont = menuStripCaNhan.Font;
            menuStripCaNhan.Items[0].Select();
            menuStripCaNhan.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT lichlamviec.maLichLamViec,lichlamviec.thang,lichlamviec.nam,CONCAT('Các ngày trong tháng', IFNULL(CONCAT(' ngoại trừ ngày ', lichlamviec.ngayLamViec), '')) AS ngayLamViec,lichlamviec.gioVao,lichlamviec.gioRa,lichlamviec.caLamViec FROM employeems.lichlamviec WHERE maNV ='"+FormTTTK.maNV+"'";
            dgvFormCaNhan.DataSource = dataAccess.GetData(query);
        }

        private void lichLamViecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*panelCheDoCaNhan.Visible = false;*/
            dgvFormCaNhan.Visible = true;
            lblBaoHiem.Visible = false;
            lblThaiSan.Visible = false;
            dataGridViewBaoHiem.Visible = false;
            dataGridViewThaiSan.Visible = false;

            menuStripCaNhan.Items[0].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT lichlamviec.maLichLamViec,lichlamviec.thang,lichlamviec.nam,CONCAT('Các ngày trong tháng', IFNULL(CONCAT(' ngoại trừ ngày ', lichlamviec.ngayLamViec), '')) AS ngayLamViec,lichlamviec.gioVao,lichlamviec.gioRa,lichlamviec.caLamViec FROM employeems.lichlamviec WHERE maNV ='"+FormTTTK.maNV+"'";
            dgvFormCaNhan.DataSource = dataAccess.GetData(query);
        }

        private void cheDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*panelCheDoCaNhan.Visible = true;*/
            dgvFormCaNhan.Visible = false;
            lblBaoHiem.Visible = true;
            lblThaiSan.Visible = true;
            dataGridViewBaoHiem.Visible = true;
            dataGridViewThaiSan.Visible = true;

            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;

            DataAccess dataAccess = new DataAccess();
            string queryBaoHiem = "SELECT * FROM employeems.baohiem WHERE maNV = '"+FormTTTK.maNV+"'";
            string queryThaiSan = "SELECT * FROM employeems.thaisan WHERE maNV = '"+FormTTTK.maNV+"'";


            dataGridViewBaoHiem.DataSource = dataAccess.GetData(queryBaoHiem);
            dataGridViewThaiSan.DataSource = dataAccess.GetData(queryThaiSan);
            /*FormCheDo fqlcdCaNhan = new FormCheDo(FormTTTK.maNV);
            panelCheDoCaNhan.Controls.Clear();
            fqlcdCaNhan.TopLevel = false;
            fqlcdCaNhan.FormBorderStyle = FormBorderStyle.None;
            fqlcdCaNhan.WindowState = FormWindowState.Maximized;
            fqlcdCaNhan.Dock = DockStyle.Fill;
            panelCheDoCaNhan.Controls.Add(fqlcdCaNhan);
            fqlcdCaNhan.Show();*/


        }

        private void luongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*panelCheDoCaNhan.Visible = false;*/
            dgvFormCaNhan.Visible = true;
            lblBaoHiem.Visible = false;
            lblThaiSan.Visible = false;
            dataGridViewBaoHiem.Visible = false;
            dataGridViewThaiSan.Visible = false;

            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = defaultFont;
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT maNV,chucVu,phuCapKhac,phuCapChucVu,thuong,kyLuat,thang,nam,soNgayCong,soNgayNghi,soGioLamThem,bangluongcty.maLuong,luongCoBan,bangcongnhanviencoban.ghiChu,bangcongnhanviencoban.luong " +
                "FROM employeems.bangcongnhanviencoban " +
                "INNER JOIN employeems.bangluongcty " +
                "ON bangcongnhanviencoban.maLuong = bangluongcty.maLuong " +
                "WHERE bangcongnhanviencoban.maNV = '"+FormTTTK.maNV+"';";
            
            dgvFormCaNhan.DataSource = dataAccess.GetData(query);
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*panelCheDoCaNhan.Visible = false;*/
            dgvFormCaNhan.Visible = true;
            lblBaoHiem.Visible = false;
            lblThaiSan.Visible = false;
            dataGridViewBaoHiem.Visible = false;
            dataGridViewThaiSan.Visible = false;

            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            menuStripCaNhan.Items[4].Font = defaultFont;
            DataAccess dataAccess = new DataAccess();
            string query = "select phongban.tenPhong,bophan.tenBoPhan,ttnvcoban.ngaySinh,ttnvcoban.gioiTinh,ttnvcoban.ttHonNhan,ttnvcoban.CMND,ttnvcoban.noiCap,ttnvcoban.chucVu,ttcanhan.noiSinh,ttcanhan.nguyenQuan,ttcanhan.dCThuongTru,ttcanhan.dcTamTru,ttcanhan.sdt,ttcanhan.danToc,ttcanhan.tonGiao,ttcanhan.quocTich,ttcanhan.hocVan " +
                "from ttcanhan inner join ttnvcoban inner join phongban inner join bophan on ttnvcoban.maNV = ttcanhan.maNV and phongban.maPhong = ttnvcoban.maPhong and phongban.maBoPhan = bophan.maBoPhan where ttcanhan.maNV = '"+FormTTTK.maNV+"'";
            dgvFormCaNhan.DataSource = dataAccess.GetData(query);
        }

        private void khoaDaoTaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*panelCheDoCaNhan.Visible = false;*/
            dgvFormCaNhan.Visible = true;
            lblBaoHiem.Visible = false;
            lblThaiSan.Visible = false;
            dataGridViewBaoHiem.Visible = false;
            dataGridViewThaiSan.Visible = false;

            menuStripCaNhan.Items[0].Font = defaultFont;
            menuStripCaNhan.Items[1].Font = defaultFont;
            menuStripCaNhan.Items[2].Font = defaultFont;
            menuStripCaNhan.Items[3].Font = defaultFont;
            menuStripCaNhan.Items[4].Font = new Font(FontFamily.GenericSansSerif,
    12.0F, FontStyle.Bold);
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT khoadaotao.maKhoaDT,khoadaotao.tenKhoaDT,khoadaotao.ngayBatDau,khoadaotao.thoiGian,khoadaotao.tienDo,khoadaotao.daHoanThanh FROM employeems.ttnvcoban inner join khoadaotao on khoadaotao.maNV = ttnvcoban.maNV where khoadaotao.maNV ='"+FormTTTK.maNV+"'";
            dgvFormCaNhan.DataSource = dataAccess.GetData(query);
        }
    }
}
