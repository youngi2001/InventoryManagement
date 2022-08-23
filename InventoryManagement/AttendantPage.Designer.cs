
namespace InventoryManagement
{
    partial class AttendantPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.PictureBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.PictureBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.PictureBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.PictureBox();
            this.users = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 90);
            this.panel1.TabIndex = 4;
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.shopName.Location = new System.Drawing.Point(182, 26);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(696, 32);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Shoprite Ghana Inventory Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(425, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendant";
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.White;
            this.product.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product.BackgroundImage")));
            this.product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product.Location = new System.Drawing.Point(87, 186);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 117);
            this.product.TabIndex = 8;
            this.product.TabStop = false;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(92, 150);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(115, 33);
            this.labelProduct.TabIndex = 9;
            this.labelProduct.Text = "Product";
            // 
            // orders
            // 
            this.orders.BackColor = System.Drawing.Color.White;
            this.orders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orders.BackgroundImage")));
            this.orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orders.Location = new System.Drawing.Point(817, 532);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(119, 114);
            this.orders.TabIndex = 18;
            this.orders.TabStop = false;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(814, 496);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(105, 33);
            this.labelOrder.TabIndex = 17;
            this.labelOrder.Text = "Orders";
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.White;
            this.customers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customers.BackgroundImage")));
            this.customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customers.Location = new System.Drawing.Point(466, 353);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(119, 117);
            this.customers.TabIndex = 16;
            this.customers.TabStop = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(451, 317);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(157, 33);
            this.labelCategories.TabIndex = 15;
            this.labelCategories.Text = "Customers";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(831, 150);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(88, 33);
            this.labelSales.TabIndex = 14;
            this.labelSales.Text = "Sales";
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.White;
            this.sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sales.BackgroundImage")));
            this.sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales.Location = new System.Drawing.Point(817, 186);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(120, 117);
            this.sales.TabIndex = 13;
            this.sales.TabStop = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // users
            // 
            this.users.BackColor = System.Drawing.Color.White;
            this.users.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("users.BackgroundImage")));
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.Location = new System.Drawing.Point(98, 532);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(120, 112);
            this.users.TabIndex = 20;
            this.users.TabStop = false;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(103, 494);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(92, 33);
            this.labelUser.TabIndex = 19;
            this.labelUser.Text = "Users";
            // 
            // AttendantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.users);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AttendantPage";
            this.Text = "Attendant";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox product;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.PictureBox orders;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.PictureBox customers;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.PictureBox sales;
        private System.Windows.Forms.PictureBox users;
        private System.Windows.Forms.Label labelUser;
    }
}