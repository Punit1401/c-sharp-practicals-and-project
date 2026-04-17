using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletronic
{
    public partial class Dashboard : Form
    {
        Dashboardpage dp = new Dashboardpage();
        Products p = new Products();
        Customer c = new Customer();
        Bill b = new Bill();
        public Dashboard()
        {
            InitializeComponent();
        }

      
        private void LoadPage(Form f)
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


        private void dashboardpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Dashboardpage());
        }

     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Customer());
        }

        private void customerlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Bill());
        }

        private void productlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPage(new Products());
        }

        private void txtlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
