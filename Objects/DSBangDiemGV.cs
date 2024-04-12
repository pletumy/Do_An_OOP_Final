using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void Nhap(string filePath, DSBangDiemGV doiTuong)
        {
            throw new NotImplementedException();
        }

        public void Sua(string filePath, DSBangDiemGV doiTuong)
        {
            throw new NotImplementedException();
        }

        public void Xoa(string filePath, string maDoiTuong)
        {
            throw new NotImplementedException();
        }

        public void TimKiem()
        {
            throw new NotImplementedException();
        }
    }
}
