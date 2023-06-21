using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Lab06_bai1 : Form
    {
        public Lab06_bai1()
        {
            InitializeComponent();
        }
        readonly string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";

        private void btn_encoder_Click(object sender, EventArgs e)
        {
            string plainText = input.Text;
            string cipherText = "";
            int n;
            if (int.TryParse(shift.Text, out n) && input.Text.Trim() != "")
            {
                for (int i = 0; i < plainText.Length; i++)
                {
                    int index = alphabet.IndexOf(plainText[i]);
                    var newIndex = (index + n) % alphabet.Length;

                    cipherText += alphabet[newIndex];
                }
                output.Text = cipherText;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại dữ liệu!");
            }

        }

        private void btn_decoder_Click(object sender, EventArgs e)
        {
            string plainText = input.Text;
            string cipherText = "";
            int n;
            if (int.TryParse(shift.Text, out n) && input.Text.Trim() != "")
            {
                for (int i = 0; i < plainText.Length; i++)
                {
                    int index = alphabet.IndexOf(plainText[i]);
                    if (index - n < 0) index = index - n + alphabet.Length;
                    else index = (index - n);// % alphabet.Length;
                    //var newIndex = 
                    cipherText += alphabet[index];
                }
                output.Text = cipherText;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại dữ liệu!");
            }
        }
    }
}
