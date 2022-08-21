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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorPage back = new AdministratorPage();
            back.Show();
        }

        private void buttonNewSales_Click(object sender, EventArgs e)
        {
            addSale newSales = new addSale();
            newSales.Show();
        }
    }
}
