using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Lab04_bai2 : Form
    {
        public Lab04_bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] postdata = Encoding.UTF8.GetBytes("param1="+datapost.Text);
            HttpWebRequest repuest = (HttpWebRequest)WebRequest.Create(url.Text);
            repuest.Method = "POST";
            repuest.ContentType = "application/x-www-form-urlencoded";
            repuest.ContentLength = postdata.Length;
            using (Stream stream = repuest.GetRequestStream())
            {
                stream.Write(postdata, 0, postdata.Length);
            }

            HttpWebResponse response = (HttpWebResponse)repuest.GetResponse();
            string responsedata = "";
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responsedata += reader.ReadToEnd();
                }
            }
            banghienthi.Text = responsedata;
        }
    }
}
