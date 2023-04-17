using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai1 : Form
    {
        public Lab02_Bai1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                textBox.Text += sr.ReadToEnd();
                fs.Close();
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
                sw.Write(textBox.Text.ToUpper());
                sw.Flush();
                fs1.Close();
            }
        }
    }
}
