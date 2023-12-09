using Microsoft.IdentityModel.Tokens;
using QuanLyDuAnBDS.DB;
using QuanLyDuAnBDS.Log;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class Register : Form
    {
        ConectionSQL con = new();
        QlbdsContext db = new QlbdsContext();
        public Register(string tdn)
        {
            InitializeComponent();
            this.txt_TenDn.Text = tdn;
            lb_ThongBao.Hide();
        }

        private void btn_Dn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login(txt_TenDn.Text);
            lg.ShowDialog();
            this.Close();
        }

        private void btn_Dk_Click(object sender, EventArgs e)
        {
            string? check = con.KiemtraMk(txt_TenDn.Text, txt_Mk.Text, txt_XnMk.Text);
            try
            {
                if (check == "")
                {
                    this.Hide();
                    infor infor = new(txt_TenDn.Text, txt_Mk.Text);
                    infor.ShowDialog();
                    this.Close();
                }
                else
                {
                    lb_ThongBao.Text = check;
                    lb_ThongBao.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thiếu dữ liệu");
                throw;
            }
        }

        private void banner1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            menuToolStripMenuItem.ForeColor = Color.Black;
        }

        private void banner2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner2;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner2;
            menuToolStripMenuItem.ForeColor = Color.White;
        }

        private void banner3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner4;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner4;
            menuToolStripMenuItem.ForeColor = Color.White;
        }

        private void banner4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner7;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner7;
            menuToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
