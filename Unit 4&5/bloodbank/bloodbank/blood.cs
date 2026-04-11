using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bloodbank
{
    public partial class blood : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\bloodbank\bloodbank.mdf;Integrated Security=True");


        public blood()
        {
            InitializeComponent();
        }

        // 🔹 FORM LOAD
        private void blood_Load(object sender, EventArgs e)
        {
            display();
        }

        // 🔹 DISPLAY DATA IN GRID
        public void display()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM blood", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // 🔹 INSERT BLOOD GROUP
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBloodID.Text == "" || txtBloodGroup.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO blood (BloodID, BloodGroup) VALUES (@id,@group)", con);

                cmd.Parameters.AddWithValue("@id", int.Parse(txtBloodID.Text));
                cmd.Parameters.AddWithValue("@group", txtBloodGroup.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Blood Group Added Successfully!");

                display(); // refresh grid

                // Clear fields
                txtBloodID.Clear();
                txtBloodGroup.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        // 🔹 GRID CLICK (OPTIONAL)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: you can use this later for update/delete
        }
    }
}