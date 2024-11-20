using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class TrangChuViewModel
    {
        public string TenNguoiDung { get; set; }
        public List<string> ThongBao { get; set; }
        public double TienDoThucTap { get; set; }
        public List<string> ViecCanHoanThanh { get; set; }
    }
}
