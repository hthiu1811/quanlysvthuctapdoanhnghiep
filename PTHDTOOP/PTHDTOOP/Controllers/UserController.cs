using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Controllers
{
    internal class UserController
    {
        private List<UserModel> users = new List<UserModel>();

        public bool DangKy(UserModel user)
        {
            // Kiểm tra xem Username hoặc Email đã tồn tại chưa
            if (users.Exists(u => u.UserName == user.UserName || u.Email == user.Email))
            {
                return false;
            }
            users.Add(user);
            Console.WriteLine("Đăng ký tài khoản thành công!");
        }

        public UserModel DangNhap(string username, string password)
        {
            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
        public void DeleteUser(int userId)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("Xóa tài khoản thành công!");
            }
        }
        public bool CapNhatThongTin(UserModel updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user.FullName = updatedUser.FullName;
                user.Email = updatedUser.Email;
                user.Address = updatedUser.Address;
                user.Phone = updatedUser.Phone;
                return true;
            }
            return false;
        }
    }
}
