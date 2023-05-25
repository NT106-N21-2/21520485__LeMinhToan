using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Viewmessage_upgrade : Form
    {
        public Viewmessage_upgrade(string mess, string from, string to, string sub, string acc, string pass)
        {
            InitializeComponent();
            richTextBox1.Text = mess;
            text_from.Text = from;
            textto.Text = to;
            this.Text = sub;
            frome = to; toe = from;
            pas = pass; ac = acc;
        }
        string frome, toe, ac, pas;
        private void button1_Click(object sender, EventArgs e)
        {
            Send_mail sm = new Send_mail("smtp.gmail.com", "465", ac, pas, true, frome, toe);
            sm.Show();
        }
    }
}
