using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSBangDiemGV : DSDieuChinh<DSBangDiemGV>, ISerializable
    {
        private BangDiemGV[] teachers = new BangDiemGV[13]; //
        public BangDiemGV[] Teachers { get => teachers; set => teachers = value; }


        public DSBangDiemGV() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Teachers", teachers);
        }

        public DSBangDiemGV Nhap()
        {
            throw new NotImplementedException();
        }

        public DSBangDiemGV Sua()
        {
            throw new NotImplementedException();
        }

        public DSBangDiemGV Xoa()
        {
            throw new NotImplementedException();
        }

        public DSBangDiemGV TimKiem()
        {
            throw new NotImplementedException();
        }

        public DSBangDiemGV(SerializationInfo info, StreamingContext context)
        {
            Teachers = (BangDiemGV[])info.GetValue("Teachers", typeof(BangDiemGV[]));
        }
        //Khởi tạo danh sách Giao Vien
        public BangDiemGV[] taoDSGiaoVien()
        {
            BangDiemGV[] giaoViens = new BangDiemGV[]
                {
                    new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024K1L10A1 ", diemGiuaKy = 5.5, diemCuoiKy = 5},
                    new BangDiemGV { maGiaoVien = "GVLY", maLop = "2023K1L10A2 ", diemGiuaKy = 5.5, diemCuoiKy = 5},
                };
            return giaoViens;
        }
    }
}
