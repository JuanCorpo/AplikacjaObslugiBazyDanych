using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddEmployeeWindow : Form
    {
        private List<Role> roleList;

        public AddEmployeeWindow()
        {
            using (var context = new DatabaseContext())
            {
                InitializeComponent();

                roleList = context.Roles.ToList();

                Roles.Items.Add("brak");
                foreach (var role in roleList)
                {
                    Roles.Items.Add(role.RoleName);
                }
                Roles.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var name = Firstname.Text;
                var lastname = Surname.Text;
                var login = Login.Text;
                var password = UserHelper.HashPassword(Password.Text);
                var phone = Phone.Text;
                var email = Email.Text;

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Podany adres email jest nieporawny!");
                    return;
                }

                if (context.Employees.Any(a => a.UserName.Equals(login)) || context.Employees.Any(a => a.Email.Equals(email)))
                {
                    MessageBox.Show("Ten login lub email jest zajęty");
                    return;
                }

                if (IsNullOrEmpty(name, lastname, login, password, phone, email, Password.Text))
                {
                    MessageBox.Show("Prosze wypełnic wszystkie pola!");
                }
                
                var selectedRole = Roles.SelectedItem.ToString();
                var role = roleList.FirstOrDefault(a => a.RoleName.Equals(Roles.SelectedItem.ToString()));

                var employee = new Employee()
                {
                    Email = email,
                    FirstName = name,
                    LastName = lastname,
                    Password = password,
                    PhoneNumber = phone,
                    UserName = login
                };

                if (selectedRole == "brak" || role == null)
                {
                    employee.RoleId = null;
                }
                else
                {
                    employee.RoleId = role.RoleId;
                }


                context.Employees.Add(employee);
                context.SaveChanges();

                // TODO !!
                // TODO Wysłanie wiadomości z danymi logowania
                // TODO !!
                
                this.Close();
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNullOrEmpty(params string[] texts)
        {
            return texts.Any(item => string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item));
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Password.Text = System.Web.Security.Membership.GeneratePassword(10, 2);
        }
    }
}
