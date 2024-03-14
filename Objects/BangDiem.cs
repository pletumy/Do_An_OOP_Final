using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public abstract class BangDiem
    {
        protected Diem diem { get; set; }

        protected HocKy hocKy { get; set; }
        protected NamHoc namHoc { get; set; }
        protected LopHoc lop { get; set; }
        protected MonHoc monHoc { get; set; }

        protected void xemBangDiem() { }
        protected void inBangDiem() { }

    }
}
