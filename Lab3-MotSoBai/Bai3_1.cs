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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoN.Text = (Convert.ToDouble(txtSoN.Text)).ToString();
                txtSoM.Text = (Convert.ToDouble(txtSoM.Text)).ToString();
                txtKetQua.Text = (Convert.ToDouble(txtSoN.Text) + Convert.ToDouble(txtSoM.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoN.Text = (Convert.ToDouble(txtSoN.Text)).ToString();
                txtSoM.Text = (Convert.ToDouble(txtSoM.Text)).ToString();
                txtKetQua.Text = (Convert.ToDouble(txtSoN.Text) - Convert.ToDouble(txtSoM.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoN.Text = (Convert.ToDouble(txtSoN.Text)).ToString();
                txtSoM.Text = (Convert.ToDouble(txtSoM.Text)).ToString();
                txtKetQua.Text = (Convert.ToDouble(txtSoN.Text) * Convert.ToDouble(txtSoM.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                txtSoN.Text = (Convert.ToDouble(txtSoN.Text)).ToString();
                txtSoM.Text = (Convert.ToDouble(txtSoM.Text)).ToString();
                txtKetQua.Text = (Convert.ToDouble(txtSoN.Text) / Convert.ToDouble(txtSoM.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Clear();
            txtSoM.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
