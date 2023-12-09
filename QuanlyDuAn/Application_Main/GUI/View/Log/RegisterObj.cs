using Application;
using QuanLyDuAnBDS.BLL.Services;
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
using WinFormsApp2;

namespace QuanLyDuAnBDS.Log
{
    public partial class RegisterObj : Form
    {
        QlbdsContext db = new();
        TkDnServices tkdn = new();
        int id;
        public RegisterObj(string tdn, string mk)
        {
            InitializeComponent();
            TkDangNhap tkdnl = tkdn.ChecktkDt(tdn, mk).Find(x => x.Tdn == tdn && x.Mk == mk);
            id = tkdnl.Idtk;
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            else
            {
                checkBox2.Checked = false;
                checkBox1.Checked = true;
            }

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox2.Checked = false;
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked)
            {

                if (checkBox1.Checked)
                {
                    MessageBox.Show(tkdn.AddChucNang(checkBox1.Text, id));
                    this.Hide();
                    HomeDT hmdt = new(id);
                    hmdt.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(tkdn.AddChucNang(checkBox2.Text, id));
                    this.Hide();
                    HomeClient hmcl = new();
                    hmcl.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Chưa chọn định dạng ");
            }
        }
    }
}
