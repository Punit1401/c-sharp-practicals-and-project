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
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace Eletronic.Admin
{
    public partial class Dashboardpage : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;

        public Dashboardpage()
        {
            InitializeComponent();
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbltv_Click(object sender, EventArgs e)
        {

        }

        public void Loaddata()
        {
            Tv();
            Ac();
            Fridge();
            WashingMachine();
            totalinventory();
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
            SqlCommand cmd= new SqlCommand(sql, con);
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
        public void totalinventory()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string sql = "SELECT ISNULL(SUM(qty),0) FROM product ";
            SqlCommand cmd = new SqlCommand(sql, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblti.Text = total.ToString();
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
        private void Dashboardpage_Load(object sender, EventArgs e)
        {
            Loaddata();
            LoadChart();
            LoadMonthlyTarget();
        }



        private void saleschart_Click(object sender, EventArgs e)
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

                saleschart.Series.Clear();

                Series series = new Series("Products");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                saleschart.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    string name = row["product_name"].ToString();
                    int qty = Convert.ToInt32(row["qty"]);

                    saleschart.Series["Products"].Points.AddXY(name, qty);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadMonthlyTarget()
        {
            SqlConnection con = new SqlConnection(conn);

            con.Open();

            // ACTUAL VALUE
            string sql = "SELECT SUM(qty) FROM Product";
            SqlCommand cmd = new SqlCommand(sql, con);

            object result = cmd.ExecuteScalar();
            int actual = result != DBNull.Value ? Convert.ToInt32(result) : 0;

            con.Close();

            // TARGET VALUE
            int target = 500;

            // CLEAR CHART
            chart1.Series.Clear();

            // CREATE SERIES
            Series series = new Series("Monthly Performance");
            series.ChartType = SeriesChartType.Column;

            chart1.Series.Add(series);

            // ADD DATA
            series.Points.AddXY("Actual", actual);
            series.Points.AddXY("Target", target);
            con.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
