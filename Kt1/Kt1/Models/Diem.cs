using System;
using System.Collections.Generic;

namespace Kt1.Models
{
    public partial class Diem
    {
        public string MaSv { get; set; } = null!;
        public string MonHoc { get; set; } = null!;
        public double? DiemThuongXuyen { get; set; }
        public double? DiemThi { get; set; }
    }
}
