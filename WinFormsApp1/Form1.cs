using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int counter = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Increment_Click(object sender, EventArgs e)
        {
            counter++; 
            label1.Text = counter.ToString(); 
        }
    }
}
