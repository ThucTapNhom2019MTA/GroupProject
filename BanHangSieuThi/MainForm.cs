﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuanLyND_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung userForm = new QuanLyNguoiDung();
            this.Hide();
            userForm.ShowDialog();
            this.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang form = new NhapHang();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnNhapHangCu_Click(object sender, EventArgs e)
        {
            NhapHangCu form = new NhapHangCu();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            BanHang form = new BanHang();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem form = new TimKiem();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnThongKeHang_Click(object sender, EventArgs e)
        {
            ThongKe form = new ThongKe();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            QuanLiNhanVien form = new QuanLiNhanVien();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnQlnd_Click(object sender, EventArgs e)
        {
            ManageAcount form = new ManageAcount();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            KhachHang form = new KhachHang();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
