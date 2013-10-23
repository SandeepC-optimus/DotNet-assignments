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
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
            Left_Vertical_Menu l = new Left_Vertical_Menu();
            button1.Visible = false;
            
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {

            Left_Vertical_Menu l = new Left_Vertical_Menu();
            
            this.Close();
            l.vNavPane1.Items[0].Select();
            l.ChangeMenu();
        }
        public string GetValues()
        {
            return txtName.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string x = txtName.Text;
        }
       
    }
}
