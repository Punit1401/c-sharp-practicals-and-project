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
    public partial class delbrand : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["Mydbconnection"].ConnectionString;
        public delbrand()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "delete from brand where id='"+txtbrandid.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Brand Deleted Successfully");
            Dashboard dash = (Dashboard)this.ParentForm;
            Brand b = new Brand();
            dash.LoadPage(b);
            b.Show();
            b.display();
            this.Close();
            con.Close();
           
        }

        private void delbrand_Load(object sender, EventArgs e)
        {

        }

       
        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.ParentForm;
            dash.LoadPage(new Brand());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbrandid_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbrandid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // block input
            }
        }
    }
}
