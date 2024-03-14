using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class HocKy
    {
        private string maHK { get; set; }
        private string tenHK { get; set; }
        private NamHoc namHoc { get; set; }

        public HocKy(string maHK, string tenHK, NamHoc namHoc)
        {
            this.maHK = maHK;
            this.tenHK = tenHK;
            this.namHoc = namHoc;
        }
    }
}
