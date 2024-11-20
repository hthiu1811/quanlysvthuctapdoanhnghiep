using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class DanhGiaController
    {
        private List<DanhGiaModel> danhGiaList = new List<DanhGiaModel>();

        public List<DanhGiaModel> GetDanhGiaBySinhVien(int sinhVienId)
        {
            return danhGiaList.Where(d => d.SinhVienId == sinhVienId).ToList();
        }

        public void AddDanhGia(DanhGiaModel danhGia)
        {
            danhGiaList.Add(danhGia);
        }
    }
}
