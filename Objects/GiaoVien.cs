using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class GiaoVien : ConNguoi
    {
        private string maGV { get; set; }
        private MonHoc monHoc { get; } 
        private Lop[] DSLopHoc { get; set; }
        private TaiKhoanGV taiKhoanGV { get; set; }

        public GiaoVien(string maGV, MonHoc monHoc, Lop[] dSLopHoc, TaiKhoanGV taiKhoanGV, string hoVaTenLot, string ten, bool gioiTinh, string soDienThoai)
        {
            this.maGV = maGV;
            this.monHoc = monHoc;
            DSLopHoc = dSLopHoc;
            this.taiKhoanGV = taiKhoanGV;
            this.hoVaTenLot = hoVaTenLot;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
        }

    }
}
