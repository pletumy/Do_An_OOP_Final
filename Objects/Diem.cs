using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Thiet_ke.Objects
{
    public class Diem : ISerializable
    {
        private double diemGiuaKy {  get; set; }
        private double diemCuoiKy { get; set; }
        private double diemTongKet { get; set; }

        public Diem()
        {
        }

        public Diem(SerializationInfo info, StreamingContext context)
        {
            // Đọc dữ liệu từ SerializationInfo và khôi phục các thuộc tính của đối tượng Student
            diemGiuaKy = info.GetDouble("diemGiuaKy");
            diemCuoiKy = info.GetDouble("diemCuoiKy");
            diemTongKet = info.GetDouble("diemTongKet");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("diemGiuaKy", diemGiuaKy);
            info.AddValue("diemCuoiKy",diemCuoiKy);
            info.AddValue("diemTongKet", diemTongKet);
        }
    }
}
