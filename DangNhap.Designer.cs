namespace Thiet_ke
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.btnHS = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHS
            // 
            this.btnHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHS.Location = new System.Drawing.Point(770, 329);
            this.btnHS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(370, 73);
            this.btnHS.TabIndex = 0;
            this.btnHS.Text = "Tài khoản học sinh";
            this.btnHS.UseVisualStyleBackColor = true;
            // 
            // btnGV
            // 
            this.btnGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGV.Location = new System.Drawing.Point(770, 467);
            this.btnGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(370, 81);
            this.btnGV.TabIndex = 1;
            this.btnGV.Text = "Tài khoản giáo viên";
            this.btnGV.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 758);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.btnHS);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnGV;
    }
}