using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bloodbank
{
    public partial class donor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\bloodbank\bloodbank.mdf;Integrated Security=True");

        public donor()
        {
            InitializeComponent();
        }

        // 🔹 FORM LOAD
        private void donor_Load(object sender, EventArgs e)
        {
            LoadBloodGroups();
            LoadGender();
            display();
        }

        // 🔹 LOAD BLOOD GROUPS
        void LoadBloodGroups()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM blood", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbBlood.DataSource = dt;
                cmbBlood.DisplayMember = "BloodGroup";  // column name
                cmbBlood.ValueMember = "BloodID";

                cmbSearchBlood.DataSource = dt;
                cmbSearchBlood.DisplayMember = "BloodGroup";
                cmbSearchBlood.ValueMember = "BloodID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading blood groups: " + ex.Message);
            }
        }

        // 🔹 LOAD GENDER
        void LoadGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbSearchGender.Items.Add("Male");
            cmbSearchGender.Items.Add("Female");
        }

        // 🔹 DISPLAY ALL DONORS
        public void display()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM donor", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading donors: " + ex.Message);
            }
        }

        // 🔹 INSERT DONOR
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtWeight.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO donor (DonorName, Address, ContactNo, DOB, Gender, Weight, BloodID) VALUES (@n,@a,@c,@d,@g,@w,@b)", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@a", txtAddress.Text);
                cmd.Parameters.AddWithValue("@c", txtContact.Text);
                cmd.Parameters.AddWithValue("@d", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@g", cmbGender.Text);
                cmd.Parameters.AddWithValue("@w", int.Parse(txtWeight.Text));
                cmd.Parameters.AddWithValue("@b", cmbBlood.SelectedValue);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Donor Added Successfully!");

                display(); // refresh

                // Clear fields
                txtName.Clear();
                txtAddress.Clear();
                txtContact.Clear();
                txtWeight.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        // 🔹 SEARCH BY BLOOD
        private void btnSearchBlood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM donor WHERE BloodID=@id", con);

                da.SelectCommand.Parameters.AddWithValue("@id", cmbSearchBlood.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔹 SEARCH BY GENDER
        private void btnSearchGender_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM donor WHERE Gender=@g", con);

                da.SelectCommand.Parameters.AddWithValue("@g", cmbSearchGender.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}