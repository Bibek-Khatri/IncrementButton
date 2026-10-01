using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Electricitybill : Form
    {
        public Electricitybill()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            
            int units = int.Parse(textBox1.Text);
            int billAmount = 0;

            
            if (units <= 100)
            {
                billAmount = units * 5;
            }
            else if (units <= 200)
            {
                billAmount = units * 7;
            }
            else
            {
                billAmount = units * 10;
            }

           
            label3.Text = "" + billAmount;
        }


    }
}
