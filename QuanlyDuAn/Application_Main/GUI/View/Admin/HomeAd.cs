using Application;
using QuanLyDuAnBDS.BLL.Services;
using QuanLyDuAnBDS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAnBDS.GUI.View.Admin
{
    public partial class HomeAd : Form
    {
        ConectionSQL conectionSQL = new ConectionSQL();
        int Id;
        public HomeAd()
        {
            InitializeComponent();
        }
        DACDServices dacd;
        DADDServices dadd;
        Services sv;
        private void btn_TcDa_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        public void Loaddata()
        {
            sv = new();
            int i = 1;
            dgv_listdanhsach.DataSource = sv.AdDa().Select(x => new
            {
                STT = i++,
                x.Idda,
                x.TenDuAn,
                x.Gia,
                x.Diachi,
                x.Dientich,
                x.Mota,
                x.Idtk,
                x.TinhTrang
            }).ToList();
            dgv_listdanhsach.Columns[0].HeaderText = "STT";
            dgv_listdanhsach.Columns[1].HeaderText = "Id Dự án";
            dgv_listdanhsach.Columns[2].HeaderText = "Tên dự án";
            dgv_listdanhsach.Columns[3].HeaderText = "Giá";
            dgv_listdanhsach.Columns[4].HeaderText = "Địa chỉ";
            dgv_listdanhsach.Columns[5].HeaderText = "Diện tích";
            dgv_listdanhsach.Columns[6].HeaderText = "Mô tả ";
            dgv_listdanhsach.Columns[7].HeaderText = "Id đối tác";
            dgv_listdanhsach.Columns[8].HeaderText = "Tình trạng";
        }
        private void HomeAd_Load(object sender, EventArgs e)
        {

            Loaddata();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_listdanhsach.DataSource = sv.Timkiem(txt_Id.Text, txt_Ten.Text, txt_Diachi.Text, txt_Dientich.Text, txt_Gia.Text, txt_IdChungCu.Text, txt_Mota.Text);
        }

        private void HomeDT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login lg = new();
            lg.ShowDialog();
            this.Close();
        }

        bool check = true;
        private void dgv_listdanhsach_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int d = e.ColumnIndex;
            int i = 1;
            sv = new();
            if (d == 0)
            {
                if (check)
                {
                    dgv_listdanhsach.DataSource = sv.Sapxep(dgv_listdanhsach, d, Id, check).Select(x => new
                    {
                        STT = i++,
                        x.Idda,
                        x.TenDuAn,
                        x.Gia,
                        x.Diachi,
                        x.Dientich,
                        x.Mota,
                        x.Idtk,
                        x.TinhTrang
                    }).OrderBy(x => x.STT).ToList();
                    check = false;
                }
                else
                {
                    check = true;
                    dgv_listdanhsach.DataSource = sv.Sapxep(dgv_listdanhsach, d, Id, check).Select(x => new
                    {
                        STT = i++,
                        x.Idda,
                        x.TenDuAn,
                        x.Gia,
                        x.Diachi,
                        x.Dientich,
                        x.Mota,
                        x.Idtk,
                        x.TinhTrang
                    }).OrderByDescending(x => x.STT).ToList();
                }
            }
            else
            {
                if (check)
                {
                    check = false;
                    dgv_listdanhsach.DataSource = sv.Sapxep(dgv_listdanhsach, d, Id, check).Select(x => new
                    {
                        STT = i++,
                        x.Idda,
                        x.TenDuAn,
                        x.Gia,
                        x.Diachi,
                        x.Dientich,
                        x.Mota,
                        x.Idtk,
                        x.TinhTrang
                    }).ToList();
                }
                else
                {
                    check = true;
                    dgv_listdanhsach.DataSource = sv.Sapxep(dgv_listdanhsach, d, Id, check).Select(x => new
                    {
                        STT = i++,
                        x.Idda,
                        x.TenDuAn,
                        x.Gia,
                        x.Diachi,
                        x.Dientich,
                        x.Mota,
                        x.Idtk,
                        x.TinhTrang
                    }).ToList();
                }
            }
        }

        private void btn_CtDa_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangDa_Click(object sender, EventArgs e)
        {

        }
    }
}
