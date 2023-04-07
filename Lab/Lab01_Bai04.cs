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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
            total_money.ReadOnly = true;
            total_km.ReadOnly = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            total_km.Text = "";
            total_money.Text = "";
            loaixang.Text = "";
            loaixe.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = loaixe.Text;
            loaixang.Items.Clear();
            loaixang.Text = "";
            if (s == "Xe tải 9 tấn")
            {
                loaixang.Items.Add("Dầu DO");
            }
            else
            {
                loaixang.Items.Add("Xăng RON 95-III");
                if (s == "Wave Alpha" || s == "Sirius" || s == "Vision")
                {
                    loaixang.Items.Add("Xăng RON 92-II");
                }
            }
        }

        private void loaixang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaixe.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại xe trước!");
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            string xe = loaixe.Text;
            string xang = loaixang.Text;
            if (xe != "" && xang != "")
            {
                double gia_xang;
                if (xang == "Xăng RON 95-III")
                {
                    gia_xang = 26830;
                }
                else if (xang == "Xăng RON 92-II")
                {
                    gia_xang = 26070;
                }
                else
                {
                    gia_xang = 21310;
                }
                if (xe == "Wave Alpha")
                {
                    total_km.Text = Math.Round(100 * 3.7 / 1.6, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 3.7, 3).ToString();
                }
                else if (xe == "Sirius")
                {
                    total_km.Text = Math.Round(100 * 3.8 / 1.99, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 3.8, 3).ToString();
                }
                else if (xe == "Vision")
                {
                    total_km.Text = Math.Round(100 * 5.2 / 1.87, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 5.2, 3).ToString();
                }
                else if (xe == "Lead")
                {
                    total_km.Text = Math.Round(100 * 6 / 2.02, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 6, 3).ToString();
                }
                else if (xe == "Winner")
                {
                    total_km.Text = Math.Round(100 * 4.5 / 1.7, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 4.5, 3).ToString();
                }
                else if (xe == "AirBlade")
                {
                    total_km.Text = Math.Round(100 * 4.4 / 2.17, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 4.4, 3).ToString();
                }
                else
                {
                    total_km.Text = Math.Round(100 * 70.0 / 13, 3).ToString();
                    total_money.Text = Math.Round(gia_xang * 70, 3).ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại xe và loại xăng!");
            }

        }
    }
}
