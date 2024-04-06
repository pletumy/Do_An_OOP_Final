using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSHocSinh : DSDieuChinh<HocSinh>, ISerializable
    {
        //trả về DS học sinh với các thao tác thêm xóa sửa
        private HocSinh[] students = new HocSinh[50]; //
        public HocSinh[] Students { get => students; set => students = value; }
        /*
        public DSHocSinh(string maLop, string maGV, string maMonHoc, List<HocSinh> students)
        {
            this.maLop = maLop;
            this.maGV = maGV;
            this.maMonHoc = maMonHoc;
            this.students = students;
        }
        */

        public DSHocSinh() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Students", students);
        }
        public DSHocSinh(SerializationInfo info, StreamingContext context)
        {
            Students = (HocSinh[])info.GetValue("Students", typeof(HocSinh[]));
        }
        //Khởi tạo danh sách học sinh
        public HocSinh[] taoDSHocSinh() {
            HocSinh[] hocSinhs = new HocSinh[]
                {
                    new HocSinh { maHS = "HS1", maLop = "2024L10A1", hoVaTenLot = "Hồ Ngọc", ten ="Hà", gioiTinh =0, soDienThoai ="0457963035", tenDangNhap ="userHS1", matKhau ="passwordHS1"},
                    new HocSinh { maHS = "HS2", maLop = "2024L10A1", hoVaTenLot = "Trấn", ten ="Thành", gioiTinh =1, soDienThoai ="0967015446", tenDangNhap ="userHS2", matKhau ="passwordHS2"},
                    new HocSinh { maHS = "HS3", maLop = "2024L10A1", hoVaTenLot = "Ninh Dương Lan", ten ="Ngọc", gioiTinh =0, soDienThoai ="0810216808", tenDangNhap ="userHS3", matKhau ="passwordHS3"},
                    new HocSinh { maHS = "HS4", maLop = "2024L10A2", hoVaTenLot = "Đàm Vĩnh", ten ="Hưng", gioiTinh =1, soDienThoai ="0572538069", tenDangNhap ="userHS4", matKhau ="passwordHS4"},
                    new HocSinh { maHS = "HS5", maLop = "2024L10A2", hoVaTenLot = "Phạm Mỹ", ten ="Tâm", gioiTinh =0, soDienThoai ="0669339877", tenDangNhap ="userHS5", matKhau ="passwordHS5"},
                    new HocSinh { maHS = "HS6", maLop = "2024L10A2", hoVaTenLot = "Hoàng Thùy", ten ="Linh", gioiTinh =0, soDienThoai ="0953734528", tenDangNhap ="userHS6", matKhau ="passwordHS6"},
                    new HocSinh { maHS = "HS7", maLop = "2023L11A1", hoVaTenLot = "Mai Hồng", ten ="Ngọc", gioiTinh =0, soDienThoai ="0704053882", tenDangNhap ="userHS7", matKhau ="passwordHS7"},
                    new HocSinh { maHS = "HS8", maLop = "2023L11A1", hoVaTenLot = "Mai Hồng", ten ="Vũ", gioiTinh =1, soDienThoai ="0981422367", tenDangNhap ="userHS8", matKhau ="passwordHS8"},
                    new HocSinh { maHS = "HS9", maLop = "2023L11A1", hoVaTenLot = "Nguyễn Thanh", ten ="Tùng", gioiTinh =1, soDienThoai ="0774292896", tenDangNhap ="userHS9", matKhau ="passwordHS9"},
                    new HocSinh { maHS = "HS10", maLop = "2023L11A2", hoVaTenLot = "Trần Đăng", ten ="Khoa", gioiTinh =1, soDienThoai ="0598912017", tenDangNhap ="userHS10", matKhau ="passwordHS10"},
                    new HocSinh { maHS = "HS11", maLop = "2023L11A2", hoVaTenLot = "Châu Đông", ten ="Vũ", gioiTinh =0, soDienThoai ="0838382442", tenDangNhap ="userHS11", matKhau ="passwordHS11"},
                    new HocSinh { maHS = "HS12", maLop = "2023L11A2", hoVaTenLot = "Trịnh Thăng", ten ="Bình", gioiTinh =1, soDienThoai ="0742811556", tenDangNhap ="userHS12", matKhau ="passwordHS12"},
                    new HocSinh { maHS = "HS13", maLop = "2022L12A1", hoVaTenLot = "Vũ Cát", ten ="Tường", gioiTinh =0, soDienThoai ="0228776416", tenDangNhap ="userHS13", matKhau ="passwordHS13"},
                    new HocSinh { maHS = "HS14", maLop = "2022L12A1", hoVaTenLot = "Nghiêm Vũ Hoàng", ten ="Long", gioiTinh =1, soDienThoai ="0642832099", tenDangNhap ="userHS14", matKhau ="passwordHS14"},
                    new HocSinh { maHS = "HS15", maLop = "2022L12A1", hoVaTenLot = "Nguyễn Thảo", ten ="Linh", gioiTinh =0, soDienThoai ="0211457896", tenDangNhap ="userHS15", matKhau ="passwordHS15"},
                    new HocSinh { maHS = "HS16", maLop = "2022L12A2", hoVaTenLot = "Nguyễn Thúc Thùy", ten ="Tiên", gioiTinh =0, soDienThoai ="0307412884", tenDangNhap ="userHS16", matKhau ="passwordHS16"},
                    new HocSinh { maHS = "HS17", maLop = "2022L12A2", hoVaTenLot = "Lê Nguyễn Trung", ten ="Đan", gioiTinh =1, soDienThoai ="0251347012", tenDangNhap ="userHS17", matKhau ="passwordHS17"},
                    new HocSinh { maHS = "HS18", maLop = "2022L12A2", hoVaTenLot = "Trần Thiện Thanh", ten ="Bảo", gioiTinh =1, soDienThoai ="0990255526", tenDangNhap ="userHS18", matKhau ="passwordHS18"},
                };
            return hocSinhs;
        }

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
