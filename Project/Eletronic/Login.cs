using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eletronic
{
    public partial class Login : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnlogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                // ✅ 1. CHECK ADMIN
                string adminQuery = "SELECT COUNT(*) FROM Admin WHERE Username=@user AND Password=@pass";
                SqlCommand cmdAdmin = new SqlCommand(adminQuery, con);
                cmdAdmin.Parameters.AddWithValue("@user", txtusername.Text.Trim());
                cmdAdmin.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());

                int adminCount = Convert.ToInt32(cmdAdmin.ExecuteScalar());

                if (adminCount > 0)
                {
                    // ✅ Admin Login
                    Eletronic.Admin.Dashboard admin = new Eletronic.Admin.Dashboard();
                    admin.Show();
                    this.Hide();
                    return;
                }

                // ✅ 2. CHECK EMPLOYEE ROLE
                string empQuery = "SELECT role FROM Employee WHERE username=@user AND password=@pass";
                SqlCommand cmdEmp = new SqlCommand(empQuery, con);
                cmdEmp.Parameters.AddWithValue("@user", txtusername.Text.Trim());
                cmdEmp.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());

                object role = cmdEmp.ExecuteScalar();

                if (role != null)
                {
                    string userRole = role.ToString().Trim().ToLower();

                    if (userRole == "manager")
                    {
                        // ✅ Manager → Admin Dashboard
                        Eletronic.Admin.Dashboard admin = new Eletronic.Admin.Dashboard();
                        admin.Show();
                        this.Hide();
                    }
                    else if (userRole == "sales")
                    {
                        // ✅ Sales → Employee Dashboard
                        Eletronic.Dashboard emp = new Eletronic.Dashboard(); // your employee dashboard
                        emp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Role Defined");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}
