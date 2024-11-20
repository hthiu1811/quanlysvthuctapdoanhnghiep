using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class HoTroController
    {
        private List<HoTroModel> hoTroList = new List<HoTroModel>();

        public void AddHoTro(HoTroModel hoTro)
        {
            hoTroList.Add(hoTro);
        }

        public List<HoTroModel> GetHoTroByUser(int userId)
        {
            return hoTroList.Where(h => h.UserId == userId).ToList();
        }

        public void UpdateTinhTrangHoTro(int hoTroId, string tinhTrang)
        {
            var hoTro = hoTroList.FirstOrDefault(h => h.Id == hoTroId);
            if (hoTro != null)
            {
                hoTro.TinhTrang = tinhTrang;
            }
        }
    }
}
