using Kt1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kt1
{
    public partial class Form3 : Form
    {
        QLDiemContext db = new QLDiemContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgv_Diem.DataSource = db.Diems.Select(x => new
            {
                ID = x.MaSv,
                x.MonHoc,
                x.DiemThuongXuyen,
                x.DiemThi,
                Dtk = (x.DiemThuongXuyen + x.DiemThi * 1)/3
            }).OrderBy(x => x.ID).ToList();

            dgv_Diem.Columns[0].HeaderText = "Mã sinh viên";
            dgv_Diem.Columns[1].HeaderText = "Môn học";
            dgv_Diem.Columns[2].HeaderText = "Điểm thường xuyên";
            dgv_Diem.Columns[3].HeaderText = "Điểm thi";
            dgv_Diem.Columns[4].HeaderText = "Điểm tổng kết";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
