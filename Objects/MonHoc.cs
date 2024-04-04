using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class MonHoc
    {
        /*
         * Mỗi môn 1 giáo viên
        Toán --> GVTOAN
        Vật Lý --> GVVATLY
        Hóa --> GVHOA
        Ngữ Văn --> GVNGUVAN
        Lịch Sử --> GVLICHSU
        Địa Lí --> GVDIALY
        Sinh học --> GVSINHHOC
        Tiếng Anh --> GVTIENGANH
        Giáo dục công dân --> GVCONGDAN
        Công nghệ --> GVCONGNGHE
        Giáo dục quốc phòng --> GVQUOCPHONG
        Giáo dục thể chất --> GVTHECHAT
        Tin học --> GVTINHOC
         */
        private string maMonHoc { get; set; }  //2024HK1TO10
        private string tenMonHoc { get; set; } //TOAN 10

        public MonHoc(string maMonHoc, string tenMonHoc)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
        }
    }
}
