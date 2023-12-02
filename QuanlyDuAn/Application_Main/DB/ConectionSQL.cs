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
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                lv.Items.Add(Convert.ToString(j + 1));
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    lv.Items[j].SubItems.Add(ds.Tables[0].Rows[j].ItemArray[i].ToString());
                }
            }
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
                            string? IDTam = "";
                            for (int i = 1; i < 1000; i++)
                            {
                                if (i > 0 && i < 10 && db.TkDangNhaps.Where(x => x.Idtk == $"00{i}") != null)
                                {
                                    IDTam = $"id00{i}";
                                }
                                else if (i >= 10 && i < 100 && db.TkDangNhaps.Where(x => x.Idtk == $"0{i}") != null)
                                {
                                    IDTam = $"id0{i}";
                                }
                                else if (db.TkDangNhaps.Where(x => x.Idtk == $"{i}") != null)
                                {
                                    IDTam = $"id{i}";
                                }
                                else
                                {
                                    MessageBox.Show("Ứng dụng hiện đang được Update !Vui lòng tạo tài khoản lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    infor infor = new();
                                    infor.Close();
                                }
                            }
                            TkDangNhap tkdn = new TkDangNhap()
                            {
                                Chucdanh = null,
                                Idtk = IDTam,
                                Tdn = tk,
                                Mk = mk,
                                Ten = hvt,
                                Gt = gt == "Nam" ? 0 : gt == "Nữ" ? 1 : 2,
                                Ns = DateTime.ParseExact(ns.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", null),
                                Gmail = gmail,
                                Sdt = sdt,
                            };
                            db.Add( tkdn);
                            db.SaveChanges();
                            RegisterObj rgo = new RegisterObj();
                            rgo.XetKh(IDTam);
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
