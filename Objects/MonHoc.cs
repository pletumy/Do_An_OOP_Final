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
        Toán
        Vật Lý
        Hóa
        Ngữ Văn
        Lịch Sử
        Địa Lí
        Sinh học
        Tiếng Anh
        Giáo dục công dân
        Công nghệ
        Giáo dục quốc phòng
        Giáo dục thể chất
        Tin học 
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
