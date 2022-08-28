
namespace InventoryManagement
{
    partial class addOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.insertOrder = new System.Windows.Forms.Button();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 90);
            this.panel1.TabIndex = 5;
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(151)))));
            this.shopName.Location = new System.Drawing.Point(56, 30);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(483, 23);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Shoprite Ghana Inventory Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "NEW ORDER";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.Location = new System.Drawing.Point(56, 201);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(99, 20);
            this.labelFirstname.TabIndex = 28;
            this.labelFirstname.Text = "Customer ID";
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(60, 224);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(210, 26);
            this.customerID.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Product ID";
            // 
            // productID
            // 
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(305, 224);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(228, 26);
            this.productID.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(60, 340);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(228, 26);
            this.quantity.TabIndex = 36;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(305, 467);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 34);
            this.cancel.TabIndex = 40;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // insertOrder
            // 
            this.insertOrder.BackColor = System.Drawing.Color.Black;
            this.insertOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertOrder.ForeColor = System.Drawing.Color.White;
            this.insertOrder.Location = new System.Drawing.Point(423, 467);
            this.insertOrder.Name = "insertOrder";
            this.insertOrder.Size = new System.Drawing.Size(110, 34);
            this.insertOrder.TabIndex = 39;
            this.insertOrder.Text = "ADD";
            this.insertOrder.UseVisualStyleBackColor = false;
            this.insertOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(305, 340);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(228, 26);
            this.totalAmount.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total Amount ($)";
            // 
            // addOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(600, 565);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.insertOrder);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "addOrder";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button insertOrder;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label label4;
    }
}