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

namespace employee
{
    public partial class Form1 : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }
        public void display()
        {
           using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "select * from Employee";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "insert into Employee (name,age,dept) value (@name,@age,@dept)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@age", txtage.Text);
                cmd.Parameters.AddWithValue("@dept", txtdept.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Insert");
                display();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {

            con.Open();
            string sql = "delete from Employee where name=@name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
            con.Close();
                display();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                string sql = "update Employee SET age=@age, dept=@dept WHERE name=@name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@age", txtage.Text);
                cmd.Parameters.AddWithValue("@dept", txtdept.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                con.Close();
                display();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
