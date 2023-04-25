using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3_bai1_menu : Form
    {
        public Lab3_bai1_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab3_bai1_server server = new Lab3_bai1_server();
            server.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Lab3_bai1_client client = new Lab3_bai1_client();
            client.Show();
        }
    }
}
