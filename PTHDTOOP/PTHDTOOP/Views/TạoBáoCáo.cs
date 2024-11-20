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
    public partial class TạoBáoCáo : Form
    {
        public TạoBáoCáo()
        {
            InitializeComponent();
        }
        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoController.TaoBaoCao(txtTitle.Text, txtContent.Text);
            MessageBox.Show("Báo cáo đã được tạo!");
        }

    }
}
