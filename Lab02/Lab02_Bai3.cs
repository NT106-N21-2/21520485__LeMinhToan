using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai3 : Form
    {
        public Lab02_Bai3()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public string Tinhchia(string s)
        {
            string[] s1 = s.Split("/");
            float t = float.Parse(s1[0]);
            for (int i = 1; i < s1.Length; i++)
            {
                t = t / float.Parse(s1[i]);
            }
            return t.ToString();
        }
        public string Tinhnhan(string s)
        {
            float t = 1, n;
            string[] s1 = s.Split("*");
            for (int i = 0; i < s1.Length; i++)
                if (float.TryParse(s1[i], out n))
                {
                    t *= n;
                }
                else
                {
                    t *= float.Parse(Tinhchia(s1[i]));
                }
            return t.ToString();
        }
        public string Tinhcong(string s)
        {
            if (s == "") return "0";
            string[] s1 = s.Split('+');
            float t = 0, n;
            for (int i = 0; i < s1.Length; i++)
                if (float.TryParse(s1[i], out n))
                {
                    t += n;
                }
                else
                {
                    t += float.Parse(Tinhtru(s1[i]));
                }
            return t.ToString();
        }
        public string Tinhtru(string s)
        {
            string[] s1 = s.Split('-');
            float n, t = float.Parse(Tinhnhan(s1[0]));
            for (int i = 1; i < s1.Length; i++)
                if (float.TryParse(s1[i], out n))
                {
                    t -= n;
                }
                else
                {
                    t -= float.Parse(Tinhnhan(s1[i]));
                }
            return t.ToString();
        }
        public string Tinh(string s)
        {
            s = "0+" + s.Replace(" ", "");
            while (s.IndexOf("(") > 0)
            {
                int bd = s.LastIndexOf('('), kt = s.IndexOf(')');
                s = s.Substring(0, bd) + Tinhcong(s.Substring(bd + 1, kt - bd - 1)) + s.Substring(kt + 1, s.Length - kt - 1);
            }
            s = Tinhcong(s);
            return s;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            bangthongtin.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string[] s = sr.ReadToEnd().Split("\n");
                for (int i = 0; i < s.Length; i++)
                {
                    bangthongtin.Text += s[i] + "=" + Tinh(s[i]) + "\r\n";
                }
            }
        }
        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs1);
                sw.Write(bangthongtin.Text);
                sw.Flush();
                fs1.Close();
            }

        }
    }
}
