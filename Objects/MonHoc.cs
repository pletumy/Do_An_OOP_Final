using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    [Serializable]
    public class MonHoc : ISerializable
    {
        /* Ví dụ mã môn học
        * 2024:
        * 2024HK1TOAN10
        * 2024HK1TOAN11
        * 2024HK1TOAN12
        * 2023:
        * 2023HK1TOAN10
        * 2023HK2TOAN10
        * 2023HK1TOAN11
        * 2023HK2TOAN11
        * 2022:
        * 2022HK1TOAN10
        * 2022HK2TOAN10         
        */
        public string maNamHoc { get; set; } //NH2024
        public int tenNamHoc { get; set; }  //2024 2023 2022
        public string maHK { get; set; } //2024HK1
        public string tenHK { get; set; } //HK1 HK2
        public string maMonHoc { get; set; } //2024HK1TO10
        public string tenMonHoc { get; set; }  //TOAN10
        public string maGV { get; set; } //GVTOAN

        public MonHoc() { }
        public MonHoc(SerializationInfo info, StreamingContext context)
        {
            // Đọc dữ liệu từ SerializationInfo và khôi phục các thuộc tính của đối tượng Student
            maNamHoc = info.GetString("maNamHoc");
            tenNamHoc = info.GetInt32("tenNamHoc");
            maHK = info.GetString("maHK");
            tenHK = info.GetString("tenHK");
            maMonHoc = info.GetString("maMonHoc");
            tenMonHoc = info.GetString("tenMonHoc");
            maGV = info.GetString("maGV");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("maNamHoc", maNamHoc);
            info.AddValue("tenNamHoc", tenNamHoc);
            info.AddValue("maHK", maHK);
            info.AddValue("tenHK", tenHK);
            info.AddValue("maMonHoc", maMonHoc);
            info.AddValue("tenMonHoc", tenMonHoc);
            info.AddValue("maGV", maGV);
        }

    }
}
