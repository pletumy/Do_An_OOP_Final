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

        public GiaoVien(string maGV, string hoVaTenLot, string ten, int gioiTinh, string soDienThoai, string tenDangNhap, string matKhau)
        {
            this.maGV = maGV;
            this.hoVaTenLot = hoVaTenLot;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

    }
}
