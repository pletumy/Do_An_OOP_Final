using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class BangDiemGV : BangDiem
    {
        //thực hiện thao tác chỉnh sửa nhập điểm
        public string maGiaoVien { get; set; }


        protected override void xemBangDiem() { }
        //protected override void inBangDiem() { }
        public void chinhSuaBangDiem() { 
        }
    }
}
