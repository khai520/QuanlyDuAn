using QuanLyDuAnBDS.DAL.Repositories;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.BLL.Services
{
    public class DADDServices
    {
        DADDRepositories dadre = new();
        public List<DuAnDaDuyet> GetAllDADD()
        {
            return dadre.GetAllDaDD();
        }
        public List<DuAnDaDuyet> Timkiem(string? Idda , string? Ten , string? Dc , string? dientich , string? gia , string? iddt , string? Mota)
        {
            var checkIdda = dadre.GetAllDaDD();
            try
            {
                if (Idda != "")
                {
                    checkIdda = checkIdda.Where(x => x.Idda == Convert.ToInt32(Idda)).ToList();
                }
                if (Ten != "")
                {
                    checkIdda = checkIdda.Where(x => x.TenDuAn.ToUpper().Contains(Ten.ToUpper())).ToList();
                }
                if (Dc != "")
                {
                    checkIdda = checkIdda.Where(x => x.Diachi.ToUpper().Contains(Dc.ToUpper())).ToList();
                }
                if (dientich != "")
                {
                    checkIdda = checkIdda.Where(x => x.Dientich == Convert.ToDouble(dientich)).ToList();
                }
                if (gia != "")
                {
                    checkIdda = checkIdda.Where(x => x.Gia == Convert.ToInt32(gia)).ToList();
                }
                if (iddt != "")
                {
                    checkIdda = checkIdda.Where(x => x.Idtk == Convert.ToInt32(iddt)).ToList();
                }
                if (Mota != "")
                {
                    checkIdda = checkIdda.Where(x => x.Mota.ToUpper().Contains(Mota.ToUpper())).ToList();
                }
                return checkIdda;
            }
            catch (Exception)
            {
                MessageBox.Show("Sai định dạng");
                return dadre.GetAllDaDD();
            }  
        }
    }
}
