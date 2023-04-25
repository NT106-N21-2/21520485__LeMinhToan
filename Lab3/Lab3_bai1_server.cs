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
    public partial class Lab3_bai1_server : Form
    {
        public Lab3_bai1_server()
        {
            InitializeComponent();
        }
        public void ShowMessage(string s)
        {
            bangchat.Items.Add(s);
        }
        public void serverThread()
        {
            int n;
            if (int.TryParse(port.Text, out n))
            {
                UdpClient udpClient = new UdpClient(n);
                while (true)
                {
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveByte = udpClient.Receive(ref ipe);
                    string returnData = Encoding.UTF8.GetString(receiveByte);
                    string mess = ipe.Address.ToString() + ": " + returnData.ToString();
                    ShowMessage(mess);
                }

            }
            else
            {
                MessageBox.Show("vui long nhập port lại cho đúng!");
            }
        }
        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread UDPserver = new Thread(new ThreadStart(serverThread));
            UDPserver.Start();
            UDPserver.IsBackground= true;
        }

    }
}
