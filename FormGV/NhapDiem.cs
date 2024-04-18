using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiet_ke.Objects;
using System.IO;
using System.Xml.Serialization;
using System.Net.NetworkInformation;

namespace Thiet_ke
{
    public partial class NhapDiem : Form
    {
        public NhapDiem(string maGV)
        {
            InitializeComponent();
            lblmaGV.Text = maGV;
        }
        string filePath = "students.json";
        string filePaths = "BDGV.json";

        public void HienThiDanhSachHocSinhTheoLop(string maLop)
        {
            lvDiem.Items.Clear();
            HocSinh[] danhSachHocSinhs = Program.DocFile<HocSinh[]>(filePath);
            foreach (HocSinh hocSinh in danhSachHocSinhs)
            {
                if (hocSinh.maLop == maLop)
                {
                    ListViewItem item = new ListViewItem(hocSinh.maHS);
                    item.SubItems.Add(hocSinh.hoVaTenLot);
                    item.SubItems.Add(hocSinh.ten);
                    lvDiem.Items.Add(item);
                }
            }
        }
        public void HienThiDanhSachTheoMaHS(string maHS)
        {

        }
        private void lvDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiem.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDiem.SelectedItems[0];
                selectedItem.Selected = true;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string maLop = (string)MaLop.Text;
            HienThiDanhSachHocSinhTheoLop(maLop);
        }

        private void btnHK_Click(object sender, EventArgs e)
        {
            btnHK.Text = btnHK.Text == "Học Kỳ II" ? "Học Kỳ I" : "Học Kỳ II";
            if (btnHK.Text == "Học Kỳ I")
            {
                grbNhapDiem.Visible = false;

                lvDiem.Items.Clear(); // Clear the list view before adding new items
                HocSinh[] danhSachHocSinhs = Program.DocFile<HocSinh[]>(filePath);
                BangDiemGV[] bangDiemGVs = Program.DocFile<BangDiemGV[]>(filePaths);

                List<BangDiemGV> bangDiemGVsForSemester = new List<BangDiemGV>();

                foreach (BangDiemGV bangDiemGV in bangDiemGVs)
                {
                    if (bangDiemGV.maHK == "Học kỳ I")
                    {
                        bangDiemGVsForSemester.Add(bangDiemGV);
                    }
                }

                foreach (HocSinh hocSinh in danhSachHocSinhs)
                {
                    if (hocSinh.maLop == MaLop.Text)
                    {
                        ListViewItem item = new ListViewItem(hocSinh.maHS);
                        item.SubItems.Add(hocSinh.hoVaTenLot);
                        item.SubItems.Add(hocSinh.ten);

                        BangDiemGV bangDiemGV = null;
                        foreach (BangDiemGV bdg in bangDiemGVsForSemester)
                        {
                            if (bdg.maHS == hocSinh.maHS && bdg.maGiaoVien == lblmaGV.Text && bdg.maHK == "Học kỳ I")
                            {
                                bangDiemGV = bdg;
                                break;
                            }
                        }

                        if (bangDiemGV != null)
                        {
                            item.SubItems.Add(bangDiemGV.diemGiuaKy.ToString()); item.SubItems.Add(bangDiemGV.diemCuoiKy.ToString());
                            item.SubItems.Add(bangDiemGV.diemTongKet.ToString());
                        }
                        else
                        {
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                        }

                        lvDiem.Items.Add(item);
                    }
                }
            }
            else
            {
                grbNhapDiem.Visible = true;
                lvDiem.Items.Clear(); // Clear the list view before adding new items
                HocSinh[] danhSachHocSinhs = Program.DocFile<HocSinh[]>(filePath);
                BangDiemGV[] bangDiemGVs = Program.DocFile<BangDiemGV[]>(filePaths);

                List<BangDiemGV> bangDiemGVsForSemester = new List<BangDiemGV>();

                foreach (BangDiemGV bangDiemGV in bangDiemGVs)
                {
                    if (bangDiemGV.maHK == "Học kỳ II")
                    {
                        bangDiemGVsForSemester.Add(bangDiemGV);
                    }
                }

                foreach (HocSinh hocSinh in danhSachHocSinhs)
                {
                    if (hocSinh.maLop == MaLop.Text)
                    {
                        ListViewItem item = new ListViewItem(hocSinh.maHS);
                        item.SubItems.Add(hocSinh.hoVaTenLot);
                        item.SubItems.Add(hocSinh.ten);

                        BangDiemGV bangDiemGV = null;
                        foreach (BangDiemGV bdg in bangDiemGVsForSemester)
                        {
                            if (bdg.maHS == hocSinh.maHS && bdg.maGiaoVien == lblmaGV.Text && bdg.maHK == "Học kỳ II")
                            {
                                bangDiemGV = bdg;
                                break;
                            }
                        }

                        if (bangDiemGV != null)
                        {
                            item.SubItems.Add(bangDiemGV.diemGiuaKy.ToString()); item.SubItems.Add(bangDiemGV.diemCuoiKy.ToString());
                            item.SubItems.Add(bangDiemGV.diemTongKet.ToString());
                        }
                        else
                        {
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                        }

                        lvDiem.Items.Add(item);
                    }
                }
            }
        }
        public BangDiemGV[] taoDSBDGV()
        {
            BangDiemGV[] bangDiemGVs = Program.DocFile<BangDiemGV[]>(filePaths);
            // Thay đổi các giá trị điểm trong bangDiemGVs tại đây
            return bangDiemGVs;
        }

        public void btnLuu_Click_1(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text;
            string maGV = lblmaGV.Text;
            string maHK = "Học kỳ II";
            double diemGK = double.Parse(txtDiemGK.Text);
            double diemCK = double.Parse(txtDiemCK.Text);

            HocSinh[] danhSachHocSinhs = Program.DocFile<HocSinh[]>(filePath);
            BangDiemGV[] bangDiemGVs = Program.DocFile<BangDiemGV[]>(filePaths);

            // Tìm kiếm học sinh tương ứng
            HocSinh hocSinh = null;
            for (int i = 0; i < danhSachHocSinhs.Length; i++)
            {
                if (danhSachHocSinhs[i].maHS == maHS)
                {
                    hocSinh = danhSachHocSinhs[i];
                    break;
                }
            }

            if (hocSinh != null)
            {
                // Tìm kiếm điểm của học sinh tương ứng
                BangDiemGV bangDiemGV = null;
                for (int i = 0; i < bangDiemGVs.Length; i++)
                {
                    if (bangDiemGVs[i].maHS == maHS && bangDiemGVs[i].maGiaoVien == maGV && bangDiemGVs[i].maHK == maHK)
                    {
                        bangDiemGV = bangDiemGVs[i];
                        break;
                    }
                }

                if (bangDiemGV != null)
                {
                    // Tạo một đối tượng của class BangDiemGV
                    bangDiemGV.diemGiuaKy = diemGK;
                    bangDiemGV.diemCuoiKy = diemCK;
                    bangDiemGV.diemTongKet = (diemGK + diemCK) / 2;

                    // Cập nhật bảng điểm
                    bangDiemGV.CapNhatBangDiem(bangDiemGV, lvDiem, filePaths);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm của học sinh này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public event EventHandler ComebackButtonClicked;
        private void btncomeback_Click(object sender, EventArgs e)
        {
            ComebackButtonClicked?.Invoke(sender, e);
            this.Close();
        }
    }
}

