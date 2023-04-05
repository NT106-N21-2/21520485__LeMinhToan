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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
            gt_A.ReadOnly = true;
            gt_B.ReadOnly = true;
            sumtoA.ReadOnly = true;
            sumtoB.ReadOnly = true;
            sumtoAB.ReadOnly = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            long n1, n2;
            if (long.TryParse(numA.Text, out n1) && long.TryParse(numB.Text, out n2))
            {
                gt_A.Text = "A! = ";
                gt_B.Text = "B! = ";
                sumtoA.Text = "S1 = 1 + 2 + 3 + 4 +...+ A = ";
                sumtoB.Text = "S1 = 1 + 2 + 3 + 4 +...+ B = ";
                sumtoAB.Text = "S1 = A^1 + A^2 + A^3 + A^4 +...+ A^B = ";
                double gt = 1, tong = 1;
                double sum = n1;
                for (int i = 2; i <= n1; i++)
                {
                    tong += i;
                    gt *= i;
                }
                gt_A.Text += gt.ToString();
                sumtoA.Text += tong.ToString();
                gt = 1; tong = 0;
                for (long i = 2; i <= n2; i++)
                {
                    tong += i;
                    gt *= i;
                    sum += Math.Pow(n1, i);
                }
                gt_B.Text += gt.ToString();
                sumtoB.Text += tong.ToString();
                sumtoAB.Text += sum.ToString();
            }
            else
            {
                MessageBox.Show("vui lòng nhập số nguyên!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            gt_A.Text = "";
            gt_B.Text = "";
            sumtoA.Text = "";
            sumtoB.Text = "";
            sumtoAB.Text = "";
        }


    }
}
