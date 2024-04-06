namespace Thiet_ke
{
    partial class XemDiem_HS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiem_HS));
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNam = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTenMon,
            this.clnSTT,
            this.clnGK,
            this.clnCK,
            this.clnTB});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 175);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1606, 583);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clnTenMon
            // 
            this.clnTenMon.DisplayIndex = 1;
            this.clnTenMon.Text = "Tên Môn Học";
            this.clnTenMon.Width = 150;
            // 
            // clnSTT
            // 
            this.clnSTT.DisplayIndex = 0;
            this.clnSTT.Text = "STT";
            this.clnSTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clnGK
            // 
            this.clnGK.Text = "Điểm giữa kỳ";
            this.clnGK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnGK.Width = 150;
            // 
            // clnCK
            // 
            this.clnCK.Text = "Điểm cuối kỳ";
            this.clnCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnCK.Width = 150;
            // 
            // clnTB
            // 
            this.clnTB.Text = "Điểm trung bình";
            this.clnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTB.Width = 170;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblNam.Location = new System.Drawing.Point(608, 31);
            this.lblNam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(87, 30);
            this.lblNam.TabIndex = 1;
            this.lblNam.Text = "Năm: ";
            this.lblNam.Click += new System.EventHandler(this.lblNam_Click);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblHocKy.Location = new System.Drawing.Point(1094, 27);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(118, 30);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học Kỳ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(696, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học Sinh: OOP";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2024"});
            this.comboBox1.Location = new System.Drawing.Point(714, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 38);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.comboBox2.Location = new System.Drawing.Point(1234, 21);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 38);
            this.comboBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNam);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblHocKy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1610, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm";
            // 
            // XemDiem_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1658, 865);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "XemDiem_HS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Điểm_HS";
            this.Load += new System.EventHandler(this.XemDiem_HS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ColumnHeader clnTenMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader clnSTT;
        private System.Windows.Forms.ColumnHeader clnGK;
        private System.Windows.Forms.ColumnHeader clnCK;
        private System.Windows.Forms.ColumnHeader clnTB;
    }
}