using QuanLyDuAnBDS.DAL.Repositories;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.BLL.Services
{
    public class TkDnServices
    {
        TkDnRepostitories tkdnre = new();
        public List<TkDangNhap> GetAllTksv()
        {
            return tkdnre.GetAllTk();
        }
        public List<TkDangNhap> ChecktkDt(string tdn ,string mk)
        {
            return tkdnre.CheckTkDt(tdn ,mk);
        }
        public string AddChucNang(string chucnang , int id)
        {
            TkDangNhap tkdn = tkdnre.GetAllTk().Find(x => x.Idtk == id);
            tkdn.Chucdanh = chucnang;
            if (tkdnre.AddChucNang(tkdn))
            {
                return "Tạo tài khoản thành công";
            }
            else 
            {
                return "Tạo tài khoản thất bại";
            }
        }
    }
}
