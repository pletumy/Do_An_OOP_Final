using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Thiet_ke.Objects
{
    [Serializable]
    public class HocSinh : ConNguoi, ISerializable
    {
        public string maHS { get; set; }

        public HocSinh()
        {
        }
        /*
        public HocSinh(string maHS, string hoVaTenLot, string ten, int gioiTinh, string soDienThoai, string tenDangNhap, string matKhau)
        {
            this.maHS = maHS;
            this.hoVaTenLot = hoVaTenLot;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
        */
        public HocSinh(SerializationInfo info, StreamingContext context)
        {
            // Đọc dữ liệu từ SerializationInfo và khôi phục các thuộc tính của đối tượng Student
            maHS = info.GetString("maHS");
            hoVaTenLot = info.GetString("hoVaTenLot");
            ten = info.GetString("ten");
            gioiTinh = info.GetInt32("gioiTinh");
            soDienThoai = info.GetString("soDienThoai");
            tenDangNhap = info.GetString("tenDangNhap");
            matKhau = info.GetString("matKhau");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("maHS", maHS);
            info.AddValue("hoVaTenLot", hoVaTenLot);
            info.AddValue("ten", ten);
            info.AddValue("gioiTinh", gioiTinh);
            info.AddValue("soDienThoai", soDienThoai);
            info.AddValue("tenDangNhap", tenDangNhap);
            info.AddValue("matKhau", matKhau);
        }
    }
}
