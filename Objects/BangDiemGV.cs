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
    public class BangDiemGV : BangDiem, ISerializable
    {
        //thực hiện thao tác chỉnh sửa nhập điểm
        public string maGiaoVien { get; set; }
        public string maLop { get; set; }


        protected override void xemBangDiem() { }
        //protected override void inBangDiem() { }
        public void chinhSuaBangDiem()
        {
        }
        public BangDiemGV()
        {
        }

        public BangDiemGV(SerializationInfo info, StreamingContext context)
        {
            maGiaoVien = info.GetString("maGiaoVien");
            maLop = info.GetString("maLop");
            diemGiuaKy = info.GetDouble("diemGiuaKy");
            diemCuoiKy = info.GetDouble("diemCuoiKy");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("maGiaoVien", diemGiuaKy);
            info.AddValue("maLop", diemGiuaKy);
            info.AddValue("diemGiuaKy", diemGiuaKy);
            info.AddValue("diemCuoiKy", diemCuoiKy);
        }
    }
}
