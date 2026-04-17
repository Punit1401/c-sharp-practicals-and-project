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
    public partial class Updateemployee : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Updateemployee()
        {
            InitializeComponent();
        }

            
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string gender = "";
            if (rdmale.Checked)
            {
                gender = "Male";
            }
            else if(rdfemale.Checked)
            {
                gender = "Female";

            }
            else
            {
                MessageBox.Show("No Data found");
            }
            string sql = "UPDATE Employee set firstname ='" + txtfname.Text + "',lastname ='" + txtlname.Text + "',mobile =" + txtmobile.Text + ",gender = '" + gender + "',username ='" + txtuser.Text + "',address='" + txtaddress.Text + "',role = '" + cbrole.Text + "' Where Id =" + txtid.Text + " ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee Data Updated");
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Employees());
            con.Close();
        }


        private void btnfetch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string q = "select * from Employee where id =" + txtid.Text + " ";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtfname.Text = dr["firstname"].ToString();
                txtlname.Text = dr["lastname"].ToString();
                txtmobile.Text = dr["mobile"].ToString();
                cbrole.Text = dr["role"].ToString();
                txtuser.Text = dr["username"].ToString();
                txtpass.Text = dr["password"].ToString();
                txtaddress.Text = dr["address"].ToString();
                string gender = dr["gender"].ToString();

                if (gender == "Male")
                {
                    rdmale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdfemale.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Employees());
        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }

        private void Updateemployee_Load(object sender, EventArgs e)
        {

        }
    }
}
