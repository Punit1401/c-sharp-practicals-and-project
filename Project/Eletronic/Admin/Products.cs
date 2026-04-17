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
    public partial class Products : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
       

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            categoryname();
            brandname();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        public void brandname()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "select id,brand_name from brand";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            txtbrand.DataSource = dt;
            txtbrand.DisplayMember = "brand_name";
            txtbrand.ValueMember = "id";
            
            con.Close();

        }
        public void categoryname()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "select id,name from category";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
                txtcategory.DataSource = dt;
                txtcategory.DisplayMember = "name";
                txtcategory.ValueMember = "id";

          
            con.Close();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            int brandId = Convert.ToInt32(txtbrand.SelectedValue);
            int categoryId = Convert.ToInt32(txtcategory.SelectedValue);

            string sql = "INSERT INTO product (product_name, p_price, s_price, brand_id, category_id, qty, color) " +
                         "VALUES ('"+txtpname.Text+ "', '" + txtp_price.Text + "', '" + txts_price.Text + "', "+brandId+", "+categoryId+", "+txtqty.Text+", '"+txtcolor.Text+"')";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Product Added Successfully");
            txtpname.Text = "";
            txtp_price.Text = "";
            txts_price.Text = "";
            txtbrand.Text = "";
            txtcategory.Text = "";
            txtqty.Text = "";
            txtcolor.Text = "";

            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpname.Text="";
            txtp_price.Text = "";
            txts_price.Text = "";
            txtbrand.Text = "";
            txtcategory.Text = "";
            txtqty.Text = "";
            txtcolor.Text = "";
        }

        private void txtp_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }

        private void txts_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }
    }
}
