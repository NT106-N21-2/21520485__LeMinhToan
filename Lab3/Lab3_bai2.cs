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
            bangchat.Text += "Start Listening!...\r\n";
            server.Start();
            server.IsBackground = true;
        }
        public async void StartUnsafe()
        {
            NetworkStream stream;
            byte[] buffer = new byte[1024];
            int bytesReceived;

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            listenerSocket.Bind(ipe);
            listenerSocket.Listen(-1);
            
            Socket client = listenerSocket.Accept();
            bangchat.Text += "Telnet running on 127.0.0.1:9000...  \n";
            stream = new NetworkStream(client);
            while (client.Connected)
            {
                 bytesReceived= stream.Read(buffer, 0, buffer.Length);
                 string data = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                 bangchat.Text += data;
            }
            listenerSocket.Close();
      
        }
    }
}
