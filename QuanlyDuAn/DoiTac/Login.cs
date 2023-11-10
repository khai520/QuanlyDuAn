using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiTac
{
    public partial class Login : Form
    {
        public Login(string text)
        {
            InitializeComponent();
            this.txt_TenDn.Text = text;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            lb_TB.Show();
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register(txt_TenDn.Text);
            rg.ShowDialog();
            this.Close();
        }
    }
}
