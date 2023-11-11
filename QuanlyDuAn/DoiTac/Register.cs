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

    public partial class Register : Form
    {

        public Register(string textbox)
        {
            InitializeComponent();
            this.txt_TenDn.Text = textbox;
        }

        private void btn_Dn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login(txt_TenDn.Text);
            lg.ShowDialog();
            this.Close();
        }
        public bool KiemtraMk(string mk, string xnmk)
        {
            if (mk != xnmk)
            {
                return true;
            }
            else
            {

                return false;
            }
        }



        private void btn_Dk_Click(object sender, EventArgs e)
        {
            if (KiemtraMk(lb_Mk.Text, lb_XnMk.Text))
            {

            }
        }


    }
}
