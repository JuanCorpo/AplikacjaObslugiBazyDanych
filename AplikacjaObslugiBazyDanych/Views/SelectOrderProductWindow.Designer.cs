namespace AplikacjaObslugiBazyDanych.Views
{
    partial class SelectOrderProductWindow
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
            this.selectedProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedProduct
            // 
            this.selectedProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedProduct.FormattingEnabled = true;
            this.selectedProduct.Location = new System.Drawing.Point(62, 27);
            this.selectedProduct.Name = "selectedProduct";
            this.selectedProduct.Size = new System.Drawing.Size(160, 21);
            this.selectedProduct.TabIndex = 0;
            this.selectedProduct.SelectedIndexChanged += new System.EventHandler(this.selectedProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produkt";
            // 
            // selectedCount
            // 
            this.selectedCount.Location = new System.Drawing.Point(63, 54);
            this.selectedCount.Name = "selectedCount";
            this.selectedCount.Size = new System.Drawing.Size(159, 20);
            this.selectedCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwa";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(56, 127);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(0, 13);
            this.Name.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(53, 153);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 13);
            this.Price.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cena";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(115, 179);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(0, 13);
            this.Stock.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stan na magazynie";
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(76, 203);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(0, 13);
            this.Employee.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pracownik";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(79, 104);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Id produktu";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(147, 226);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "Zapisz";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 226);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zniżka";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(63, 81);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(159, 20);
            this.Discount.TabIndex = 20;
            // 
            // SelectOrderProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedProduct);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Text = "SelectOrderProductWindow";
            ((System.ComponentModel.ISupportInitialize)(this.selectedCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown selectedCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Discount;
    }
}