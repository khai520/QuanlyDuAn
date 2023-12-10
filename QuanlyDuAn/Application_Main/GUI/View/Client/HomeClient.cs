using Application;
using QuanLyDuAnBDS.BLL.Services;

namespace WinFormsApp2
{
    public partial class HomeClient : Form
    {
        int Id;
        public HomeClient(int ID)
        {
            InitializeComponent();
            Id = ID;
        }
        private DADDServices dadd;
        private Services sv;
        public void LoadData()
        {
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
            dgv_listdanhsach.Columns[2].HeaderText = "Id D? án";
            dgv_listdanhsach.Columns[3].HeaderText = "Tên d? án";
            dgv_listdanhsach.Columns[4].HeaderText = "Giá";
            dgv_listdanhsach.Columns[5].HeaderText = "Ð?a ch?";
            dgv_listdanhsach.Columns[6].HeaderText = "Di?n tích";
            dgv_listdanhsach.Columns[7].HeaderText = "Mô t? ";
        }

        private void HomeClient_Load(object sender, EventArgs e)
        {
            dadd = new();
            LoadData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_listdanhsach.DataSource = dadd.Timkiem(txt_Id.Text, txt_Ten.Text, txt_Diachi.Text, txt_Dientich.Text, txt_Gia.Text, txt_IdChungCu.Text, txt_Mota.Text);
        }


        private void HomeClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login lg = new();
            lg.ShowDialog();
            this.Close();
        }

        private void dgv_listdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        x.Idtk
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
                        x.Idtk
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
                        x.Idtk
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
                        x.Idtk
                    }).ToList();
                }

            }
        }
    }
}