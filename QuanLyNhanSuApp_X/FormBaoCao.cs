using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuApp
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
            reportViewerBCCT.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerBCCT.ZoomPercent = 100;
            reportViewerBCCT.ZoomMode = ZoomMode.Percent;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            reportViewerBCCT.LocalReport.DataSources.Clear();
            /*reportViewerBCCT.LocalReport.DataSources
                .Add(new ReportDataSource("BaoCaoCongTy", 
                DataAccess.GetDataToDTS("SELECT * FROM employeems.baocaotinhtrangnhansu", "BaoCao").Tables[0]));*/
            reportViewerBCCT.LocalReport.DataSources
                .Add(new ReportDataSource("BaoCaoCongTy",
                DataAccess.GetDataToDTS("SELECT bophan.tenBoPhan,phongban.tenPhong,tongSoNV,soNVRoiToChuc,thang,nam,ngayTaoBaoCao FROM employeems.baocaotinhtrangnhansu INNER JOIN phongban INNER JOIN bophan " +
                "ON phongban.maPhong = baocaotinhtrangnhansu.maPhong AND phongban.maBoPhan = bophan.maBoPhan", "BaoCao").Tables[0]));
            reportViewerBCCT.LocalReport.ReportEmbeddedResource = "QuanLyNhanSuApp.BaoCao.rdlc";
            reportViewerBCCT.RefreshReport();
            
        }
    }
}
