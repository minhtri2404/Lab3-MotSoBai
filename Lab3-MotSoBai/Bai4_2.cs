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
    public partial class Bai4_2 : Form
    {
        public Bai4_2()
        {
            InitializeComponent();
        }

        private void txtSoNguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSoNguyen = (Control)sender;
            if (ctrSoNguyen.Text.Length > 0)
            {
                if (!char.IsDigit(ctrSoNguyen.Text[ctrSoNguyen.Text.Length - 1]))
                {
                    this.erroSoNguyen.SetError(ctrSoNguyen, "Vui lòng nhập số nguyên");
                }
            }
            else
            {
                this.erroSoNguyen.Clear();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Add(txtSoNguyen.Text);
            txtSoNguyen.Text = "";
            txtSoNguyen.Focus();
        }

        private void btnTangPhanTu_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetQua.Items[i].ToString()) + 2;
                lstKetQua.Items.RemoveAt(i);
                lstKetQua.Items.Insert(i, tam.ToString());
            }
        }
        private void btnChonSo_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetQua.Items[i].ToString();
                    lstKetQua.SelectedItem = s;
                    break;
                }
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetQua.Items[i].ToString();
                    lstKetQua.SelectedItem = s;
                    break;
                }
            }
        }

        private void btnXoaPhanTu_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.SelectedItems.Count;
            for (int i = 0; i < n; i++)
            {
                lstKetQua.Items.Remove(lstKetQua.SelectedItems[i].ToString());
            }
        }

        private void btnXoaPhanDau_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Remove(lstKetQua.Items[0].ToString());
        }

        private void btnXoaPhanTuCuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count; 
            lstKetQua.Items.Remove(lstKetQua.Items[n - 1].ToString());

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
