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
    public partial class TheoDõiQuaTrinhThựcTập : Form
    {
        public TheoDõiQuaTrinhThựcTập()
        {
            InitializeComponent();
        }
        private void LoadInternshipData()
        {
            var danhSachThucTap = internshipController.LayDanhSachThucTap(currentUser.Id);
            dgvInternships.DataSource = danhSachThucTap;
        }
    }
}
