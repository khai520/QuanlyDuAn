using Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAnBDS.Log
{
    public partial class infor : Form
    {
        private string tk;
        private string mk;

        public infor()
        {
            InitializeComponent();
        }
        public void LayThongTin(string tkc, string mkc)
        {
            tk = tkc; mk = mkc;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new(tk);
            rg.ShowDialog();
            this.Close();
        }

        private bool CheckThongtin()
        {
            return false;
        }
        private void btn_DK_Click(object sender, EventArgs e)
        {

        }
    }
}
