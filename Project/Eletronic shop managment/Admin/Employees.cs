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
    public partial class Employees : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Employees()
        {
            InitializeComponent();
            this.Activated += new System.EventHandler(this.Employees_Activated);
        }

        public void display()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            employeelist.DataSource = dt;
            Tabledesign.tabledesign(employeelist);
            con.Close();
        }
       

        private void Staff_list_Load(object sender, EventArgs e) {
            display();
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void employeelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Updateemployee());
            display();
        }

        private void txtdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "delete from Employee where id = "+txtid.Text+"";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }
        private void Employees_Activated(object sender, EventArgs e)
        {
            display(); // refresh data automatically
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }
    }
}