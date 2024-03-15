using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class HocKy
    {
        private string maHK { get; set; } //2024HK1
        private string tenHK { get; set; } //HK1 -> 
        private string maNamHoc { get; set; } //NH2024

        public HocKy(string maHK, string tenHK, string maNamHoc)
        {
            this.maHK = maHK;
            this.tenHK = tenHK;
            this.maNamHoc = maNamHoc;
        }
    }
}
