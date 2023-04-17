using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai5 : Form
    {
        public Lab02_Bai5()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        string filein = "", filezip = "", filezipout = "", folderout = "";

        private void btn_giainenzip_Click(object sender, EventArgs e)
        {
            if (filezipout == "")
            {
                MessageBox.Show("Hãy chọn file zip cần giải nén trước");
            }
            else if (folderout == "")
            {
                MessageBox.Show("Hãy chọn thư mục để giải nén zip");
            }
            else
            {
                ZipFile.ExtractToDirectory(filezipout, folderout);
            }
        }

        private void btn_chosezip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filezipout = ofd.FileName;
            }
        }

        private void btn_chosefolderextract_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderout = fbd.SelectedPath;
            }
        }

        private void btn_chonluufile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filein = fbd.SelectedPath;
                FileStream fs1 = new FileStream(filein + "\\input5.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs1);
                sw.Write(bangthongtin.Text);
                sw.Flush();
                fs1.Close();
            }
        }

        private void btn_luufiledenen_Click(object sender, EventArgs e)
        {
            if (filein == "")
            {
                MessageBox.Show("Hãy chọn thư mục để lưu file trước");
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    filezip = fbd.SelectedPath + "\\output5.zip";
                    ZipFile.CreateFromDirectory(filein, filezip);
                }
            }
        }
    }
}
