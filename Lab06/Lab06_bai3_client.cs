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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab06
{
    public partial class Lab06_bai3_client : Form
    {
        public Lab06_bai3_client()
        {
            InitializeComponent();
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }
        TcpClient client;
        NetworkStream stream_send, stream_recv;
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        string publicKey;
        string privateKey;
        string Key = "";
        async private void Connect()
        {
            int portn;
            IPAddress ipn;
            if (int.TryParse(port_tb.Text, out portn) && IPAddress.TryParse(ip_tb.Text, out ipn))
            {
                try
                {
                    client = new TcpClient();
                    await client.ConnectAsync(ipn, portn);
                    Sendmessage(publicKey);
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
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin ip,port ");
            }
        }
        void Sendmessage(string s)
        {
            try
            {
                stream_send = client.GetStream();
                byte[] mess = Encoding.UTF8.GetBytes(s);
                stream_send.Write(mess, 0, mess.Length);
            }
            catch {
                MessageBox.Show("Không gửi tin nhắn đc");
            }
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
                    if (Key=="")
                    {
                        Key = mess;
                    }
                    else
                    {

                        byte[] aa = new byte[bytesRead];
                        Array.Copy(buffer, aa, bytesRead);
                      //  byte[] decryptedText = rsa.Decrypt(aa, false);
                      //  mess = Encoding.UTF8.GetString(decryptedText);
                        Chat.Invoke((MethodInvoker)(() => Chat.Items.Add(mess)));
                    }
                }
                catch {   }

            }
            if (stream_recv != null) { stream_recv.Close(); }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Connect();
            btn_connect.Visible = false;
            btn_disconnect.Visible = true;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_connect.Visible = true;
            btn_disconnect.Visible = false;
            Chat.Items.Clear();
            client.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chat.Items.Add("me: " + inputmess.Text);
            RSACryptoServiceProvider rsa1 = new RSACryptoServiceProvider();
            rsa1.FromXmlString(Key);

            byte[] plainText = Encoding.UTF8.GetBytes(inputmess.Text);
            byte[] cipherText = rsa1.Encrypt(plainText, false);

            Sendmessageencrypt(cipherText);
            inputmess.Text = "";
        }
        //---------------------------------------------------------------------------
        void Sendmessageencrypt(byte[] cipherText)
        {
            NetworkStream stream_send;
            stream_send = client.GetStream();
            stream_send.Write(cipherText, 0, cipherText.Length);
        }
        //---------------------------------------------------------------------------
    }
}
