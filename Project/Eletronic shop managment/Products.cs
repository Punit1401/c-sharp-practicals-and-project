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

namespace Eletronic
{
   
    public partial class Products : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Products()
        {
            InitializeComponent();
        }

        private void productlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
            
        }
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "select p.product_name,p.p_price as Purchase_price,b.brand_name,c.name as category_name,p.qty,p.color from product p inner join brand b on p.brand_id=b.id inner join category c on p.category_id = c.id";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            Tabledesign.tabledesign(productslist);
            productslist.DataSource = dt;
            da.Fill(dt);
            con.Close();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            display();
        }

        private void productslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string q = "select p.product_name,p.p_price as Purchase_price,b.brand_name,c.name as category_name,p.qty,p.color from product p inner join brand b on p.brand_id=b.id inner join category c on p.category_id = c.id WHERE p.product_name LIKE '%" + txtsearch.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            productslist.DataSource = dt;
            Tabledesign.tabledesign(productslist);
            con.Close();
        }
    }
}
