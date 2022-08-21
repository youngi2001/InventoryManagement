using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InventoryManagement
{
    public partial class addProduct : Form
    {
        private string conn;
        private MySqlConnection connection;
        public addProduct()
        {
            InitializeComponent();
        }
        private void db_connection()
        {
            try
            {
                conn = "server=localhost;uid=root;" + "pwd=;database=shoprite";
                connection = new MySqlConnection(conn);
                connection.Open();

            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        

        private void addProductButton_Click(object sender, EventArgs e)
        {
            db_connection();
            if (productID.Text == "" || name.Text == "" || supplier.Text == "" || price.Text == "" || quantity.Text == "" || subTotal.Text == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                Hide();
            }
            else
            {
                string query = "INSERT INTO `product`(`productID`, `name`, `supplier`, `price`, `quantity`, `subTotal`) VALUES ('" + productID.Text + "','" + name.Text + "','" + supplier.Text + "','" + price.Text + "','" + quantity.Text + "' ,'" + subTotal.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Account created successfully\n " + rows + " Products added successfully!!");
                Hide();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
