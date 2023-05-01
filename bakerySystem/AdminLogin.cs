using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakerySystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            adminPwdField.UseSystemPasswordChar = true;
        }

        private void adminUsrField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminPwdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                adminPwdField.UseSystemPasswordChar = false;
            }
            else
            {
                adminPwdField.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(adminUsrField.Text == "admin" && adminPwdField.Text == "admin")
            {
                MessageBox.Show("Welcome Back Admin!", "Login Success");
                AdminMenu am = new AdminMenu();
                am.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
