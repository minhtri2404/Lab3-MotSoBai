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
    public partial class Bai5_1 : Form
    {
        public Bai5_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btmon = sender as Button;
            if (btmon == null)
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }

            if (dgvOrder.Rows.Count == 0)
            {
                // Thêm món ăn vào hàng đầu tiên nếu danh sách hiện tại trống
                dgvOrder.Rows.Add(btmon.Text, 1);
            }
            else
            {
                bool CD = false;
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == btmon.Text)
                    {
                        // Tăng số lượng nếu món ăn đã tồn tại trong danh sách
                        row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + 1;
                        CD = true;
                        break;
                    }
                }
                if (!CD)
                {
                    // Thêm món ăn mới vào danh sách nếu nó chưa có
                    dgvOrder.Rows.Add(btmon.Text, 1);
                }
            }
        }

        private void Bai5_1_Load(object sender, EventArgs e)
        {
            // Thêm các số bàn vào ComboBox khi form load
            for (int i = 1; i <= 10; i++)
            {
                cbbBan.Items.Add("Bàn " + i);
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbBan.Text) || dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn và danh sách món cần order!");
                return;
            }
            MessageBox.Show("Bạn đã order bàn: " + cbbBan.Text);
            cbbBan.SelectedIndex = -1;
            dgvOrder.Rows.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món nào được order để xóa!"); 
                return;
            }
            if (dgvOrder.SelectedRows.Count > 0)
                dgvOrder.Rows.Remove(dgvOrder.SelectedRows[0]);
        }
    }
}
