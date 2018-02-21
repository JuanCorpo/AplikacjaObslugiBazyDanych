namespace AplikacjaObslugiBazyDanych.Views
{
    partial class AddProductWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.ProductEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AddParameterButton = new System.Windows.Forms.Button();
            this.ProductParametersTable = new System.Windows.Forms.DataGridView();
            this.LP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteParameterButton = new System.Windows.Forms.Button();
            this.ProductStockStatus = new System.Windows.Forms.NumericUpDown();
            this.ProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductParametersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoria produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena produktu";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(12, 39);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(156, 20);
            this.ProductName.TabIndex = 7;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(12, 65);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(156, 20);
            this.ProductPrice.TabIndex = 8;
            // 
            // ProductCategory
            // 
            this.ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Location = new System.Drawing.Point(12, 12);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(156, 21);
            this.ProductCategory.TabIndex = 10;
            // 
            // ProductEmployee
            // 
            this.ProductEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductEmployee.FormattingEnabled = true;
            this.ProductEmployee.Location = new System.Drawing.Point(12, 117);
            this.ProductEmployee.Name = "ProductEmployee";
            this.ProductEmployee.Size = new System.Drawing.Size(157, 21);
            this.ProductEmployee.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stan magazynowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Opiekun produktu";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(78, 403);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 15;
            this.AddProductButton.Text = "Ok";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Location = new System.Drawing.Point(247, 403);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseWindowButton.TabIndex = 16;
            this.CloseWindowButton.Text = "Anuluj";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lista dodanych parametrów";
            // 
            // AddParameterButton
            // 
            this.AddParameterButton.Location = new System.Drawing.Point(373, 160);
            this.AddParameterButton.Name = "AddParameterButton";
            this.AddParameterButton.Size = new System.Drawing.Size(111, 23);
            this.AddParameterButton.TabIndex = 21;
            this.AddParameterButton.Text = "Dodaj nowe pole";
            this.AddParameterButton.UseVisualStyleBackColor = true;
            this.AddParameterButton.Click += new System.EventHandler(this.AddParameterButton_Click);
            // 
            // ProductParametersTable
            // 
            this.ProductParametersTable.AllowUserToAddRows = false;
            this.ProductParametersTable.AllowUserToDeleteRows = false;
            this.ProductParametersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductParametersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LP,
            this.ParameterType,
            this.ParameterValue,
            this.ParameterId});
            this.ProductParametersTable.Location = new System.Drawing.Point(12, 144);
            this.ProductParametersTable.Name = "ProductParametersTable";
            this.ProductParametersTable.RowHeadersVisible = false;
            this.ProductParametersTable.Size = new System.Drawing.Size(355, 253);
            this.ProductParametersTable.TabIndex = 22;
            // 
            // LP
            // 
            this.LP.HeaderText = "LP";
            this.LP.Name = "LP";
            this.LP.ReadOnly = true;
            this.LP.Width = 50;
            // 
            // ParameterType
            // 
            this.ParameterType.HeaderText = "Typ parametru";
            this.ParameterType.Name = "ParameterType";
            this.ParameterType.Width = 150;
            // 
            // ParameterValue
            // 
            this.ParameterValue.HeaderText = "Wartość";
            this.ParameterValue.Name = "ParameterValue";
            this.ParameterValue.Width = 150;
            // 
            // ParameterId
            // 
            this.ParameterId.HeaderText = "ParameterId";
            this.ParameterId.Name = "ParameterId";
            this.ParameterId.ReadOnly = true;
            this.ParameterId.Visible = false;
            // 
            // DeleteParameterButton
            // 
            this.DeleteParameterButton.Location = new System.Drawing.Point(373, 189);
            this.DeleteParameterButton.Name = "DeleteParameterButton";
            this.DeleteParameterButton.Size = new System.Drawing.Size(111, 23);
            this.DeleteParameterButton.TabIndex = 23;
            this.DeleteParameterButton.Text = "Usuń parametr";
            this.DeleteParameterButton.UseVisualStyleBackColor = true;
            this.DeleteParameterButton.Click += new System.EventHandler(this.DeleteParameterButton_Click);
            // 
            // ProductStockStatus
            // 
            this.ProductStockStatus.Location = new System.Drawing.Point(13, 92);
            this.ProductStockStatus.Name = "ProductStockStatus";
            this.ProductStockStatus.Size = new System.Drawing.Size(155, 20);
            this.ProductStockStatus.TabIndex = 26;
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(423, 20);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(0, 13);
            this.ProductId.TabIndex = 27;
            this.ProductId.Visible = false;
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 465);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.ProductStockStatus);
            this.Controls.Add(this.DeleteParameterButton);
            this.Controls.Add(this.ProductParametersTable);
            this.Controls.Add(this.AddParameterButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductEmployee);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 503);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 503);
            this.Name = "AddProductWindow";
            this.Text = "AddProductWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ProductParametersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.ComboBox ProductCategory;
        private System.Windows.Forms.ComboBox ProductEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddParameterButton;
        private System.Windows.Forms.DataGridView ProductParametersTable;
        private System.Windows.Forms.Button DeleteParameterButton;
        private System.Windows.Forms.NumericUpDown ProductStockStatus;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LP;
        private System.Windows.Forms.DataGridViewComboBoxColumn ParameterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterId;
    }
}