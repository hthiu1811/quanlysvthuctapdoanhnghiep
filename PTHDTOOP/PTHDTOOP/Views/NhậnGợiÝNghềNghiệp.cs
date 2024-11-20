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
    public partial class NhậnGợiÝNghềNghiệp : Form
    {
        private object lstGoiY;

        public NhậnGợiÝNghềNghiệp()
        {
            InitializeComponent();
        }
        private void btnLayGoiY_Click(object sender, EventArgs e)
        {
            var goiY = GoiYNgheNghiepController.LayGoiY(txtKyNang.Text);
            lstGoiY.DataSource = goiY;
        }
    }
}
