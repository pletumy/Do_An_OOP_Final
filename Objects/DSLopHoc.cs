using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSLopHoc : DSDieuChinh<LopHoc>
    {
        // trả về DS Lớp học
        public string maLop { get; set; }
        public string maGV { get; set; }
        public string maMonHoc { get; set; }

        public LopHoc Nhap()
        {
            throw new NotImplementedException();
        }

        public LopHoc Sua()
        {
            throw new NotImplementedException();
        }

        public LopHoc TimKiem()
        {
            throw new NotImplementedException();
        }

        public LopHoc Xoa()
        {
            throw new NotImplementedException();
        }
    }
}
