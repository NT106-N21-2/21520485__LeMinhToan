using MailKit.Net.Pop3;
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

namespace Lab05
{
    public partial class Lab05_bai3 : Form
    {
        public Lab05_bai3()
        {
            InitializeComponent();
        }
        Pop3Client client = new Pop3Client();
        private void btn_login_Click(object sender, EventArgs e)
        {
           
            client.Connect("pop.gmail.com", 995, true);
            try
            {
                client.Authenticate(email.Text, pass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int length = client.GetMessageCount();
            total.Text = length.ToString();

            for (int i = length; i > length - 19; i--)
            {
                try
                {
                    var message = client.GetMessage(i);
                    dataGridView2.Rows.Add(message.Subject, message.From, message.Date);
                }
                catch { }
            }
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var message = client.GetMessage(client.GetMessageCount()-e.RowIndex-1);
            View_email ve = new View_email(message.TextBody);
            ve.Show();
        }
    }
}
