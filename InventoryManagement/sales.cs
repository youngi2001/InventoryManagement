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
    public partial class sales : Form
    {
        private string conn;
        private MySqlConnection connection;
        public sales()
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
            Hide();
            AdministratorPage back = new AdministratorPage();
            back.Show();
        }

        private void buttonNewSales_Click(object sender, EventArgs e)
        {
            addSale newSales = new addSale();
            newSales.Show();
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            
                
            
        }
        public void updateTable()
        {
            db_connection();
            string query = "SELECT * FROM `sales`";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //fill the table 2
            salesTable.DataSource = dataTable;

        }

        private void buttonUpdateUsers_Click(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}
