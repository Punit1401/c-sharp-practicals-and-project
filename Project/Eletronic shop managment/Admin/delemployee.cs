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

    public partial class delemployee : Form
    {
    string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public delemployee()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "delete from Employee where Id='" + txtemployeeid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Deleted Successfully");
            Dashboard dash = (Dashboard)this.ParentForm;
            Employees emp = new Employees();
            dash.LoadPage(emp);
            emp.display();
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Employees());
        }

        private void delemployee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtemployeeid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }
    }
}
