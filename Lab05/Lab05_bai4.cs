using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab05
{
    public partial class Lab05_bai4 : Form
    {
        public Lab05_bai4()
        {
            InitializeComponent();
            account.Text = "lory265265@gmail.com";
            password.Text = "vaoalyvahsaclalq";
            set_imap.Text = "imap.gmail.com";
            set_smtp.Text = "smtp.gmail.com";
            port_imap.Text = "993";
            port_smtp.Text = "465";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Send_mail sm = new Send_mail(set_smtp.Text, port_smtp.Text, account.Text, password.Text, false, account.Text);
            sm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            client.Connect(set_imap.Text, int.Parse(port_imap.Text), true);
            try
            {
                client.Authenticate(account.Text, password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Rows.Clear();
            var inbox = client.Inbox;
            client.Inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count; i > inbox.Count - 19; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    dataGridView1.Rows.Add(message.From, message.Subject, message.Date);
                }
                catch { }
            }
        }
        private void Set_status(bool kt)
        {
            btn_refresh.Visible = kt;
            btn_signout.Visible = kt;
            btn_send.Visible = kt;
            kt = !kt;
            btn_signin.Visible = kt;
            account.Enabled = kt;
            password.Enabled = kt;
            groupBox2.Enabled = kt;
        }
        private void btn_signout_Click(object sender, EventArgs e)
        {
            Set_status(false);
            client.Disconnect(true);
            dataGridView1.Rows.Clear();
        }

        ImapClient client = new ImapClient();

        private void btn_signin_Click(object sender, EventArgs e)
        {
            Set_status(true);
           
            //--------------------------------------------------
            client.Connect(set_imap.Text, int.Parse(port_imap.Text), true);
            try
            {
                client.Authenticate(account.Text, password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count; i > inbox.Count - 19; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    dataGridView1.Rows.Add(message.From, message.Subject, message.Date);
                }
                catch { }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var inbox = client.Inbox;
            var message = inbox.GetMessage(inbox.Count - e.RowIndex - 1);

            var body = message.BodyParts.OfType<TextPart>().FirstOrDefault(x => x.IsHtml);
            
            Viewmessage_upgrade veu = new Viewmessage_upgrade(body.Text, message.From.ToString(), account.Text, message.Subject, account.Text, password.Text);
            veu.Show();
        }
       
    }
}
