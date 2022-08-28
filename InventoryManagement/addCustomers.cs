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
    public partial class addCustomers : Form
    {
        public addCustomers()
        {
            InitializeComponent();
        }
        private string conn;
        private MySqlConnection connection;
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

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addAccount_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            db_connection();
            if (fullName.Text == "" || email.Text == "" || customerID.Text == "" || labelPhoneNumber.Text == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                Hide();
            }
            else
            {
                string query = "INSERT INTO `customer`(`customerID`, `fullName`,  `phoneNumber`, `email`) VALUES ('" + customerID.Text + "','" + fullName.Text + "','" + labelPhoneNumber.Text + "','" + email.Text +"')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Customer account created successfully\n " + rows + " user added!!");
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
