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
    public partial class Lab02_Menu : Form
    {
        public Lab02_Menu()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Lab02_Bai1 bai1 = new Lab02_Bai1();
            bai1.ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Lab02_Bai2 bai2 = new Lab02_Bai2();
            bai2.ShowDialog();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Lab02_Bai3 bai3=new Lab02_Bai3();
            bai3.ShowDialog();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Lab02_Bai4 bai4 = new Lab02_Bai4();
            bai4.ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Lab02_Bai5 bai5 = new Lab02_Bai5();
            bai5.ShowDialog();
        }

        private void btn_bai6_Click(object sender, EventArgs e)
        {
            Lab02_Bai6 bai6 = new Lab02_Bai6();
            bai6.ShowDialog();
        }
    }
}
