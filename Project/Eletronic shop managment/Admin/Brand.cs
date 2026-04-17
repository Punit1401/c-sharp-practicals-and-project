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
    public partial class Brand : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Brand()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void Brand_Load(object sender, EventArgs e)
        {
            display();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "insert into brand (brand_name) values ('"+txtbrand.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Brand Added Successfully");
            con.Close();
            display();
        }

        private void databrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "select * from brand";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            databrand.DataSource = dt;
            Tabledesign.tabledesign(databrand);
            con.Close();
        }

        

        private void databrand_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void btndelete_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new delbrand());
        }
    }
}
