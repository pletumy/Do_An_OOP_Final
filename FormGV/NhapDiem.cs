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

        private void NhapDiem_Load(object sender, EventArgs e)
        {

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
        static T DocFiles<T>(string filePaths)
        {
            if (File.Exists(filePaths))
            {
                string json = File.ReadAllText(filePaths);
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }
            else
            {
                Console.WriteLine("File không tồn tại.");
                return default(T);
            }
        }
        public void HienThiDanhSachHocSinhTheoLop(string maLop)
        {
            lvDiem.Items.Clear();
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
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
        public void refresh(string maLop)
        {

            lvDiem.Items.Clear(); // Clear the list view before adding new items
            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
            BangDiemGV[] bangDiemGVs = DocFiles<BangDiemGV[]>(filePaths);

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
                        if (bdg.maHS == hocSinh.maHS)
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
                HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
                BangDiemGV[] bangDiemGVs = DocFiles<BangDiemGV[]>(filePaths);

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
                            if (bdg.maHS == hocSinh.maHS)
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
                HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
                BangDiemGV[] bangDiemGVs = DocFiles<BangDiemGV[]>(filePaths);

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
                            if (bdg.maHS == hocSinh.maHS)
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
            BangDiemGV[] bangDiemGVs = new BangDiemGV[]
            {
        new BangDiemGV { maGiaoVien = lblmaGV.Text, maLop = MaLop.Text, maHS =txtMaHS.Text,maHK=btnHK.Text, diemGiuaKy =double.Parse(txtDiemGK.Text), diemCuoiKy =double.Parse(txtDiemCK.Text), diemTongKet =(double.Parse(txtDiemGK.Text)+ double.Parse(txtDiemCK.Text))/2}
            };
            return bangDiemGVs;
        }

        public void btnLuu_Click_1(object sender, EventArgs e)
        {

            string maHS = txtMaHS.Text;
            string maGV = lblmaGV.Text;
            string maHK = btnHK.Text;
            double diemGK = double.Parse(txtDiemGK.Text);
            double diemCK = double.Parse(txtDiemCK.Text);

            HocSinh[] danhSachHocSinhs = DocFile<HocSinh[]>(filePath);
            BangDiemGV[] bangDiemGVs = DocFiles<BangDiemGV[]>(filePaths);

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
                    if (bangDiemGVs[i].maHS == maHS)
                    {
                        bangDiemGV = bangDiemGVs[i];
                        break;
                    }
                }

                if (bangDiemGV != null)
                {
                    // Cập nhật điểm của học sinh trong lvDiem
                    ListViewItem item = lvDiem.FindItemWithText(maHS);
                    if (item != null)
                    {
                        item.SubItems[3].Text = diemGK.ToString();
                        item.SubItems[4].Text = diemCK.ToString();
                        item.SubItems[5].Text = ((diemGK + diemCK) / 2).ToString();
                    }

                    // Cập nhật điểm của học sinh trong danh sách điểm của giáo viên
                    bangDiemGV.diemGiuaKy = diemGK;
                    bangDiemGV.diemCuoiKy = diemCK;
                    bangDiemGV.diemTongKet = (diemGK + diemCK) / 2;

                    // Lưu danh sách điểm của giáo viên cập nhật vào file BDGV.json
                    string json = JsonConvert.SerializeObject(bangDiemGVs, Formatting.Indented);
                    File.WriteAllText(filePaths, json);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm của học sinh tương ứng.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh tương ứng.");
            }
        }
    }
}

