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
        private List<HocSinh> hocSinhs = new List<HocSinh>();
        public List<HocSinh> HocSinhs { get => hocSinhs; set => hocSinhs = value; }
        public DSHocSinh() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("HocSinhs", hocSinhs);
        }
        public DSHocSinh(SerializationInfo info, StreamingContext context)
        {
            HocSinhs = (List<HocSinh>)info.GetValue("HocSinhs", typeof(List<HocSinh>));
        }
        public HocSinh Nhap()
        {
            throw new NotImplementedException();
        }

        public HocSinh Sua()
        {
            throw new NotImplementedException();
        }

        public HocSinh Xoa()
        {
            throw new NotImplementedException();
        }
    }
}
