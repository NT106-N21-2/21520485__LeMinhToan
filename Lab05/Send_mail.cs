using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class Send_mail : Form
    {
        public Send_mail(string smtp, string port, string account, string pass, bool isreply,string frome,string toe="")
        {
            InitializeComponent();
            smtpClient.Connect(smtp, int.Parse(port), true);
            try
            {
                smtpClient.Authenticate(account, pass);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            from.Text = frome;
            from.Enabled = false;
          
            if (isreply)
            {
                label6.Visible = false;
                file_link.Visible = false;
                btn_browse.Visible = false;
                content.Height = 360;
                this.Text = "Reply Mail";
                to.Text = toe;
                mailto = toe.Split("<")[1].Split(">")[0].Trim();
            }
            
        }
        SmtpClient smtpClient = new SmtpClient();
        string mailto="";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               file_link.Text=ofd.FileName;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name.Text, from.Text));
            if (mailto == "") mailto = to.Text;
            message.To.Add(new MailboxAddress("", mailto));
           // MessageBox.Show(mailto);
            message.Subject = subject.Text;
            string k = "plain";
            if (checkBox1.Checked)
            {
                k = "HTML";
            }
            var builder = new BodyBuilder();
            builder.TextBody = content.Text;
            if (file_link.Text != "")
            {
                builder.Attachments.Add(file_link.Text);
            }
            message.Body = new TextPart(k);
            message.Body = builder.ToMessageBody();
            smtpClient.Send(message);
            MessageBox.Show("Đã gửi thư xong!");
        }
    }
}
