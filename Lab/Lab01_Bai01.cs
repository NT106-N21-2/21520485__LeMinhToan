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

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
            result.ReadOnly = true;
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            int n;
            result.Text = "";
            if (int.TryParse(num1.Text.Trim(), out n) || num1.Text == ""||num1.Text=="-" )
            { }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            int n;
            result.Text = "";
            if (int.TryParse(num2.Text.Trim(), out n) || num2.Text==""||num2.Text=="-")
            { }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            int n1, n2;
            if (int.TryParse(num1.Text.Trim(), out n1) && int.TryParse(num2.Text.Trim(), out n2))
            {
                long s = n1 + n2;
                result.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }
    }
}
