using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3_bai5_server : Form
    {
        public Lab3_bai5_server()
        {
            InitializeComponent();
        }

        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();
        List<string> name = new List<string>();
        void Nameonline(string s = " ")
        {
            if (s != " ") name.Add(s.Trim());

            for (int i = 0; i < clients.Count; i++)
            {
                string s2 = " ";
                for (int j = 0; j < name.Count; j++) s2 += " " + name[j];
                Sendmessage(s2, clients[i]);
            }
        }
        void Sendmessage(string s, TcpClient client)
        {
            NetworkStream stream_send;
            stream_send = client.GetStream();
            byte[] mess = Encoding.UTF8.GetBytes(s);

            stream_send.Write(mess, 0, mess.Length);
        }

        void Receivemessage(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream_recv;
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;
            stream_recv = client.GetStream();

            while (client.Connected)
            {

                bytesRead = stream_recv.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                //---------------------------------------------------------------------
                if (mess.IndexOf(" ") == 0)
                {
                    Nameonline(mess);
                }
                else if (mess.LastIndexOf(" ") == mess.Length - 1)
                {
                    mess = mess.Trim();
                    string s = mess.Substring(0, mess.LastIndexOf(' '));
                    string s1 = mess.Substring(mess.LastIndexOf(' '), mess.Length - mess.LastIndexOf(' '));

                    Sendmessage(s, clients[int.Parse(s1) - 1]);
                    bangchat.Items.Add(s);
                }
                else
                {
                    bangchat.Items.Add(mess);

                    foreach (TcpClient i in clients)
                        if (i != null && i != client)
                        {
                            Sendmessage(mess, i);
                        }
                }

            }

            bangchat.Items.Add("client " + name[clients.IndexOf(client)] + " đã rời đoạn chat ");
            name.RemoveAt(clients.IndexOf(client));
            clients.Remove(client);
            Nameonline();

            if (client != null) { client.Close(); }
            if (stream_recv != null) { stream_recv.Close(); }
        }
        public async void serverThread()
        {
            btn_listen.Enabled = false;
            server = new TcpListener(IPAddress.Any, 9000);
            server.Start();

            bangchat.Items.Add("Server started");


            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                bangchat.Items.Add("Accept client from " + server.LocalEndpoint);

                clients.Add(client);

                ///*
                Thread recveive = new Thread(Receivemessage);
                recveive.IsBackground = true;
                recveive.Start(client);
                // */
            }

            server.Stop();

        }
        //----------------------------------------------------------
        private void btn_listen_Click(object sender, EventArgs e)
        {
            serverThread();
        }
    }
}
