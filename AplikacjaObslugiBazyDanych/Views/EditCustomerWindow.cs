using AplikacjaObslugiBazyDanych.Models;
using AplikacjaObslugiBazyDanych.CustomClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EditCustomerWindow : Form
    {
        List<Customer> Customers;
        public EditCustomerWindow()
        {
            Customers = new List<Customer>();
            InitializeComponent();
            RefreshCustomerComboBox();
        }

        private void CustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                int Buffid = (CustomerSelect.SelectedItem as CustomComboBox).Id.Value;

                var Customer = context.Customers.SingleOrDefault(a => a.CustomerId == Buffid);
                if (Customer != null)
                {
                    CustomerFirstName.Text = Customer.FirstName;
                    CustomerLastName.Text = Customer.LastName;
                    CustomerAddress.Text = Customer.Address;
                    CustomerCity.Text = Customer.City;
                    CustomerCountry.Text = Customer.Country;
                    CustomerPhoneNumber.Text = Customer.PhoneNumber;
                    CustomerEmail.Text = Customer.Email;
                }
            }
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerSelect.SelectedIndex == -1) { MessageBox.Show("Wybierz klienta!"); return; }
            if (!IsNullOrEmpty(CustomerFirstName.Text, CustomerLastName.Text, CustomerAddress.Text, CustomerCity.Text, CustomerCountry.Text, CustomerPhoneNumber.Text, CustomerEmail.Text))
            {
                if (IsValidEmail(CustomerEmail.Text))
                {
                    using (var context = new DatabaseContext())
                    {
                        var Customer = new Customer();
                        Customer.CustomerId = (CustomerSelect.SelectedItem as CustomComboBox).Id.Value;
                        Customer.FirstName = CustomerFirstName.Text;
                        Customer.LastName = CustomerLastName.Text;
                        Customer.Address = CustomerAddress.Text;
                        Customer.City = CustomerCity.Text;
                        Customer.Country = CustomerCountry.Text;
                        Customer.PhoneNumber = CustomerPhoneNumber.Text;
                        Customer.Email = CustomerEmail.Text;


                        context.Customers.AddOrUpdate(Customer);
                        context.SaveChanges();
                        this.Close();
                    }
                }
                else MessageBox.Show("Podaj poprawny adres email!");
            }
            else MessageBox.Show("Wypełnij wszystkie pola!");

        }

        private bool IsNullOrEmpty(params string[] texts)
        {
            return texts.Any(item => string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item));
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

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                int Buffid = (CustomerSelect.SelectedItem as CustomComboBox).Id.Value;

                var Customer = context.Customers.SingleOrDefault(a => a.CustomerId == Buffid);
                context.Customers.Remove(Customer);
                context.SaveChanges();

                CustomerFirstName.Text = "";
                CustomerLastName.Text = "";
                CustomerAddress.Text = "";
                CustomerCity.Text = "";
                CustomerCountry.Text = "";
                CustomerPhoneNumber.Text = "";
                CustomerEmail.Text = "";

                RefreshCustomerComboBox();
            }
        }
        private void RefreshCustomerComboBox()
        {
            using (var context = new DatabaseContext())
            {
                Customers.Clear();
                Customers = context.Customers.ToList();

                CustomerSelect.Items.Clear();
                foreach (var item in Customers)
                {
                    var CustomerBuff = new CustomComboBox();
                    CustomerBuff.Value = item.FirstName + " " + item.LastName;
                    CustomerBuff.Id = item.CustomerId;
                    CustomerSelect.Items.Add(CustomerBuff);
                }
            }
        }

        private void CustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
