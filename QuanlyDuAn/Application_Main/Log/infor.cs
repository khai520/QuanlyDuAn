using Application;
using QuanLyDuAnBDS.DB;
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

namespace QuanLyDuAnBDS.Log
{
    public partial class infor : Form
    {
        private string tk;
        private string mk;
        QlbdsContext db = new QlbdsContext();
        TkDangNhap tkdn = new TkDangNhap();
        ConectionSQL cn = new();
        public infor()
        {
            InitializeComponent();
        }
        public void LayThongTin(string tkc, string mkc)
        {
            tk = tkc;
            mk = mkc;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new(tk);
            rg.ShowDialog();
            this.Close();
        }
        private string GioiTinh()
        {
            if (!rb_Nam.Checked)
                if (!rb_Nu.Checked)
                    return "Khác";
                else
                    return "Nữ";
            else
                return "Nam";
        }
        private void btn_DK_Click(object sender, EventArgs e)
        {
            if (cn.setDataTk(tk,mk,txt_HovaTen.Text,GioiTinh(),dtp_Ngaysinh,txt_Gmail.Text,txt_SDT.Text))
            {
                this.Hide();
                RegisterObj rgo = new();
                rgo.XetKh()
                rgo.ShowDialog();
                this.Close();
            }
        }

        private void infor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
