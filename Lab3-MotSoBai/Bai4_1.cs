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

namespace Lab3_MotSoBai
{
    public partial class Bai4_1 : Form
    {
        public Bai4_1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = (MessageBox.Show("Bạn có muốn thoát khỏi form không!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongBao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btTinhTien_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            if (cbCaoVoi.Checked)
            {
                total += 100000;
            }
            if (cbTayTrang.Checked)
            {
                total += 1200000;
            }
            if (cbChupHinh.Checked)
            {
                total += 200000;
            }
            total += NumCai.Value * 80000;
            tbTongTien.Text = total.ToString("N0") + "đ";
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string tenKhachHang = tbTenKhachHang.Text.Trim();
            string tongTien = tbTongTien.Text.Trim();

            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(tongTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string item = $"{tenKhachHang} - {tongTien}";
            listBox1.Items.Add(item);

            // Sau khi thêm vào ListBox, bạn có thể xóa nội dung của các TextBox để chuẩn bị cho việc nhập thông tin khách hàng tiếp theo.
            tbTenKhachHang.Text = "";
            tbTongTien.Text = "";
        }

        private void btnluuFile_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng nào!");
                return;
            }
            List<string> content = new List<string>();
            foreach (var item in listBox1.Items)
                content.Add(item.ToString());
            File.WriteAllLines("DSKhachHang.txt", content);
            MessageBox.Show("Đã ghi lên file" + Application.StartupPath + "\nDSKhachHang.txt");
        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("DSKhachHang.txt"))
            {
                string[] khachhang = File.ReadAllLines("DSKhachHang.txt");
                foreach (var item in khachhang)
                    listBox1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Chưa có file lưu danh sách khách hàng!");
            }
        }
    }
}
