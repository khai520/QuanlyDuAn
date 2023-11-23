using Kt1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kt1
{
    public partial class Form2 : Form
    {
        QLDiemContext db = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SinhVien svThem = new SinhVien()
            {
                MaSv = txt_Msv.Text,
                HoTen = txt_Hvt.Text,
                SoDt = txt_dt.Text,
            };
            db.SinhViens.Add(svThem);
            db.SaveChanges();
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string luu = txt_Msv.Text;
            SinhVien svSua = db.SinhViens.Find(luu);
            if (svSua != null)
            {
                svSua.MaSv = txt_Msv.Text;
                svSua.HoTen = txt_Hvt.Text;
                svSua.SoDt = txt_dt.Text;
            }
            db.SaveChanges();
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string xoa = txt_Msv.Text;
            SinhVien svxoa = db.SinhViens.Find(xoa);
            if (svxoa != null)
            {
               db.Remove(svxoa);
            }
            db.SaveChanges();
            LoadData();
        }
        private void LoadData()
        {
            dgv_danhsach.DataSource = db.SinhViens.Select(x => new
            {
                ID = x.MaSv,
                x.HoTen,
                x.SoDt
            }).OrderBy(x => x.HoTen).ToList();

            dgv_danhsach.Columns[0].HeaderText = "Mã sinh viên";
            dgv_danhsach.Columns[1].HeaderText = "Họ và tên sinh viên";
            dgv_danhsach.Columns[2].HeaderText = "SDT";

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_Msv.Text = dgv_danhsach.Rows[d].Cells[0].Value.ToString();
            txt_Hvt.Text = dgv_danhsach.Rows[d].Cells[1].Value.ToString();
            txt_dt.Text = dgv_danhsach.Rows[d].Cells[2].Value.ToString();
        }
    }
}
