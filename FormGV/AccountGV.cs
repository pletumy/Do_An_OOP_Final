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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            TaiKhoanGV taiKhoanGV = new TaiKhoanGV();
            taiKhoanGV.DangNhap(username, password);
        }

        private void AccountGV_Load(object sender, EventArgs e)
        {

        }
    }
}
