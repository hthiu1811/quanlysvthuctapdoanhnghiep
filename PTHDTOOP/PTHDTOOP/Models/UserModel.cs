﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTHDTOOP.Models
{
    internal class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // SinhVien, DoanhNghiep, Admin
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
