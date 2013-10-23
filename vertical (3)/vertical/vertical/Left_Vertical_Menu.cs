using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace vertical
{
    public partial class Left_Vertical_Menu : Form
    {
        int counter = 1;
        
        public Left_Vertical_Menu()
        {
            InitializeComponent();
            vNavPaneItem2.Click += (s, e) =>
            {
                panel1.Controls.Clear();
                Test1 T1 = new Test1();
                T1.TopLevel = false;
                T1.AutoScroll = true;
                panel1.Controls.Add(T1);
                T1.Show();
                T1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                
            };          
            //VIBlend.WinForms.Controls.vApplicationMenuItem obj= new VIBlend.WinForms.Controls.vApplicationMenuItem();
            //obj.Text="menu1";            
            //vApplicationMenuItem34.Items.Add(obj);
            
        }        

        private void vApplicationMenuItem91_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vApplicationMenuItem9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Test1 T1 = new Test1();
            T1.TopLevel = false;
            T1.AutoScroll = true;
            panel1.Controls.Add(T1);
            T1.Show();
            T1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void vApplicationMenuItem14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Test1 T1 = new Test1();
            T1.TopLevel = false;
            T1.AutoScroll = true;
            panel1.Controls.Add(T1);
            T1.Show();
            T1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void vApplicationMenuItem20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Test1 T1 = new Test1();
            T1.TopLevel = false;
            T1.AutoScroll = true;
            panel1.Controls.Add(T1);
            T1.Show();
            T1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void vApplicationMenuItem90_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MainMenu m1 = new MainMenu();
            m1.TopLevel = false;
            m1.AutoScroll = true;
            panel1.Controls.Add(m1);
            m1.Show();
            m1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        MainMenu m1 = new MainMenu();
        public void ChangeMenu()
        {
            m1.TopLevel = false;
            m1.AutoScroll = true;
            panel1.Controls.Add(m1);
            m1.Show();
            m1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m1.GetLifetimeService();
        }

        public void Left_Vertical_Menu_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MainMenu m1 = new MainMenu();
            m1.TopLevel = false;
            m1.AutoScroll = true;
            panel1.Controls.Add(m1);
            m1.Show();
            m1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            vNavPane1.SelectItem(mnuHome);
            //vApplicationMenuItem90.BackColor = Color.BurlyWood;
        }

        public void mnuHome_Click(object sender, EventArgs e)
        {
            vNavPane1.SelectItem(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "e:\\abc.txt";
            string x="";
            int z = 0;
            if (counter == 9 || (counter-7)==9)
                counter = 0;
            if (counter == 0 || (counter - 7) == 0)
                counter = 1;
            if (counter == 1)
            {
                vNavPane1.SelectItem(counter);
                panel1.Controls.Clear();
                Test1 T1 = new Test1();
                T1.TopLevel = false;
                T1.AutoScroll = true;
                panel1.Controls.Add(T1);
                T1.Show();
                T1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                z = 1;                
            }
            if (counter == 2)
            {
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(string.Format(panel1.Controls[0].Controls["txtName"].Text + "  " + panel1.Controls[0].Controls["txtAge"].Text));
                sw.Close();
                vNavPane1.SelectItem(counter);
            }
            else
            {             
                vNavPane1.SelectItem(counter);                
            }
            counter += 1;
           
        }

        private void vApplicationMenuItem90_MouseHover(object sender, EventArgs e)
        {
            vApplicationMenuItem90.BackgroundImageLayout = ImageLayout.None;
            vApplicationMenuItem90.BackColor = Color.Aqua;
        }

        private void vApplicationMenuItem90_MouseLeave(object sender, EventArgs e)
        {
            vApplicationMenuItem90.BackgroundImageLayout = ImageLayout.Stretch;
            //vApplicationMenuItem90.BackColor = Color.BurlyWood;
        }
                   
                    //counter++;
            //vNavPane1.SelectItem(counter);
            

    
    }
}

