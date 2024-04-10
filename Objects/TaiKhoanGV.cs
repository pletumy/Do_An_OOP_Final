using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class TaiKhoanGV : ITaiKhoan
    {
        private List<GiaoVien> teacherAccounts = new List<GiaoVien>();
        private static GiaoVien currentUser;

        public TaiKhoanGV()
        {
            // Initialize the list of teacher accounts
            teacherAccounts.Add(new GiaoVien { maGV = "GVTOAN", hoVaTenLot = "Nguyễn Trường", ten = "An", gioiTinh = 1, soDienThoai = "0204019960", tenDangNhap = "userGVTOAN", matKhau = "passwordGVTOAN" });
            teacherAccounts.Add(new GiaoVien { maGV = "GVLY", hoVaTenLot = "Nguyễn Quang ", ten = "Anh", gioiTinh = 1, soDienThoai = "0230515773", tenDangNhap = "userGVLY", matKhau = "passwordGVLY" });
            // Add more teacher accounts here...
        }

        public void DangNhap(string tenDangNhap, string matKhau)
        {
            // Check if the entered login credentials match any of the teacher accounts
            GiaoVien matchedAccount = teacherAccounts.FirstOrDefault(account => account.tenDangNhap == tenDangNhap && account.matKhau == matKhau);

            if (matchedAccount != null)
            {
                // If the login credentials match a teacher account, set the current user to the matched account
                currentUser = matchedAccount;
            }
            else
            {
                // If the login credentials do not match any teacher account, display an error message
                Console.WriteLine("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
        public static GiaoVien CurrentUser
        {
            get { return currentUser; }
        }
    }
}