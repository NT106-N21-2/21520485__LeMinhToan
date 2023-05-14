using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class View_news : Form
    {
        string url;

        public View_news(string s)
        {
            InitializeComponent();
            url = s;
        }
        private void View_news_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri(url.Trim());
        }
    }
}
