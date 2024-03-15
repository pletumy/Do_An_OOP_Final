using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class BangDiemGV : BangDiem
    {
        //thực hiện thao tác chỉnh sửa nhập điểm
        public string maGiaoVien { get; set; }

        protected BangDiemGV(string maGV, string maMonHoc, string tenMonHoc, string maLopHoc, double diemGiuaKy, double diemCuoiKy, double diemTongKet)
        {
            this.maGiaoVien = maGV;
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.maLopHoc = maLopHoc;
            this.diemGiuaKy = diemGiuaKy;
            this.diemCuoiKy = diemCuoiKy;
            this.diemTongKet = diemTongKet;
        }

        protected override void xemBangDiem() { }
        //protected override void inBangDiem() { }
        public void chinhSuaBangDiem() { 
        }
    }
}
