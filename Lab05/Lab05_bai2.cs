using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab05
{
    public partial class Lab05_bai2 : Form
    {
        public Lab05_bai2()
        {
            InitializeComponent();
        }
         ImapClient client = new ImapClient();

        private void btn_login_Click(object sender, EventArgs e)
        {
   
            client.Connect("imap.gmail.com", 993, true);
            try
            {
                client.Authenticate(email.Text, pass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            total.Text = inbox.Count.ToString();
            recent.Text = inbox.Recent.ToString();
            for (int i = inbox.Count; i > inbox.Count - 19; i--)
            {
                try
                {
                    var message = inbox.GetMessage(i);
                    dataGridView2.Rows.Add(message.Subject, message.From, message.Date);

                }
                catch { }
            }
        }
        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var inbox = client.Inbox;
            var message = inbox.GetMessage(inbox.Count - e.RowIndex-1);
            
            View_email ve = new View_email(message.TextBody);
            ve.Show();
        }
    }
}
