using System;
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
    public partial class AccountGV : Form
    {
        public AccountGV()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string password = txtMatKhau.Text;
        }
        GiaoVien matchedAccount = null;

        private void AccountGV_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            TaiKhoanGV taiKhoanGV = new TaiKhoanGV();
            taiKhoanGV.DangNhap(username, password);

            if (TaiKhoanGV.CurrentUser != null)
            {
                // If the login credentials match a teacher account, open the corresponding form and pass the matched account to it
                QuanLyDiem quanLyDiem = new QuanLyDiem(TaiKhoanGV.CurrentUser);
                quanLyDiem.ShowDialog();
                this.Hide();
            }
            else
            {
                // If the login credentials do not match any teacher account, display an error message
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Hide();
        }
    }
}
