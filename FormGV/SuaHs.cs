using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiet_ke.Objects;

namespace Thiet_ke
{
    public partial class SuaHs : Form
    {
        private string maHS;
      
        public SuaHs(string maHS)
        {
            InitializeComponent();
            this.maHS = maHS;
        }

        private void SuaHs_Load(object sender, EventArgs e)
        {
            string filePath = "students.json";

            // Đọc nội dung từ tệp JSON
            string json = File.ReadAllText(filePath);

            // Chuyển đổi JSON thành đối tượng HocSinh
            HocSinh[] danhSachHocSinhs = JsonConvert.DeserializeObject<HocSinh[]>(json);

            // Tìm đối tượng HocSinh có maHocSinh trùng với maHocSinh được truyền vào
            HocSinh hocSinh = danhSachHocSinhs.FirstOrDefault(hs => hs.maHS == maHS);
            //tét
            if (hocSinh != null)
            {
                txtMahs.Text = hocSinh.maHS;
                txtho.Text = hocSinh.hoVaTenLot;
                txtTen.Text = hocSinh.ten;
                if (hocSinh.gioiTinh == 1)
                {
                    cbNam.Checked = true;
                } else cbNu.Checked = true;
                txtSDT.Text = hocSinh.soDienThoai;
            }
        }
    }
}
