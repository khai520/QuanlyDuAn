using QuanLyDuAnBDS.DAL.Repositories;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.BLL.Services
{
    public class DACDServices
    {
        DACDrepositories dacdre = new();
        public List<DuAnChuaDuyet> GetAllDACD()
        {
            return dacdre.GetAllDACD();
        }
        public List<DuAnChuaDuyet> Timkiem(int? Idda, string? Ten, string? Dc, double? dientich, int? gia, int? iddt, string? Mota)
        {
            var checkIdda = dacdre.GetAllDACD();
            if (Idda != null)
            {
                checkIdda = checkIdda.Where(x => x.Idda == Idda).ToList();
            }
            if (Ten != null)
            {
                checkIdda = checkIdda.Where(x => x.TenDuAn == Ten).ToList();
            }
            if (Dc != null)
            {
                checkIdda = checkIdda.Where(x => x.Diachi == Dc).ToList();
            }
            if (dientich != null)
            {
                checkIdda = checkIdda.Where(x => x.Dientich == dientich).ToList();
            }
            if (gia != null)
            {
                checkIdda = checkIdda.Where(x => x.Gia == gia).ToList();
            }
            if (iddt != null)
            {
                checkIdda = checkIdda.Where(x => x.Idtk == iddt).ToList();
            }
            if (Mota != null)
            {
                checkIdda = checkIdda.Where(x => x.Mota == Mota).ToList();
            }
            return checkIdda;
        }
    }
}
