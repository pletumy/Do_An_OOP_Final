using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class NamHoc
    {
        private string maNamHoc;
        private string tenNamHoc;


        public NamHoc(string maNamHoc, string tenNamHoc)
        {
            this.maNamHoc = maNamHoc;
            this.tenNamHoc = tenNamHoc;
        }

        //Chỉ có thể "lấy giá trị" năm học chứ không thể điều chỉnh => Giữ "Get", Bỏ "Set"
        public string MaNamHoc { get => maNamHoc; }
        public string TenNamHoc { get => tenNamHoc; }
    }
}
