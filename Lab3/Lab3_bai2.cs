using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace Lab3
{
    public partial class Lab3_bai2 : Form
    {
        public Lab3_bai2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread server = new Thread(new ThreadStart(StartUnsafe));
            bangchat.Text+="Start Listening!...\r\n";
            server.Start();
            server.IsBackground = true;
        }
        public void StartUnsafe()
        {
            int bytesrcv = 0;
            byte[] recv = new byte[1];
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.67"), 9000);
            listenerSocket.Bind(ipe);
            listenerSocket.Listen(-1);

            Socket client = listenerSocket.Accept();
            while (client.Connected)
            {
                string text = "";
                do
                {
                  bytesrcv = client.Receive(recv);
                  text += Encoding.UTF8.GetString(recv);
                }while (text[text.Length - 1] == '\n');
                bangchat.Text+=text;
            }
            listenerSocket.Close();
        }
    }
}
