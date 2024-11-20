using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class HoTroModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayYeuCau { get; set; }
        public string TinhTrang { get; set; } // Pending, Resolved
    }
}
