using QuanLyDuAnBDS.DB;
using QuanLyDuAnBDS.Upg;
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
        private ItemComparer lvwColumnSorter;
        public HomeDT()
        {
            InitializeComponent();
            conectionSQL.Ketnoi();
            ListDataAll();
        }

        public void ListDataAll()
        {
            conectionSQL.getDataDSDD(list_Danhsach);
        }

        private void btn_TcDa_Click(object sender, EventArgs e)
        {
            ListDataAll();
        }
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.list_Danhsach.Sort();
        }

        private void list_Danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void XemChiTietDuAn()
        {
             
        }
        private void btn_CtDa_Click(object sender, EventArgs e)
        {

        }
    }
}
