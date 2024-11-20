using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class PhanHoiController
    {
        private List<PhanHoiModel> phanHoiList = new List<PhanHoiModel>();

        public void AddPhanHoi(PhanHoiModel phanHoi)
        {
            phanHoiList.Add(phanHoi);
        }

        public List<PhanHoiModel> GetPhanHoiBySinhVien(int sinhVienId)
        {
            return phanHoiList.Where(p => p.SinhVienId == sinhVienId).ToList();
        }
    }
}
