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
    public partial class QuanLyDiem : Form
    {
        // Thêm dữ liệu học sinh
        public string filePath = "students.json";

        

        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void grbDsLop_Enter(object sender, EventArgs e)
        {

        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {

            // thêm dữ liệu lớp học
            string FilePath = "lophocs.json";
            //Đọc dữ liệu lớp học từ tệp Json
            LopHoc[] danhsachLophocs = DocFile<LopHoc[]>(FilePath);

            //Hiển thị lên ListView
            foreach (LopHoc lophoc in danhsachLophocs)
            {
                ListViewItem item = new ListViewItem(lophoc.maLop);
                item.SubItems.Add(lophoc.tenLop);
                item.SubItems.Add(lophoc.tenHK);
                item.SubItems.Add(lophoc.tenNamHoc.ToString());
                item.SubItems.Add(lophoc.maNamHoc);
                item.SubItems.Add(lophoc.maHocKy);

                lvLop.Items.Add(item);
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

            if (lvSinhVien.SelectedItems.Count > 0 && lvLop.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSinhVien.SelectedItems[0];
                string maHocSinh = selectedItem.SubItems[0].Text;

                SuaHs suaHS = new SuaHs(maHocSinh);
                suaHS.ShowDialog();
            }
            else {
                MessageBox.Show("Vui lòng chọn Lớp và Học Sinh cần chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count > 0)
            {
                // Lấy lớp được chọn trong listViewStudents
                ListViewItem selectedItem = lvLop.SelectedItems[0];
                string maLop = selectedItem.SubItems[0].Text;

                // Hiển thị form EditForm và truyền maLop vào
                SuaLop suaLop = new SuaLop(maLop);
                suaLop.ShowDialog();
            }
        }



        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvLop.SelectedItems[0];
                string maLop = selectedItem.SubItems[0].Text;

                HienThiDanhSachHocSinhTheoLop(maLop);
            }
        }
        private void HienThiDanhSachHocSinhTheoLop(string maLop)
        {
            lvSinhVien.Items.Clear();
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
            foreach (HocSinh hocSinh in danhSachHocSinhs)
            {
                if (hocSinh.maLop == maLop)
                {
                    ListViewItem item = new ListViewItem(hocSinh.maHS);
                    item.SubItems.Add(hocSinh.hoVaTenLot);
                    item.SubItems.Add(hocSinh.ten);
                    item.SubItems.Add(hocSinh.gioiTinh == 0 ? "Nữ" : "Nam");
                    item.SubItems.Add(hocSinh.soDienThoai);
                    item.SubItems.Add(hocSinh.tenDangNhap);
                    item.SubItems.Add(hocSinh.matKhau);
                    lvSinhVien.Items.Add(item);
                }
            }
        }
        
    }
}
