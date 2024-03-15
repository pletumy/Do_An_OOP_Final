using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class LopHoc
    {
        private string maLop { get; set; }
        private string tenLop { get; set; }
        private string maMonHoc { get; set; }
        private string maNamHoc { get; set; }   
        private string maHocKy { get; set ; }
        private string maGV { get; set; }

        public LopHoc(string maLop, string tenLop, string maMonHoc, string maHocKy, string maGV)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maMonHoc = maMonHoc;
            this.maHocKy = maHocKy;
            this.maGV = maGV;
        }
    }
}
