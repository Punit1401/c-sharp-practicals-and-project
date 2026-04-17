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
    
    public partial class Category : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Category()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            String sql = "insert into category (name) values ('"+txtcategory.Text+"')";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            txtcategory.Clear();
            con.Close();
            display();
        }

        

       
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            String sql = "select * from category";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            dispcategory.DataSource = dt;
            da.Fill(dt);
            Tabledesign.tabledesign(dispcategory);
            con.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            display();

        }

        private void dispcategory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new delcategory());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
