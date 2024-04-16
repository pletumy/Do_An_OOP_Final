﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSBangDiemGV : ISerializable
    {

        private BangDiemGV[] bangDiemGVs = new BangDiemGV[18];


        public BangDiemGV[] BangDiemGVs { get => bangDiemGVs; set => bangDiemGVs = value; }
        public DSBangDiemGV() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("BangDiemGVs", BangDiemGVs);
        }
        public DSBangDiemGV(SerializationInfo info, StreamingContext context)
        {
            BangDiemGVs = (BangDiemGV[])info.GetValue("BangDiemGVs", typeof(BangDiemGV[]));
        }
        public BangDiemGV[] taoDSBDGV()
        {
            BangDiemGV[] bangDiemGVs = new BangDiemGV[]
                {
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS1",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS2",maHK ="Học kỳ I", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS3",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS4",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS5",maHK ="Học kỳ I", diemGiuaKy =5, diemCuoiKy =9, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS6",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS7",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS8",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS9",maHK ="Học kỳ I", diemGiuaKy =4, diemCuoiKy =9, diemTongKet =6.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS10",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS11",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS12",maHK ="Học kỳ I", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS13",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS14",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS15",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS16",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS17",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS18",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},

                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS1",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS2",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A1", maHS ="HS3",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS4",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =7, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS5",maHK ="Học kỳ II", diemGiuaKy =8, diemCuoiKy =4, diemTongKet =6},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L10A2", maHS ="HS6",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =7, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS7",maHK ="Học kỳ II", diemGiuaKy =6, diemCuoiKy =6, diemTongKet =6},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS8",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A1", maHS ="HS9",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =6, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS10",maHK ="Học kỳ II", diemGiuaKy =8, diemCuoiKy =8, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS11",maHK ="Học kỳ II", diemGiuaKy =6, diemCuoiKy =6, diemTongKet =6},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L11A2", maHS ="HS12",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =8, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS13",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS14",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =7, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A1", maHS ="HS15",maHK ="Học kỳ II", diemGiuaKy =10, diemCuoiKy =6, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS16",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =8, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS17",maHK ="Học kỳ II", diemGiuaKy =8, diemCuoiKy =8, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVTOAN", maLop = "2024L12A2", maHS ="HS18",maHK ="Học kỳ II", diemGiuaKy = 3, diemCuoiKy =9, diemTongKet =6},

                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS1",maHK ="Học kỳ I", diemGiuaKy =7, diemCuoiKy =7, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS2",maHK ="Học kỳ I", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS3",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS4",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS5",maHK ="Học kỳ I", diemGiuaKy =5, diemCuoiKy =9, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS6",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS7",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS8",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS9",maHK ="Học kỳ I", diemGiuaKy =4, diemCuoiKy =9, diemTongKet =6.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS10",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS11",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS12",maHK ="Học kỳ I", diemGiuaKy =7, diemCuoiKy =9, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS13",maHK ="Học kỳ I", diemGiuaKy =2, diemCuoiKy =9, diemTongKet =5.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS14",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS15",maHK ="Học kỳ I", diemGiuaKy =6, diemCuoiKy =9, diemTongKet =7.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS16",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS17",maHK ="Học kỳ I", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS18",maHK ="Học kỳ I", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},

                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS1",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =7, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS2",maHK ="Học kỳ II", diemGiuaKy =8, diemCuoiKy =8, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A1", maHS ="HS3",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS4",maHK ="Học kỳ II", diemGiuaKy =6, diemCuoiKy =6, diemTongKet =6},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS5",maHK ="Học kỳ II", diemGiuaKy =8, diemCuoiKy =9, diemTongKet =8.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L10A2", maHS ="HS6",maHK ="Học kỳ II", diemGiuaKy =4, diemCuoiKy =4, diemTongKet =4},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS7",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS8",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =6, diemTongKet =6.5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A1", maHS ="HS9",maHK ="Học kỳ II", diemGiuaKy =6, diemCuoiKy =8, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS10",maHK ="Học kỳ II", diemGiuaKy =4, diemCuoiKy =4, diemTongKet =4},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS11",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L11A2", maHS ="HS12",maHK ="Học kỳ II", diemGiuaKy =6, diemCuoiKy =6, diemTongKet =6},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS13",maHK ="Học kỳ II", diemGiuaKy =7, diemCuoiKy =7, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS14",maHK ="Học kỳ II", diemGiuaKy =5, diemCuoiKy =5, diemTongKet =5},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A1", maHS ="HS15",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =5, diemTongKet =7},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS16",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =7, diemTongKet =8},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS17",maHK ="Học kỳ II", diemGiuaKy =9, diemCuoiKy =9, diemTongKet =9},
                  new BangDiemGV { maGiaoVien = "GVLY", maLop = "2024L12A2", maHS ="HS18",maHK ="Học kỳ II", diemGiuaKy =1, diemCuoiKy =1, diemTongKet =1},


                };
            return bangDiemGVs;
        }
    }
}
