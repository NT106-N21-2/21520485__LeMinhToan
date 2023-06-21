using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Lab06_bai3 : Form
    {
        public Lab06_bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab06_bai3_server server = new Lab06_bai3_server();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab06_bai3_client client = new Lab06_bai3_client();
            client.Show();
        }
    }
}
