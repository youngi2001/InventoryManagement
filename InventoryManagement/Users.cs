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
    public partial class Users : Form
    {
        private string conn;
        private MySqlConnection connection;
        public Users()
        {
            InitializeComponent();
            getUsers();
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

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        public void getUsers()
        {
            db_connection();
            string query = "SELECT * FROM `users`";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //fill the table 2
            userTable.DataSource = dataTable;
        }

        private void buttonUpdateUsers_Click(object sender, EventArgs e)
        {
            getUsers();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            addUser newUser = new addUser();
            newUser.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser delUser = new deleteUser();
            delUser.Show();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            changePassword newPass = new changePassword();
            newPass.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Hide();
            AdministratorPage back = new AdministratorPage();
            back.Show();
        }
    }
}
