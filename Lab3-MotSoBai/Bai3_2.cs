using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai3_2 : Form
    {
        public Bai3_2()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0; // Sử dụng kiểu int thay vì float để tính toán với số nguyên
            if (txtSoThuNhat.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số N!");
                txtSoThuNhat.Focus();
                return;
            }
            if (txtSoThuHai.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số M!");
                txtSoThuHai.Focus();
                return;
            }
            if (rdUSC.Checked && rdBSC.Checked)
            {
                MessageBox.Show("Bạn cần phải chọn yêu cầu trước khi thực hiện!");
                return;
            }
            try
            {
                n = int.Parse(txtSoThuNhat.Text);
                m = int.Parse(txtSoThuHai.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số N và M phải là số nguyên!");
                return;
            }

            int uscln = 0, bscnn = 0;

            // Tìm USCLN và BSCNN
            if (rdUSC.Checked)
            {
                uscln = USCLN(n, m);
                txtKetQua.Text = uscln.ToString();
            }
            else if (rdBSC.Checked)
            {
                bscnn = BSCNN(n, m);
                txtKetQua.Text = bscnn.ToString();
            }
        }

        // Hàm tìm USCLN sử dụng thuật toán Euclid
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tìm BSCNN dựa trên USCLN
        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtKetQua.Clear();
            txtSoThuNhat.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
