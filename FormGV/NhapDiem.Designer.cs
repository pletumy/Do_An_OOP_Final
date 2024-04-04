namespace Thiet_ke
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnMaHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNhapMHS = new System.Windows.Forms.Label();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.lblGK = new System.Windows.Forms.Label();
            this.lblCK = new System.Windows.Forms.Label();
            this.lblNhapHo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grbNhapDiem = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbNhapDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnSTT,
            this.clnMaHS,
            this.clnHo,
            this.clnTen,
            this.clnGK,
            this.clnCK,
            this.clnTB});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 64);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1051, 268);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clnSTT
            // 
            this.clnSTT.Text = "STT";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(112, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn: Toán";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblLop.Location = new System.Drawing.Point(644, 26);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(95, 20);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Chọn Lớp:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(753, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // lblNhapMHS
            // 
            this.lblNhapMHS.AutoSize = true;
            this.lblNhapMHS.Location = new System.Drawing.Point(55, 40);
            this.lblNhapMHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMHS.Name = "lblNhapMHS";
            this.lblNhapMHS.Size = new System.Drawing.Size(160, 20);
            this.lblNhapMHS.TabIndex = 4;
            this.lblNhapMHS.Text = "Nhập mã học sinh";
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Location = new System.Drawing.Point(55, 104);
            this.lblNhapTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(84, 20);
            this.lblNhapTen.TabIndex = 5;
            this.lblNhapTen.Text = "Nhập tên";
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.Location = new System.Drawing.Point(55, 136);
            this.lblGK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(163, 20);
            this.lblGK.TabIndex = 6;
            this.lblGK.Text = "Nhập điểm giữa kỳ";
            // 
            // lblCK
            // 
            this.lblCK.AutoSize = true;
            this.lblCK.Location = new System.Drawing.Point(55, 168);
            this.lblCK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCK.Name = "lblCK";
            this.lblCK.Size = new System.Drawing.Size(163, 20);
            this.lblCK.TabIndex = 7;
            this.lblCK.Text = "Nhập điểm cuối kỳ";
            // 
            // lblNhapHo
            // 
            this.lblNhapHo.AutoSize = true;
            this.lblNhapHo.Location = new System.Drawing.Point(55, 72);
            this.lblNhapHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapHo.Name = "lblNhapHo";
            this.lblNhapHo.Size = new System.Drawing.Size(78, 20);
            this.lblNhapHo.TabIndex = 8;
            this.lblNhapHo.Text = "Nhập họ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 133);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(253, 165);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 69);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 26);
            this.textBox5.TabIndex = 13;
            // 
            // grbNhapDiem
            // 
            this.grbNhapDiem.Controls.Add(this.btnLuu);
            this.grbNhapDiem.Controls.Add(this.textBox1);
            this.grbNhapDiem.Controls.Add(this.lblNhapHo);
            this.grbNhapDiem.Controls.Add(this.textBox5);
            this.grbNhapDiem.Controls.Add(this.lblCK);
            this.grbNhapDiem.Controls.Add(this.lblNhapMHS);
            this.grbNhapDiem.Controls.Add(this.lblGK);
            this.grbNhapDiem.Controls.Add(this.textBox4);
            this.grbNhapDiem.Controls.Add(this.lblNhapTen);
            this.grbNhapDiem.Controls.Add(this.textBox2);
            this.grbNhapDiem.Controls.Add(this.textBox3);
            this.grbNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapDiem.ForeColor = System.Drawing.Color.SandyBrown;
            this.grbNhapDiem.Location = new System.Drawing.Point(16, 357);
            this.grbNhapDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNhapDiem.Name = "grbNhapDiem";
            this.grbNhapDiem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNhapDiem.Size = new System.Drawing.Size(1052, 228);
            this.grbNhapDiem.TabIndex = 14;
            this.grbNhapDiem.TabStop = false;
            this.grbNhapDiem.Text = "Nhập điểm";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 0;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(737, 87);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(165, 52);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Lưu");
            this.imageList1.Images.SetKeyName(1, "Thoát");
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1091, 659);
            this.Controls.Add(this.grbNhapDiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.grbNhapDiem.ResumeLayout(false);
            this.grbNhapDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clnSTT;
        private System.Windows.Forms.ColumnHeader clnMaHS;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnGK;
        private System.Windows.Forms.ColumnHeader clnCK;
        private System.Windows.Forms.ColumnHeader clnTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNhapMHS;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.Label lblNhapHo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grbNhapDiem;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.ImageList imageList1;
    }
}