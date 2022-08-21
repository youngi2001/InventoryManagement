
namespace InventoryManagement
{
    partial class customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateList = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.updateCustomerDetials = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.label1.Location = new System.Drawing.Point(402, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers";
            // 
            // customerTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.fullName,
            this.phoneNumber,
            this.email});
            this.customerTable.Location = new System.Drawing.Point(217, 179);
            this.customerTable.Name = "customerTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customerTable.Size = new System.Drawing.Size(790, 485);
            this.customerTable.TabIndex = 7;
            this.customerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellContentClick);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.Width = 190;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.Width = 250;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.updateList);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Controls.Add(this.updateCustomerDetials);
            this.panel2.Controls.Add(this.deleteCustomer);
            this.panel2.Controls.Add(this.addCustomer);
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 485);
            this.panel2.TabIndex = 8;
            // 
            // updateList
            // 
            this.updateList.BackColor = System.Drawing.Color.Black;
            this.updateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateList.ForeColor = System.Drawing.Color.White;
            this.updateList.Location = new System.Drawing.Point(33, 268);
            this.updateList.Name = "updateList";
            this.updateList.Size = new System.Drawing.Size(149, 53);
            this.updateList.TabIndex = 8;
            this.updateList.Text = "Update List";
            this.updateList.UseVisualStyleBackColor = false;
            this.updateList.Click += new System.EventHandler(this.updateList_Click);
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
            // updateCustomerDetials
            // 
            this.updateCustomerDetials.BackColor = System.Drawing.Color.Black;
            this.updateCustomerDetials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerDetials.ForeColor = System.Drawing.Color.White;
            this.updateCustomerDetials.Location = new System.Drawing.Point(33, 182);
            this.updateCustomerDetials.Name = "updateCustomerDetials";
            this.updateCustomerDetials.Size = new System.Drawing.Size(149, 63);
            this.updateCustomerDetials.TabIndex = 6;
            this.updateCustomerDetials.Text = "Update Customer Details";
            this.updateCustomerDetials.UseVisualStyleBackColor = false;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.BackColor = System.Drawing.Color.Black;
            this.deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.deleteCustomer.Location = new System.Drawing.Point(33, 120);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(149, 45);
            this.deleteCustomer.TabIndex = 5;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.Black;
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.ForeColor = System.Drawing.Color.White;
            this.addCustomer.Location = new System.Drawing.Point(33, 53);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(149, 41);
            this.addCustomer.TabIndex = 5;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customerTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button updateCustomerDetials;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button updateList;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}