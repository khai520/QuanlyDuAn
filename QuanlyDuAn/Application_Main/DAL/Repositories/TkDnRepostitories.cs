using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.DAL.Repositories
{
    public class TkDnRepostitories
    {
        QlbdsContext db = new();
        public List<TkDangNhap> GetAllTk()
        {
            return db.TkDangNhaps.ToList();
        }
        public List<TkDangNhap> CheckTkDt(string tdn , string mk)
        {
                return db.TkDangNhaps.Where(x => x.Tdn == tdn && x.Mk == mk).ToList();
        }
        public bool AddChucNang(TkDangNhap tkdn )
        {
            db.TkDangNhaps.Update(tkdn);
            return db.SaveChanges() > 0;
        }
    }
}
