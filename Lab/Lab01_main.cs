using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_main : Form
    {
        public Lab01_main()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 bai1 = new Lab01_Bai01();
            bai1.ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 bai2 = new Lab01_Bai02();
            bai2.ShowDialog();
        }

        private void btn_ba3_1_Click(object sender, EventArgs e)
        {
            Lab01_Bai03_1 bai3_1 = new Lab01_Bai03_1();
            bai3_1.ShowDialog();
        }

        private void btn_bai3_2_Click(object sender, EventArgs e)
        {
            Lab01_Bai03_2 bai3_2 = new Lab01_Bai03_2();
            bai3_2.ShowDialog();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 bai4 = new Lab01_Bai04();
            bai4.ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 bai5 = new Lab01_Bai05();
            bai5.ShowDialog();
        }

        private void btn_bai7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 bai7 = new Lab01_Bai07();
            bai7.ShowDialog();
        }

        private void btn_bai8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 bai8 = new Lab01_Bai08();
            bai8.ShowDialog();
        }
    }
}
