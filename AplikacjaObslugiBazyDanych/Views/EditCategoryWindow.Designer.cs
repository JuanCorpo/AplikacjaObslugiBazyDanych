namespace AplikacjaObslugiBazyDanych.Views
{
    partial class EditCategoryWindow
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.AddCategory = new System.Windows.Forms.Button();
            this.RemoveCategory = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryNam,
            this.ParentCategory});
            this.DataTable.Location = new System.Drawing.Point(12, 12);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.Size = new System.Drawing.Size(637, 537);
            this.DataTable.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(655, 12);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(117, 50);
            this.AddCategory.TabIndex = 1;
            this.AddCategory.Text = "Dodaj kategorie";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // RemoveCategory
            // 
            this.RemoveCategory.Location = new System.Drawing.Point(655, 68);
            this.RemoveCategory.Name = "RemoveCategory";
            this.RemoveCategory.Size = new System.Drawing.Size(117, 50);
            this.RemoveCategory.TabIndex = 2;
            this.RemoveCategory.Text = "Usuń kategorie";
            this.RemoveCategory.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(655, 396);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 50);
            this.Save.TabIndex = 3;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(655, 499);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 50);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Zamknij";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Numer kategorii";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 200;
            // 
            // CategoryNam
            // 
            this.CategoryNam.HeaderText = "Nazwa kategorii";
            this.CategoryNam.Name = "CategoryNam";
            this.CategoryNam.Width = 200;
            // 
            // ParentCategory
            // 
            this.ParentCategory.HeaderText = "Kategoria nadrzędna";
            this.ParentCategory.Name = "ParentCategory";
            this.ParentCategory.Width = 200;
            // 
            // EditCategoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemoveCategory);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.DataTable);
            this.Name = "EditCategoryWindow";
            this.Text = "EditCategoryWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button RemoveCategory;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNam;
        private System.Windows.Forms.DataGridViewComboBoxColumn ParentCategory;
    }
}