﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
                  new LopHoc { maLop = "2024L10A1", tenLop = "10A1",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L10A2", tenLop = "10A2",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L11A1", tenLop = "11A1",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L11A2", tenLop = "11A2",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L12A1", tenLop = "12A1",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L12A2", tenLop = "12A2",tenHK="HK1" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L10A1", tenLop = "10A1",tenHK="HK2" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L10A2", tenLop = "10A2",tenHK="HK2" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L11A1", tenLop = "11A1",tenHK="HK2" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L11A2", tenLop = "11A2",tenHK="HK2" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L12A1", tenLop = "12A1",tenHK="HK2" ,tenNamHoc = 2024},
                  new LopHoc { maLop = "2024L12A2", tenLop = "12A2",tenHK="HK2" ,tenNamHoc = 2024},
            };
            return lophoc;
        }
        public LopHoc Nhap()
        {
            throw new NotImplementedException();
        }

        public void Sua(LopHoc lopHoc)
        {
            throw new NotImplementedException();
        }

        public void Xoa()
        {
            throw new NotImplementedException();
        }

        public void TimKiem()
        {
            throw new NotImplementedException();
        }
    }
}
