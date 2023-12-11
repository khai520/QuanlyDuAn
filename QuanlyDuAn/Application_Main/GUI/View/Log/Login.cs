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
using QuanLyDuAnBDS.Log;
using QuanLyDuAnBDS.Models;
using WinFormsApp2;

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
            if (tkdn == null)
            {
                lb_TB.Show();
            }
            else
            {
                if (tkdn.Chucdanh == null)
                {
                    this.Hide();
                    RegisterObj obj = new(tkdn.Tdn, tkdn.Mk);
                    obj.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (tkdn.Chucdanh == "Doi Tac")
                    {
                        this.Hide();
                        HomeDT home = new HomeDT(tkdn.Idtk);
                        home.ShowDialog();
                        this.Close();
                    }
                    else if (tkdn.Chucdanh == "Khach Hang")
                    {
                        this.Hide();
                        HomeClient homecl = new HomeClient(tkdn.Idtk);
                        homecl.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register(txt_TenDn.Text);
            rg.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lb_TB.Hide();
        }
        public void Changer()
        {
            lb_TenDN.Location = new Point(267, 160);
            txt_TenDn.Location = new Point(415, 160);
            lb_MK.Location = new Point(267, 211);
            txt_Mk.Location = new Point(415, 209);
            lb_TB.Location = new Point(349, 257);
            btn_DK.Location = new Point(334, 363);
            btn_DN.Location = new Point(528, 363);
        }
        public void Changer2()
        {
            lb_TenDN.Location = new Point(79, 235);
            txt_TenDn.Location = new Point(227, 235);
            lb_MK.Location = new Point(79, 286);
            txt_Mk.Location = new Point(227, 284);
            lb_TB.Location = new Point(171, 327);
            btn_DK.Location = new Point(146, 381);
            btn_DN.Location = new Point(340, 381);
        }
        private void banner1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            menuToolStripMenuItem.ForeColor = Color.Black;
            lb_TenDN.ForeColor = Color.White;
            lb_MK.ForeColor = Color.White;
            lb_TB.ForeColor = Color.White;
            Changer();
        }

        private void banner2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner2;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner2;
            menuToolStripMenuItem.ForeColor = Color.White;
            lb_TenDN.ForeColor = Color.White;
            lb_MK.ForeColor = Color.White;
            lb_TB.ForeColor = Color.White;
            Changer();
        }

        private void banner3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_TenDN.Location = new Point(130, 270);
            txt_TenDn.Location = new Point(278, 270);
            lb_MK.Location = new Point(130, 321);
            txt_Mk.Location = new Point(278, 319);
            lb_TB.Location = new Point(222, 362);
            btn_DK.Location = new Point(197, 416);
            btn_DN.Location = new Point(391, 416);
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner6;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner6;
            menuToolStripMenuItem.ForeColor = Color.White;
            lb_TenDN.ForeColor = Color.White;
            lb_MK.ForeColor = Color.White;
            lb_TB.ForeColor = Color.White;
        }

        private void banner4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner5;
            menuStrip1.BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner5;
            menuToolStripMenuItem.ForeColor = Color.Black;
            lb_TenDN.ForeColor = Color.Black;
            lb_MK.ForeColor = Color.Black;
            lb_TB.ForeColor = Color.Black;
            Changer2();
        }
    }
}
