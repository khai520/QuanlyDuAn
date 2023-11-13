using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.DB
{
    internal class ConectionSQL
    {
        SqlConnection conn; //Hỗ trợ kết nối
        SqlCommand com; // Hỗ trợ xử lý lệnh
        SqlDataAdapter da; //adapter
        DataSet ds; // anh bang du lieu
        public void Ketnoi()
        {
            // chuỗi kết nối csdl
            string s = "Data Source =.; Initial Catalog = QLBDS; Integrated Security = True";
            conn = new SqlConnection(s); //  khởi tạo kết nối
            da = new SqlDataAdapter(); // khởi tạo bộ điều phối dữ liệu
            ds = new DataSet(); // khởi tạo ảnh của cơ sở dữ liệu
        }
        public void getDataDSDD(ListView lv)
        {
            lv.Items.Clear();
            ds.Reset();
            com = new SqlCommand("select * from DuAnDaDuyet ", conn);// Câu lệnh truy vấn
            da.SelectCommand = com; // select
            da.Fill(ds, "DuAnDaDuyet"); // điền dữ liệu vào dataset
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                lv.Items.Add(Convert.ToString(j + 1));
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    lv.Items[j].SubItems.Add(ds.Tables[0].Rows[j].ItemArray[i].ToString());
                }
            }
        }
        public string getDataTk(string tdn, string mk)
        {
            ds.Reset();
            com = new SqlCommand($"select Chucdanh from TkDangNhap where Tdn = '{tdn}' and Mk = '{mk}'", conn);
            da.SelectCommand = com;
            da.Fill(ds, "TkDangNhap");
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "DoiTac")
                {
                    return "DT";
                }
                else
                {
                    return "Null";
                }
            }
            else
            {
                return "Null";
            }
        }
    }
}
