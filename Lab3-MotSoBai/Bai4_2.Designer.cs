namespace Lab3_MotSoBai
{
    partial class Bai4_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.erroSoNguyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaPhanDau = new System.Windows.Forms.Button();
            this.btnXoaPhanTu = new System.Windows.Forms.Button();
            this.btnXoaPhanTuCuoi = new System.Windows.Forms.Button();
            this.btnChonSo = new System.Windows.Forms.Button();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnTangPhanTu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lstKetQua = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.erroSoNguyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thao Tác Số";
            // 
            // erroSoNguyen
            // 
            this.erroSoNguyen.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Số Nguyên";
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(208, 75);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(226, 22);
            this.txtSoNguyen.TabIndex = 2;
            this.txtSoNguyen.TextChanged += new System.EventHandler(this.txtSoNguyen_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(458, 75);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaPhanDau
            // 
            this.btnXoaPhanDau.Location = new System.Drawing.Point(30, 211);
            this.btnXoaPhanDau.Name = "btnXoaPhanDau";
            this.btnXoaPhanDau.Size = new System.Drawing.Size(184, 23);
            this.btnXoaPhanDau.TabIndex = 11;
            this.btnXoaPhanDau.Text = "Xóa phần tử đầu";
            this.btnXoaPhanDau.UseVisualStyleBackColor = true;
            this.btnXoaPhanDau.Click += new System.EventHandler(this.btnXoaPhanDau_Click);
            // 
            // btnXoaPhanTu
            // 
            this.btnXoaPhanTu.Location = new System.Drawing.Point(30, 167);
            this.btnXoaPhanTu.Name = "btnXoaPhanTu";
            this.btnXoaPhanTu.Size = new System.Drawing.Size(184, 23);
            this.btnXoaPhanTu.TabIndex = 10;
            this.btnXoaPhanTu.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTu.UseVisualStyleBackColor = true;
            this.btnXoaPhanTu.Click += new System.EventHandler(this.btnXoaPhanTu_Click);
            // 
            // btnXoaPhanTuCuoi
            // 
            this.btnXoaPhanTuCuoi.Location = new System.Drawing.Point(30, 251);
            this.btnXoaPhanTuCuoi.Name = "btnXoaPhanTuCuoi";
            this.btnXoaPhanTuCuoi.Size = new System.Drawing.Size(184, 23);
            this.btnXoaPhanTuCuoi.TabIndex = 9;
            this.btnXoaPhanTuCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaPhanTuCuoi.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuCuoi.Click += new System.EventHandler(this.btnXoaPhanTuCuoi_Click);
            // 
            // btnChonSo
            // 
            this.btnChonSo.Location = new System.Drawing.Point(30, 74);
            this.btnChonSo.Name = "btnChonSo";
            this.btnChonSo.Size = new System.Drawing.Size(184, 23);
            this.btnChonSo.TabIndex = 8;
            this.btnChonSo.Text = "Chọn số đầu tiên";
            this.btnChonSo.UseVisualStyleBackColor = true;
            this.btnChonSo.Click += new System.EventHandler(this.btnChonSo_Click);
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(30, 125);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(184, 23);
            this.btnChonSoLe.TabIndex = 7;
            this.btnChonSoLe.Text = "Chọn số lẻ cuối";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnTangPhanTu
            // 
            this.btnTangPhanTu.Location = new System.Drawing.Point(30, 33);
            this.btnTangPhanTu.Name = "btnTangPhanTu";
            this.btnTangPhanTu.Size = new System.Drawing.Size(184, 23);
            this.btnTangPhanTu.TabIndex = 6;
            this.btnTangPhanTu.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangPhanTu.UseVisualStyleBackColor = true;
            this.btnTangPhanTu.Click += new System.EventHandler(this.btnTangPhanTu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTangPhanTu);
            this.groupBox1.Controls.Add(this.btnChonSoLe);
            this.groupBox1.Controls.Add(this.btnChonSo);
            this.groupBox1.Controls.Add(this.btnXoaPhanTuCuoi);
            this.groupBox1.Controls.Add(this.btnXoaPhanTu);
            this.groupBox1.Controls.Add(this.btnXoaPhanDau);
            this.groupBox1.Location = new System.Drawing.Point(401, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(128, 456);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(473, 23);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lstKetQua
            // 
            this.lstKetQua.FormattingEnabled = true;
            this.lstKetQua.ItemHeight = 16;
            this.lstKetQua.Location = new System.Drawing.Point(39, 125);
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Size = new System.Drawing.Size(307, 308);
            this.lstKetQua.TabIndex = 7;
            this.lstKetQua.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Bai4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(759, 490);
            this.Controls.Add(this.lstKetQua);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai4_2";
            this.Text = "frm Thaotacso";
            ((System.ComponentModel.ISupportInitialize)(this.erroSoNguyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroSoNguyen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTangPhanTu;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnChonSo;
        private System.Windows.Forms.Button btnXoaPhanTuCuoi;
        private System.Windows.Forms.Button btnXoaPhanTu;
        private System.Windows.Forms.Button btnXoaPhanDau;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKetQua;
    }
}