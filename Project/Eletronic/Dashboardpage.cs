using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Eletronic
{
    public partial class Dashboardpage : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Dashboardpage()
        {
            InitializeComponent();
        }

        private void Dashboardpage_Load(object sender, EventArgs e)
        {
            Loaddata();
            LoadChart();
        }
        public void Loaddata()
        {
            Tv();
            Ac();
            Fridge();
            WashingMachine();
            todayssales();
        }

        public void Tv()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(SUM(qty),0) FROM product where category_id= 1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lbltv.Text = total.ToString();
            con.Close();
        }
        public void Ac()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(SUM(qty),0) FROM product where category_id= 2 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblac.Text = total.ToString();
            con.Close();
        }
        public void Fridge()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(SUM(qty),0) FROM product where category_id= 3 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblfr.Text = total.ToString(); // display total
            con.Close();
        }
        public void WashingMachine()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(SUM(qty),0) FROM product where category_id= 4 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblwm.Text = total.ToString();
            con.Close();
        }
        
        public void todayssales()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(COUNT(*),0) FROM billitems WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE) ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lbltts.Text = total.ToString();
            con.Close();
        }
        private void lblnotice_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblnotice_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
        public void LoadChart()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);

                con.Open();

                // IMPORTANT: using "id" not product_id
                string query = "SELECT product_name, qty FROM Product";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart1.Series.Clear();

                Series series = new Series("Products");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                chart1.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    string name = row["product_name"].ToString();
                    int qty = Convert.ToInt32(row["qty"]);

                    chart1.Series["Products"].Points.AddXY(name, qty);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
