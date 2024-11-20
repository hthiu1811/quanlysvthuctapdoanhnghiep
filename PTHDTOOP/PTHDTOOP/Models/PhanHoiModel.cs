using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class PhanHoiModel
    {
        public int Id { get; set; }
        public int SinhVienId { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
