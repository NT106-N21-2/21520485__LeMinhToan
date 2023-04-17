using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai2 : Form
    {
        public Lab02_Bai2()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rff_Click(object sender, EventArgs e)
        {
            bangthongtin.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                name.Text = ofd.SafeFileName;
                url.Text = ofd.FileName;
                bangthongtin.Text = sr.ReadToEnd();
                FileInfo f = new FileInfo(ofd.FileName);
                size.Text = f.Length.ToString() + " bytes";
                string[] s = bangthongtin.Text.Split("\n");
                linecount.Text = s.Length.ToString();
                s=bangthongtin.Text.Split(new Char [] { ' ' , '\n'} );
                wordcount.Text=s.Length.ToString();
                fs.Close();
                string s1 = bangthongtin.Text.Replace("\r\n", "");
                s1 = s1.Replace(" ","");
                charactercount.Text = s1.Length.ToString();
            }
        }
    }
}
