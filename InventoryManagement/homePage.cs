﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        public void DrawRectangleInt(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of rectangle.
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 200;

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            createAccount account = new createAccount();
            Hide();
            account.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            login newLogin = new login();
            Hide();
            newLogin.Show();
        }
    }
}
