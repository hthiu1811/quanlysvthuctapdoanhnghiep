using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class ThucTapController
    {
        private List<ThucTapModel> thucTapList = new List<ThucTapModel>();

        public List<ThucTapModel> GetThucTapBySinhVien(int sinhVienId)
        {
            return thucTapList.Where(t => t.SinhVienId == sinhVienId).ToList();
        }

        public void AddThucTap(ThucTapModel thucTap)
        {
            thucTapList.Add(thucTap);
        }
    }
}
