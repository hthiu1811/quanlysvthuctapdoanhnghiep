using PTHDTOOP.Controllers;
using PTHDTOOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTHDTOOP
{
    public partial class ĐăngKýTàiKhoản : Form
    {
        public ĐăngKýTàiKhoản()
        {
            InitializeComponent();
        }
        // RegisterForm.cs
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            UserModel newUser = new UserModel
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                
            };

            //UserController userController = new UserController();

            //if (userController.DangKy(newUser))
            bool result = userController.DangKy(newUser);
            if (result)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Username hoặc Email đã tồn tại!");
            }
        }

    }
}
