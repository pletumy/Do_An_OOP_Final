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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            string json = File.ReadAllText(filePath);

            HocSinh[] danhSachHocSinhs = JsonConvert.DeserializeObject<HocSinh[]>(json);

            HocSinh hocSinh = null;
            foreach (HocSinh hs in danhSachHocSinhs)
            {
                if (hs.maHS == maHS)
                {
                    hocSinh = hs;
                    break;
                }
            }
            if (hocSinh != null)
            {
                txtMahs.Text = hocSinh.maHS;
                txtho.Text = hocSinh.hoVaTenLot;
                txtTen.Text = hocSinh.ten;
                if (hocSinh.gioiTinh == 1)
                {
                    rBtnNam.Checked = true;

                }
                else { rBtnNu.Checked = true; }
                txtSDT.Text = hocSinh.soDienThoai;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
    }
}
