using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InputUsingTextbox : Form
    {
        public InputUsingTextbox()
        {
            InitializeComponent();
        }


        private void Display_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            textBox2.Text = "Hello, " + name;
        }
    }
}
