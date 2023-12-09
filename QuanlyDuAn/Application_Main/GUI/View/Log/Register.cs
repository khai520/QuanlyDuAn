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
                    infor infor = new(lb_TenDn.Text, lb_Mk.Text);
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
    }
}
