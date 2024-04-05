using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class LopHoc
    {
        /* 
         * 1 năm => 6 Lớp
         * mỗi khối 2 lớp:
         * mỗi Lớp 3HS thoi
         * Lớp 10: 2L
         * Lớp 11: 2L
         * Lớp 12: 2L
         */
        public string maLop { get; set; } //2024L10A1; 2024L10A2;
                                          //2023L11A1; 2023L11A2;
                                          //2022L12A1; 2022L12A2
        public string tenLop { get; set; } //10A1
        public string maMonHoc { get; set; } //
        public string maNamHoc { get; set; } //NH2024  
        public string maHocKy { get; set ; } //2024HK1
        public string maGV { get; set; } 

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
