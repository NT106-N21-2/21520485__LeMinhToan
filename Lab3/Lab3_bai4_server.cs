using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3_bai4_server : Form
    {
        public Lab3_bai4_server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        TcpListener server;
        TcpClient client;
        NetworkStream stream;

        public async void serverThread()
        {
            IPAddress t_ip;
            int t_port;
            if (int.TryParse(port.Text, out t_port) && IPAddress.TryParse(ip.Text, out t_ip))
            {
                btn_listen.Enabled = false;
                server = new TcpListener(t_ip, t_port);

                server.Start();

                bangchat.Items.Add("Server started");

                client = await server.AcceptTcpClientAsync();
                bangchat.Items.Add("Connection accepted " + server.LocalEndpoint);

                stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead;

                while (client.Connected)
                {
                    try
                    {
                        bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        bangchat.Items.Add("From client: " + mess);
                    }
                    catch
                    {
                        break;
                    }

                }
                bangchat.Items.Add("Client disconnected!... ");
                if (client != null) { client.Close(); }
                if (stream != null) { stream.Close(); }

                server.Stop();
                btn_listen.Enabled = true;
            }
            else { MessageBox.Show("Vui lòng nhập đúng thông tin ip,port!"); }

        }

        private async void btn_listen_Click_1(object sender, EventArgs e)
        {

            Thread TCPserver = new Thread(new ThreadStart(serverThread));
            TCPserver.Start();
            TCPserver.IsBackground = true;
        }



        private void Lab3_bai4_server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null) { client.Close(); }
            if (stream != null) { stream.Close(); }
            server.Stop();
        }
    }
}
