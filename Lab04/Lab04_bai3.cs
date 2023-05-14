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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class Lab04_bai3 : Form
    {
        public Lab04_bai3()
        {
            InitializeComponent();
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(linkweb.Text);
            myClient.DownloadFile(linkweb.Text, linkfile.Text);
            string s;
            bangshow.Text = getHTML(linkweb.Text);
        }
    }
}
