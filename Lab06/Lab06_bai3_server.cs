using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab06
{
    public partial class Lab06_bai3_server : Form
    {
        public Lab06_bai3_server()
        {
            InitializeComponent();
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }
        TcpListener server;

        List<TcpClient> clients = new List<TcpClient>();
 

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
      
        string publicKey;
        string privateKey;

        void Sendmessage(byte[] cipherText, TcpClient client)
        {
            NetworkStream stream_send;
            stream_send = client.GetStream();
            stream_send.Write(cipherText, 0, cipherText.Length);
        }
        void Sendkey(string s, TcpClient client)
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
            string key="";
           

            while (client.Connected)
            {
                try
                {
                    bytesRead = stream_recv.Read(buffer, 0, buffer.Length);
                }
                catch { return; }
                if (bytesRead == 0)
                {
                    break;
                }
                string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (key == "")
                {
                    key = mess;
                   
                }
                else
                {
                    //--------------------------------------------------------------
                    
                    byte[] aa=new byte[bytesRead];
                    Array.Copy(buffer,aa,bytesRead);
                    byte[] decryptedText = rsa.Decrypt(aa, false);
                    mess = client.Client.RemoteEndPoint + ": " + Encoding.UTF8.GetString(decryptedText);
                    //mess = client.Client.RemoteEndPoint + ": " + mess;
                    //-------------------------------------------------------------------*/
                    bangchat.Invoke((MethodInvoker)(() => bangchat.Items.Add(mess)));
                    foreach (TcpClient i in clients)
                        if (i != client && i != null) 
                        {
                            RSACryptoServiceProvider rsa1 = new RSACryptoServiceProvider();
                            rsa1.FromXmlString(key);
                            byte[] plainText = Encoding.UTF8.GetBytes(mess);
                            byte[] cipherText = rsa1.Encrypt(plainText, false);
                            Sendmessage(cipherText, i);
                            //Sendmessage(plainText, i);
                        }
                }
            }
            bangchat.Invoke((MethodInvoker)(() => bangchat.Items.Add("client " + client.Client.RemoteEndPoint + " đã ngắt kết nối")));
            clients.Remove(client);
            if (client != null) { client.Close(); }
            if (stream_recv != null) { stream_recv.Close(); }
        }
        public async void serverThread()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9000);
            server.Start();

            bangchat.Items.Add("Server started!...");
            while (true)
            {
                TcpClient client;
                try
                {
                    client = await server.AcceptTcpClientAsync();
                }
                catch { return; }

                bangchat.Items.Add("Accept client from " + client.Client.RemoteEndPoint);
                clients.Add(client);
                Sendkey(publicKey, client);
                Thread recveive = new Thread(Receivemessage);
                recveive.IsBackground = true;
                recveive.Start(client);
            }
        }
        private void Disconnect()
        {
            bangchat.Items.Add("Server Stop!");
            foreach (TcpClient cl in clients) if (cl != null) cl.Close();
            clients.Clear();
            server.Stop();
        }
        
        private void btn_listen_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = true;
            btn_listen.Visible = false;
            serverThread();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = false;
            btn_listen.Visible = true;
            Disconnect();
        }
    }
}
