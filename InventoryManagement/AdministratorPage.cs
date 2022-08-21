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
    public partial class AdministratorPage : Form
    {
        public AdministratorPage()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Users viewUsers = new Users();
            Hide();
            viewUsers.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            Hide();
            newProduct.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Orders newOrders = new Orders();
            Hide();
            newOrders.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sales newSale = new sales();
            Hide();
            newSale.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            customers customerList = new customers();
            Hide();
            customerList.Show();
        }
    }
}
