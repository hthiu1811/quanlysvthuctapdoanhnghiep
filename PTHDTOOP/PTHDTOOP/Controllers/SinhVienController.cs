using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class SinhVienController
    {
        private List<SinhVienModel> sinhVienList = new List<SinhVienModel>();

        public SinhVienModel GetSinhVien(int id)
        {
            return sinhVienList.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateSinhVien(SinhVienModel sinhVien)
        {
            var existing = sinhVienList.FirstOrDefault(s => s.Id == sinhVien.Id);
            if (existing != null)
            {
                existing.HoTen = sinhVien.HoTen;
                existing.NgaySinh = sinhVien.NgaySinh;
                existing.NganhHoc = sinhVien.NganhHoc;
                existing.KyNang = sinhVien.KyNang;
                Console.WriteLine("Cập nhật thông tin thành công!");
            }
        }
        //public SinhVienModel GetSinhVien(int id)
        //{
        //    // Giả lập dữ liệu (có thể kết nối cơ sở dữ liệu tại đây)
        //    return new SinhVienModel
        //    {
        //        Id = id,
        //        HoTen = "Nguyen Van A",
        //        NgaySinh = new DateTime(2000, 1, 1),
        //        NganhHoc = "Công nghệ thông tin",
        //        KyNang = "C#, SQL"
        //    };
        //}

        //public void UpdateSinhVien(SinhVienModel sinhVien)
        //{
        //    // Thực hiện cập nhật sinh viên vào cơ sở dữ liệu
        //    Console.WriteLine($"Đã cập nhật thông tin sinh viên: {sinhVien.HoTen}");
        //}
    }
}
