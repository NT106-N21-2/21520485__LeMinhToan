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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
            max.ReadOnly = true;
            min.ReadOnly = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            min.Text = "";
            max.Text = "";
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(num1.Text.Trim(), out n) || num1.Text == "" || num1.Text == "-")
            { }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(num2.Text.Trim(), out n) || num2.Text == "" || num2.Text == "-")
            { }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void num3_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(num3.Text.Trim(), out n) || num3.Text == "" || num3.Text == "-")
            { }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            double n1, n2, n3;
            if (double.TryParse(num1.Text,out n1)&& double.TryParse(num2.Text, out n2)&& double.TryParse(num3.Text, out n3)) 
            {
                double nho = n1, lon = n1;
                if (n2 > n1) { lon = n2; }
                else nho = n2;
                if (lon < n3) lon = n3;
                if (nho > n3) nho = n3;
                max.Text = lon.ToString();
                min.Text = nho.ToString();
            }
            else
            {
                MessageBox.Show("vui lòng nhập số nguyên!");
            }
        }
    }
}
