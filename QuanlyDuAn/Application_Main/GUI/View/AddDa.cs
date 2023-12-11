using Application;
using QuanLyDuAnBDS.BLL.Services;
using QuanLyDuAnBDS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAnBDS.GUI.View
{
    public partial class AddDa : Form
    {
        int Id;
        public AddDa(int ID)
        {
            InitializeComponent();
            Id = ID;
        }
        private DACDServices dacdser = new();
        int i = 1;
        private void Chuyen_Click(object sender, EventArgs e)
        {
            pb_anh.Image = i == 1 ? pb_anh.Image = Properties.Resources._1 : i == 2 ? pb_anh.Image = Properties.Resources._2 : i == 3 ? pb_anh.Image = Properties.Resources._3 : i == 4 ? pb_anh.Image = Properties.Resources._4 : i == 5 ? pb_anh.Image = Properties.Resources._5 : pb_anh.Image = Properties.Resources._6;
            i++;
            if (i == 7)
            {
                i = 1;
            }
        }
        private void TinhThanh()
        {
            cbx_2.Text = "";
            cbx_2.Items.Clear();
            string[] str;
            var docFile = File.ReadAllLines(@"C:\Users\khai5\OneDrive\Tài liệu\GitHub\QuanlyDuAn\QuanlyDuAn\Application_Main\GUI\View\Thanhpho.txt");
            bool check = false;
            foreach (string line in docFile)
            {
                if (line == cbx_1.SelectedItem.ToString())
                {
                    check = true;
                    continue;
                }
                if (check)
                {
                    if (line == "-----------")
                    {
                        break;
                    }
                    cbx_2.Items.Add(line);
                }

            }
        }
        private void Dang_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_Ten.Text))
            {
                if (cbx_2.SelectedItem != null)
                {
                    MessageBox.Show(dacdser.Addser(txt_Ten.Text, cbx_1.SelectedItem.ToString() + "-" + cbx_2.SelectedItem.ToString(), Convert.ToInt32(txt_Gia.Text), Convert.ToDouble(txt_Gia.Text), txt_Mota.Text, Id));
                    this.Hide();
                    HomeDT hmdt = new(Id);
                    hmdt.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Thiếu địa chỉ");
            }
            else MessageBox.Show("Thiếu tên dự án");
            
        }

        private void cbx_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhThanh();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeDT hmdt = new(Id);
            hmdt.ShowDialog();
            this.Close();
        }

        private void AddDa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeDT hmdt = new(Id);
            hmdt.ShowDialog();
            this.Close();
        }
    }
}
