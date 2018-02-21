namespace AplikacjaObslugiBazyDanych.Views
{
    partial class AddEmployeeWindow
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
            this.Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 64);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(152, 20);
            this.Login.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nazwisko";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 20);
            this.Password.TabIndex = 5;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(12, 12);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(152, 20);
            this.Firstname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numer Telefonu";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(12, 38);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(152, 20);
            this.Surname.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(12, 116);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(152, 20);
            this.Phone.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 142);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(152, 20);
            this.Email.TabIndex = 7;
            // 
            // Roles
            // 
            this.Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roles.FormattingEnabled = true;
            this.Roles.Location = new System.Drawing.Point(12, 168);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(152, 21);
            this.Roles.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rola";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(89, 195);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Ok";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 100;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(215, 90);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(64, 20);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Generuj";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(272, 9);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 13);
            this.Id.TabIndex = 17;
            this.Id.Visible = false;
            // 
            // AddEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 270);
            this.Name = "AddEmployeeWindow";
            this.Text = "AddEmployeeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label Id;
    }
}