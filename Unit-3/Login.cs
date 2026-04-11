using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            // Question:
            // Show alert message if login data is wrong
           
                string username = textBox1.Text;
                string password = textBox2.Text;

                // Example correct credentials
                if (username == "admin" && password == "1234")
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
