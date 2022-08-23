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
    public partial class login : Form
    {
        private string conn;
        private MySqlConnection connection;
        public login()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = userID.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validateLogin(user, pass);
            if (r && role.SelectedItem =="Administrator")
            {
                MessageBox.Show("Login Successfully as administrator");
                AdministratorPage admin = new AdministratorPage();
                Hide();
                admin.Show();
            }
            else if (r &&  role.SelectedItem == "Attendant")
            {
                MessageBox.Show("Login Successfully as attendant");
                AttendantPage attendant = new AttendantPage();
                Hide();
                attendant.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials");
            }
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
        private bool validateLogin(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT `userID`, `password`, `role` FROM `users` WHERE `userID` = @user and `password` = @pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connection;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
