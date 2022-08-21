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
    public partial class Product : Form
    {
        private string conn;
        private MySqlConnection connection;
        public Product()
        {
            InitializeComponent();
            getProduct();
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

        private void newProduct_Click(object sender, EventArgs e)
        {
            addProduct addP = new addProduct();
            addP.Show();
        }

        private void buttonUpdateUsers_Click(object sender, EventArgs e)
        {
            getProduct();
        }
        private void getProduct()
        {
            db_connection();
            string query = "SELECT * FROM `product`";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            //fill the table 2
            productTable.DataSource = dataTable;
        }

        private void productTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
