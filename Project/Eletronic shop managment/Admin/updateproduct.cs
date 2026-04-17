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
    public partial class updateproduct : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public updateproduct()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            int brandId = Convert.ToInt32(txtbrand.SelectedValue);
            int categoryId = Convert.ToInt32(txtcategory.SelectedValue);
            string sql = "UPDATE product set product_name ='"+txtpname.Text+"',p_price ="+txtp_price.Text+",s_price ="+txts_price.Text+",brand_id = "  +txtbrand.SelectedValue+",category_id ="+txtcategory.SelectedValue+",qty="+txtqty.Text+",color = '"+txtcolor.Text+"' Where Id ="+txtid.Text+" ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Data Updated");
            Productlist pl = new Productlist();
            pl.Show();
            pl.Hide();

        }

        private void updateproduct_Load(object sender, EventArgs e)
        {
            brandname();
            categoryname();
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

        private void btnfetch_Click(object sender, EventArgs e)
        {
         

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string q = "select * from product where id ="+ txtid.Text + " ";
            SqlCommand cmd = new SqlCommand(q,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtpname.Text = dr["product_name"].ToString();
                txtp_price.Text = dr["p_price"].ToString();
                txts_price.Text = dr["s_price"].ToString();
                txtbrand.SelectedValue = Convert.ToInt32(dr["brand_id"]);
                txtcategory.SelectedValue = Convert.ToInt32(dr["category_id"]);
                txtqty.Text = dr["qty"].ToString();
                txtcolor.Text = dr["color"].ToString();




            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Productlist());
            this.Close();
            
        }
    }
}
