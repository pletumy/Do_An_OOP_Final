using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Thiet_ke.Objects
{

    [Serializable]
    public class BangDiemGV : BangDiem, ISerializable
    {
        //thực hiện thao tác chỉnh sửa nhập điểm
        public string maGiaoVien { get; set; }
        public string maLop { get; set; }
        public string maHS { get; set; }
        public string maHK { get; set; }

        public override void luuBangDiem(string filepath, string maHS, string maHK) {
            
        }
        //protected override void inBangDiem() { }
        public void CapNhatBangDiem(BangDiemGV bangDiemGV, ListView lvDiem, string filePath)
        {
            // Cập nhật điểm của học sinh trong danh sách điểm của giáo viên
            this.diemGiuaKy = bangDiemGV.diemGiuaKy;
            this.diemCuoiKy = bangDiemGV.diemCuoiKy;
            this.diemTongKet = bangDiemGV.diemTongKet;

            // Lưu danh sách điểm của giáo viên cập nhật vào file BDGV.json
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);

            // Đọc toàn bộ nội dung file JSON
            string fileContent = File.ReadAllText(filePath);

            // Chuyển đổi nội dung file JSON thành một danh sách các đối tượng BangDiemGV
            List<BangDiemGV> bangDiemGVs = JsonConvert.DeserializeObject<List<BangDiemGV>>(fileContent);

            // Tìm và cập nhật điểm của học sinh tương ứng
            BangDiemGV hsToUpdate = null;
            for (int i = 0; i < bangDiemGVs.Count; i++)
            {
                BangDiemGV hs = bangDiemGVs[i];
                if (hs.maGiaoVien == this.maGiaoVien && hs.maLop == this.maLop && hs.maHS == this.maHS && hs.maHK == this.maHK)
                {
                    hsToUpdate = hs;
                    break;
                }
            }
            if (hsToUpdate != null)
            {
                int index = bangDiemGVs.IndexOf(hsToUpdate);
                bangDiemGVs[index] = this;
            }

            // Ghi toàn bộ nội dung file JSON lại vào file
            File.WriteAllText(filePath, JsonConvert.SerializeObject(bangDiemGVs, Formatting.Indented));

            // Cập nhật điểm của học sinh trong lvDiem
            ListViewItem item = lvDiem.FindItemWithText(bangDiemGV.maHS);
            if (item != null)
            {
                item.SubItems[3].Text = bangDiemGV.diemGiuaKy.ToString();
                item.SubItems[4].Text = bangDiemGV.diemCuoiKy.ToString();
                item.SubItems[5].Text = bangDiemGV.diemTongKet.ToString();
            }
        }
        public BangDiemGV()
        {
        }

        public BangDiemGV(SerializationInfo info, StreamingContext context)
        {
            maGiaoVien = info.GetString("maGiaoVien");
            maLop = info.GetString("maLop");
            maHS = info.GetString("maHS");
            maHK = info.GetString("maHK");
            diemGiuaKy = info.GetDouble("diemGiuaKy");
            diemCuoiKy = info.GetDouble("diemCuoiKy");
            diemTongKet = info.GetDouble("diemTongKet");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("maGiaoVien", maGiaoVien);
            info.AddValue("maLop", maLop);
            info.AddValue("maHS", maHS);
            info.AddValue("maHK", maHK);
            info.AddValue("diemGiuaKy", diemGiuaKy);
            info.AddValue("diemCuoiKy", diemCuoiKy);
            info.AddValue("diemTongKet", diemTongKet);
        }
    }
}