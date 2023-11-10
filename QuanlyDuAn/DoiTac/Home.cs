using ListViewSortAnyColumn;
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


namespace DoiTac
{
   
    public partial class Home : Form
    {
        
        ConectionSQL conectionSQL = new ConectionSQL();
        private ItemComparer lvwColumnSorter;
        public Home()
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
    }
}
