using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class ThucTapSinhModel
    {
        public int Id { get; set; }
        public int SinhVienId { get; set; }
        public int DoanhNghiepId { get; set; }
        public string ViTriThucTap { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
    }
}
}
