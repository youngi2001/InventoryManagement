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
    public partial class deleteOrder : Form
    {
        private string conn;
        private MySqlConnection connection;
        public deleteOrder()
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            db_connection();
            string query = "DELETE FROM `orders` WHERE `userID` = '" + orderID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAffected + " row deleted from database");
            Hide();
        }
    }
}
