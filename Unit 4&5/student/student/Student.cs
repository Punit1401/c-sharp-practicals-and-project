// Question:
// Apply Exception Handling in Student Application

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace student
{
    public partial class Student : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\student\student.mdf;Integrated Security=True");

        public Student()
        {
            InitializeComponent();
        }

        // 🔹 Form Load
        private void Student_Load(object sender, EventArgs e)
        {
            LoadCourses();
            display();
        }

        // 🔹 Load Course into ComboBox
        void LoadCourses()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM course", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "id";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error (Course Load): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        // 🔹 Display Student Data
        public void display()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM student", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error (Display): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        // 🔹 Insert Student with Proper Exception Handling
        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            if (txtStudName.Text == "" || txtAddress.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO student (StudName, Address, CourseID, YrOfAdmsn) VALUES (@name,@add,@cid,@year)", con);

                cmd.Parameters.AddWithValue("@name", txtStudName.Text);
                cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                cmd.Parameters.AddWithValue("@cid", cmbCourse.SelectedValue);

                // 🔥 Can throw FormatException
                cmd.Parameters.AddWithValue("@year", int.Parse(txtYear.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Added Successfully!");

                display();

                // Clear fields
                txtStudName.Clear();
                txtAddress.Clear();
                txtYear.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Year must be a number.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // 🔥 Always executes
            }
        }

        // 🔹 Open Course Form
        private void btnOpenCourse_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
        }

        private void txtStudName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}