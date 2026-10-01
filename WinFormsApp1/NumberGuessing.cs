using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NumberGuessing : Form
    {
        public NumberGuessing()
        {
            InitializeComponent();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            int secretNumber = 41;

            int userGuess = int.Parse(textBox1.Text);

            if (userGuess == secretNumber)
            {
                label3.Text = "Correct Guess!";
            }
            else if (userGuess > secretNumber)
            {
                label3.Text = "Try a smaller number.";
            }
            else
            {
                label3.Text = "Try a larger number.";
            }
        }
    }
}
