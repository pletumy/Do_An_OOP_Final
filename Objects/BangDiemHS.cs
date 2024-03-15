using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class BangDiemHS : BangDiem
    {
        public string maHS { get; set; }

        protected BangDiemHS(string maHS, string maMonHoc, string tenMonHoc, string maLopHoc, double diemGiuaKy, double diemCuoiKy, double diemTongKet)
        {
            this.maHS = maHS;
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.maLopHoc = maLopHoc;
            this.diemGiuaKy = diemGiuaKy;
            this.diemCuoiKy = diemCuoiKy;
            this.diemTongKet = diemTongKet;
        }

        protected override void xemBangDiem() { }
        //protected override void inBangDiem() { }
    }
}
