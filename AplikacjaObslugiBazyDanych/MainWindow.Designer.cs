using System;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych
{
    partial class MainWindow
    {
        private DateTime currentTime;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleName = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditRemoveEmployee = new System.Windows.Forms.Button();
            this.EditParametersTypes = new System.Windows.Forms.Button();
            this.EditStatuses = new System.Windows.Forms.Button();
            this.EditCategories = new System.Windows.Forms.Button();
            this.EditRole = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.EditOrder = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rola:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.DateTime);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RoleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 24);
            this.panel1.TabIndex = 1;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(307, -2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 24);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Wyloguj";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // DateTime
            // 
            this.DateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(654, 3);
            this.DateTime.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(106, 13);
            this.DateTime.TabIndex = 4;
            this.DateTime.Text = "07.02.2018 23:12:42";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(193, 3);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Użytkownik:";
            // 
            // RoleName
            // 
            this.RoleName.AutoSize = true;
            this.RoleName.Location = new System.Drawing.Point(41, 3);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(57, 13);
            this.RoleName.TabIndex = 1;
            this.RoleName.Text = "RoleName";
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.DateTimeUpdate);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.EditRemoveEmployee);
            this.panel2.Controls.Add(this.EditParametersTypes);
            this.panel2.Controls.Add(this.EditStatuses);
            this.panel2.Controls.Add(this.EditCategories);
            this.panel2.Controls.Add(this.EditRole);
            this.panel2.Controls.Add(this.DeleteOrder);
            this.panel2.Controls.Add(this.DeleteClient);
            this.panel2.Controls.Add(this.DeleteProduct);
            this.panel2.Controls.Add(this.EditOrder);
            this.panel2.Controls.Add(this.EditClient);
            this.panel2.Controls.Add(this.EditProduct);
            this.panel2.Controls.Add(this.AddEmployee);
            this.panel2.Controls.Add(this.AddOrder);
            this.panel2.Controls.Add(this.AddClient);
            this.panel2.Controls.Add(this.AddProduct);
            this.panel2.Location = new System.Drawing.Point(13, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 471);
            this.panel2.TabIndex = 2;
            // 
            // EditRemoveEmployee
            // 
            this.EditRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRemoveEmployee.Location = new System.Drawing.Point(579, 119);
            this.EditRemoveEmployee.Name = "EditRemoveEmployee";
            this.EditRemoveEmployee.Size = new System.Drawing.Size(187, 226);
            this.EditRemoveEmployee.TabIndex = 16;
            this.EditRemoveEmployee.Text = "Edytuj / Usuń pracownika\r\n";
            this.EditRemoveEmployee.UseVisualStyleBackColor = true;
            this.EditRemoveEmployee.Click += new System.EventHandler(this.EditRemoveEmployee_Click);
            // 
            // EditParametersTypes
            // 
            this.EditParametersTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditParametersTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditParametersTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditParametersTypes.Location = new System.Drawing.Point(579, 351);
            this.EditParametersTypes.Name = "EditParametersTypes";
            this.EditParametersTypes.Size = new System.Drawing.Size(187, 110);
            this.EditParametersTypes.TabIndex = 15;
            this.EditParametersTypes.Text = "Edytuj parametry";
            this.EditParametersTypes.UseVisualStyleBackColor = true;
            this.EditParametersTypes.Click += new System.EventHandler(this.EditParametersTypes_Click);
            // 
            // EditStatuses
            // 
            this.EditStatuses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditStatuses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditStatuses.Location = new System.Drawing.Point(388, 351);
            this.EditStatuses.Name = "EditStatuses";
            this.EditStatuses.Size = new System.Drawing.Size(187, 110);
            this.EditStatuses.TabIndex = 14;
            this.EditStatuses.Text = "Edytuj statusy";
            this.EditStatuses.UseVisualStyleBackColor = true;
            this.EditStatuses.Click += new System.EventHandler(this.EditStatuses_Click);
            // 
            // EditCategories
            // 
            this.EditCategories.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditCategories.Location = new System.Drawing.Point(195, 351);
            this.EditCategories.Name = "EditCategories";
            this.EditCategories.Size = new System.Drawing.Size(187, 110);
            this.EditCategories.TabIndex = 13;
            this.EditCategories.Text = "Edytuj kategorie";
            this.EditCategories.UseVisualStyleBackColor = true;
            this.EditCategories.Click += new System.EventHandler(this.EditCategories_Click);
            // 
            // EditRole
            // 
            this.EditRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditRole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRole.Location = new System.Drawing.Point(3, 351);
            this.EditRole.Name = "EditRole";
            this.EditRole.Size = new System.Drawing.Size(187, 110);
            this.EditRole.TabIndex = 12;
            this.EditRole.Text = "Edytuj role";
            this.EditRole.UseVisualStyleBackColor = true;
            this.EditRole.Click += new System.EventHandler(this.EditRole_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteOrder.Location = new System.Drawing.Point(388, 235);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(187, 110);
            this.DeleteOrder.TabIndex = 10;
            this.DeleteOrder.Text = "Usuń zamówienie";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteClient.Location = new System.Drawing.Point(195, 237);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(187, 110);
            this.DeleteClient.TabIndex = 9;
            this.DeleteClient.Text = "Usuń klienta";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteProduct.Location = new System.Drawing.Point(3, 235);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(187, 110);
            this.DeleteProduct.TabIndex = 8;
            this.DeleteProduct.Text = "Usuń produkt";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // EditOrder
            // 
            this.EditOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditOrder.Location = new System.Drawing.Point(388, 119);
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.Size = new System.Drawing.Size(187, 110);
            this.EditOrder.TabIndex = 6;
            this.EditOrder.Text = "Edytuj zamówienie";
            this.EditOrder.UseVisualStyleBackColor = true;
            this.EditOrder.Click += new System.EventHandler(this.EditOrder_Click);
            // 
            // EditClient
            // 
            this.EditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditClient.Location = new System.Drawing.Point(195, 119);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(187, 110);
            this.EditClient.TabIndex = 5;
            this.EditClient.Text = "Edytuj klienta";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // EditProduct
            // 
            this.EditProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EditProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditProduct.Location = new System.Drawing.Point(3, 119);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(187, 110);
            this.EditProduct.TabIndex = 4;
            this.EditProduct.Text = "Edytuj produkt";
            this.EditProduct.UseVisualStyleBackColor = true;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEmployee.Location = new System.Drawing.Point(579, 3);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(187, 110);
            this.AddEmployee.TabIndex = 3;
            this.AddEmployee.Text = "Dodaj pracownika";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddOrder.Location = new System.Drawing.Point(388, 3);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(187, 110);
            this.AddOrder.TabIndex = 2;
            this.AddOrder.Text = "Dodaj zamówienie";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // AddClient
            // 
            this.AddClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddClient.Location = new System.Drawing.Point(195, 3);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(187, 110);
            this.AddClient.TabIndex = 1;
            this.AddClient.Text = "Dodaj klienta";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddProduct.Location = new System.Drawing.Point(2, 3);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(187, 110);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Dodaj produkt";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 29);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sekcja ___ 2018 All Rights Received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aplikacja obsługi sklepu ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void DateTimeUpdate(object sender, EventArgs e)
        {
            currentTime = System.DateTime.Now;
            this.DateTime.Text = currentTime.ToString();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoleName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateTime;
        private Timer MyTimer;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Button EditParametersTypes;
        private Button EditStatuses;
        private Button EditCategories;
        private Button EditRole;
        private Button DeleteOrder;
        private Button DeleteClient;
        private Button DeleteProduct;
        private Button EditOrder;
        private Button EditClient;
        private Button EditProduct;
        private Button AddEmployee;
        private Button AddOrder;
        private Button AddClient;
        private Button AddProduct;
        private Button Logout;
        private Button EditRemoveEmployee;
    }
}