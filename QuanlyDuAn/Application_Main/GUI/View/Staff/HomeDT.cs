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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Application
{

    public partial class HomeDT : Form
    {

        ConectionSQL conectionSQL = new ConectionSQL();
        int Id;
        public HomeDT(int Id)
        {
            InitializeComponent();
            Id = Id;
        }
        DACDServices dacd;
        DADDServices dadd;
        private void btn_TcDa_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void list_Danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_CtDa_Click(object sender, EventArgs e)
        {

        }
        public void Loaddata()
        {
            dadd = new DADDServices();
            int i = 1;
            dgv_listdanhsach.DataSource = dadd.GetAllDADD().Select(x => new
            {
                STT = i++,
                x.Idda,
                x.TenDuAn,
                x.Gia,
                x.Diachi,
                x.Dientich,
                x.Mota,
                x.Idtk

            }).ToList();
            dgv_listdanhsach.Columns[0].HeaderText = "STT";
            dgv_listdanhsach.Columns[2].HeaderText = "Id Dự án";
            dgv_listdanhsach.Columns[3].HeaderText = "Tên dự án";
            dgv_listdanhsach.Columns[4].HeaderText = "Giá";
            dgv_listdanhsach.Columns[5].HeaderText = "Địa chỉ";
            dgv_listdanhsach.Columns[6].HeaderText = "Diện tích";
            dgv_listdanhsach.Columns[7].HeaderText = "Mô tả ";
            //dgv_listdanhsach.Columns[8].HeaderText = "Id đối tác";
        }
        private void HomeDT_Load(object sender, EventArgs e)
        {

            Loaddata();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            dgv_listdanhsach.DataSource = dadd.Timkiem(txt_Id.Text, txt_Ten.Text, txt_Diachi.Text, txt_Dientich.Text, txt_Gia.Text, txt_IdChungCu.Text, txt_Mota.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_DaCt_Click(object sender, EventArgs e)
        {
            int i = 1;
            dgv_listdanhsach.DataSource = dacd.GetAllDACD().Where(x => x.Idtk == Id).Select(x => new
            {
                STT = i++,
                x.Idda,
                x.TenDuAn,
                x.Gia,
                x.Diachi,
                x.Dientich,
                x.Mota,
                x.Idtk
            }).ToList();
            dgv_listdanhsach.DataSource.Equals(dadd.GetAllDADD().Where(x => x.Idtk == Id).Select(x => new
            {
                STT = i++,
                x.Idda,
                x.TenDuAn,
                x.Gia,
                x.Diachi,
                x.Dientich,
                x.Mota,
                x.Idtk
            }).ToList());
        }
    }
}
