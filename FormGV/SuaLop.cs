using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiet_ke.Objects;

namespace Thiet_ke
{
    public partial class SuaLop : Form
    {
        private string maLop;
        // Sửa mã lớp, tên lớp, Năm học
        // Nên để mới dô sẽ hiện thông tin mã, tên, năm học cũ để dễ sửa thông tin
        public SuaLop(string maLop)
        {
            InitializeComponent();
            this.maLop = maLop;
        }

        private void SuaLop_Load(object sender, EventArgs e)
        {
            string FilePath = "lophocs.json";
            // Đọc lớp học từ tệp JSON
            string json=File.ReadAllText(FilePath);

            // Chuyển đổi JSON thành đối tượng LopHoc
            LopHoc[] danhsachlophocs= JsonConvert.DeserializeObject<LopHoc[]>(json);

            // Tìm đối tượng lớp học có maLopHoc trùng vs maLopHoc được truyển vào
            LopHoc lophoc = null;
            foreach (LopHoc lh in danhsachlophocs)
            {
                if (lh.maLop == maLop)
                {
                    lophoc = lh;
                    break;
                }
            }
            //Sửa
            if (lophoc != null)
            {
                txtMalop.Text = lophoc.maLop;
                txtTenlop.Text = lophoc.tenLop;
                txtHocKy.Text = lophoc.tenHK;
                CBNamhoc.Text = lophoc.tenNamHoc.ToString();
            }
        }
    }
}
