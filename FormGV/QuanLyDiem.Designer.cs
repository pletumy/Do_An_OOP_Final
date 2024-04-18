namespace Thiet_ke
{
    partial class QuanLyDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDiem));
            this.clnGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSodt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDssv = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.clnMaHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaSv = new System.Windows.Forms.Button();
            this.btnSuaSv = new System.Windows.Forms.Button();
            this.grbSinhVien = new System.Windows.Forms.GroupBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.clnMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHocKy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNamHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDsLop = new System.Windows.Forms.GroupBox();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnNhapLop = new System.Windows.Forms.Button();
            this.lblPhanMem = new System.Windows.Forms.Label();
            this.btnNhapHS = new System.Windows.Forms.Button();
            this.grbDiemSo = new System.Windows.Forms.GroupBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblGv = new System.Windows.Forms.Label();
            this.btncomeback = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSearchhs = new System.Windows.Forms.TextBox();
            this.grbDssv.SuspendLayout();
            this.grbDsLop.SuspendLayout();
            this.grbDiemSo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.Text = "Giới tính";
            this.clnGioiTinh.Width = 100;
            // 
            // clnSodt
            // 
            this.clnSodt.Text = "Số điện thoại";
            this.clnSodt.Width = 160;
            // 
            // grbDssv
            // 
            this.grbDssv.BackColor = System.Drawing.Color.Transparent;
            this.grbDssv.Controls.Add(this.txtSearchhs);
            this.grbDssv.Controls.Add(this.lvSinhVien);
            this.grbDssv.Controls.Add(this.btnXoaSv);
            this.grbDssv.Controls.Add(this.btnSuaSv);
            this.grbDssv.Controls.Add(this.grbSinhVien);
            this.grbDssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDssv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.grbDssv.Location = new System.Drawing.Point(884, 317);
            this.grbDssv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grbDssv.Name = "grbDssv";
            this.grbDssv.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grbDssv.Size = new System.Drawing.Size(1172, 690);
            this.grbDssv.TabIndex = 12;
            this.grbDssv.TabStop = false;
            this.grbDssv.Text = "Danh sách học sinh";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaHS,
            this.clnHo,
            this.clnTen,
            this.clnGioiTinh,
            this.clnSodt});
            this.lvSinhVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvSinhVien.Location = new System.Drawing.Point(8, 99);
            this.lvSinhVien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(1142, 477);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // clnMaHS
            // 
            this.clnMaHS.Text = "Mã học sinh";
            this.clnMaHS.Width = 140;
            // 
            // clnHo
            // 
            this.clnHo.Text = "Họ";
            this.clnHo.Width = 140;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            this.clnTen.Width = 80;
            // 
            // btnXoaSv
            // 
            this.btnXoaSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoaSv.Location = new System.Drawing.Point(734, 598);
            this.btnXoaSv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaSv.Name = "btnXoaSv";
            this.btnXoaSv.Size = new System.Drawing.Size(180, 69);
            this.btnXoaSv.TabIndex = 2;
            this.btnXoaSv.Text = "Xóa";
            this.btnXoaSv.UseVisualStyleBackColor = true;
            this.btnXoaSv.Click += new System.EventHandler(this.btnXoaSv_Click);
            // 
            // btnSuaSv
            // 
            this.btnSuaSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSuaSv.Location = new System.Drawing.Point(214, 598);
            this.btnSuaSv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaSv.Name = "btnSuaSv";
            this.btnSuaSv.Size = new System.Drawing.Size(180, 69);
            this.btnSuaSv.TabIndex = 1;
            this.btnSuaSv.Text = "Sửa";
            this.btnSuaSv.UseVisualStyleBackColor = true;
            this.btnSuaSv.Click += new System.EventHandler(this.btnSuaSv_Click);
            // 
            // grbSinhVien
            // 
            this.grbSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.grbSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbSinhVien.Location = new System.Drawing.Point(166, 688);
            this.grbSinhVien.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grbSinhVien.Name = "grbSinhVien";
            this.grbSinhVien.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grbSinhVien.Size = new System.Drawing.Size(698, 185);
            this.grbSinhVien.TabIndex = 13;
            this.grbSinhVien.TabStop = false;
            this.grbSinhVien.Text = "Sinh viên";
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaLop,
            this.clnTenLop,
            this.clnHocKy,
            this.clnNamHoc});
            this.lvLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.HideSelection = false;
            this.lvLop.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvLop.Location = new System.Drawing.Point(8, 99);
            this.lvLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(762, 477);
            this.lvLop.TabIndex = 0;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            this.lvLop.SelectedIndexChanged += new System.EventHandler(this.lvLop_SelectedIndexChanged);
            // 
            // clnMaLop
            // 
            this.clnMaLop.Text = "Mã lớp";
            this.clnMaLop.Width = 130;
            // 
            // clnTenLop
            // 
            this.clnTenLop.Text = "Tên lớp";
            this.clnTenLop.Width = 80;
            // 
            // clnHocKy
            // 
            this.clnHocKy.Text = "Học kỳ";
            this.clnHocKy.Width = 80;
            // 
            // clnNamHoc
            // 
            this.clnNamHoc.Text = "Năm học";
            this.clnNamHoc.Width = 100;
            // 
            // grbDsLop
            // 
            this.grbDsLop.BackColor = System.Drawing.Color.Transparent;
            this.grbDsLop.Controls.Add(this.txtSearch);
            this.grbDsLop.Controls.Add(this.lvLop);
            this.grbDsLop.Controls.Add(this.btnXoaLop);
            this.grbDsLop.Controls.Add(this.btnSuaLop);
            this.grbDsLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDsLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbDsLop.Location = new System.Drawing.Point(92, 317);
            this.grbDsLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grbDsLop.Name = "grbDsLop";
            this.grbDsLop.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grbDsLop.Size = new System.Drawing.Size(778, 690);
            this.grbDsLop.TabIndex = 9;
            this.grbDsLop.TabStop = false;
            this.grbDsLop.Text = "Danh sách Lớp";
            this.grbDsLop.Enter += new System.EventHandler(this.grbDsLop_Enter);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoaLop.Location = new System.Drawing.Point(538, 598);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(180, 69);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSuaLop.Location = new System.Drawing.Point(100, 598);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(180, 69);
            this.btnSuaLop.TabIndex = 1;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapLop.Location = new System.Drawing.Point(192, 1027);
            this.btnNhapLop.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.Size = new System.Drawing.Size(620, 83);
            this.btnNhapLop.TabIndex = 0;
            this.btnNhapLop.Text = "Nhập lớp";
            this.btnNhapLop.UseVisualStyleBackColor = true;
            this.btnNhapLop.Click += new System.EventHandler(this.btnNhapLop_Click);
            // 
            // lblPhanMem
            // 
            this.lblPhanMem.AutoSize = true;
            this.lblPhanMem.BackColor = System.Drawing.Color.Transparent;
            this.lblPhanMem.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.lblPhanMem.Location = new System.Drawing.Point(-664, -319);
            this.lblPhanMem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPhanMem.Name = "lblPhanMem";
            this.lblPhanMem.Size = new System.Drawing.Size(1311, 88);
            this.lblPhanMem.TabIndex = 10;
            this.lblPhanMem.Text = "Phần Mềm Quản Lí Điểm Sinh Viên ";
            // 
            // btnNhapHS
            // 
            this.btnNhapHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapHS.Location = new System.Drawing.Point(1096, 1027);
            this.btnNhapHS.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnNhapHS.Name = "btnNhapHS";
            this.btnNhapHS.Size = new System.Drawing.Size(700, 83);
            this.btnNhapHS.TabIndex = 0;
            this.btnNhapHS.Text = "Nhập học sinh";
            this.btnNhapHS.UseVisualStyleBackColor = true;
            this.btnNhapHS.Click += new System.EventHandler(this.btnNhapHS_Click);
            // 
            // grbDiemSo
            // 
            this.grbDiemSo.BackColor = System.Drawing.Color.Transparent;
            this.grbDiemSo.Controls.Add(this.btnNhapDiem);
            this.grbDiemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDiemSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbDiemSo.Location = new System.Drawing.Point(550, 1131);
            this.grbDiemSo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grbDiemSo.Name = "grbDiemSo";
            this.grbDiemSo.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grbDiemSo.Size = new System.Drawing.Size(1042, 162);
            this.grbDiemSo.TabIndex = 16;
            this.grbDiemSo.TabStop = false;
            this.grbDiemSo.Text = "Điểm số";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapDiem.Location = new System.Drawing.Point(236, 42);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(562, 83);
            this.btnNhapDiem.TabIndex = 0;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.lblTenGV);
            this.groupBox1.Controls.Add(this.lblMon);
            this.groupBox1.Controls.Add(this.lblGv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Location = new System.Drawing.Point(92, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1964, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(374, 79);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(160, 56);
            this.lblTenGV.TabIndex = 3;
            this.lblTenGV.Text = "label1";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(1732, 112);
            this.lblMon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(128, 45);
            this.lblMon.TabIndex = 2;
            this.lblMon.Text = "label2";
            // 
            // lblGv
            // 
            this.lblGv.AutoSize = true;
            this.lblGv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGv.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblGv.Location = new System.Drawing.Point(90, 79);
            this.lblGv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGv.Name = "lblGv";
            this.lblGv.Size = new System.Drawing.Size(271, 56);
            this.lblGv.TabIndex = 0;
            this.lblGv.Text = "GIÁO VIÊN";
            this.lblGv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncomeback
            // 
            this.btncomeback.Location = new System.Drawing.Point(1832, 1173);
            this.btncomeback.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btncomeback.Name = "btncomeback";
            this.btncomeback.Size = new System.Drawing.Size(150, 44);
            this.btncomeback.TabIndex = 18;
            this.btncomeback.Text = "Quay Lại";
            this.btncomeback.UseVisualStyleBackColor = true;
            this.btncomeback.Click += new System.EventHandler(this.btncomeback_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(291, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(464, 44);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtSearchhs
            // 
            this.txtSearchhs.Location = new System.Drawing.Point(686, 35);
            this.txtSearchhs.Name = "txtSearchhs";
            this.txtSearchhs.Size = new System.Drawing.Size(464, 44);
            this.txtSearchhs.TabIndex = 4;
            this.txtSearchhs.TextChanged += new System.EventHandler(this.txtSearchhs_TextChanged);
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2090, 1327);
            this.Controls.Add(this.btncomeback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhapHS);
            this.Controls.Add(this.grbDssv);
            this.Controls.Add(this.btnNhapLop);
            this.Controls.Add(this.grbDsLop);
            this.Controls.Add(this.lblPhanMem);
            this.Controls.Add(this.grbDiemSo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "QuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            this.grbDssv.ResumeLayout(false);
            this.grbDssv.PerformLayout();
            this.grbDsLop.ResumeLayout(false);
            this.grbDsLop.PerformLayout();
            this.grbDiemSo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clnGioiTinh;
        private System.Windows.Forms.ColumnHeader clnSodt;
        private System.Windows.Forms.GroupBox grbDssv;
        public System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader clnMaHS;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.Button btnXoaSv;
        private System.Windows.Forms.Button btnSuaSv;
        private System.Windows.Forms.GroupBox grbDsLop;
        public System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader clnMaLop;
        private System.Windows.Forms.ColumnHeader clnTenLop;
        private System.Windows.Forms.ColumnHeader clnNamHoc;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnNhapLop;
        private System.Windows.Forms.Label lblPhanMem;
        private System.Windows.Forms.Button btnNhapHS;
        private System.Windows.Forms.GroupBox grbDiemSo;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.GroupBox grbSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGv;
        private System.Windows.Forms.ColumnHeader clnHocKy;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Button btncomeback;
        private System.Windows.Forms.TextBox txtSearchhs;
        private System.Windows.Forms.TextBox txtSearch;
    }
}