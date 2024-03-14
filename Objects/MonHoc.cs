using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class MonHoc
    {
        private string maMonHoc { get; set; }
        private string tenMonHoc { get; set; }

        private string[] maLop { get; set; }

        public MonHoc(string maMonHoc, string tenMonHoc, string[] maLop)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.maLop = maLop;
        }
    }
}
