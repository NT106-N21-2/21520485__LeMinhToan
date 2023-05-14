using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HtmlAgilityPack;

namespace Lab04
{
    public partial class Lab4_bai4 : Form
    {
        public Lab4_bai4()
        {
            InitializeComponent();
        }
        private string getHTML(string szUrl)
        {
            try 
            {
                WebRequest request = WebRequest.Create(szUrl);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                return responseFromServer;
            }
            catch { 
                return "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                webView21.Source = new Uri(textBox1.Text.Trim());
            }
            catch { }
        }
        private void btn_pagesource_Click_1(object sender, EventArgs e)
        {
            var htmlurl = getHTML(webView21.Source.ToString());
            PageSource viewSource = new PageSource(htmlurl);
            viewSource.Show();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
         
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };

            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(webView21.Source.ToString());
           
            var imgs = document.DocumentNode.Descendants("img");

            foreach ( var img in imgs )
            {
                string imgurl = img.GetAttributeValue("src", "");

                if(imgurl != "")
                {
                    string fullpath = "D:\\" + Path.GetFileName(imgurl);
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(imgurl, fullpath);
                        }
                        catch { }
                    }
                }
            }
            MessageBox.Show("đã tải xong các ảnh trên web này!");
              
        }
    }
}
