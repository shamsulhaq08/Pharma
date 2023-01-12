using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma
{
    public partial class FrmSMS : Form
    {
        public FrmSMS()
        {
            InitializeComponent();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {

                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    try
                    {
                        string url = "http://smsc.vianett.no/v3/send.ashx?" +
                            "src=" + txtPassword.Text + "&" +
                            "dst=" + txtPassword.Text + "&" +
                            "msg=" + System.Web.HttpUtility.UrlEncode(txtMessage.Text, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "&" +
                            "username=" + System.Web.HttpUtility.UrlEncode(txtUsername.Text) + "&" +
                            "password=" + System.Web.HttpUtility.UrlEncode(txtPassword.Text);
                        //Call web api to send sms messages
                        string result = client.DownloadString(url);
                        if (result.Contains("OK"))
                            MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Message send failure.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
           
        }
    }
}
