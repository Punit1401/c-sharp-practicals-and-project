using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void btnproduct1_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Product: Laptop\nPrice: ₹50,000\nBrand: Dell";
        }

        private void btnproduct2_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Product: Mobile\nPrice: ₹20,000\nBrand: Samsung";
        }

        private void btnproduct3_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Product: Headphones\nPrice: ₹2,000\nBrand: Sony";
        }
    }
}
