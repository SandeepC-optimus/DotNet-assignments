using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vertical
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "hello  " + textBox1.Text;
            button1.Enabled = false;
        }
    }
}
