namespace Lab3_MotSoBai
{
    partial class Bai4_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.NumCai = new System.Windows.Forms.NumericUpDown();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTinhTien = new System.Windows.Forms.Button();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.cbChupHinh = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.btnluuFile = new System.Windows.Forms.Button();
            this.btndocFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumCai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trám răng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(155, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "100.000đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "1.200.000đ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "200.000đ";
            // 
            // tbTenKhachHang
            // 
            this.tbTenKhachHang.Location = new System.Drawing.Point(203, 66);
            this.tbTenKhachHang.Name = "tbTenKhachHang";
            this.tbTenKhachHang.Size = new System.Drawing.Size(245, 36);
            this.tbTenKhachHang.TabIndex = 7;
            // 
            // tbTongTien
            // 
            this.tbTongTien.ForeColor = System.Drawing.Color.Red;
            this.tbTongTien.Location = new System.Drawing.Point(274, 306);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(163, 36);
            this.tbTongTien.TabIndex = 8;
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumCai
            // 
            this.NumCai.Location = new System.Drawing.Point(156, 256);
            this.NumCai.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.NumCai.Name = "NumCai";
            this.NumCai.Size = new System.Drawing.Size(50, 36);
            this.NumCai.TabIndex = 9;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(30, 369);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 47);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTinhTien
            // 
            this.btTinhTien.ForeColor = System.Drawing.Color.Red;
            this.btTinhTien.Location = new System.Drawing.Point(299, 368);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(116, 48);
            this.btTinhTien.TabIndex = 11;
            this.btTinhTien.Text = "Tính tiền";
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Location = new System.Drawing.Point(55, 122);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(113, 33);
            this.cbCaoVoi.TabIndex = 12;
            this.cbCaoVoi.Text = "Cạo vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Location = new System.Drawing.Point(55, 166);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(138, 33);
            this.cbTayTrang.TabIndex = 13;
            this.cbTayTrang.Text = "Tẩy trắng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            // 
            // cbChupHinh
            // 
            this.cbChupHinh.AutoSize = true;
            this.cbChupHinh.Location = new System.Drawing.Point(55, 210);
            this.cbChupHinh.Name = "cbChupHinh";
            this.cbChupHinh.Size = new System.Drawing.Size(196, 33);
            this.cbChupHinh.TabIndex = 14;
            this.cbChupHinh.Text = "Chụp hình răng";
            this.cbChupHinh.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "80.000đ/cái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "cái";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.AutoSize = true;
            this.lbDanhSach.Location = new System.Drawing.Point(483, 80);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(220, 29);
            this.lbDanhSach.TabIndex = 17;
            this.lbDanhSach.Text = "Danh sách hóa đơn";
            // 
            // btnluuFile
            // 
            this.btnluuFile.Location = new System.Drawing.Point(709, 75);
            this.btnluuFile.Name = "btnluuFile";
            this.btnluuFile.Size = new System.Drawing.Size(110, 38);
            this.btnluuFile.TabIndex = 19;
            this.btnluuFile.Text = "Lưu File";
            this.btnluuFile.UseVisualStyleBackColor = true;
            this.btnluuFile.Click += new System.EventHandler(this.btnluuFile_Click);
            // 
            // btndocFile
            // 
            this.btndocFile.Location = new System.Drawing.Point(834, 75);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(110, 38);
            this.btndocFile.TabIndex = 20;
            this.btndocFile.Text = "Đọc File";
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(488, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 294);
            this.listBox1.TabIndex = 21;
            this.listBox1.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // Bai4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 435);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndocFile);
            this.Controls.Add(this.btnluuFile);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbChupHinh);
            this.Controls.Add(this.cbTayTrang);
            this.Controls.Add(this.cbCaoVoi);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.NumCai);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.tbTenKhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bai4_1";
            this.Text = "Bài tập 4 - Câu 1";
            ((System.ComponentModel.ISupportInitialize)(this.NumCai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenKhachHang;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.NumericUpDown NumCai;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.CheckBox cbChupHinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDanhSach;
        private System.Windows.Forms.Button btnluuFile;
        private System.Windows.Forms.Button btndocFile;
        private System.Windows.Forms.ListBox listBox1;
    }
}