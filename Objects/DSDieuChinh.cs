using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiet_ke.Objects
{
    public interface DSDieuChinh<T>
    {
       public T Nhap();
       public T Sua();
       public T Xoa();
    }
}
