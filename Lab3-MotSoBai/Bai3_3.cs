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
    public partial class Bai3_3 : Form
    {
        public Bai3_3()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            tbCode.Text += btn.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbCode.Clear();
        }

        class Account
        {
            public int code { get; set; }
            public string name { get; set; }
        }
        List<Account> accounts = new List<Account>();

        private void Bai3_3_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account() { code = 1645, name = "Technicians"});
            accounts.Add(new Account() { code = 1689, name = "Technicians"});
            accounts.Add(new Account() { code = 8345, name = "Custodians"});
            accounts.Add(new Account() { code = 9998, name = "ScientList"});
            accounts.Add(new Account() { code = 1066, name = "ScientList"});
            accounts.Add(new Account() { code = 1007, name = "ScientList"});
            accounts.Add(new Account() { code = 1008, name = "ScientList"});
        }

        private void btLoggin_Click(object sender, EventArgs e)
        {
            Account LoggesAccount = accounts.Find(a => a.code == Int32.Parse(tbCode.Text));
            if (LoggesAccount == null)
            {
                lbAccessedList.Items.Add(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt" + "\nRestricted access"));
            }
            else
            {
                lbAccessedList.Items.Add(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt" + $"\n{LoggesAccount.name}!"));
            }
        }
    }
}
