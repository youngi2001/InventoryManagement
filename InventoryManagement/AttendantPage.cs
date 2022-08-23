using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AttendantPage : Form
    {
        public AttendantPage()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Access Denied Admistrators Only", "Warning");
        }

        private void product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Access Denied Admistrators Only", "Warning");

        }

        private void customers_Click(object sender, EventArgs e)
        {
            customers customerList = new customers();
            Hide();
            customerList.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            sales newSale = new sales();
            Hide();
            newSale.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Orders newOrders = new Orders();
            Hide();
            newOrders.Show();
        }
    }
}
