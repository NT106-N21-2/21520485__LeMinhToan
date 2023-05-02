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
    public partial class Lab3_bai5_client : Form
    {
        public Lab3_bai5_client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        TcpClient client = new TcpClient();
        NetworkStream stream_send, stream_recv;


        void Nameonline(string s)
        {
            string[] s1 = s.Trim().Split(" ");
            toclient.Items.Clear();
            danhsachclient.Items.Clear();
            toclient.Items.Add("All");
            for (int i = 0; i < s1.Length; i++)
            {
                danhsachclient.Items.Add(s1[i]);
                toclient.Items.Add(s1[i]);
            }
        }
        async void Connect()
        {
            try
            {
                await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 9000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Thread recv = new Thread(Receivemessage);
            recv.Start();
            recv.IsBackground = true;
        }
        void Sendmessage(string s)
        {
            stream_send = client.GetStream();
            byte[] mess = Encoding.UTF8.GetBytes(s);
            stream_send.Write(mess, 0, mess.Length);
        }
        void Receivemessage()
        {
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead;
            stream_recv = client.GetStream();

            while (client.Connected)
            {
                try
                {
                    bytesRead = stream_recv.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    string mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (mess.IndexOf(" ") == 0)
                    {
                        Nameonline(mess);
                    }
                    else
                    {
                        bangchat.Items.Add(mess);
                    }
                }
                catch { }

            }
            if (stream_recv != null) { stream_recv.Close(); }
        }

        //------------------------------------------------------------------------
        private void btn_send_Click(object sender, EventArgs e)
        {
            message.Text = message.Text.Trim();
            if (message.Text != "" && nameclient.Text != "")
            {
                if (toclient.SelectedIndex > 0)
                {
                    Sendmessage(nameclient.Text + ": " + message.Text.Trim() + " " + toclient.SelectedIndex.ToString() + " ");
                }
                else
                {
                    Sendmessage(nameclient.Text + ": " + message.Text.Trim());
                }
                bangchat.Items.Add(nameclient.Text + ": " + message.Text);
                message.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tin nhắn hoặc tên người dùng!");
            }
        }

        private void Lab3_bai5_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null) client.Close();
        }

        private void nameclient_Leave(object sender, EventArgs e)
        {
            nameclient.Text = nameclient.Text.Trim();
            if (message.Text != null)
            {
                Sendmessage(" " + nameclient.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!");
            }
        }
    }
}
