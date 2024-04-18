using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public abstract class BangDiem
    {
        public string MonHoc;    //thay maMonHoc thành MonHoc vì 1 mã GV: GVTOAN có tới 3 mã MonHoc khác nhau. 
        public string maHK;
        public double diemGiuaKy;
        public double diemCuoiKy;
        public double diemTongKet;
        public abstract void luuBangDiem(string filepath, string maHS, string maHK);
    }
}
