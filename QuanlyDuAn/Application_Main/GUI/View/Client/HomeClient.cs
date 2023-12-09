using Application;
using QuanLyDuAnBDS.BLL.Services;

namespace WinFormsApp2
{
    public partial class HomeClient : Form
    {
        public HomeClient()
        {
            InitializeComponent();
        }
        private DADDServices dadd;
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
    }
}