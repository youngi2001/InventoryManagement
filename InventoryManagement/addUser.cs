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
    public partial class addUser : Form
    {
        private string conn;
        private MySqlConnection connection;
        public addUser()
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
            db_connection();
            if (userId.Text == "" || firstName.Text == "" || password.Text == "" || surName.Text == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                Hide();
            }
            else{
                string query = "INSERT INTO `users`(`userID`, `firstName`, `surName`, `password`, `role`) VALUES ('" + userId.Text + "','" + firstName.Text + "','" + surName.Text + "','" + password.Text + "','" + role.SelectedItem.ToString() + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Account created successfully\n " + rows + " user added!!");
                Hide();
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
    }
}
