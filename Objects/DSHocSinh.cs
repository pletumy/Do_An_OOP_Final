using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSHocSinh : DSDieuChinh<HocSinh>
    {
        //trả về DS học sinh với các thao tác thêm xóa sửa
        public string maLop { get; set; }
        public string maGV { get; set; }
        public string maMonHoc { get; set; }

        
        public HocSinh Nhap()
        {
            throw new NotImplementedException();
        }

        public HocSinh Sua()
        {
            throw new NotImplementedException();
        }

        public HocSinh TimKiem()
        {
            throw new NotImplementedException();
        }

        public HocSinh Xoa()
        {
            throw new NotImplementedException();
        }
    }
}
