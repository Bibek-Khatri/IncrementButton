using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sub1 = int.Parse(textBox1.Text);
            int sub2 = int.Parse(textBox2.Text);
            int sub3 = int.Parse(textBox3.Text);

            
            int total = sub1 + sub2 + sub3;

            
            label1.Text = "" + total;

           
            if (sub1 >= 40 && sub2 >= 40 && sub3 >= 40)
            {
                label2.Text = "Pass";
            }
            else
            {
                label2.Text = "Fail";
            }
        }
    }
}
