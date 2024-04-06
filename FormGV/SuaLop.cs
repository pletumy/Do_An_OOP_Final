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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Thiet_ke
{
    public partial class SuaLop : Form
    {
        private QuanLyDiem parentForm; // Tham chiếu đến lớp QuanLyDiem
        private string maLop;
        private string tenHK;
        // Sửa mã lớp, tên lớp, Năm học
        // Nên để mới dô sẽ hiện thông tin mã, tên, năm học cũ để dễ sửa thông tin
        public SuaLop(string maLop, string tenHK, QuanLyDiem parent)
        {
            InitializeComponent();
            this.maLop = maLop;
            this.tenHK = tenHK;
            parentForm = parent; // Gán tham chiếu của parent vào biến parentForm
        }

        private void SuaLop_Load(object sender, EventArgs e)
        {
            string FilePath = "lophocs.json";
            // Đọc lớp học từ tệp JSON
            string json = File.ReadAllText(FilePath);
            // Chuyển đổi JSON thành đối tượng LopHoc
            LopHoc[] danhsachlophocs= JsonConvert.DeserializeObject<LopHoc[]>(json);

            // Tìm đối tượng lớp học có maLop trùng vs maLop được truyển vào
            LopHoc lophoc = null;
            foreach (LopHoc lh in danhsachlophocs)
            {
                if (lh.maLop == maLop && lh.tenHK == tenHK)
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
                txtNamHoc.Text = lophoc.tenNamHoc.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string FilePath = "lophocs.json";
            string json= File.ReadAllText(FilePath);

            // Chuyển đổi JSON thành đối tượng LopHoc
            List<LopHoc> danhsachlophocs= JsonConvert.DeserializeObject<List<LopHoc>>(json);

            // Tìm và xóa đối tượng LopHoc có mã trùng với mã lớp đang chọn để sửa
            danhsachlophocs.RemoveAll(lh => lh.maLop == txtMalop.Text && lh.tenHK==txtHocKy.Text);

            //Tạo đối tượng lớp học mới để lưu vào file Json
            LopHoc SuaLop = new LopHoc();
            SuaLop.maLop = txtMalop.Text;
            SuaLop.tenLop= txtTenlop.Text;
            SuaLop.tenHK= txtHocKy.Text;
            SuaLop.tenNamHoc = int.Parse(txtNamHoc.Text);

            //Kiểm tra xem đối tượng LopHoc mới tạo có bị trùng không 
            bool existed=false;
            foreach (var lh in danhsachlophocs)
            {
                if(lh.tenHK==txtHocKy.Text && lh.tenLop==txtTenlop.Text)
                { existed = true; break; }
            }
            if (existed)
            {
                MessageBox.Show("Lớp học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sử dụng lvLop từ lớp QuanLyDiem thông qua tham chiếu parentForm
                ListView lvLop = parentForm.lvLop;

                // Duyệt qua từng mục trong ListView để hiển thị ra màn hình
                foreach (ListViewItem item in lvLop.Items)
                {
                    if (item.SubItems[0].Text == SuaLop.maLop && item.SubItems[2].Text == SuaLop.tenHK)
                    {
                        // Nếu mã lớp của mục trong ListView trùng với mã lớp của đối tượng đã sửa
                        // thì cập nhật thông tin của mục đó với thông tin mới từ đối tượng đã sửa
                        item.SubItems[1].Text = SuaLop.tenLop;
                        item.SubItems[3].Text = SuaLop.tenNamHoc.ToString();
                        break;
                    }
                }
                //Thêm đối tượng vào danhsachlophocs
                danhsachlophocs.Add(SuaLop);

                //Chuyển đổi danhsachlophocs mới thành chuỗi JSON
                string newJson = JsonConvert.SerializeObject(danhsachlophocs, Formatting.Indented);

                // Ghi chuỗi JSON mới vào tệp lophocs.json
                File.WriteAllText(FilePath, newJson);

                // Thông báo cho người dùng rằng lớp học đã được sửa đổi thành công
                MessageBox.Show("Lớp học đã được sửa đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
