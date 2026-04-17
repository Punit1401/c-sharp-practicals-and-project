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

namespace Eletronic.Admin
{
    public partial class Register : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Register()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string gender = "";
            if(rdmale.Checked)
            {
                gender = "Male";
            }
            else if(rdfemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Select any one");
            }
            string sql = "INSERT INTO Employee (firstname,lastname,mobile,gender,username,password,address,role) VALUES ('"+txtfname.Text+ "','"+txtlname.Text+ "',"+txtmobile.Text+ ",'"+gender+"','"+txtuser.Text+"','"+txtpass.Text+ "','"+txtaddress.Text+ "','"+cbrole.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            txtfname.Text = "";
            txtlname.Text = "";
            txtmobile.Text = "";
            rdmale.Checked = false;
            rdfemale.Checked = false;
            txtuser.Text = "";
            txtpass.Text = "";
            txtaddress.Text = "";
            cbrole.Text = "";



            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);

            txtfname.Text = "";
            txtlname.Text = "";
            txtmobile.Text = "";
            rdmale.Checked = false;
            rdfemale.Checked = false;
            txtuser.Text = "";
            txtpass.Text = "";
            txtaddress.Text = "";
            cbrole.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }
    }
}
