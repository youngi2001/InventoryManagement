using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagement
{
    public partial class updateCustomerDetails : Form
    {
        private string conn;
        private MySqlConnection connection;
        public updateCustomerDetails()
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateCustomer();
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void updateCustomer()
        {
            db_connection();
            string query = "UPDATE `customer` SET `fullName`='" + fullName.Text + "', `phoneNumber`='" + phoneNumber.Text + "' , `email`='" + email.Text + "'  WHERE `customerID` = '" + customerID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAffected + " row updated from database");

        }

    }
}
