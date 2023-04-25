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
using System.IO;
using System.Net.Http;

namespace Lab3
{
    public partial class Lab3_bai3_server : Form
    {
        public Lab3_bai3_server()
        {
            InitializeComponent();
        }
        TcpListener server;
        TcpClient client;
        NetworkStream stream;
        
        private async void btn_listen_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            server = new TcpListener(9001);
         
            server.Start();

            bangchat.Items.Add("Server started");

            client = await server.AcceptTcpClientAsync();
            bangchat.Items.Add("Connection accepted " );

            stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;
            // Dạ đây là phần dùng try catch nhưng bị lỗi ạ
            try
            {
                while (true)
                {
                    bytesRead=await stream.ReadAsync(buffer, 0, buffer.Length);
                    string mess=Encoding.UTF8.GetString(buffer,0, bytesRead);
                    bangchat.Items.Add(mess);
                }
            }
            catch
            {
                bangchat.Items.Add("Client disconnected!... ");
                if (client != null) { client.Close(); }
                if (stream != null) { stream.Close(); }
            }
            //-------------------------------------------------------------------

            /* Dạ đây là phần em không dùng try catch và chạy được bình thường ạ/
            while (client.Connected)
            {
                bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                bangchat.Items.Add("From client: " + mess);
            }
            bangchat.Items.Add("Client disconnected!... " );
            if (client != null) { client.Close(); }
            if (stream != null) { stream.Close(); }
            */
            //-------------------------------------------------------------------
            server.Stop();
            btn_listen.Enabled = true;
        }
    }
}
