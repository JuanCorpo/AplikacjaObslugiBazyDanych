namespace AplikacjaObslugiBazyDanych.Views
{
    partial class EditRoleWindow
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
            this.RoleTable = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleClaims = new System.Windows.Forms.DataGridView();
            this.ClaimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcludedRoleClaims = new System.Windows.Forms.DataGridView();
            this.ClaimsFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimIdFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClaimToRole = new System.Windows.Forms.Button();
            this.RevokeRoleClaim = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EmployeesTable = new System.Windows.Forms.DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.RevokeEmployeeRole = new System.Windows.Forms.Button();
            this.AddEmployeeToRole = new System.Windows.Forms.Button();
            this.AddRole = new System.Windows.Forms.Button();
            this.RemoveRole = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.EmployeesList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleClaims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcludedRoleClaims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleTable
            // 
            this.RoleTable.AllowUserToAddRows = false;
            this.RoleTable.AllowUserToDeleteRows = false;
            this.RoleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RoleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleName,
            this.Id});
            this.RoleTable.Location = new System.Drawing.Point(12, 25);
            this.RoleTable.Name = "RoleTable";
            this.RoleTable.RowHeadersVisible = false;
            this.RoleTable.Size = new System.Drawing.Size(150, 524);
            this.RoleTable.TabIndex = 0;
            this.RoleTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleTable_CellContentClick);
            this.RoleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleTable_CellContentClick);
            // 
            // RoleName
            // 
            this.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleName.HeaderText = "Nazwa grupy";
            this.RoleName.Name = "RoleName";
            // 
            // Id
            // 
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // RoleClaims
            // 
            this.RoleClaims.AllowUserToAddRows = false;
            this.RoleClaims.AllowUserToDeleteRows = false;
            this.RoleClaims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RoleClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimName,
            this.ClaimId});
            this.RoleClaims.Location = new System.Drawing.Point(168, 25);
            this.RoleClaims.Name = "RoleClaims";
            this.RoleClaims.RowHeadersVisible = false;
            this.RoleClaims.Size = new System.Drawing.Size(150, 524);
            this.RoleClaims.TabIndex = 1;
            this.RoleClaims.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleClaims_CellContentClick);
            // 
            // ClaimName
            // 
            this.ClaimName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClaimName.HeaderText = "Uprawnienia";
            this.ClaimName.Name = "ClaimName";
            this.ClaimName.ReadOnly = true;
            // 
            // ClaimId
            // 
            this.ClaimId.HeaderText = "#";
            this.ClaimId.Name = "ClaimId";
            this.ClaimId.ReadOnly = true;
            this.ClaimId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupy użytkowników";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uprawnienia grupy";
            // 
            // ExcludedRoleClaims
            // 
            this.ExcludedRoleClaims.AllowUserToAddRows = false;
            this.ExcludedRoleClaims.AllowUserToDeleteRows = false;
            this.ExcludedRoleClaims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExcludedRoleClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcludedRoleClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimsFree,
            this.ClaimIdFree});
            this.ExcludedRoleClaims.Location = new System.Drawing.Point(350, 25);
            this.ExcludedRoleClaims.Name = "ExcludedRoleClaims";
            this.ExcludedRoleClaims.RowHeadersVisible = false;
            this.ExcludedRoleClaims.Size = new System.Drawing.Size(150, 524);
            this.ExcludedRoleClaims.TabIndex = 4;
            this.ExcludedRoleClaims.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExcludedRoleClaims_CellClick);
            // 
            // ClaimsFree
            // 
            this.ClaimsFree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClaimsFree.HeaderText = "Uprawnienia";
            this.ClaimsFree.Name = "ClaimsFree";
            this.ClaimsFree.ReadOnly = true;
            // 
            // ClaimIdFree
            // 
            this.ClaimIdFree.HeaderText = "#";
            this.ClaimIdFree.Name = "ClaimIdFree";
            this.ClaimIdFree.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dostępne uprawnienia";
            // 
            // AddClaimToRole
            // 
            this.AddClaimToRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddClaimToRole.Location = new System.Drawing.Point(324, 257);
            this.AddClaimToRole.Name = "AddClaimToRole";
            this.AddClaimToRole.Size = new System.Drawing.Size(20, 20);
            this.AddClaimToRole.TabIndex = 6;
            this.AddClaimToRole.Text = "<";
            this.AddClaimToRole.UseVisualStyleBackColor = true;
            this.AddClaimToRole.Click += new System.EventHandler(this.AddClaimToRole_Click);
            // 
            // RevokeRoleClaim
            // 
            this.RevokeRoleClaim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RevokeRoleClaim.Location = new System.Drawing.Point(324, 283);
            this.RevokeRoleClaim.Name = "RevokeRoleClaim";
            this.RevokeRoleClaim.Size = new System.Drawing.Size(20, 20);
            this.RevokeRoleClaim.TabIndex = 7;
            this.RevokeRoleClaim.Text = ">";
            this.RevokeRoleClaim.UseVisualStyleBackColor = true;
            this.RevokeRoleClaim.Click += new System.EventHandler(this.RevokeRoleClaim_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(662, 499);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 50);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Zamknij";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmployeesTable
            // 
            this.EmployeesTable.AllowUserToAddRows = false;
            this.EmployeesTable.AllowUserToDeleteRows = false;
            this.EmployeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.EmployeeId});
            this.EmployeesTable.Location = new System.Drawing.Point(506, 25);
            this.EmployeesTable.Name = "EmployeesTable";
            this.EmployeesTable.RowHeadersVisible = false;
            this.EmployeesTable.Size = new System.Drawing.Size(150, 524);
            this.EmployeesTable.TabIndex = 11;
            this.EmployeesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesTable_CellContentClick);
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.HeaderText = "Pracownik";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "#";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pracownicy w grupie";
            // 
            // RevokeEmployeeRole
            // 
            this.RevokeEmployeeRole.Location = new System.Drawing.Point(662, 25);
            this.RevokeEmployeeRole.Name = "RevokeEmployeeRole";
            this.RevokeEmployeeRole.Size = new System.Drawing.Size(116, 50);
            this.RevokeEmployeeRole.TabIndex = 13;
            this.RevokeEmployeeRole.Text = "Usuń pracownika z grupy";
            this.RevokeEmployeeRole.UseVisualStyleBackColor = true;
            this.RevokeEmployeeRole.Click += new System.EventHandler(this.RevokeEmployeeRole_Click);
            // 
            // AddEmployeeToRole
            // 
            this.AddEmployeeToRole.Location = new System.Drawing.Point(662, 81);
            this.AddEmployeeToRole.Name = "AddEmployeeToRole";
            this.AddEmployeeToRole.Size = new System.Drawing.Size(116, 50);
            this.AddEmployeeToRole.TabIndex = 14;
            this.AddEmployeeToRole.Text = "Dodaj pracownika do grupy";
            this.AddEmployeeToRole.UseVisualStyleBackColor = true;
            this.AddEmployeeToRole.Click += new System.EventHandler(this.AddEmployeeToRole_Click);
            // 
            // AddRole
            // 
            this.AddRole.Location = new System.Drawing.Point(662, 201);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(116, 50);
            this.AddRole.TabIndex = 15;
            this.AddRole.Text = "Dodaj nową grupe";
            this.AddRole.UseVisualStyleBackColor = true;
            this.AddRole.Click += new System.EventHandler(this.AddRole_Click);
            // 
            // RemoveRole
            // 
            this.RemoveRole.Location = new System.Drawing.Point(662, 257);
            this.RemoveRole.Name = "RemoveRole";
            this.RemoveRole.Size = new System.Drawing.Size(116, 50);
            this.RemoveRole.TabIndex = 16;
            this.RemoveRole.Text = "Usuń wybraną grupe";
            this.RemoveRole.UseVisualStyleBackColor = true;
            this.RemoveRole.Click += new System.EventHandler(this.RemoveRole_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(662, 389);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 50);
            this.Save.TabIndex = 17;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EmployeesList
            // 
            this.EmployeesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.Location = new System.Drawing.Point(662, 137);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(116, 21);
            this.EmployeesList.TabIndex = 18;
            // 
            // EditRoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.EmployeesList);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemoveRole);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.AddEmployeeToRole);
            this.Controls.Add(this.RevokeEmployeeRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeesTable);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RevokeRoleClaim);
            this.Controls.Add(this.AddClaimToRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExcludedRoleClaims);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleClaims);
            this.Controls.Add(this.RoleTable);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EditRoleWindow";
            this.Text = "EditRoleWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RoleTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleClaims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcludedRoleClaims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoleTable;
        private System.Windows.Forms.DataGridView RoleClaims;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ExcludedRoleClaims;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddClaimToRole;
        private System.Windows.Forms.Button RevokeRoleClaim;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView EmployeesTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RevokeEmployeeRole;
        private System.Windows.Forms.Button AddEmployeeToRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimsFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimIdFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimId;
        private System.Windows.Forms.Button AddRole;
        private System.Windows.Forms.Button RemoveRole;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox EmployeesList;
    }
}