using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    [Serializable]
    public class LopHoc: ISerializable
    {
        /* 
         * 1 năm => 6 Lớp
         * mỗi khối 2 lớp:
         * mỗi Lớp 3HS thoi
         * Lớp 10: 2L
         * Lớp 11: 2L
         * Lớp 12: 2L
         */
        public string maLop { get; set; } //2024L10A1; 2024L10A2;
        public string tenLop { get; set; } //10A1
       // public string maMonHoc { get; set; } //
        public int tenNamHoc { get; set; }  //2024 2023 2022
        public string tenHK { get; set; } 
        //public string maGV { get; set; } 

        public LopHoc()
        {
        }
        public LopHoc(SerializationInfo info, StreamingContext context)
        {
            // Đọc dữ liệu từ SerializationInfo và khôi phục các thuộc tính của đối tượng Student
            maLop = info.GetString("maLop");
            tenLop = info.GetString("tenLop");
            tenHK = info.GetString("tenHK");
            tenNamHoc = info.GetInt32("tenNamHoc");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("maLop", maLop);
            info.AddValue("tenLop", tenLop);
            info.AddValue("tenHK", tenHK);
            info.AddValue("tenNamHoc", tenNamHoc);
        }
        public static void XoaLop(List<LopHoc> danhSachLopHocs, string maLop, string tenHK) //Dùng cho xoá, sửa lớp
        {
            danhSachLopHocs.RemoveAll(lh => lh.maLop == maLop && lh.tenHK == tenHK);
        }

    }
}
