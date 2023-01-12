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
    public partial class FrmMedicineCompanyName : Form
    {
        bool vIsOpen = false;
        DAL.MedicineCompanyName objDAL = new DAL.MedicineCompanyName();
        public FrmMedicineCompanyName()
        {
            InitializeComponent();
        }

        private void DataGrid()
        {
            CompanyDataTable.DataSource = null;
            DataTable dt = objDAL.getRecord();
            CompanyDataTable.DataSource = dt;
            CompanyDataTable.AutoGenerateColumns = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Object.MedicineCompanyName obj = new Object.MedicineCompanyName();
  
            obj.CompanyID = Convert.ToInt32(txtCompanyID.Text);
            obj.CompanyName = txtCompanyName.Text;
            obj.ContactPerson = txtContactPerson.Text;
            obj.ContactNo = txtContactNo.Text;
            obj.Remarks = txtRemarks.Text;


            if (txtCompanyName.Text.Length == 0)
            {

                MessageBox.Show("Department Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return;
            }

            if (vIsOpen)
            {
                objDAL.UpdateRecord(obj);
            }
            else
            {
                objDAL.InsertRecord(obj);
            }
            MessageBox.Show("Data Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyID.Text = objDAL.GetNextNumber();
            txtRemarks.Clear();
            vIsOpen = false;

            DataGrid();
        }

        private void FrmMedicineCompanyName_Load(object sender, EventArgs e)
        {
            btnClear_Click(null, null);
            DataGrid();

          
        }

     
    }
}
