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
    public partial class deleteUser : Form
    {
        private string conn;
        private MySqlConnection connection;
        public deleteUser()
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


        private void deleteButton_Click(object sender, EventArgs e)
        {
            db_connection();
            string query = "DELETE FROM `users` WHERE `userID` = '" + userID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAffected + " row deleted from database");
            Hide();
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            
        }
    }
}
