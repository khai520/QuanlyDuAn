﻿using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.DAL.Repositories
{
    public class DADDRepositories
    {
        QlbdsContext db = new();
        public List<DuAnDaDuyet> GetAllDaDD()
        {
            return db.DuAnDaDuyets.ToList();
        }
    }
}
