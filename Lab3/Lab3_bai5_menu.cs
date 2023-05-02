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
    public partial class Lab3_bai5_menu : Form
    {
        public Lab3_bai5_menu()
        {
            InitializeComponent();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Lab3_bai5_client client = new Lab3_bai5_client();
            client.Show();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            Lab3_bai5_server server = new Lab3_bai5_server();
            server.Show();
        }
    }
}
