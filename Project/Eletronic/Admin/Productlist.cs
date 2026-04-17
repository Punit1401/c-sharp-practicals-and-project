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
    public partial class Productlist : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Productlist()
        {
            InitializeComponent();
        }

        private void productslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
             string sql = "SELECT p.id,p.product_name,p.p_price as Purchase_price,p.s_price as Selling_price,b.brand_name,c.name AS category_name,p.qty,p.color FROM Product p LEFT JOIN Brand b ON p.brand_id = b.id LEFT JOIN Category c ON p.category_id = c.id; ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            productslist.DataSource = dt;
            Tabledesign.tabledesign(productslist);

            con.Close();
        }

        private void Productlist_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new updateproduct());
            display();
        }

        private void txtdelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "delete from product where id="+txtid.Text+" ";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            display();

            con.Close();
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
