using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class DanhGiaModel
    {
        public int Id { get; set; }
        public int SinhVienId { get; set; }
        public int DoanhNghiepId { get; set; }
        public string NhanXet { get; set; }
        public int DiemDanhGia { get; set; } // 1-10
        public DateTime NgayDanhGia { get; set; }
    }
}
