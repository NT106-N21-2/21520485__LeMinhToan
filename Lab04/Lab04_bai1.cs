using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab04_bai1 : Form
    {
        public Lab04_bai1()
        {
            InitializeComponent();
        }
        private string getHTML(string szURL)
        {
            try
            {
                WebRequest request = WebRequest.Create(szURL);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                return responseFromServer;
            }
            catch
            {
                return "";
            }
           
        }
        private void btn_get_Click(object sender, EventArgs e)
        {
            if (link.Text.Trim() != "")
                banghienthi.Text = getHTML(link.Text);
            else 
                MessageBox.Show("Vui lòng nhập link");
        }
    }
}
