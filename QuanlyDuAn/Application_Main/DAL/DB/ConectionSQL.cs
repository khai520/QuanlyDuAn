using QuanLyDuAnBDS.Log;
using QuanLyDuAnBDS.Models;
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
        QlbdsContext db = new();
        
        public void Ketnoi()
        {
            // chuỗi kết nối csdl
            string s = "Data Source =.; Initial Catalog = QLBDS; Integrated Security = True";
            conn = new SqlConnection(s); //  khởi tạo kết nối
            da = new SqlDataAdapter(); // khởi tạo bộ điều phối dữ liệu
            ds = new DataSet(); // khởi tạo ảnh của cơ sở dữ liệu
        }
        //private bool check()
        //{

        //}
        public void getData(ListView lv , string cmd)
        {
            Ketnoi();
            lv.Items.Clear();
            ds.Reset();
            com = new SqlCommand(cmd, conn);// Câu lệnh truy vấn
            da.SelectCommand = com; // select
            da.Fill(ds, "DuAnDaDuyet"); // điền dữ liệu vào dataset
            
        }
        public string KiemtraMk(string tk, string mk, string xnmk)
        {
            string check = tk == "" && mk == "" && xnmk == "" ? "Chưa nhập tài khoản và mật khẩu" : db.TkDangNhaps.Where(x => x.Tdn == tk).SingleOrDefault() != null ? "Tên đăng nhập hiện đã có" : mk.Length < 6 ? "Mật khẩu quá ngắn" : mk != xnmk ? "Xác nhận mật khẩu không trùng khớp" : "";
            return check;
        }
        public string? getDataTk(string tdn, string mk)
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
                return null;
            }
        }
        //private string idTam()
        //{
        //    string idtam;
        //    for (int j = 0; j < 1000; j++) 
        //    {
        //        int i = 1;
                
              
        //    }
        //}
        public bool setDataTk(string tk , string mk, string hvt , string gt , DateTimePicker ns , string? gmail , string sdt)
        {
            Ketnoi();
            ds.Reset();
            if (!string.IsNullOrEmpty(hvt))
            {
                if (DateTime.Now.Year - ns.Value.Year > 18)
                {
                    if (string.IsNullOrEmpty(gmail) || gmail.Contains("@gmail.com"))
                    {
                        if (!string.IsNullOrEmpty(sdt) && sdt.Length > 9 && (sdt.StartsWith("01") || sdt.StartsWith("09") || sdt.StartsWith("08")))
                        {

                            
                        TkDangNhap tkdn = new TkDangNhap()
                        {
                            Chucdanh = null,
                            Tdn = tk,
                            Mk = mk,
                            HoTen = hvt,
                            Gt = gt,
                            Ns = DateTime.ParseExact(ns.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", null),
                            Gmail = gmail,
                            Sdt = sdt,
                        };
                        db.Add(tkdn);
                        db.SaveChanges();
                        RegisterObj rgo = new RegisterObj(tk , mk);
                        return true;
                        }
                        else
                        {
                            MessageBox.Show("Sdt sai!!" , "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gmail sai!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Ngày sinh phải trên 18 tuổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Họ và tên thiếu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
