using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace Eletronic
{
    public partial class billprint : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        int billId; // receive bill_id from previous form

        public billprint(int id)
        {
            InitializeComponent();
            billId = id;
        }

        private void billprint_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadItems();
        }

        // ✅ Load Customer Data
        public void LoadCustomer()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string query = @"SELECT c.firstname, c.lastname, c.mobile, c.address,
               ISNULL(SUM(b.total), 0) as total
               FROM customer c
               LEFT JOIN billitems b ON c.Id = b.bill_id
               WHERE c.Id = @id
               GROUP BY c.firstname, c.lastname, c.mobile, c.address";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", billId);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblName.Text = dr["firstname"].ToString() + " " + dr["lastname"].ToString();
                lblMobile.Text = dr["mobile"].ToString();
                lblAddress.Text = dr["address"].ToString();
                lbltotal.Text = "Total: ₹ " + dr["total"].ToString();
                lblbillno.Text = billId.ToString();

            }

            con.Close();
        }

        // ✅ Load Bill Items
        public void LoadItems()
        {
            SqlConnection con = new SqlConnection(conn);

            string query = "SELECT productname, price, qty, total FROM billitems WHERE bill_id=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", billId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            Tabledesign.tabledesign(guna2DataGridView1);
            con.Close();

            guna2DataGridView1.DataSource = dt;
        }

        // ✅ PRINT FUNCTION

        public string GenerateHTML()
        {
            string html = @"
<html>
<head>
<style>
    body {
        font-family: Arial;
        padding: 20px;
    }

    .container {
        border: 2px solid #000;
        padding: 15px;
    }

    .header {
       
        border-bottom: 2px solid black;
        padding-bottom: 10px;
    }

    .header h1 {
        text-align: center;
        margin: 0;
        color: #014f8d;
        font-size: 23px;
    }
     .contact {
        margin: 0;
        color: #014f8d;
        font-size: 16px;
    }


    .header h3 {
 text-align: center;
        margin: 5px 0;
        font-weight: normal;
    }

    .info {
        margin-top: 10px;
        font-size: 14px;
    }

    .info div {
        margin: 4px 0;
    }

    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 15px;
        table-layout: fixed;
    }

    th, td {
        border: 1px solid black;
        padding: 8px;
        text-align: center;
        word-wrap: break-word;
    }

    th {
        background-color: #01468D;
        color: white;
    }

    /* column width */
    th:nth-child(1), td:nth-child(1) { width: 40px; }
    th:nth-child(2), td:nth-child(2) { width: 220px; }
    th:nth-child(3), td:nth-child(3) { width: 80px; }
    th:nth-child(4), td:nth-child(4) { width: 60px; }
    th:nth-child(5), td:nth-child(5) { width: 100px; }

    .total-box {
        margin-top: 10px;
        text-align: right;
        font-size: 16px;
        font-weight: bold;
    }

    .footer {
        margin-top: 20px;
        font-size: 12px;
    }

    .sign {
        margin-top: 30px;
        text-align: right;
    }

</style>
</head>

<body>

<div class='container'>

    <div class='header'>
        <h1>Tech Hevan</h1>
        <h3>The Electronic Hub</h3>
        <h6 class='contact'>Contact No.:9834567765</h5>
    </div>
    <div class='info'>
        <div><b>Customer Details</b></div>
        <div><b>Bill No:</b> " + lblbillno.Text + @"</div>
        <div><b>Name:</b> " + lblName.Text + @" <b>Mobile:</b> " + lblMobile.Text + @"</div>
        <div><b>Address:</b> " + lblAddress.Text + @"</div>
        <div><b>Date:</b> " + DateTime.Now.ToString("dd-MM-yyyy") + @"</div>
    </div>

    <table>
        <tr>
            <th>Sr</th>
            <th>Product Name</th>
            <th>Price</th>
            <th>Qty</th>
            <th>Amount</th>
        </tr>";

            int sr = 1;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                html += "<tr>";
                html += "<td>" + sr++ + "</td>";
                html += "<td>" + row.Cells["productname"].Value + "</td>";
                html += "<td>" + row.Cells["price"].Value + "</td>";
                html += "<td>" + row.Cells["qty"].Value + "</td>";
                html += "<td>" + row.Cells["total"].Value + "</td>";
                html += "</tr>";
            }

            html += @"
    </table>

    <div class='total-box'>
        " + lbltotal.Text + @"
    </div>

    <div class='footer'>
        <p>* Thank you for shopping with Tech Hevan</p>
        <p>* Goods once sold will not be taken back</p>
    </div>

    <div class='sign'>
        Authorised Signature
    </div>

</div>

</body>
</html>";

            return html;
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            string html = GenerateHTML();

            WebBrowser wb = new WebBrowser();
            wb.DocumentText = html;

            wb.DocumentCompleted += (s, ev) =>
            {
                wb.Print(); // print the bill
                this.Close();
            };
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}