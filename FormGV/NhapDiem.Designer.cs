﻿namespace Thiet_ke
{
    partial class NhapDiem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapDiem));
            this.lvDiem = new System.Windows.Forms.ListView();
            this.clnMaHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNhapMHS = new System.Windows.Forms.Label();
            this.lblGK = new System.Windows.Forms.Label();
            this.lblCK = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.grbNhapDiem = new System.Windows.Forms.GroupBox();
            this.lblmaGV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timmalop = new System.Windows.Forms.Button();
            this.MaLop = new System.Windows.Forms.TextBox();
            this.btnHK = new System.Windows.Forms.Button();
            this.btncomeback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNhapDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDiem
            // 
            this.lvDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaHS,
            this.clnHo,
            this.clnTen,
            this.clnGK,
            this.clnCK,
            this.clnTB});
            this.lvDiem.HideSelection = false;
            this.lvDiem.Location = new System.Drawing.Point(12, 52);
            this.lvDiem.Name = "lvDiem";
            this.lvDiem.Size = new System.Drawing.Size(789, 218);
            this.lvDiem.TabIndex = 0;
            this.lvDiem.UseCompatibleStateImageBehavior = false;
            this.lvDiem.View = System.Windows.Forms.View.Details;
            this.lvDiem.SelectedIndexChanged += new System.EventHandler(this.lvDiem_SelectedIndexChanged);
            // 
            // clnMaHS
            // 
            this.clnMaHS.Text = "Mã học sinh";
            this.clnMaHS.Width = 100;
            // 
            // clnHo
            // 
            this.clnHo.Text = "Họ";
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            // 
            // clnGK
            // 
            this.clnGK.Text = "Điểm giữa kỳ";
            this.clnGK.Width = 100;
            // 
            // clnCK
            // 
            this.clnCK.Text = "Điểm cuối kỳ";
            this.clnCK.Width = 100;
            // 
            // clnTB
            // 
            this.clnTB.Text = "Điểm trung bình";
            this.clnTB.Width = 100;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblLop.Location = new System.Drawing.Point(405, 21);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(95, 16);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Nhập mã lớp";
            // 
            // lblNhapMHS
            // 
            this.lblNhapMHS.AutoSize = true;
            this.lblNhapMHS.Location = new System.Drawing.Point(41, 50);
            this.lblNhapMHS.Name = "lblNhapMHS";
            this.lblNhapMHS.Size = new System.Drawing.Size(130, 16);
            this.lblNhapMHS.TabIndex = 4;
            this.lblNhapMHS.Text = "Nhập mã học sinh";
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.Location = new System.Drawing.Point(40, 95);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(136, 16);
            this.lblGK.TabIndex = 6;
            this.lblGK.Text = "Nhập điểm giữa kỳ";
            // 
            // lblCK
            // 
            this.lblCK.AutoSize = true;
            this.lblCK.Location = new System.Drawing.Point(41, 136);
            this.lblCK.Name = "lblCK";
            this.lblCK.Size = new System.Drawing.Size(135, 16);
            this.lblCK.TabIndex = 7;
            this.lblCK.Text = "Nhập điểm cuối kỳ";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(190, 50);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(199, 22);
            this.txtMaHS.TabIndex = 9;
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Location = new System.Drawing.Point(190, 92);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(199, 22);
            this.txtDiemGK.TabIndex = 11;
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Location = new System.Drawing.Point(190, 134);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(199, 22);
            this.txtDiemCK.TabIndex = 12;
            // 
            // grbNhapDiem
            // 
            this.grbNhapDiem.Controls.Add(this.btncomeback);
            this.grbNhapDiem.Controls.Add(this.lblmaGV);
            this.grbNhapDiem.Controls.Add(this.btnLuu);
            this.grbNhapDiem.Controls.Add(this.txtMaHS);
            this.grbNhapDiem.Controls.Add(this.lblCK);
            this.grbNhapDiem.Controls.Add(this.lblNhapMHS);
            this.grbNhapDiem.Controls.Add(this.lblGK);
            this.grbNhapDiem.Controls.Add(this.txtDiemCK);
            this.grbNhapDiem.Controls.Add(this.txtDiemGK);
            this.grbNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapDiem.ForeColor = System.Drawing.Color.SandyBrown;
            this.grbNhapDiem.Location = new System.Drawing.Point(12, 290);
            this.grbNhapDiem.Name = "grbNhapDiem";
            this.grbNhapDiem.Size = new System.Drawing.Size(789, 185);
            this.grbNhapDiem.TabIndex = 14;
            this.grbNhapDiem.TabStop = false;
            this.grbNhapDiem.Text = "Nhập điểm";
            // 
            // lblmaGV
            // 
            this.lblmaGV.AutoSize = true;
            this.lblmaGV.Location = new System.Drawing.Point(664, 30);
            this.lblmaGV.Name = "lblmaGV";
            this.lblmaGV.Size = new System.Drawing.Size(49, 16);
            this.lblmaGV.TabIndex = 20;
            this.lblmaGV.Text = "maGV";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 0;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(465, 108);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 42);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Lưu");
            this.imageList1.Images.SetKeyName(1, "Thoát");
            // 
            // timmalop
            // 
            this.timmalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timmalop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timmalop.Location = new System.Drawing.Point(699, 15);
            this.timmalop.Name = "timmalop";
            this.timmalop.Size = new System.Drawing.Size(75, 23);
            this.timmalop.TabIndex = 16;
            this.timmalop.Text = "Tìm kiếm";
            this.timmalop.UseVisualStyleBackColor = true;
            this.timmalop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MaLop
            // 
            this.MaLop.Location = new System.Drawing.Point(515, 17);
            this.MaLop.Name = "MaLop";
            this.MaLop.Size = new System.Drawing.Size(156, 20);
            this.MaLop.TabIndex = 17;
            // 
            // btnHK
            // 
            this.btnHK.BackColor = System.Drawing.SystemColors.Control;
            this.btnHK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHK.Location = new System.Drawing.Point(144, 12);
            this.btnHK.Name = "btnHK";
            this.btnHK.Size = new System.Drawing.Size(106, 23);
            this.btnHK.TabIndex = 19;
            this.btnHK.Text = "Học kỳ II";
            this.btnHK.UseVisualStyleBackColor = false;
            this.btnHK.Click += new System.EventHandler(this.btnHK_Click);
            // 
            // btncomeback
            // 
            this.btncomeback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncomeback.ForeColor = System.Drawing.Color.Brown;
            this.btncomeback.Location = new System.Drawing.Point(649, 118);
            this.btncomeback.Name = "btncomeback";
            this.btncomeback.Size = new System.Drawing.Size(101, 23);
            this.btncomeback.TabIndex = 20;
            this.btncomeback.Text = "Đăng xuất";
            this.btncomeback.UseVisualStyleBackColor = true;
            this.btncomeback.Click += new System.EventHandler(this.btncomeback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bấm để chọn học kỳ -->";
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHK);
            this.Controls.Add(this.MaLop);
            this.Controls.Add(this.timmalop);
            this.Controls.Add(this.grbNhapDiem);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lvDiem);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm";
            this.grbNhapDiem.ResumeLayout(false);
            this.grbNhapDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDiem;
        private System.Windows.Forms.ColumnHeader clnMaHS;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnGK;
        private System.Windows.Forms.ColumnHeader clnCK;
        private System.Windows.Forms.ColumnHeader clnTB;
        private System.Windows.Forms.Label lblNhapMHS;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.GroupBox grbNhapDiem;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Button timmalop;
        private System.Windows.Forms.TextBox MaLop;
        private System.Windows.Forms.Button btnHK;
        private System.Windows.Forms.Label lblmaGV;
        private System.Windows.Forms.Button btncomeback;
        private System.Windows.Forms.Label label1;
    }
}