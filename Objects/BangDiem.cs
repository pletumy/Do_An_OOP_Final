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
        protected string maMonHoc;
        protected string tenMonHoc;
        protected string maLopHoc;
        protected double diemGiuaKy;
        protected double diemCuoiKy;
        protected double diemTongKet;

        protected abstract void xemBangDiem();
        protected abstract void inBangDiem();

    }
}
