using PTHDTOOP.Controllers;
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
    public partial class CậpNhậtThôngTinCáNhân : Form
    {
        private object currentUser;
        public CậpNhậtThôngTinCáNhân()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            currentUser.FullName = txtFullName.Text;
            currentUser.Email = txtEmail.Text;
            currentUser.Address = txtAddress.Text;
            currentUser.Phone = txtPhone.Text;

            if (UserController.CapNhatThongTin(currentUser))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
    }
}
