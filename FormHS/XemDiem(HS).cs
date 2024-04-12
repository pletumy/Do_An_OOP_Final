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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thiet_ke
{
    public partial class XemDiem_HS : Form
    {
        public XemDiem_HS(HocSinh hocSinh)
        {
            InitializeComponent();
            CurrentStudent = hocSinh;
            lblMaHS.Text = CurrentStudent.maHS.ToString();
            lblHoTen.Text = CurrentStudent.hoVaTenLot.ToString() + " " + CurrentStudent.ten.ToString();
        }
        private HocSinh CurrentStudent;
        private void lblNam_Click(object sender, EventArgs e)
        {

        }

        private void XemDiem_HS_Load(object sender, EventArgs e)
        {
            string filePath_monHocs = "monHocs.json";
            // Đọc lớp học từ tệp JSON
            string json = File.ReadAllText(filePath_monHocs);
            // Chuyển đổi JSON thành đối tượng MonHoc
            MonHoc[] danhsachmonhocs = JsonConvert.DeserializeObject<MonHoc[]>(json);
            // Sau khi có danh sách môn học, gán nó vào ListView
            foreach (MonHoc monhoc in danhsachmonhocs)
            {
                ListViewItem item = new ListViewItem(monhoc.tenMonHoc); // Chỉ hiển thị tên môn học trong cột "Tên Môn Học"
                listView1.Items.Add(item);
            }
        }
    }
}
