using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma
{
    public partial class FrmBusinessinfo : Form
    {
        DAL.Businessinfo objDAL = new DAL.Businessinfo();
        Byte[] openedBLOBData = new Byte[0];
        public FrmBusinessinfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Object.Businessinfo obj = new Object.Businessinfo();

            obj.CompanyName = txtCompanyName.Text;
            obj.Website = txtWebsite.Text;
            obj.ContactNo = txtContactNo.Text;
            obj.Address = txtAddress.Text;

            if (CompanyLogo.ImageLocation != null)
            {
                FileInfo finfo = new FileInfo(CompanyLogo.ImageLocation);
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
                fStream.Read(btImage, 0, btImage.Length);
                fStream.Close();
                obj.Logo = btImage;
            }
            else
            if (openedBLOBData.Length > 0)
            {
                obj.Logo = openedBLOBData;
            }

            objDAL.DeleteRecord();
            objDAL.InsertRecord(obj);

            MessageBox.Show("Data Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            CompanyLogo.Load(openFileDialog1.FileName);
            CompanyLogo.Tag = openFileDialog1.FileName;
        }

        private void FrmBusinessinfo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCompanyName;

            DataTable du = objDAL.getRecord();

            if (du.Rows.Count > 0)
            {
                txtCompanyName.Text = du.Rows[0]["CompanyName"].ToString();
                txtWebsite.Text = du.Rows[0]["Website"].ToString();
                txtContactNo.Text = du.Rows[0]["ContactNo"].ToString();
                txtAddress.Text = du.Rows[0]["Address"].ToString();

                if (du.Rows[0]["Logo"].ToString() != string.Empty)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    openedBLOBData = byteBLOBData = (Byte[])(du.Rows[0]["Logo"]);

                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    stmBLOBData.Seek(0, SeekOrigin.Begin);
                    //CompanyLogo.Image = Image.FromStream(stmBLOBData);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CompanyLogo.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
