using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.DAL.Repositories
{
    public class DACDrepositories
    {
        QlbdsContext db = new();
        public List<DuAnChuaDuyet> GetAllDACD()
        {
            return db.DuAnChuaDuyets.ToList();
        }
        public bool AddDa(DuAnChuaDuyet list)
        {
            db.DuAnChuaDuyets.Add(list);
            return db.SaveChanges() > 0;
        }
    }
}
