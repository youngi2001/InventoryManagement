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
    public partial class addSale : Form
    {
        private string conn;
        private MySqlConnection connection;
        public addSale()
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

        private void addAccount_Click(object sender, EventArgs e)
        {
            newSale();
            updateTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void newSale()
        {
            db_connection();
            if (customerID.Text == "" || userID.Text == "" || quantity.Text == "" || totalAmount.Text == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                Hide();
            }
            else
            {
                string query = "INSERT INTO `sales` (`userID`,`customerID`,  `quantity`, `total`) VALUES ('" + userID.Text + "', '" + customerID.Text + "','" + quantity.Text + "','" + totalAmount.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Customer account created successfully\n " + rows + " user added!!");
                Hide();
            }
        }
        private void updateTable()
        {
            sales table = new sales();
            table.updateTable();
        }
    }
    
}
