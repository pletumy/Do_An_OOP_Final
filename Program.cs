using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Thiet_ke.Objects;

namespace Thiet_ke
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void GhiFile<T>(string filePath, T data)
        {
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Đã ghi file JSON thành công.");
        }

        static T DocFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                T data = JsonConvert.DeserializeObject<T>(json);
                Console.WriteLine("Đã đọc file JSON thành công.");
                return data;
            }
            else
            {
                Console.WriteLine("File không tồn tại.");
                return default(T);
            }
        }
        static void Main()
        {
            string filePath = "students.json";

            // Ghi danh sách học sinh vào file JSON
            HocSinh[] hocSinhs = new HocSinh[]
            {
            new HocSinh { maHS = "HS001", hoVaTenLot = "Nguyen Van", ten = "A", gioiTinh = 1, soDienThoai = "123456789", tenDangNhap = "user1", matKhau = "password1" },
            new HocSinh { maHS = "HS002", hoVaTenLot = "Tran Thi", ten = "B", gioiTinh = 0, soDienThoai = "987654321", tenDangNhap = "user2", matKhau = "password2" }
            };
            GhiFile(filePath, hocSinhs);

            // Đọc danh sách học sinh từ file JSON
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);

            // In danh sách học sinh đã được đọc
            Console.WriteLine("\nDanh sách học sinh:");
            foreach (HocSinh hocSinh in danhSachHocSinhs)
            {
                Console.WriteLine("Mã HS: " + hocSinh.maHS);
                Console.WriteLine("Họ và tên lót: " + hocSinh.hoVaTenLot);
                Console.WriteLine("Tên: " + hocSinh.ten);
                Console.WriteLine("Giới tính: " + hocSinh.gioiTinh);
                Console.WriteLine("Số điện thoại: " + hocSinh.soDienThoai);
                Console.WriteLine("Tên đăng nhập: " + hocSinh.tenDangNhap);
                Console.WriteLine("Mật khẩu: " + hocSinh.matKhau);
                Console.WriteLine();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLyDiem());
            
        }
    }
}
