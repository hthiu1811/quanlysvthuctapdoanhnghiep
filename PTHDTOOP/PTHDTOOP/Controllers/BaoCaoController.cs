using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class BaoCaoController
    {
        private List<BaoCaoModel> baoCaoList = new List<BaoCaoModel>();

        public void TaoBaoCao(string title, string content)
        {
            baoCaoList.Add(new BaoCaoModel
            {
                Id = baoCaoList.Count + 1,
                TieuDe = title,
                NoiDung = content,
                NgayTao = DateTime.Now
            });
        }
        //public void AddBaoCao(BaoCaoModel baoCao)
        //{
        //    baoCaoList.Add(baoCao);
        //}

        public List<BaoCaoModel> GetBaoCaoBySinhVien(int sinhVienId)
        {
            return baoCaoList.Where(b => b.SinhVienId == sinhVienId).ToList();
        }
    }
}
