using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class View_email : Form
    {
        public View_email(string t)
        {
            InitializeComponent();
            RichTextBox tb=new RichTextBox();
            groupBox1.Controls.Add(tb);
            tb.Text = t;
            tb.Dock= DockStyle.Fill;
        }
    }
}
