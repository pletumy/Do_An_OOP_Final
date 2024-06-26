﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiet_ke.Objects;

namespace Thiet_ke
{
    public partial class AccountHS : Form
    {
        public AccountHS()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
        }

        private void AccountHS_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            TaiKhoanHS taiKhoanHS = new TaiKhoanHS();
            taiKhoanHS.DangNhap(username, password);

            if (TaiKhoanHS.CurrentUser != null)
            {
                // If the login credentials match a teacher account, open the corresponding form and pass the matched account to it
                XemDiem_HS xemDiem_HS = new XemDiem_HS(TaiKhoanHS.CurrentUser);
                xemDiem_HS.ShowDialog();
                this.Close();
            }
            else
            {
                // If the login credentials do not match any teacher account, display an error message
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
    }

