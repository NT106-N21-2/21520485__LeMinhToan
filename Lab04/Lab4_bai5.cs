using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab4_bai5 : Form
    {
        public Lab4_bai5()
        {
            InitializeComponent();
        }
        private string getHTML(string szUrl)
        {
            WebRequest request = WebRequest.Create(szUrl);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("first_name")]
            public string fname { get; set; }
            [JsonPropertyName("last_name")]
            public string lname { get; set; }
            [JsonPropertyName("avatar")]
            public string avatar { get; set; }
        }
        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }
        private void Lab4_bai5_Load(object sender, EventArgs e)
        {
            var response = getHTML("https://reqres.in/api/users?page=1");
            var data = JsonSerializer.Deserialize<UserPagination>(response);
            page.Text = data.Page.ToString();
            userspage.Text = data.PerPage.ToString();
            ttpage.Text = data.TotalPages.ToString();
            ttuser.Text = data.Total.ToString();
            
            foreach (var user in data.Data)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Width = panel1.Size.Width;
                groupBox.Height = 167;
                groupBox.Text = "";
                Label lb = new Label();
                lb.Width = panel1.Size.Width - 170;
                lb.Height = 150;
                lb.Text = user.fname + " " + user.lname + "\n" + user.Email;
                groupBox.Controls.Add(lb);
                lb.Location = new Point(3, 3);

                PictureBox pb = new PictureBox();
                pb.Width = 150;
                pb.Height = 150;
                pb.ImageLocation = user.avatar;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                groupBox.Controls.Add(pb);
                pb.Location = new Point(panel1.Size.Width - 153, 7);

                panel1.Controls.Add(groupBox);
                groupBox.Location = new Point(3, (user.Id - 1) * 167 + 9);

            }


        }
    }
}
