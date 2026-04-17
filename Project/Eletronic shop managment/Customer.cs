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
    public partial class Customer : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Customer()
        {
            InitializeComponent();
            this.Activated += new System.EventHandler(this.Customer_Activated);
        }

        private void customerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = " select c.id as Bill_id,c.firstname as Firstname,c.lastname as Lastname,c.mobile as Mobile,b.productname as Productname,b.qty as Qty,b.price as Price,b.date as Date ,b.total as Total from customer c LEFT JOIN billitems b ON c.id=b.bill_id; ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            Tabledesign.tabledesign(customerlist);
            da.Fill(dt);
            customerlist.DataSource = dt;
            Tabledesign.tabledesign(customerlist);
            con.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            display();
        }

       
        private void Customer_Activated(object sender, EventArgs e)
        {
            display();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string q = " select c.id as Bill_id,c.firstname as Firstname,c.lastname as Lastname,c.mobile as Mobile,b.productname as Productname,b.qty as Qty,b.price as Price,b.date as Date ,b.total as Total from customer c LEFT JOIN billitems b ON c.id=b.bill_id where mobile=" + txtsearch.Text + " ";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customerlist.DataSource = dt;
            Tabledesign.tabledesign(customerlist);
            con.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
