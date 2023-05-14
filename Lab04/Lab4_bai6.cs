using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Lab04
{
    public partial class Lab4_bai6 : Form
    {
        public Lab4_bai6()
        {
            InitializeComponent();
            url.Text = "https://thanhnien.vn/cong-nghe-game.htm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            HtmlWeb html = new HtmlWeb();
            var htmlDoc = html.Load(url.Text);
            var news = htmlDoc.DocumentNode.SelectNodes("//div[@class='box-category-item' and @data-id]").ToList();
            foreach (var item in news)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = "";
                groupBox.Width = panel1.Size.Width - 22;
                groupBox.Height = 167;
                panel1.Controls.Add(groupBox);
                groupBox.Location = new Point(12, 167 * i + 93);

                //var imgurl = item.SelectSingleNode("//img[@src and @class='box-category-avatar']").Attributes["src"].Value;
                //var imgurl = item.QuerySelector("img.src").Attributes["src"].Value;
                var imgurl = item.Descendants("img").First().Attributes["src"].Value;

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = imgurl;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                groupBox.Controls.Add(pictureBox);
                pictureBox.Location = new Point(17, 17);

                var title = item.Descendants("a").First().Attributes["title"].Value;

                Label labeltitle = new Label();
                labeltitle.Text = title;
                labeltitle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                labeltitle.Width = groupBox.Size.Width - 240;
                labeltitle.Height = 30;
                groupBox.Controls.Add(labeltitle);
                labeltitle.Location = new Point(240, 33);

                var newurl = item.Descendants("a").First().Attributes["href"].Value;
                labeltitle.Click += delegate (object sender, EventArgs e)
                {
                    View_news vn = new View_news("https://thanhnien.vn/" + newurl);
                    vn.Show();
                };

                groupBox.Click += delegate (object sender, EventArgs e)
                {
                    View_news vn = new View_news("https://thanhnien.vn/" + newurl);
                    vn.Show();
                };

                var title2 = item.Descendants("a").Last().Attributes["title"].Value;
                Label labeltitle2 = new Label();
                labeltitle2.Text = title2;
                labeltitle2.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                labeltitle2.Width = groupBox.Size.Width - 240;
                labeltitle2.Height = 40;
                groupBox.Controls.Add(labeltitle2);
                labeltitle2.Location = new Point(240, 82);

                var newurl1 = item.Descendants("a").Last().Attributes["href"].Value;
                labeltitle2.Click += delegate (object sender, EventArgs e)
                {
                    View_news vn = new View_news("https://thanhnien.vn/" + newurl1);
                    vn.Show();
                };
                i++;
            }

        }
    }
}
