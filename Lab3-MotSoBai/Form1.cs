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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MoformCon(Form f)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == f.Name)
                {
                    child.Activate();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai3_3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai4_1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai5_1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai5_3());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai3_1());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai3_2());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MoformCon(new Bai4_2());
        }
    }
}
