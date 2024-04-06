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
            string filePath_students = "students.json";
            string filePath_teachers = "teachers.json";
            string filePath_monHocs = "monHocs.json";
            string filePath_lophocs = "lophocs.json";

            // Ghi danh sách học sinh vào file JSON => 18 bạn, một lớp 3 bạn
            DSHocSinh dsHocSinh = new DSHocSinh();
            HocSinh[] hocSinhs = dsHocSinh.taoDSHocSinh();
            //Ghi danh sách giáo viên vào file JSON => 13 giáo viên, một giáo viên dạy một môn
            DSGiaoVien dSGiaoVien = new DSGiaoVien();
            GiaoVien[] giaoViens = dSGiaoVien.taoDSGiaoVien();
            //Ghi danh sách môn học vào file JSON => 13 môn học, nhưng chỉ lấy 2 môn của 1 khối thoy
            DSMonHoc dsMonHoc = new DSMonHoc();
            MonHoc[] monHocs = dsMonHoc.taoDSMonHoc();
            // Ghi danh sách lớp học vào file JSON => 6 bạn, 3 lớp 10, 2 lớp 11, 1 lớp 12
            DSLopHoc dsLopHoc = new DSLopHoc();
            LopHoc[] lophocs = dsLopHoc.taoDSLopHoc();

            GhiFile(filePath_students, hocSinhs);
            GhiFile(filePath_teachers, giaoViens);
            GhiFile(filePath_monHocs, monHocs);
            GhiFile(filePath_lophocs, lophocs);

            // Đọc danh sách học sinh từ file JSON
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath_students);
            GiaoVien[] danhSachGiaoViens = DocFile<GiaoVien[]>(filePath_teachers);
            MonHoc[] danhSachMonHocs = DocFile<MonHoc[]>(filePath_monHocs);
            LopHoc[] danhsachLopHocs = DocFile<LopHoc[]>(filePath_lophocs);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLyDiem());
            
        }
    }
}
