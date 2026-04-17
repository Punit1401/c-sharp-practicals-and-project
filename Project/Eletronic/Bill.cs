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
    public partial class Bill : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public Bill()
        {
            InitializeComponent();
        }

        public void display()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            String sql = "SELECT id,product_name,brand_id as brand,color,qty as Qty,s_price as price FROM product";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            searchproduct.DataSource = dt;
            da.Fill(dt);
            Tabledesign.tabledesign(searchproduct);
            con.Close();
        }
        private void cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = searchproduct.Rows[e.RowIndex];

                int productId = Convert.ToInt32(row.Cells["id"].Value);
                string productName = row.Cells["product_name"].Value.ToString();
                int productPrice = Convert.ToInt32(row.Cells["price"].Value);

                // 🔍 Check qty from DB
                SqlConnection con = new SqlConnection(conn);
                con.Open();

                string checkQty = "SELECT qty FROM product WHERE id = " + productId;
                SqlCommand cmd = new SqlCommand(checkQty, con);

                int qty = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                // ❌ If out of stock
                if (qty == 0)
                {
                    MessageBox.Show(productName + " is Out of Stock");

                    // Clear fields so user cannot add
                    pname.Clear();
                    price.Clear();
                    txtid.Clear();
                }
                else
                {
                    // ✅ Set values only if stock available
                    pname.Text = productName;
                    price.Text = productPrice.ToString();
                    txtid.Text = productId.ToString();
                }
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            addcart();

        }
        public void searchData(string keyword)
        {
            SqlConnection con = new SqlConnection(conn);

            string query = "SELECT id,product_name,brand_id as brand,color,qty as Qty,s_price as price FROM product WHERE product_name LIKE @key";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            searchproduct.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found");
            }

            Tabledesign.tabledesign(searchproduct);
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            searchData(txtsearch.Text.Trim());


        }

        private void cart_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void addcart()
        {
            cart.ColumnCount = 6;
            cart.Columns[0].Name = "Sr.no";
            cart.Columns[1].Name = "Product ID";
            cart.Columns[2].Name = "Product Name";
            cart.Columns[3].Name = "Price";
            cart.Columns[4].Name = "Qty";
            cart.Columns[5].Name = "Total";
            cartdesign(cart);
        }

        public void cartdesign(DataGridView grid)
        {
            

            // Grid basic settings
            grid.EnableHeadersVisualStyles = false;
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.BorderStyle = BorderStyle.None;

            // Header style
            grid.ColumnHeadersHeight = 45;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 70, 141);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Row style
            grid.DefaultCellStyle.BackColor = Color.FromArgb(77, 126, 175);
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Grid lines
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.Gray;

            // AUTO SIZE
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
       

        private void addtocart_Click(object sender, EventArgs e)
        {
            try
            {

                int srno = cart.Rows.Count + 1;
                int productid = Convert.ToInt32(txtid.Text);
                string productname = pname.Text;
                int prices = Convert.ToInt32(price.Text);
                int qtys = Convert.ToInt32(qty.Text);
                int total = prices * qtys;

                cart.Rows.Add(srno,productid,productname, prices, qtys, total);
                CalculateTotal();

                pname.Clear();
                price.Clear();
                qty.Clear();
            }
            catch 
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pname.Clear();
            price.Clear();
            qty.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cart.Rows.Clear();
        }

        public void CalculateTotal()
        {
            int sum = 0;

            foreach (DataGridViewRow row in cart.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    sum += Convert.ToInt32(row.Cells[5].Value);
                }
            }

            lbltotal.Text = sum.ToString();
        }
        private void printbill_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlTransaction trans = con.BeginTransaction(); // 🔥 IMPORTANT (safe transaction)

            try
            {
                // ✅ Insert into customer
                string query = @"INSERT INTO customer 
                (firstname, lastname, mobile, address) 
                OUTPUT INSERTED.Id
                VALUES (@fname, @lname, @mobile, @address)";

                SqlCommand cmd = new SqlCommand(query, con, trans);

                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@mobile", Convert.ToInt64(txtmobile.Text));
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);

                int billId = (int)cmd.ExecuteScalar();

                // ✅ LOOP CART ITEMS
                foreach (DataGridViewRow row in cart.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells[1].Value);
                    string productName = row.Cells[2].Value.ToString();
                    int price = Convert.ToInt32(row.Cells[3].Value);
                    int qtySold = Convert.ToInt32(row.Cells[4].Value);

                    // 🔥 CHECK STOCK
                    string checkQty = "SELECT qty FROM product WHERE id = @id";
                    SqlCommand checkCmd = new SqlCommand(checkQty, con, trans);
                    checkCmd.Parameters.AddWithValue("@id", productId);

                    int currentQty = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // ❌ If stock not available → STOP EVERYTHING
                    if (currentQty == 0)
                    {
                        MessageBox.Show(productName + " is Out of Stock");
                        trans.Rollback(); // 🔥 undo everything
                        con.Close();
                        return;
                    }

                    if (currentQty < qtySold)
                    {
                        MessageBox.Show("Only " + currentQty + " available for " + productName);
                        trans.Rollback(); // 🔥 undo everything
                        con.Close();
                        return;
                    }

                    // ✅ CALCULATE TOTAL
                    int total = price * qtySold;

                    // ✅ INSERT INTO billitems
                    string insertItem = @"INSERT INTO billitems 
                    (bill_id, productname, qty, price, date, total) 
                    VALUES (@billid, @pname, @qty, @price, @date, @total)";

                    SqlCommand itemCmd = new SqlCommand(insertItem, con, trans);
                    itemCmd.Parameters.AddWithValue("@billid", billId);
                    itemCmd.Parameters.AddWithValue("@pname", productName);
                    itemCmd.Parameters.AddWithValue("@qty", qtySold);
                    itemCmd.Parameters.AddWithValue("@price", price);
                    itemCmd.Parameters.AddWithValue("@date", DateTime.Now);
                    itemCmd.Parameters.AddWithValue("@total", total);

                    itemCmd.ExecuteNonQuery();

                    // ✅ SAFE UPDATE (NO NEGATIVE)
                    string updateQty = @"UPDATE product 
                                SET qty = qty - @qty 
                                WHERE id = @id AND qty >= @qty";

                    SqlCommand updateCmd = new SqlCommand(updateQty, con, trans);
                    updateCmd.Parameters.AddWithValue("@qty", qtySold);
                    updateCmd.Parameters.AddWithValue("@id", productId);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Stock issue for " + productName);
                        trans.Rollback(); // 🔥 undo everything
                        con.Close();
                        return;
                    }
                }

                // ✅ COMMIT (FINAL SAVE)
                trans.Commit();

                MessageBox.Show("Bill Saved Successfully");

                billprint bp = new billprint(billId);
                bp.Show();

                display(); // refresh product table
            }
            catch (Exception ex)
            {
                trans.Rollback(); // 🔥 rollback on error
                MessageBox.Show("Error: " + ex.Message);
            }

            con.Close();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }
    }
}
