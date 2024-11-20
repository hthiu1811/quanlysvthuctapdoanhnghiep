using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class DoanhNghiepController
    {
        private List<DoanhNghiepModel> doanhNghiepList = new List<DoanhNghiepModel>();

        public List<DoanhNghiepModel> GetAllDoanhNghiep()
        {
            return doanhNghiepList;
        }

        public bool ThemDoanhNghiep(DoanhNghiepModel company)
        {
            if (doanhNghiepList.Exists(c => c.TenDoanhNghiep == company.TenDoanhNghiep))
            {
                return false; // Doanh nghiệp đã tồn tại
            }

            doanhNghiepList.Add(company);
            return true;
        }

        //public void AddDoanhNghiep(DoanhNghiepModel doanhNghiep)
        //{
        //    doanhNghiepList.Add(doanhNghiep);
        //}
        public void DangKyDoanhNghiep(DoanhNghiepModel doanhNghiep)
        {
            doanhNghiepList.Add(doanhNghiep);
            Console.WriteLine("Doanh nghiệp đã được đăng ký thành công!");
        }
    }
}
