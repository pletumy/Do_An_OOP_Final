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
        string filepath_BangdiemHS = "BDHS.json";
        string filePath_BDGVs = "BDGV.json";
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
        // Lấy soft theo MaHK: maHS = CurrentStudent.maHS và maGV = GVTOAN,... -> 
        private void XemDiem_HS_Load(object sender, EventArgs e)
        {
        }
        private void btncomeback_Click(object sender, EventArgs e)
        {
            AccountHS accountHS = new AccountHS();
            accountHS.ShowDialog();
            this.Close();
        }
        private void CBBHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy maHS và maHK từ Đăng nhập và comboBox học kỳ
            string maHS = CurrentStudent.maHS.ToString();
            string maHK = CBBHocKy.SelectedItem.ToString();
            // Tạo BDHS cho tất cả học sinh để xem 
            BangDiemHS BDHS = new BangDiemHS(this);
            BDHS.luuBangDiem(filePath_BDGVs, maHS, maHK);

            BangDiemHS[] bangdiemHSs = BangDiem.DocFile<BangDiemHS[]>(filepath_BangdiemHS);
            //đếm số môn học có điểm của HS đang xét
            int count = 0;
            foreach (BangDiemHS diem in bangdiemHSs)
            {
                if (diem.maHS == maHS)
                {
                    count++;
                }
            }
            // tạo Bảng điểm HS mới
            BangDiemHS[] diemHS = new BangDiemHS[count];
            int index = 0;
            foreach (BangDiemHS diem in bangdiemHSs)
            {
                if (diem.maHS == maHS)
                {
                    diemHS[index] = diem;
                    index++;
                }
            }

            string selectedHocKy = CBBHocKy.SelectedItem.ToString(); // Giá trị được chọn từ comboBox
            lvXemDiem.Items.Clear(); // Xóa tất cả các mục trong ListView
            int stt = 1;                                             // Biến đếm số thứ tự
            foreach (BangDiemHS diem in diemHS)
            {
                if (diem.maHK == selectedHocKy)
                {
                    string monHoc = diem.MonHoc;
                    double diemGK = diem.diemGiuaKy;
                    double diemCk = diem.diemCuoiKy;
                    double diemTK = diem.diemTongKet;

                    //hiển thị ra listview
                    ListViewItem ViewDiemHS = new ListViewItem(monHoc);
                    ViewDiemHS.SubItems.Add(stt.ToString());
                    ViewDiemHS.SubItems.Add(diemGK.ToString());
                    ViewDiemHS.SubItems.Add(diemCk.ToString());
                    ViewDiemHS.SubItems.Add(diemTK.ToString());

                    lvXemDiem.Items.Add(ViewDiemHS);
                    stt++;
                }
            }
        }

        private void CBBHocKy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Lấy maHS và maHK từ Đăng nhập và comboBox học kỳ
            string maHS = CurrentStudent.maHS.ToString();
            string maHK = CBBHocKy.SelectedItem.ToString();
            // Tạo BDHS cho tất cả học sinh để xem 
            BangDiemHS BDHS = new BangDiemHS(this);
            BDHS.luuBangDiem(filePath_BDGVs, maHS, maHK);

            BangDiemHS[] bangdiemHSs = BangDiem.DocFile<BangDiemHS[]>(filepath_BangdiemHS);
            //đếm số môn học có điểm của HS đang xét
            int count = 0;
            foreach (BangDiemHS diem in bangdiemHSs)
            {
                if (diem.maHS == maHS)
                {
                    count++;
                }
            }
            // tạo Bảng điểm HS mới
            BangDiemHS[] diemHS = new BangDiemHS[count];
            int index = 0;
            foreach (BangDiemHS diem in bangdiemHSs)
            {
                if (diem.maHS == maHS)
                {
                    diemHS[index] = diem;
                    index++;
                }
            }

            string selectedHocKy = CBBHocKy.SelectedItem.ToString(); // Giá trị được chọn từ comboBox
            lvXemDiem.Items.Clear(); // Xóa tất cả các mục trong ListView
            int stt = 1;                                             // Biến đếm số thứ tự
            foreach (BangDiemHS diem in diemHS)
            {
                if (diem.maHK == selectedHocKy)
                {
                    string monHoc = diem.MonHoc;
                    double diemGK = diem.diemGiuaKy;
                    double diemCk = diem.diemCuoiKy;
                    double diemTK = diem.diemTongKet;

                    //hiển thị ra listview
                    ListViewItem ViewDiemHS = new ListViewItem(monHoc);
                    ViewDiemHS.SubItems.Add(stt.ToString());
                    ViewDiemHS.SubItems.Add(diemGK.ToString());
                    ViewDiemHS.SubItems.Add(diemCk.ToString());
                    ViewDiemHS.SubItems.Add(diemTK.ToString());

                    lvXemDiem.Items.Add(ViewDiemHS);
                    stt++;
                }
            }

        }
    }
}
