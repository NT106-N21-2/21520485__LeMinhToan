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
    public partial class Lab06_bai2 : Form
    {
        public Lab06_bai2()
        {
            InitializeComponent();
        }
        readonly string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        //readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void btn_encoder_Click(object sender, EventArgs e)
        {
            string plainText = input.Text;
            string cipherText = "";
            string Key = key.Text;
            int n;
            if (input.Text.Trim() != "")
            {
                for (int i = 0; i < plainText.Length; i++)
                {
                    int index = alphabet.IndexOf(plainText[i]);
                    int  index_p=alphabet.IndexOf(Key[i% Key.Length]);
                    var newIndex = (index + index_p) % alphabet.Length;
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
            string Key=key.Text;
            int n;
            if ( input.Text.Trim()!= "")
            {
                for (int i = 0; i < plainText.Length; i++)
                {
                    int index = alphabet.IndexOf(plainText[i]);
                    int index_p = alphabet.IndexOf(Key[i % Key.Length]);
                    index -= index_p;
                    if (index < 0) index = index + alphabet.Length;
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
