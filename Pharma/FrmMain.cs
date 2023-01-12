using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers vForm = new FrmUsers();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusinessinfo vForm = new FrmBusinessinfo();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void medicineCompanyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicineCompanyName vForm = new FrmMedicineCompanyName();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void medicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedType vForm = new FrmMedType();
            vForm.MdiParent = this;
            vForm.Show();
        }
    }
}
