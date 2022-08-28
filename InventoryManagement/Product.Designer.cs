
namespace InventoryManagement
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.buttonUpdateUsers = new System.Windows.Forms.Button();
            this.newProduct = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChangeProductDetials = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 90);
            this.panel1.TabIndex = 5;
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
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.labelProduct.Location = new System.Drawing.Point(357, 121);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(269, 32);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Products in Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonChangeProductDetials);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Controls.Add(this.buttonUpdateUsers);
            this.panel2.Controls.Add(this.newProduct);
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 485);
            this.panel2.TabIndex = 7;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(33, 387);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(149, 45);
            this.menu.TabIndex = 7;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // buttonUpdateUsers
            // 
            this.buttonUpdateUsers.BackColor = System.Drawing.Color.Black;
            this.buttonUpdateUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateUsers.Location = new System.Drawing.Point(33, 127);
            this.buttonUpdateUsers.Name = "buttonUpdateUsers";
            this.buttonUpdateUsers.Size = new System.Drawing.Size(149, 45);
            this.buttonUpdateUsers.TabIndex = 6;
            this.buttonUpdateUsers.Text = "Update Prduct";
            this.buttonUpdateUsers.UseVisualStyleBackColor = false;
            this.buttonUpdateUsers.Click += new System.EventHandler(this.buttonUpdateUsers_Click);
            // 
            // newProduct
            // 
            this.newProduct.BackColor = System.Drawing.Color.Black;
            this.newProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProduct.ForeColor = System.Drawing.Color.White;
            this.newProduct.Location = new System.Drawing.Point(33, 53);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(149, 41);
            this.newProduct.TabIndex = 5;
            this.newProduct.Text = "New Product";
            this.newProduct.UseVisualStyleBackColor = false;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // productTable
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.name,
            this.Supplier,
            this.price,
            this.quantity,
            this.subTotal});
            this.productTable.Location = new System.Drawing.Point(217, 179);
            this.productTable.Name = "productTable";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.productTable.Size = new System.Drawing.Size(790, 485);
            this.productTable.TabIndex = 8;
            this.productTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellContentClick);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.Width = 90;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 175;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.Width = 120;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subtotal";
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.Width = 160;
            // 
            // buttonChangeProductDetials
            // 
            this.buttonChangeProductDetials.BackColor = System.Drawing.Color.Black;
            this.buttonChangeProductDetials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeProductDetials.ForeColor = System.Drawing.Color.White;
            this.buttonChangeProductDetials.Location = new System.Drawing.Point(33, 197);
            this.buttonChangeProductDetials.Name = "buttonChangeProductDetials";
            this.buttonChangeProductDetials.Size = new System.Drawing.Size(149, 53);
            this.buttonChangeProductDetials.TabIndex = 8;
            this.buttonChangeProductDetials.Text = "Update Product Detials";
            this.buttonChangeProductDetials.UseVisualStyleBackColor = false;
            this.buttonChangeProductDetials.Click += new System.EventHandler(this.buttonChangeProductDetials_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button buttonUpdateUsers;
        private System.Windows.Forms.Button newProduct;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Button buttonChangeProductDetials;
    }
}