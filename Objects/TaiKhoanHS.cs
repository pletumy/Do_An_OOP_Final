using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class TaiKhoanHS : ITaiKhoan
    {
        private List<HocSinh> studentAccounts = new List<HocSinh>();
        private static HocSinh currentUser;
        public TaiKhoanHS()
        {
            // Initialize the list of student accounts
            studentAccounts.Add(new HocSinh { maHS = "HS1", maLop = "2024L10A1", hoVaTenLot = "Hồ Ngọc", ten = "Hà", gioiTinh = 0, soDienThoai = "0215036840", tenDangNhap = "userHS1", matKhau = "passwordHS1" });
            studentAccounts.Add(new HocSinh { maHS = "HS2", maLop = "2024L10A1", hoVaTenLot = "Trấn", ten = "Thành", gioiTinh = 1, soDienThoai = "0203225675", tenDangNhap = "userHS2", matKhau = "passwordHS2" });
            // Add more student accounts here...
        }
        public void DangNhap(string tenDangNhap, string matKhau)
        {
            // Check if the entered login credentials match any of the teacher accounts
            bool isMatched = false;
            foreach (HocSinh account in studentAccounts)
            {
                if (account.tenDangNhap == tenDangNhap && account.matKhau == matKhau)
                {
                    isMatched = true;
                    currentUser = account;
                    break;
                }
            }

            if (!isMatched)
            {
                // If the login credentials do not match any teacher account, display an error message
                Console.WriteLine("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
        public static HocSinh CurrentUser
        {
            get { return currentUser; }
        }
    }
}