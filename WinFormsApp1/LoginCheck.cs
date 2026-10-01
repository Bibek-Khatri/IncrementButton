using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginCheck : Form
    {
        public LoginCheck()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "1234")
            {
                label3.Text = "Login Successful";
            }
            else
            {
                label3.Text = "Invalid Username or Password";
            }
        }
    }
}
