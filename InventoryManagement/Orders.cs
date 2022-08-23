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
    public partial class Orders : Form
    {
        private string conn;
        private MySqlConnection connection;
        public Orders()
        {
            InitializeComponent();
            updateTable();
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
            if (Security.sessionRole == "Administrator")
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

        

        
        public void updateTable()
        {
            db_connection();
            string query = "SELECT * FROM `orders`";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //fill the table 2
            orderTable.DataSource = dataTable;

        }

        private void updateOrder_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            addOrder newO = new addOrder();
            newO.Show();

        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            deleteOrder delOder = new deleteOrder();
            delOder.Show();
        }

        private void orderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
