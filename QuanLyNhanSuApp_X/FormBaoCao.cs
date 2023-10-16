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
        private string queryConditions = string.Empty;
        private string header = string.Empty;
        public FormBaoCao()
        {
            InitializeComponent();
            reportViewerBCCT.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerBCCT.ZoomPercent = 100;
            reportViewerBCCT.ZoomMode = ZoomMode.Percent;
        }

        public FormBaoCao(string conditions,string textHeader)
        {
            InitializeComponent();
            reportViewerBCCT.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerBCCT.ZoomPercent = 100;
            reportViewerBCCT.ZoomMode = ZoomMode.Percent;
            queryConditions = conditions;
            header = textHeader;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            string reportQuery = "SELECT bophan.tenBoPhan,phongban.tenPhong,tongSoNV,soNVRoiToChuc,thang,nam,ngayTaoBaoCao FROM employeems.baocaotinhtrangnhansu INNER JOIN phongban INNER JOIN bophan " +
                "ON phongban.maPhong = baocaotinhtrangnhansu.maPhong AND phongban.maBoPhan = bophan.maBoPhan" +
                queryConditions;
            reportViewerBCCT.LocalReport.DataSources.Clear();
            reportViewerBCCT.LocalReport.DataSources
                .Add(new ReportDataSource("BaoCaoCongTy",
                DataAccess.GetDataToDTS(reportQuery, "BaoCaoTheoThang").Tables[0]));
            
            reportViewerBCCT.LocalReport.ReportEmbeddedResource = "QuanLyNhanSuApp.BaoCao.rdlc";
            //Thiết kế dynamic Header
            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
                new ReportParameter("reportMonth", header)
            };
            reportViewerBCCT.LocalReport.SetParameters(reportParameters);
            reportViewerBCCT.RefreshReport();
        }
    }
}
