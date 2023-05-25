using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab05
{
    public partial class Lab05_bai1 : Form
    {
        public Lab05_bai1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            try
            {
                smtpClient.Authenticate(from_e.Text, password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Toan", from_e.Text));
            message.To.Add(new MailboxAddress("", to_e.Text));
            message.Subject = subject.Text;
            message.Body = new TextPart("plain")
            {
                Text = mail.Text
            };
            smtpClient.Send(message);
            MessageBox.Show("Đã gửi thư xong!");
        }
    }
}
