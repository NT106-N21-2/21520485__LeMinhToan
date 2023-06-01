﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab05
{
    public partial class Viewmessage_upgrade : Form
    {
        public Viewmessage_upgrade(string html, string from, string to, string sub, string acc, string pass)
        {
            InitializeComponent();
            text_from.Text = from;
            textto.Text = to;
            this.Text = sub;
            frome = to; toe = from;
            pas = pass; ac = acc;
            InitBrowser(html);
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser(string s)
        {
            await initizated();
            webView21.CoreWebView2.NavigateToString(s);
        }
        string frome, toe, ac, pas;
        private void button1_Click(object sender, EventArgs e)
        {
            Send_mail sm = new Send_mail("smtp.gmail.com", "465", ac, pas, true, frome, toe);
            sm.Show();
        }
    }
}
