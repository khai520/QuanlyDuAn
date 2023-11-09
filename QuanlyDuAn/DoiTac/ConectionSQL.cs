using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTac
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
            string s = "Data Source =.; Initaial Catalog = QLDA; Integarated Security = True";
            conn = new SqlConnection(s); //  khởi tạo kết nối
            da = new SqlDataAdapter(); // khởi tạo bộ điều phối dữ liệu
            ds = new DataSet(); // khởi tạo ảnh của cơ sở dữ liệu
        }
        public void getData(ListView lv)
        {
            com = new SqlCommand("select * form ", conn);// Câu lệnh truy vấn
            da.SelectCommand = com; // select
            da.Fill(ds, "Product"); // điền dữ liệu trên listview
            for (int row = 0; row < ds.Tables[0].Rows.Count; row++)// chạy từ dòng 0 đến n
            {
                lv.Items.Add(ds.Tables[0].Rows[row].ItemArray[0].ToString());// Thêm dòng
                lv.Items[row].SubItems.Add(ds.Tables[0].Rows[row].ItemArray[1].ToString());
                lv.Items[row].SubItems.Add(ds.Tables[0].Rows[row].ItemArray[2].ToString());
                lv.Items[row].SubItems.Add(ds.Tables[0].Rows[row].ItemArray[3].ToString());
            }
        }
    }
}
