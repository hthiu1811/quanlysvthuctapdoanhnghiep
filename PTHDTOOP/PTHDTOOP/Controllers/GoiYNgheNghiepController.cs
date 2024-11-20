using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class GoiYNgheNghiepController
    {
        private List<GoiYNgheNghiepModel> goiYList = new List<GoiYNgheNghiepModel>();

        public List<GoiYNgheNghiepModel> GetGoiYByKyNang(string kyNang)
        {
            return goiYList.Where(g => g.YeuCauKyNang.Contains(kyNang)).ToList();
        }
    }
}
