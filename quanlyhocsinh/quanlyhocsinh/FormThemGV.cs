﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyhocsinh
{
    public partial class FormThemGV : Form
    {
        public FormThemGV()
        {
            InitializeComponent();
        }

        private void Bt_themGV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
<<<<<<< HEAD
            string query = "INSERT INTO dbo.GIAOVIEN ( MAGIAOVIEN, HOTEN, GIOITINH, NGAYSINH, NOISINH, CHUYENMON, SODIENTHOAI ) " +
                "VALUES (@MAHOCSINH, @HOTEN, @GIOITINH, @NGAYSINH, @NOISINH, @CHUYENMON, @SODIENTHOAI )";
=======

            string query = "INSERT INTO dbo.GIAOVIEN ( MAGIAOVIEN, HOTEN, GIOITINH, NGAYSINH, NOISINH, CHUYENMON, SODIENTHOAI ) " +
                "VALUES (@MAHOCSINH, @HOTEN, @GIOITINH, @NGAYSINH, @NOISINH, @CHUYENMON, @SODIENTHOAI )";
            
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
            SqlCommand comm = new SqlCommand(query,conn);
//            comm.Connection = conn;
            comm.Parameters.AddWithValue("@MAHOCSINH", txt_magv.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToString());
            comm.Parameters.AddWithValue("@NOISINH", txt_noisinh.Text);
            comm.Parameters.AddWithValue("@CHUYENMON", txt_chuyenmon.Text);
            comm.Parameters.AddWithValue("@SODIENTHOAI", txt_sdt.Text);
            comm.ExecuteNonQuery();
<<<<<<< HEAD
            MessageBox.Show("Thêm thành công", "Thông báo");
=======

            MessageBox.Show("Thêm giao vien thành công", "Thông báo");
>>>>>>> f2abc71dc8bd6270e71659bbe7cdf2a5541c9b96
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            Formgiaovien fgv = new Formgiaovien();
            fgv.Show();
            this.Hide();
        }
    }
}
