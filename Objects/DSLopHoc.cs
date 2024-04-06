using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSLopHoc : DSDieuChinh<LopHoc>, ISerializable
    {
        //trả về DS lớp học với các thao tác thêm xóa sửa
        private LopHoc[] lophocs = new LopHoc[10]; //
        public LopHoc[] Lophocs { get => lophocs; set => lophocs = value; }
        //Khởi tạo danh sách học sinh
        public DSLopHoc() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Students", lophocs);
        }
        public DSLopHoc(SerializationInfo info, StreamingContext context)
        {
            Lophocs = (LopHoc[])info.GetValue("LopHoc", typeof(LopHoc[]));
        }
        public LopHoc[] taoDSLopHoc()
        {
            LopHoc[] lophoc = new LopHoc[]
            {
                  new LopHoc { maLop = "2024K1L10A1", tenLop = "10A1",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"},
                  new LopHoc { maLop = "2024K1L10A2", tenLop = "10A2",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"},
                  new LopHoc { maLop = "2024K1L11A1", tenLop = "11A1",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"},
                  new LopHoc { maLop = "2024K1L11A2", tenLop = "11A2",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"},
                  new LopHoc { maLop = "2024K1L12A1", tenLop = "12A1",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"},
                  new LopHoc { maLop = "2024K1L12A2", tenLop = "12A2",maHocKy="HK12024",tenHK="HK1" ,tenNamHoc = 2024, maNamHoc = "NH2024"}
            };
            return lophoc;
        }
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
