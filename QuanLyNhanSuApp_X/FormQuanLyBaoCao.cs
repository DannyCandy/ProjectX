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
    public partial class FormQuanLyBaoCao : Form
    {
        private bool isExistReport = false;
        private static DateTime now = DateTime.Now;
        int thang = now.Month;
        int nam = now.Year;
        public FormQuanLyBaoCao()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = dataAccess.GetData("SELECT thang,nam FROM baocaotinhtrangnhansu WHERE thang = '" + thang.ToString() + "' AND nam = '"+ nam.ToString()+"'");
            if (dataTable.Rows.Count != 0)
            {
                isExistReport = true;
            }
        }

        private void BindToDataGridView()
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM baocaotinhtrangnhansu";
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dataGridViewReport.DataSource = dataTable;
                // Đặt định dạng hiển thị cho cột ngày (indexColumn là chỉ số cột trong DataGridView)
                dataGridViewReport.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            }
        }

        private void WhenReportExist()
        {
            if (isExistReport)
            {
                btnTaoBaoCao.Text = "Cập nhật báo cáo";
            }
            else
            {
                btnTaoBaoCao.Text = "Tạo báo cáo";
            }
        }

        private void FormQuanLyBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                BindToDataGridView();
                WhenReportExist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu Datagridview. Error: " + ex.Message);
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess dataAccess = new DataAccess();
                /*string query = "DELETE FROM baocaotinhtrangnhansu WHERE thang = '" + thang + "' AND nam = '" + nam + "'";
                dataAccess.DeleteData(query);*/

                //Lấy mã tất cả phòng ban
                string queryPhongBan = "SELECT maPhong FROM phongban";
                DataTable dataTable = dataAccess.GetData(queryPhongBan);

                // Tạo một danh sách để lưu giá trị mã phòng
                List<string> maPhongList = new List<string>();

                // Lặp qua từng dòng trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row["maPhong"].ToString();
                    maPhongList.Add(value);
                }
                if (!isExistReport)
                {
                    foreach (string valueList in maPhongList)
                    {
                        string queryInsert = "INSERT INTO baocaotinhtrangnhansu (maPhong) VALUES ('" + valueList + "');";
                        dataAccess.InsertData(queryInsert);
                    }
                    BindToDataGridView();
                    isExistReport = true;
                }
                else
                {
                    foreach (string valueList in maPhongList)
                    {
                        string queryUpdate = "UPDATE baocaotinhtrangnhansu SET `maPhong` = '"+valueList+"' WHERE maPhong = '"+valueList+"' AND thang = '"+thang+"' AND nam = '"+nam+"';";
                        dataAccess.UpdateData(queryUpdate);
                    }
                    BindToDataGridView();
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Lỗi");
            }
            finally
            {
                WhenReportExist();
            }
            
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT nam FROM baocaotinhtrangnhansu";
            FormChonBaoCao fchonbaocao = new FormChonBaoCao(query);
            fchonbaocao.ShowDialog();
        }

        //Chức năng tra cứu
        private string fieldValue = string.Empty;

        private void BindToDataGridView(string queryCondition)
        {
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT * FROM baocaotinhtrangnhansu WHERE " + queryCondition;
            DataTable dataTable = dataAccess.GetData(query);
            if (dataTable != null)
            {
                dataGridViewReport.DataSource = dataTable;
            }
        }
        private void FormSearchClosed(object sender, FormClosedEventArgs e)
        {
            FormSearching fsearch = sender as FormSearching;
            if (fsearch != null)
            {
                fieldValue = fsearch.ResultSearching();
            }

            if (fieldValue.Equals(string.Empty))
            {
                BindToDataGridView();
            }
            else
            {
                Console.WriteLine(fieldValue.ToString());
                BindToDataGridView(fieldValue);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string query = "SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS` " +
                "WHERE `TABLE_SCHEMA`='employeems' AND `TABLE_NAME`='baocaotinhtrangnhansu'";
            FormSearching fsearch = new FormSearching(query,3);
            fsearch.FormClosed += FormSearchClosed;
            fsearch.ShowDialog();
        }
    }
}
