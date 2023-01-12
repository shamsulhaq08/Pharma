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
    public partial class FrmMedType : Form
    {
        DAL.MedType objDAL = new DAL.MedType();

        bool vIsOpen = false;
        public FrmMedType()
        {
            InitializeComponent();
        }


        private void DataGrid()
        {
            MedicineTypeGrid.DataSource = null;
            DataTable dt = objDAL.getRecord("");
            MedicineTypeGrid.DataSource = dt;
            MedicineTypeGrid.AutoGenerateColumns = false;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            Object.MedType obj = new Object.MedType();

            obj.TypeID = Convert.ToInt32(txtTypeID.Text);

         
            obj.MediType = txtMediType.Text;

            if (txtMediType.Text.Length == 0)
            {

                MessageBox.Show("Designation Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMediType.Focus();
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
            MessageBox.Show("Record Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(null, null);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTypeID.Text = objDAL.GetNextNumber();
            txtMediType.Clear();
            DataGrid();
            vIsOpen = false;
            //MedicineTypeGrid();
            MedicineTypeGrid.Enabled = false;
        }


        private void FrmMedType_Load(object sender, EventArgs e)
        {
            DataGrid();
            btnClear_Click(null, null);
        }

        private void MedicineTypeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MedicineTypeGrid.Rows.Count > 0 && MedicineTypeGrid.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.MedicineTypeGrid.Rows[MedicineTypeGrid.CurrentRow.Index];
                txtTypeID.Text = row.Cells["TypeID"].Value.ToString();
                DataTable dt = objDAL.getRecord("AND MedType.TypeID =" + txtTypeID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtTypeID.Text = dt.Rows[0]["TypeID"].ToString();
                    txtMediType.Text = dt.Rows[0]["MediType"].ToString();


                }

                vIsOpen = true;
            }

        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfilter.Text))
            {
                MedicineTypeGrid.AutoGenerateColumns = false;
                MedicineTypeGrid.DataSource = objDAL.getRecord("AND MedType.MediType like '%" + txtfilter.Text + "%'");
            }
            else
            {
                MedicineTypeGrid.AutoGenerateColumns = false;
                MedicineTypeGrid.DataSource = objDAL.getRecord("");
            }
        }
    }
}
