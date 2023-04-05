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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();


        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            bangthongtin.Controls.Clear();
            mondau.Clear();
            monrot.Clear();
            monmax.Clear();
            monmin.Clear();
            xeploai.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Additem(string s)
        {
            Label l = new Label();
            l.Text = s;
            l.Width = 400;
            l.Height = 45;
            bangthongtin.Controls.Add(l);
        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            bangthongtin.Controls.Clear();
            double dtb = 0, min = 10, max = 0;
            int vtmin = 0, vtmax = 0;
            int smd65 = 0, smd5 = 0, smd35 = 0, smd2 = 0;
            string[] list = thongtin.Text.Split(",");
            if (list.Length <= 1) dtb = -1;
            for (int i = 1; i < list.Length; i++)
            {
                double diem;
                list[i]=list[i].Replace(" ", "");
                if (double.TryParse(list[i], out diem) && diem <= 10 && diem >= 0)
                {
                    dtb += diem;
                    if (diem < 6.5) smd65 += 1;
                    else if (diem < 5) smd5 += 1;
                    else if (diem < 3.5) smd35 += 1;
                    else if (diem < 2) smd2 += 1;
                    if (diem > max) { max = diem; vtmax = i; }
                    if (diem < min) { min = diem; vtmin = i; }
                }
                else
                {
                    bangthongtin.Controls.Clear();
                    dtb = -1;
                    break;
                }
            }
            if (dtb >= 0)
            {
                dtb = Math.Round(dtb / (list.Length - 1), 2);
                Dtb.Text = (dtb).ToString();
                monmax.Text = "Môn " + vtmax.ToString();
                monmin.Text = "Môn " + vtmin.ToString();
                mondau.Text = (list.Length - 1 - smd5).ToString();
                monrot.Text = smd5.ToString();
                if (dtb >= 8 && smd65 == 0) { xeploai.Text = "Giỏi"; }
                else if (dtb >= 6.5 && smd5 == 0) { xeploai.Text = "Khá"; }
                else if (dtb >= 5 && smd35 == 0) { xeploai.Text = "TB"; }
                else if (dtb >= 3.5 && smd2 == 0) { xeploai.Text = "Yếu"; }
                else { xeploai.Text = "Kém"; }
                Additem("Họ và tên: " + list[0]);
                for (int i = 1; i < list.Length; i++)
                {
                    Additem("Môn " + i.ToString() + ": " + list[i]);
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin sai format!");
            }
        }
    }
}
