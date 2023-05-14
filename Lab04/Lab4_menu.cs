using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab4_menu : Form
    {
        public Lab4_menu()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Lab04_bai1 b1 = new Lab04_bai1();
            b1.Show();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Lab04_bai2 b2 = new Lab04_bai2();
            b2.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Lab04_bai3 b3 = new Lab04_bai3();
            b3.Show();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Lab4_bai4 b4 = new Lab4_bai4();
            b4.Show();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Lab4_bai5 b5 = new Lab4_bai5();
            b5.Show();
        }

        private void btn_bai6_Click(object sender, EventArgs e)
        {
            Lab4_bai6 b6 = new Lab4_bai6();
            b6.Show();
        }
    }
}
