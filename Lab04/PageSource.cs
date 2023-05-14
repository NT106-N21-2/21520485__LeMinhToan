using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class PageSource : Form
    {
        public PageSource(string url)
        {
            InitializeComponent();
            richTextBox1.Text = url;
        }

        private void PageSource_Load(object sender, EventArgs e)
        {

        }
    }
}
