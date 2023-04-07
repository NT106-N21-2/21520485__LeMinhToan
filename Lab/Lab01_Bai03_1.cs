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
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
            result.ReadOnly = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            num.Text = "";
            result.Text = "";
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int n;
            string s = num.Text;
            if (int.TryParse(s, out n))
            {
                switch (n)
                {
                    case 0: result.Text = "Không"; break;
                    case 1: result.Text = "Một"; break;
                    case 2: result.Text = "Hai"; break;
                    case 3: result.Text = "Ba"; break;
                    case 4: result.Text = "Bốn"; break;
                    case 5: result.Text = "Năm"; break;
                    case 6: result.Text = "Sáu"; break;
                    case 7: result.Text = "Bảy"; break;
                    case 8: result.Text = "Tám"; break;
                    case 9: result.Text = "Chín"; break;
                    default:
                        MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
