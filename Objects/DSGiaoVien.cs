using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public class DSGiaoVien : DSDieuChinh<GiaoVien>, ISerializable
    {
        //trả về DS Giao Vien với các thao tác thêm xóa sửa
        private GiaoVien[] teachers = new GiaoVien[13]; //
        public GiaoVien[] Teachers { get => teachers; set => teachers = value; }


        public DSGiaoVien() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Teachers", teachers);
        }

        public GiaoVien Nhap()
        {
            throw new NotImplementedException();
        }

        public GiaoVien Sua()
        {
            throw new NotImplementedException();
        }

        public GiaoVien Xoa()
        {
            throw new NotImplementedException();
        }

        public GiaoVien TimKiem()
        {
            throw new NotImplementedException();
        }

        public DSGiaoVien(SerializationInfo info, StreamingContext context)
        {
            Teachers = (GiaoVien[])info.GetValue("Teachers", typeof(GiaoVien[]));
        }
        //Khởi tạo danh sách Giao Vien
        public GiaoVien[] taoDSGiaoVien()
        {
            GiaoVien[] giaoViens = new GiaoVien[]
                {
                  new GiaoVien { maGV = "GVTOAN", hoVaTenLot = "Nguyễn Trường", ten ="An", gioiTinh =1, soDienThoai ="0204019960", tenDangNhap ="userGVTOAN", matKhau ="passwordGVTOAN"},
                    new GiaoVien { maGV = "GVLY", hoVaTenLot = "Nguyễn Quang ", ten ="Anh", gioiTinh =1, soDienThoai ="0230515773", tenDangNhap ="userGVLY", matKhau ="passwordGVLY"},
                    new GiaoVien { maGV = "GVHOA", hoVaTenLot = "Nguyễn Xuân ", ten ="Bách", gioiTinh =1, soDienThoai ="0998182654", tenDangNhap ="userGVHOA", matKhau ="passwordGVHOA"},
                    new GiaoVien { maGV = "GVVAN", hoVaTenLot = "Nguyễn Tuấn ", ten ="Ngọc", gioiTinh =1, soDienThoai ="0934914939", tenDangNhap ="userGVVAN", matKhau ="passwordGVVAN"},
                    new GiaoVien { maGV = "GVSU", hoVaTenLot = "Nguyễn Hiếu ", ten ="Nghĩa", gioiTinh =1, soDienThoai ="0674647750", tenDangNhap ="userGVSU", matKhau ="passwordGVSU"},
                    new GiaoVien { maGV = "GVDIA", hoVaTenLot = "Nguyễn Thành ", ten ="Nhân", gioiTinh =1, soDienThoai ="0693269527", tenDangNhap ="userGVDIA", matKhau ="passwordGVDIA"},
                    new GiaoVien { maGV = "GVSINH", hoVaTenLot = "Trần Bảo Gia ", ten ="Khiêm", gioiTinh =1, soDienThoai ="0903204781", tenDangNhap ="userGVSINH", matKhau ="passwordGVSINH"},
                    new GiaoVien { maGV = "GVANH", hoVaTenLot = "Lê Yến ", ten ="Di", gioiTinh =0, soDienThoai ="0585653550", tenDangNhap ="userGVANH", matKhau ="passwordGVANH"},
                    new GiaoVien { maGV = "GVCD", hoVaTenLot = "Lê Kim ", ten ="Hoa", gioiTinh =0, soDienThoai ="0964956574", tenDangNhap ="userGVCD", matKhau ="passwordGVCD"},
                    new GiaoVien { maGV = "GVCN", hoVaTenLot = "Lê Nhã ", ten ="Quế", gioiTinh =0, soDienThoai ="0920029060", tenDangNhap ="userGVCN", matKhau ="passwordGVCN"},
                    new GiaoVien { maGV = "GVQP", hoVaTenLot = "Phạm Tuệ ", ten ="Doanh", gioiTinh =0, soDienThoai ="0203089302", tenDangNhap ="userGVQP", matKhau ="passwordGVQP"},
                    new GiaoVien { maGV = "GVTC", hoVaTenLot = "Phạm Tuệ Phương ", ten ="Anh", gioiTinh =0, soDienThoai ="0199331045", tenDangNhap ="userGVTC", matKhau ="passwordGVTC"},
                    new GiaoVien { maGV = "GVTIN", hoVaTenLot = "Trần Lâm ", ten ="Anh", gioiTinh =0, soDienThoai ="0392136597", tenDangNhap ="userGVTIN", matKhau ="passwordGVTIN"},
                };
            return giaoViens;
        }

    }
}
