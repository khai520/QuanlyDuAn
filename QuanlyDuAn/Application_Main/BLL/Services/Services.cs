using QuanLyDuAnBDS.DAL.Models;
using QuanLyDuAnBDS.DAL.Repositories;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.BLL.Services
{
    public class Services
    {
        private DACDrepositories dACDrepositories;
        private DADDRepositories aDDRepositories;
        public List<DuAnChuaDuyet> DACDCT(int Id)
        {
            return dACDrepositories.GetAllDACD().Where(x => x.Idtk == Id).ToList();
        }
        public List<DuAnDaDuyet> DADDCT(int Id)
        {
            return aDDRepositories.GetAllDaDD().Where(x => x.Idtk == Id).ToList();
        }
    }
}
