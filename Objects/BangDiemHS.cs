using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thiet_ke.Objects
{
    public class BangDiemHS : BangDiem
    {
        public string maHS { get; set; }
        string filepath_BangdiemHS = "BDHS.json";
        private XemDiem_HS parentForm;

        public BangDiemHS(XemDiem_HS parent)
        {
            this.parentForm = parent;
        }

        // Tạo BDHS cho tất cả học sinh để xem
        public override void luuBangDiem(string filepath, string maHocSinh, string maHocKy)
        {
            BangDiemGV[] bangdiems = Program.DocFile<BangDiemGV[]>(filepath);

            // Tạo danh sách để lưu trữ thông tin BDHS
            List<BangDiemHS> BDHSItems = new List<BangDiemHS>();

            // Duyệt qua từng đối tượng trong danh sách BDGV
            foreach (BangDiemGV diem in bangdiems)
            {
                string maGiaoVien = diem.maGiaoVien;
                string maLop = diem.maLop;
                string maHS = diem.maHS;
                string maHK = diem.maHK;
                double diemGiuaKy = diem.diemGiuaKy;
                double diemCuoiKy = diem.diemCuoiKy;
                double diemTongKet = diem.diemTongKet;

                // Tạo thông tin BDHS từ các trường thu thập được
                string maMonHoc = maGiaoVien.Replace("GV", "");
                
                
                double diemTrungBinh = (diemGiuaKy + diemCuoiKy) / 2;



                // Tạo đối tượng BDHS
                BangDiemHS bdhsItem = new BangDiemHS(parentForm)
                {
                    maHS = maHS,
                    maHK = maHK,
                    MonHoc = maMonHoc,
                    diemCuoiKy = diemCuoiKy,
                    diemGiuaKy = diemGiuaKy,
                    diemTongKet = diemTrungBinh
                };

                // Thêm đối tượng BDHS vào danh sách
                BDHSItems.Add(bdhsItem);
            }
            Program.GhiFile(filepath_BangdiemHS, BDHSItems);
        }
        //protected
        //void inBangDiem() { }
    }
}
