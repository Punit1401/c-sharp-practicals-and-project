using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletronic.Admin
{
    
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Register());
        }

        private void txtstafflist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Employees());
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbllinkcategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Category());

        }

        private void brand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Brand());
        }

        private void linkproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Products());
        }

        private void customerlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Customer());
        }

        private void dashboardpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Dashboardpage());
        }
        public void LoadPage(Form f)
        {
            mainpanel.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(f);
            f.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadPage(new Dashboardpage());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkproductlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Productlist());
        }

        private void txtlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }


        private void sidebaroptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
