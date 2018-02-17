namespace AplikacjaObslugiBazyDanych.Views
{
    partial class EditParametersWindow
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParameterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.RemoveSelectedRow = new System.Windows.Forms.Button();
            this.AddNewRow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.DataTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 557);
            this.panel1.TabIndex = 0;
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ParameterName,
            this.ParameterType,
            this.ParameterId});
            this.DataTable.Location = new System.Drawing.Point(3, 3);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(548, 551);
            this.DataTable.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Lp";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 50;
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "Nazwa parametru";
            this.ParameterName.Name = "ParameterName";
            this.ParameterName.Width = 225;
            // 
            // ParameterType
            // 
            this.ParameterType.HeaderText = "Typ parametru";
            this.ParameterType.Items.AddRange(new object[] {
            "Tekst",
            "123",
            "Tak/Nie"});
            this.ParameterType.Name = "ParameterType";
            this.ParameterType.Width = 225;
            // 
            // ParameterId
            // 
            this.ParameterId.HeaderText = "#";
            this.ParameterId.Name = "ParameterId";
            this.ParameterId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Controls.Add(this.RemoveSelectedRow);
            this.panel2.Controls.Add(this.AddNewRow);
            this.panel2.Location = new System.Drawing.Point(569, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 554);
            this.panel2.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(3, 501);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(194, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Zamknij";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 415);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(194, 50);
            this.Save.TabIndex = 2;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RemoveSelectedRow
            // 
            this.RemoveSelectedRow.Location = new System.Drawing.Point(3, 59);
            this.RemoveSelectedRow.Name = "RemoveSelectedRow";
            this.RemoveSelectedRow.Size = new System.Drawing.Size(194, 50);
            this.RemoveSelectedRow.TabIndex = 1;
            this.RemoveSelectedRow.Text = "Usuń zaznaczony typ parametru";
            this.RemoveSelectedRow.UseVisualStyleBackColor = true;
            this.RemoveSelectedRow.Click += new System.EventHandler(this.RemoveSelectedRow_Click);
            // 
            // AddNewRow
            // 
            this.AddNewRow.Location = new System.Drawing.Point(3, 3);
            this.AddNewRow.Name = "AddNewRow";
            this.AddNewRow.Size = new System.Drawing.Size(194, 50);
            this.AddNewRow.TabIndex = 0;
            this.AddNewRow.Text = "Dodaj nowy typ parametru";
            this.AddNewRow.UseVisualStyleBackColor = true;
            this.AddNewRow.Click += new System.EventHandler(this.AddNewRow_Click);
            // 
            // EditParametersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EditParametersWindow";
            this.Text = "EditParametersWindow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button RemoveSelectedRow;
        private System.Windows.Forms.Button AddNewRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ParameterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterId;
    }
}