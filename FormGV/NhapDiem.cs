using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiet_ke.Objects;
using System.IO;

namespace Thiet_ke
{
    public partial class NhapDiem : Form
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            string filePath = "students.json";

            // Đọc dữ liệu từ tệp JSON
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);

            // Hiển thị dữ liệu trong ListView
            foreach (HocSinh hocSinh in danhSachHocSinhs)
            {
                ListViewItem item = new ListViewItem(hocSinh.maHS);
                item.SubItems.Add(hocSinh.hoVaTenLot);
                item.SubItems.Add(hocSinh.ten);

                lvDiem.Items.Add(item);
            }
        }
        static T DocFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }
            else
            {
                Console.WriteLine("File không tồn tại.");
                return default(T);
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSv_Click(object sender, EventArgs e)
        {
            if (lvDiem.SelectedItems.Count > 0)
            {
                // Lấy học sinh được chọn trong listViewStudents
                ListViewItem selectedItem = lvDiem.SelectedItems[0];
                string maHocSinh = selectedItem.SubItems[0].Text;

                // Hiển thị form EditForm và truyền maHocSinh vào
                SuaHs suaHS = new SuaHs(maHocSinh);
                suaHS.ShowDialog();

                // Sau khi form EditForm đóng, bạn có thể cập nhật hoặc làm gì đó với dữ liệu đã chỉnh sửa
                // Ví dụ: cập nhật lại dữ liệu trong listViewStudents
                // danhSachHocSinhs = ... (cập nhật lại danh sách học sinh từ nguồn dữ liệu)
                // Hiển thị lại danh sách học sinh trong listViewStudents
                // ...
            }
        }

        private void lvDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLop_Click(object sender, EventArgs e)
        {

        }

        private void lblNhapMHS_Click(object sender, EventArgs e)
        {

        }

        private void lblGK_Click(object sender, EventArgs e)
        {

        }

        private void lblCK_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbNhapDiem_Enter(object sender, EventArgs e)
        {

        }

        private void btntimmhs_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MaLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
