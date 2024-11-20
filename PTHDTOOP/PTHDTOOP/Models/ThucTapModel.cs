using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class ThucTapModel
    {
        public int Id { get; set; }
        public int SinhVienId { get; set; }
        public string TenGiaiDoan { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string TrangThai { get; set; }
        public string DanhGia { get; set; }
    }
}
