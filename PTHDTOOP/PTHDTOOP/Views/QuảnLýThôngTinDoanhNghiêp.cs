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
using System.Xml.Linq;

namespace PTHDTOOP
{
    public partial class QuảnLýThôngTinDoanhNghiêp : Form
    {
        public QuảnLýThôngTinDoanhNghiêp()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DoanhNghiepModel company = new DoanhNghiepModel
            {
                TenDoanhNghiep = txtName.Text,
                LinhVuc = txtIndustry.Text,
                DiaChi = txtAddress.Text
            };

            if (DoanhNghiepController.ThemDoanhNghiep(company))
            {
                MessageBox.Show("Thêm doanh nghiệp thành công!");
            }
            else
            {
                MessageBox.Show("Doanh nghiệp đã tồn tại!");
            }
        }
    }
}
