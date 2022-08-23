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
    public partial class changePassword : Form
    {
        private string conn;
        private MySqlConnection connection;
        public changePassword()
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
            changePassword2();
            Hide();
        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePassword2()
        {
            db_connection();
            string query = "UPDATE `users` SET `firstName`='"+firstName.Text+ "' ,`surName`='"+surName.Text+ "', `password`='" + password.Text + "' , `role`='"+role.SelectedItem+"' WHERE `userID` = '" + userID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAffected + " row updated from database");

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
    }
}
