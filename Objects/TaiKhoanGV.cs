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

        public TaiKhoanGV()
        {
            // Initialize the list of teacher accounts
            teacherAccounts.Add(new GiaoVien { maGV = "GVTOAN", tenDangNhap = "userGVTOAN", matKhau = "passwordGVTOAN" });
            teacherAccounts.Add(new GiaoVien { maGV = "GVLY", tenDangNhap = "userGVLY", matKhau = "passwordGVLY" });
            // Add more teacher accounts here...
        }

        public void DangNhap(string tenDangNhap, string matKhau)
        {
            // Check if the entered login credentials match any of the teacher accounts
            GiaoVien matchedAccount = teacherAccounts.FirstOrDefault(account => account.tenDangNhap == tenDangNhap && account.matKhau == matKhau);

            if (matchedAccount != null)
            {
                // If the login credentials match a teacher account, open the corresponding form
                switch (matchedAccount.maGV)
                {
                    case "GVTOAN":
                        QuanLyDiem quanLyDiem = new QuanLyDiem();
                        quanLyDiem.ShowDialog();

                        break;
                    case "GVLY":
                        // Open the form for the literature teacher
                        break;
                    // Add more cases here for other teacher accounts...
                    default:
                        break;
                }
            }
            else
            {
                // If the login credentials do not match any teacher account, display an error message
                Console.WriteLine("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
    }
}