namespace AplikacjaObslugiBazyDanych.Views
{
    partial class AddCustomerWindow
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
            this.CustomerCancelButton = new System.Windows.Forms.Button();
            this.CustomerButtonOk = new System.Windows.Forms.Button();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.CustomerCountry = new System.Windows.Forms.TextBox();
            this.CustomerCity = new System.Windows.Forms.TextBox();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.CustomerLastName = new System.Windows.Forms.TextBox();
            this.CustomerFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerCancelButton
            // 
            this.CustomerCancelButton.Location = new System.Drawing.Point(140, 202);
            this.CustomerCancelButton.Name = "CustomerCancelButton";
            this.CustomerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerCancelButton.TabIndex = 31;
            this.CustomerCancelButton.Text = "Anuluj";
            this.CustomerCancelButton.UseVisualStyleBackColor = true;
            this.CustomerCancelButton.Click += new System.EventHandler(this.CustomerCancelButton_Click);
            // 
            // CustomerButtonOk
            // 
            this.CustomerButtonOk.Location = new System.Drawing.Point(36, 202);
            this.CustomerButtonOk.Name = "CustomerButtonOk";
            this.CustomerButtonOk.Size = new System.Drawing.Size(75, 23);
            this.CustomerButtonOk.TabIndex = 30;
            this.CustomerButtonOk.Text = "Ok";
            this.CustomerButtonOk.UseVisualStyleBackColor = true;
            this.CustomerButtonOk.Click += new System.EventHandler(this.CustomerButtonOk_Click);
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(12, 176);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(144, 20);
            this.CustomerEmail.TabIndex = 29;
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.Location = new System.Drawing.Point(12, 149);
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            this.CustomerPhoneNumber.Size = new System.Drawing.Size(144, 20);
            this.CustomerPhoneNumber.TabIndex = 28;
            // 
            // CustomerCountry
            // 
            this.CustomerCountry.Location = new System.Drawing.Point(12, 122);
            this.CustomerCountry.Name = "CustomerCountry";
            this.CustomerCountry.Size = new System.Drawing.Size(144, 20);
            this.CustomerCountry.TabIndex = 27;
            // 
            // CustomerCity
            // 
            this.CustomerCity.Location = new System.Drawing.Point(12, 95);
            this.CustomerCity.Name = "CustomerCity";
            this.CustomerCity.Size = new System.Drawing.Size(144, 20);
            this.CustomerCity.TabIndex = 26;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Location = new System.Drawing.Point(12, 66);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(144, 20);
            this.CustomerAddress.TabIndex = 25;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Location = new System.Drawing.Point(12, 39);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(144, 20);
            this.CustomerLastName.TabIndex = 24;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.Location = new System.Drawing.Point(12, 12);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(144, 20);
            this.CustomerFirstName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Numer Telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Miasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Imię";
            // 
            // AddCustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CustomerCancelButton);
            this.Controls.Add(this.CustomerButtonOk);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.CustomerPhoneNumber);
            this.Controls.Add(this.CustomerCountry);
            this.Controls.Add(this.CustomerCity);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.CustomerFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerWindow";
            this.Text = "AddCustomerWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerCancelButton;
        private System.Windows.Forms.Button CustomerButtonOk;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerPhoneNumber;
        private System.Windows.Forms.TextBox CustomerCountry;
        private System.Windows.Forms.TextBox CustomerCity;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.TextBox CustomerLastName;
        private System.Windows.Forms.TextBox CustomerFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}