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
    public partial class Lab01_Bai03_2 : Form
    {
        public Lab01_Bai03_2()
        {
            InitializeComponent();
            result.ReadOnly = true;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int i;
            string s = num.Text;
            if (int.TryParse(s, out i) & i <= 9999)
            {
                string ketqua = "";
                if (i < 0) { ketqua += "Âm "; i *= -1; }
                if (i == 0) { ketqua = "Không"; }
                switch (i / 1000)
                {
                    case 1: ketqua += "Một Ngàn "; break;
                    case 2: ketqua += "Hai Ngàn "; break;
                    case 3: ketqua += "Ba Ngàn "; break;
                    case 4: ketqua += "Bốn Ngàn "; break;
                    case 5: ketqua += "Năm Ngàn "; break;
                    case 6: ketqua += "Sáu Ngàn "; break;
                    case 7: ketqua += "Bảy Ngàn "; break;
                    case 8: ketqua += "Tám Ngàn "; break;
                    case 9: ketqua += "Chín Ngàn "; break;
                }
                if (i > 999 & i % 1000 == 0)
                {
                    result.Text = ketqua;
                }
                else
                {
                    if (i > 99)
                    {
                        switch ((i % 1000) / 100)
                        {
                            case 0: ketqua += "Không Trăm "; break;
                            case 1: ketqua += "Một Trăm "; break;
                            case 2: ketqua += "Hai Trăm "; break;
                            case 3: ketqua += "Ba Trăm "; break;
                            case 4: ketqua += "Bốn Trăm "; break;
                            case 5: ketqua += "Năm Trăm "; break;
                            case 6: ketqua += "Sáu Trăm "; break;
                            case 7: ketqua += "Bảy Trăm "; break;
                            case 8: ketqua += "Tám Trăm "; break;
                            case 9: ketqua += "Chín Trăm "; break;
                        }
                    }
                    if (i > 9)
                    {
                        switch ((i / 10) % 10)
                        {
                            case 0:
                                if (i % 10 > 0) { ketqua += "Linh "; }
                                break;
                            case 1: ketqua += "Mười "; break;
                            case 2: ketqua += "Hai Mươi "; break;
                            case 3: ketqua += "Ba Mươi "; break;
                            case 4: ketqua += "Bốn Mươi "; break;
                            case 5: ketqua += "Năm Mươi "; break;
                            case 6: ketqua += "Sáu Mươi "; break;
                            case 7: ketqua += "Bảy Mươi "; break;
                            case 8: ketqua += "Tám Mươi "; break;
                            case 9: ketqua += "Chín Mươi "; break;
                        }
                    }
                    switch (i % 10)
                    {
                        case 1:
                            if ((i / 10) % 10 > 1) ketqua += "Mốt";
                            else ketqua += "Một";
                            break;
                        case 2: ketqua += "Hai"; break;
                        case 3: ketqua += "Ba"; break;
                        case 4: ketqua += "Bốn"; break;
                        case 5:
                            if ((i / 10) % 10 > 0) ketqua += "Lăm";
                            else ketqua += "Năm";
                            break;
                        case 6: ketqua += "Sáu"; break;
                        case 7: ketqua += "Bảy"; break;
                        case 8: ketqua += "Tám"; break;
                        case 9: ketqua += "Chín"; break;
                    }

                }
                result.Text = ketqua;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 4 chữ số trở xuống!");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            num.Text = "";
            result.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            int i;
            string s = num.Text;

            if (int.TryParse(s, out i) & i <= 9999) { }
            else
            {
                if (s != "-" & s != "") MessageBox.Show("Vui lòng nhập số nguyên từ 4 chữ số trở xuống!");
            }
        }
    }
}
