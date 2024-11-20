using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class ThucTapSinhController
    {
        private List<ThucTapSinhModel> thucTapSinhList = new List<ThucTapSinhModel>();

        public List<ThucTapSinhModel> GetThucTapSinhByDoanhNghiep(int doanhNghiepId)
        {
            return thucTapSinhList.Where(t => t.DoanhNghiepId == doanhNghiepId).ToList();
        }

        public List<ThucTapSinhModel> GetThucTapSinhBySinhVien(int sinhVienId)
        {
            return thucTapSinhList.Where(t => t.SinhVienId == sinhVienId).ToList();
        }

        public void AddThucTapSinh(ThucTapSinhModel thucTapSinh)
        {
            thucTapSinhList.Add(thucTapSinh);
        }
    }
}
