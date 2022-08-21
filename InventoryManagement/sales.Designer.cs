
namespace InventoryManagement
{
    partial class sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.buttonUpdateUsers = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonNewSales = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.salesTable = new System.Windows.Forms.DataGridView();
            this.salesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 90);
            this.panel1.TabIndex = 3;
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.shopName.Location = new System.Drawing.Point(174, 27);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(696, 32);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Shoprite Ghana Inventory Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menu);
            this.panel2.Controls.Add(this.buttonUpdateUsers);
            this.panel2.Controls.Add(this.receipt);
            this.panel2.Controls.Add(this.buttonDeleteUser);
            this.panel2.Controls.Add(this.buttonNewSales);
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 485);
            this.panel2.TabIndex = 4;
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
            this.buttonUpdateUsers.Location = new System.Drawing.Point(33, 182);
            this.buttonUpdateUsers.Name = "buttonUpdateUsers";
            this.buttonUpdateUsers.Size = new System.Drawing.Size(149, 45);
            this.buttonUpdateUsers.TabIndex = 6;
            this.buttonUpdateUsers.Text = "Update Sales table";
            this.buttonUpdateUsers.UseVisualStyleBackColor = false;
            this.buttonUpdateUsers.Click += new System.EventHandler(this.buttonUpdateUsers_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.Black;
            this.receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.ForeColor = System.Drawing.Color.White;
            this.receipt.Location = new System.Drawing.Point(33, 246);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(149, 53);
            this.receipt.TabIndex = 5;
            this.receipt.Text = "Generate Sales Receipt";
            this.receipt.UseVisualStyleBackColor = false;
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(33, 120);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(149, 45);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Delete sale";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            // 
            // buttonNewSales
            // 
            this.buttonNewSales.BackColor = System.Drawing.Color.Black;
            this.buttonNewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSales.ForeColor = System.Drawing.Color.White;
            this.buttonNewSales.Location = new System.Drawing.Point(33, 53);
            this.buttonNewSales.Name = "buttonNewSales";
            this.buttonNewSales.Size = new System.Drawing.Size(149, 41);
            this.buttonNewSales.TabIndex = 5;
            this.buttonNewSales.Text = "New Sale";
            this.buttonNewSales.UseVisualStyleBackColor = false;
            this.buttonNewSales.Click += new System.EventHandler(this.buttonNewSales_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.labelUser.Location = new System.Drawing.Point(295, 120);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(425, 32);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Sales(transaction) for Today";
            // 
            // salesTable
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.salesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesID,
            this.userID,
            this.customerID,
            this.date,
            this.quantity,
            this.Total});
            this.salesTable.Location = new System.Drawing.Point(217, 179);
            this.salesTable.Name = "salesTable";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.salesTable.Size = new System.Drawing.Size(790, 485);
            this.salesTable.TabIndex = 6;
            // 
            // salesID
            // 
            this.salesID.DataPropertyName = "salesID";
            this.salesID.HeaderText = "Sales ID";
            this.salesID.Name = "salesID";
            this.salesID.Width = 110;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "User ID";
            this.userID.Name = "userID";
            this.userID.Width = 125;
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.Width = 120;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 160;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quatity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 110;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 120;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.salesTable);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sales";
            this.Text = "sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button buttonUpdateUsers;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonNewSales;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView salesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}