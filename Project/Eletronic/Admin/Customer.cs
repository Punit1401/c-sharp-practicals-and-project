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
    public partial class Customer : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Customer()
        {
            InitializeComponent();
        }

        private void customerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }
        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            string sql = "select * from customer";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            Tabledesign.tabledesign(customerlist);
            customerlist.DataSource = dt;
            da.Fill(dt);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            display();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerlist_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string q = "";
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                // 🔹 Show ALL data
                q = "select c.id as Bill_id, c.firstname as Firstname, c.lastname as Lastname, " +
                    "c.mobile as Mobile, b.productname as Productname, b.qty as Qty, " +
                    "b.price as Price, b.date as Date, b.total as Total " +
                    "from customer c " +
                    "LEFT JOIN billitems b ON c.id = b.bill_id";
            }
            else
            {
                // 🔹 Search by mobile or bill id
                q = "select c.id as Bill_id, c.firstname as Firstname, c.lastname as Lastname, " +
                    "c.mobile as Mobile, b.productname as Productname, b.qty as Qty, " +
                    "b.price as Price, b.date as Date, b.total as Total " +
                    "from customer c " +
                    "LEFT JOIN billitems b ON c.id = b.bill_id " +
                    "where c.mobile LIKE '%" + txtsearch.Text + "%' " +
                    "OR b.bill_id LIKE '%" + txtsearch.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customerlist.DataSource = dt;
            Tabledesign.tabledesign(customerlist);
            con.Close();
        }
    }
}
