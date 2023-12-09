using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAnBDS.BLL.Services;
using QuanLyDuAnBDS.DB;
using QuanLyDuAnBDS.Models;

namespace Application
{
    public partial class Login : Form
    {
        TkDnServices tkser = new();

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
            TkDangNhap tkdn = tkser.ChecktkDt(txt_TenDn.Text, txt_Mk.Text).Find(x => x.Tdn == txt_TenDn.Text && x.Mk == txt_Mk.Text);
            if (tkdn  != null)
            {
                this.Hide();
                HomeDT home = new HomeDT(tkdn.Idtk);
                home.ShowDialog();
                this.Close();
            }
            else
            {
                lb_TB.Show();
            }
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register(txt_TenDn.Text );
            rg.ShowDialog();
            this.Close();
        }
    }
}
