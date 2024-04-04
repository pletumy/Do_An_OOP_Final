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

            // Ghi danh sách học sinh vào file JSON => 18 bạn, một lớp 3 bạn
            DSHocSinh dsHocSinh = new DSHocSinh();
            HocSinh[] hocSinhs = dsHocSinh.taoDSHocSinh();

            GhiFile(filePath, hocSinhs);

            // Đọc danh sách học sinh từ file JSON
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLyDiem());
            
        }
    }
}
