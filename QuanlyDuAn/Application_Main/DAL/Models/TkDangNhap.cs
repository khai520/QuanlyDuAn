using System;
using System.Collections.Generic;

namespace QuanLyDuAnBDS.Models;

public partial class TkDangNhap
{
    public string? Chucdanh { get; set; }

    public int Idtk { get; set; }

    public string Tdn { get; set; } = null!;

    public string Mk { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Gt { get; set; } = null!;

    public DateTime Ns { get; set; }

    public string? Gmail { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<DuAnChuaDuyet> DuAnChuaDuyets { get; set; } = new List<DuAnChuaDuyet>();
}
