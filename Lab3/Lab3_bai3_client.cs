using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3_bai3_client : Form
    {
        public Lab3_bai3_client()
        {
            InitializeComponent();
            btn_disconect.Enabled = false;
        }
        class TcpClient1_1
        {
            private IPAddress ip;
            private int port;
            private TcpClient clienttcp;
            private NetworkStream stream;

            public TcpClient1_1(IPAddress ip, int port)
            {
                this.ip = ip;
                this.port = port;
                this.clienttcp = new TcpClient();
            }
            public async void Connect()
            {
                try
                {
                    await this.clienttcp.ConnectAsync(this.ip, this.port);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            public void sendmessage(string s)
            {
                this.stream = clienttcp.GetStream();
                byte[] mess = Encoding.UTF8.GetBytes(s);
                this.stream.Write(mess, 0, mess.Length);
            }
            public void disconnected()
            {

                if (this.stream != null)
                {
                    this.stream.Close();
                }
                if (this.clienttcp != null) this.clienttcp.Close();
            }
        }
        TcpClient1_1 client;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_disconect.Enabled = true;
            btn_connect.Enabled = false;
            client = new TcpClient1_1(IPAddress.Parse("192.168.1.67"), 9001);
            client.Connect();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (bangchat.Text.Trim() != null)
            {
                client.sendmessage(bangchat.Text);
                bangchat.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung!");
            }
        }

        private void btn_disconect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconect.Enabled = false;
            client.disconnected();

        }
    }
}
