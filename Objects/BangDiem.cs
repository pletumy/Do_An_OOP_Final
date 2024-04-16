using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public abstract class BangDiem
    {
        public string MonHoc;    //thay maMonHoc thành MonHoc vì 1 mã GV: GVTOAN có tới 3 mã MonHoc khác nhau. 
        public string maHK;
        public double diemGiuaKy;
        public double diemCuoiKy;
        public double diemTongKet;
        public static void GhiFile<T>(string filePath, T data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Đã ghi file JSON thành công.");
        }

        public static T DocFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }
            else
            {
                Console.WriteLine("File không tồn tại.");
                return default(T);
            }
        }
        public abstract void luuBangDiem(string filepath, string maHS, string maHK);
    }
}
