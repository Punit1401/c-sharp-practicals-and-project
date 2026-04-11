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
namespace student
{
    public partial class Course : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\student\student.mdf;Integrated Security=True");
        public Course()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {

        }
        // 🔹 Load Courses into DataGridView
        void LoadCourses()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM course", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO course VALUES(@name)", con);
                cmd.Parameters.AddWithValue("@name", txtCourseName.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Course Added Successfully!");

                // Refresh Grid
                LoadCourses();

                // Clear Fields
                
                txtCourseName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
