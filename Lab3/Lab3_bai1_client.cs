using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3_bai1_client : Form
    {
        public Lab3_bai1_client()
        {
            InitializeComponent();

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int n;
            IPAddress ip1;
            if (!int.TryParse(port.Text, out n) || !IPAddress.TryParse(ip.Text, out ip1))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin ip hoặc port.");
            }
            else if (bangchat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tin nhắn!");
            }
            else
            {
                UdpClient udpClient = new UdpClient();
                Byte[] sendBytes = Encoding.UTF8.GetBytes(bangchat.Text);
                udpClient.Send(sendBytes, sendBytes.Length, ip.Text, n);
                bangchat.Clear();
            }

        }
    }

}
