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
        public string maLop { get; set; }
        public string maGV { get; set; }
        public string maMonHoc { get; set; }

        private HocSinh[] students = new HocSinh[3];

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

        public DSHocSinh(){ }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Students", students);
        }
        public DSHocSinh(SerializationInfo info, StreamingContext context)
        {
            Students = (HocSinh[])info.GetValue("Students", typeof(HocSinh[]));
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
