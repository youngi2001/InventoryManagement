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
    public partial class customers : Form
    {
        private string conn;
        private MySqlConnection connection;
        public customers()
        {
            InitializeComponent();
            getCustomers();
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

        private void menu_Click(object sender, EventArgs e)
        {
            if(Security.sessionRole == "Administrator")
            {
                Hide();
                AdministratorPage back = new AdministratorPage();
                back.Show();
            }
            else
            {
                Hide();
                AttendantPage back = new AttendantPage();
                back.Show();
            }
        }

        private void receipt_Click(object sender, EventArgs e)
        {

        }

        private void updateList_Click(object sender, EventArgs e)
        {
            getCustomers();
        }
        private void getCustomers()
        {
            db_connection();
            string query = "SELECT * FROM `customer`";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //fill the table 2
            customerTable.DataSource = dataTable;
        }

        private void customerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomer delUser = new deleteCustomer();
            delUser.Show();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            addCustomers newCustomer = new addCustomers();
            newCustomer.Show();

        }
    }
    
}
