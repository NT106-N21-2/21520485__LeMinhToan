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
using System.Net.NetworkInformation;
using System.Net.Http;

namespace Lab3
{
    public partial class Lab3_bai4_client : Form
    {
        public Lab3_bai4_client()
        {
            InitializeComponent();
            btn_disconnect.Enabled = false;
        }
        //-----------------------------------------------------------------------------
        class TcpClient1_1
        {
            private TcpClient clienttcp;
            private NetworkStream stream;
            private IPEndPoint endpoint;
            public bool isConnected()
            {
                var socket = this.clienttcp.Client;
                bool state = socket.Poll(1000, SelectMode.SelectRead);
                if (state && socket.Available == 0)
                {
                    return false;
                }
                if (this.endpoint != null) return this.clienttcp.Connected;
                return false;
            }

            public TcpClient1_1(IPEndPoint ep)
            {
                this.endpoint = ep;
                this.clienttcp = new TcpClient();
            }

            public async void Connect()
            {

                try
                {
                    await this.clienttcp.ConnectAsync(this.endpoint);
                }
                catch (Exception ex)
                {
                    this.endpoint = null;
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
        //----------------------------------------------------------------------------------
        TcpClient1_1 client;
        List<IPEndPoint> endpoints = new List<IPEndPoint>();

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                endpoints.Clear();
                endpoints.Add(new IPEndPoint(IPAddress.Parse(ips1.Text), int.Parse(ports1.Text)));
                endpoints.Add(new IPEndPoint(IPAddress.Parse(ips2.Text), int.Parse(ports2.Text)));

                btn_disconnect.Enabled = true;
                btn_connect.Enabled = false;
                foreach (IPEndPoint endpoint in endpoints)
                {
                    client = new TcpClient1_1(endpoint);
                    client.Connect();
                    if (client.isConnected()) { break; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            client.disconnected();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            if (bangchat.Text.Trim() == null) MessageBox.Show("Vui lòng nhập nội dung!");
            if (client.isConnected())
            {
                client.sendmessage(bangchat.Text);
                bangchat.Text = "";
            }
            else
            {
                // MessageBox.Show("hahaha");
                foreach (IPEndPoint endpoint in endpoints)
                {
                    client = new TcpClient1_1(endpoint);
                    client.Connect();
                    if (client.isConnected()) break;
                }
                //--------------------------------------------------------
                if (client.isConnected())
                {
                    client.sendmessage(bangchat.Text);
                    bangchat.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể kết nối tới cả 2 server");
                }
            }
        }
    }
}
