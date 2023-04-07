using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }
        public string Convert_ip(string s, int t = 8)
        {
            if (t == 0) return "";
            int thu = int.Parse(s);
            string ip = Convert.ToString(thu, 2);
            int ip_len = ip.Length;
            for (int i = 0; i < t - ip_len; i++)
            {
                ip = "0" + ip;
            }
            return ip;
        }
        public string chiadiachimang(string s, int i, int bitmuon, int sub, int t)
        {
            string network = "";
            for (int j = 0; j < sub; j++)
            {
                network += s[j];
            }
            network = s.Substring(0, sub);
            network += Convert_ip(i.ToString(), bitmuon);

            if (t == 0)
            {
                network += s.Substring(sub + bitmuon);
            }
            else if (t == 1)
            {
                for (int j = sub + bitmuon; j < 31; j++) network += s[j];
                network += '1';
            }
            else if (t == 2)
            {
                for (int j = 0; j < 31 - sub - bitmuon; j++) network += '1';
                network += "0";
            }
            else
            {
                for (int j = 0; j < 32 - sub - bitmuon; j++) network += '1';
            }

            return network;
        }
        public string Chialaiip(string s)
        {
            string ip = "", s1 = "";
            for (int j = 0; j < 32; j++)
            {
                s1 += s[j];
                if (s1.Length == 8)
                {
                    ip += Convert.ToInt32(s1, 2).ToString();
                    if (j != 31) ip += ".";
                    s1 = "";
                }
            }
            return ip;
        }
        public bool kiemtraip()
        {
            int subnet = int.Parse(sb_mask.Text);
            IPAddress ip1;
            if (ip.Text == "") return false;
            bool ValidateIP = IPAddress.TryParse(ip.Text, out ip1);

            if (ValidateIP)
            {
                string[] s = ip.Text.Split(".");
                s[0] = Convert_ip(s[0], 8);
                s[1] = s[0] + Convert_ip(s[1], 8);
                s[1] += Convert_ip(s[2], 8);
                s[1] += Convert_ip(s[3], 8);
                if (long.Parse(s[1].Substring(subnet)) == 0)
                {
                    long t = Convert.ToInt32(s[0], 2);
                    if (t > 1 && t <= 125 && subnet < 8) return false;
                    if (t >= 128 && t < 192 && subnet < 16) return false;
                    if (t >= 192 && t < 224 && subnet < 24) return false;
                }
                else return false;
            }
            else
            {
                return false;
            }

            return true;
        }
        public void Addrow(int i, string s0, string s1, string s2, string s3)
        {
            string[] s = { i.ToString(), s0, s1, s2, s3 };
            bangip.Rows.Add(s);
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            bangip.Rows.Clear();
            int subnet;
            long mangcon;
            if (long.TryParse(host.Text, out mangcon) && int.TryParse(sb_mask.Text, out subnet) && kiemtraip())
            {
                int bitmuon = 0;
                if (Math.Pow(2, 30 - subnet) >= mangcon)
                {
                    for (int i = 0; i < 30 - subnet; i++)
                        if (Math.Pow(2, i) >= mangcon) { bitmuon = i; break; }
                    mangcon = (long)Math.Pow(2, bitmuon);
                    string[] s = ip.Text.Split(".");
                    s[0] = Convert_ip(s[0], 8);
                    s[1] = s[0] + Convert_ip(s[1], 8);
                    s[1] += Convert_ip(s[2], 8);
                    s[1] += Convert_ip(s[3], 8);

                    for (int i = 0; i < mangcon; i++)
                    {
                        Addrow(i, Chialaiip(chiadiachimang(s[1], i, bitmuon, subnet, 0)), Chialaiip(chiadiachimang(s[1], i, bitmuon, subnet, 1)),
                            Chialaiip(chiadiachimang(s[1], i, bitmuon, subnet, 2)), Chialaiip(chiadiachimang(s[1], i, bitmuon, subnet, 3)));

                        s[1] = chiadiachimang(s[1], i, bitmuon, subnet, 0);
                    }

                }
                else
                {
                    MessageBox.Show("Mạng con cần chia quá nhiều nên chia ko đủ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại ip hoặc Subnet Mask cho đúng!");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            bangip.Rows.Clear();
            ip.Clear();
            sb_mask.Clear();
            host.Clear();
        }
    }
}
