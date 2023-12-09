using System;
using System.Collections.Generic;

namespace QuanLyDuAnBDS.Models;

public partial class DuAnDaDuyet
{
    public int Idda { get; set; }

    public string TenDuAn { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string? Mota { get; set; }

    public int? Gia { get; set; }

    public double? Dientich { get; set; }

    public int Idtk { get; set; }

    public virtual TkDangNhap IdtkNavigation { get; set; } = null!;
}
