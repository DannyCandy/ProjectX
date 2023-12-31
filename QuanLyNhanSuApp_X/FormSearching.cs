﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSuApp
{
    public partial class FormSearching : Form
    {
        private string queryDBToCbb = string.Empty;
        private string queryParam = string.Empty;
        private List<int> listDateIndex = new List<int>();
        public FormSearching()
        {
            InitializeComponent();
        }

        public FormSearching(string query,params int[] dateIndex)
        {
            InitializeComponent();
            queryDBToCbb = query;
            foreach (int num in dateIndex)
            {
                listDateIndex.Add(num);
            }
        }

        private void BindToComboboxField()
        {
            DataAccess dataAccess = new DataAccess();
            cbbTruongTimKiem.DataSource = dataAccess.GetData(queryDBToCbb);
            cbbTruongTimKiem.DisplayMember = "COLUMN_NAME";
            cbbTruongTimKiem.ValueMember = "COLUMN_NAME";
        }

        private void FormSearching_Load(object sender, EventArgs e)
        {
            try
            {
                BindToComboboxField();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi không thể tải dữ liệu vào Trường tìm kiếm: "+ex.ToString(), "Thông báo");
            }
        }
        
        private bool isRequire()
        {
            bool isRequire = true;
            if (txtGiaTriTK.Text == string.Empty && txtGiaTriTK.Visible)
            {
                txtGiaTriTK.BackColor = Color.Red;
                isRequire = false;

            }
            else
            {
                txtGiaTriTK.BackColor = SystemColors.Window;
            }
            if (cbbTruongTimKiem.SelectedIndex == -1)
            {
                cbbTruongTimKiem.BackColor = Color.Red;
                isRequire = false;
            }
            else
            {
                cbbTruongTimKiem.BackColor = SystemColors.Window;
            }
            return isRequire;
        }

        public string ResultSearching()
        {
            return queryParam;  
        }

        private string isValid()
        {
            string message = "";
            if (dateTimePickerFrom.Value >= dateTimePickerTo.Value)
            {
                message += "Khoảng thời gian không hợp lệ!\n";

            }
            return message;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isRequire())
            {
                MessageBox.Show("Vui lòng nhập thông tin vào các trường yêu cầu!", "Thông báo");
            }
            else
            {
                if(listDateIndex.Contains(cbbTruongTimKiem.SelectedIndex))
                {
                    if(isValid() == "")
                    {
                        queryParam = "`" + cbbTruongTimKiem.Text + "` BETWEEN '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd") + "'";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(isValid(), "Cảnh báo");
                    }
                    
                }
                else
                {
                    queryParam = "`" + cbbTruongTimKiem.Text + "` LIKE '%" + txtGiaTriTK.Text + "%'";
                    this.Close();
                }
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTruongTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDateIndex.Contains(cbbTruongTimKiem.SelectedIndex))
            {
                lblFrom.Visible = true;
                lblTo.Visible = true;

                dateTimePickerFrom.Visible = true;
                dateTimePickerTo.Visible = true;

                lblValueSearch.Visible = false;
                txtGiaTriTK.Visible = false;

                dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
                dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";

                dateTimePickerTo.Format = DateTimePickerFormat.Custom;
                dateTimePickerTo.CustomFormat = "yyyy-MM-dd";

                /*dateTimePickerFrom.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                dateTimePickerTo.Value = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);*/
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;

                dateTimePickerFrom.Visible = false;
                dateTimePickerTo.Visible = false;

                lblValueSearch.Visible = true;
                txtGiaTriTK.Visible = true;
            }
        }
    }
}
