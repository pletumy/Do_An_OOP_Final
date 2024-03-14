using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Thiet_ke.Objects
{
    public class HocSinh : ConNguoi
    {
        private string maHS { get; set; }

        protected HocSinh(string maHS, string hoVaTenLot, string ten, bool gioiTinh, string soDienThoai, string tenDangNhap, string matKhau)
        {
            this.maHS = maHS;
            this.hoVaTenLot = hoVaTenLot;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
    }
}
