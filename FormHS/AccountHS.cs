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
    public partial class AccountHS : Form
    {
        public AccountHS()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;
            TaiKhoanHS taiKhoanHS = new TaiKhoanHS();
            taiKhoanHS.DangNhap(username, pass);
        }

        private void AccountHS_Load(object sender, EventArgs e)
        {

        }
    }
}
