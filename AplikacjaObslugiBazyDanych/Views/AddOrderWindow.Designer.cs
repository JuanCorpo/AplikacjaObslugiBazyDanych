namespace AplikacjaObslugiBazyDanych.Views
{
    partial class AddOrderWindow
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
            this.Customers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProduct = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customers.FormattingEnabled = true;
            this.Customers.Location = new System.Drawing.Point(51, 12);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(187, 21);
            this.Customers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klient";
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ProductName,
            this.NumberOf,
            this.Price,
            this.Discount,
            this.TotalPrice,
            this.PID});
            this.DataTable.Location = new System.Drawing.Point(12, 81);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.Size = new System.Drawing.Size(560, 468);
            this.DataTable.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.HeaderText = "Lp";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Produkt";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // NumberOf
            // 
            this.NumberOf.HeaderText = "Ilość";
            this.NumberOf.Name = "NumberOf";
            this.NumberOf.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cena jednostkowa";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Rabat";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Cena całkowita";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Visible = false;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(12, 52);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(104, 23);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Dodaj produkt";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(122, 52);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(116, 23);
            this.RemoveSelected.TabIndex = 4;
            this.RemoveSelected.Text = "Usuń zaznaczony";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(446, 52);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(126, 23);
            this.Order.TabIndex = 5;
            this.Order.Text = "Zapisz zamówiene";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(244, 52);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 23);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edytuj zaznaczony";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(287, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(161, 21);
            this.Status.TabIndex = 8;
            // 
            // AddOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddOrderWindow";
            this.Text = "AddOrderWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
    }
}