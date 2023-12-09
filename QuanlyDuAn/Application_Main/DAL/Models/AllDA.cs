using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.DAL.Models
{
    public class AllDA
    {
        public int Idda { get; set; }

        public string TenDuAn { get; set; } = null!;

        public string Diachi { get; set; } = null!;

        public string? Mota { get; set; }

        public int? Gia { get; set; }

        public double? Dientich { get; set; }

        public int Idtk { get; set; }
        public string? TinhTrang { get; set; }
    }
}
