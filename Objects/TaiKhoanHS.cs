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
            // Khởi tạo DS học sinh
            studentAccounts.Add(new HocSinh { maHS = "HS1", maLop = "2024L10A1", hoVaTenLot = "Hồ Ngọc", ten = "Hà", gioiTinh = 0, soDienThoai = "0215036840", tenDangNhap = "userHS1", matKhau = "passwordHS1" });
            studentAccounts.Add(new HocSinh { maHS = "HS2", maLop = "2024L10A1", hoVaTenLot = "Trấn", ten = "Thành", gioiTinh = 1, soDienThoai = "0203225675", tenDangNhap = "userHS2", matKhau = "passwordHS2" });
        }
        public void DangNhap(string tenDangNhap, string matKhau)
        {
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
                Console.WriteLine("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
        public static HocSinh CurrentUser
        {
            get { return currentUser; }
        }
    }
}