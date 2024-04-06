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

        public TaiKhoanHS()
        {
            // Initialize the list of student accounts
            studentAccounts.Add(new HocSinh { maHS = "HS1", tenDangNhap = "userHS1", matKhau = "passwordHS1" });
            studentAccounts.Add(new HocSinh { maHS = "HS2", tenDangNhap = "userHS2", matKhau = "passwordHS2" });
            studentAccounts.Add(new HocSinh { maHS = "HS3", tenDangNhap = "userHS3", matKhau = "passwordHS3" });
            // Add more student accounts here...
        }

        public void DangNhap(string tenDangNhap, string matKhau)
        {
            // Check if the entered login credentials match any of the student accounts
            HocSinh matchedAccount = studentAccounts.FirstOrDefault(account => account.tenDangNhap == tenDangNhap && account.matKhau == matKhau);

            if (matchedAccount != null)
            {
                // If the login credentials match a student account, open the corresponding form
                switch (matchedAccount.maHS)
                {
                    case "HS1":
                        XemDiem_HS xemDiem_HS = new XemDiem_HS();
                        xemDiem_HS.ShowDialog();
                        break;
                    case "HS2":
                        XemDiem_HS xemDiem_HS2 = new XemDiem_HS();
                        xemDiem_HS2.ShowDialog();
                        break;
                    case "HS3":
                        XemDiem_HS xemDiem_HS3 = new XemDiem_HS();
                        xemDiem_HS3.ShowDialog();
                        break;
                    // Add more cases here for other student accounts...
                    default:
                        break;
                }
            }
            else
            {
                // If the login credentials do not match any student account, display an error message
                Console.WriteLine("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
        }
    }
}