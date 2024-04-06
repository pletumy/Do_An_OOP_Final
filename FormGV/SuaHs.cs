﻿using Newtonsoft.Json;
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
        //enable-disable textbox
        private void EnableAllControls(Control control, bool enable)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is System.Windows.Forms.TextBox || childControl is RadioButton)
                {
                    if (childControl.Name == "txtMahs")
                    {
                        childControl.Enabled = false;
                    }
                    else
                    {
                        childControl.Enabled = enable;
                    }
                }
                else if (childControl.HasChildren)
                {
                    EnableAllControls(childControl, enable);
                }
            }
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
                EnableAllControls(this, false);
            }
        }

        bool isEditing = false;

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            EnableAllControls(this, isEditing);
        }
    }
}
