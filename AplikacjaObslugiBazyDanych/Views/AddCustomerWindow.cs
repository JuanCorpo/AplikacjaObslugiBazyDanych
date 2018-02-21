using AplikacjaObslugiBazyDanych.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddCustomerWindow : Form
    {
        Customer CustomerModel;
        public AddCustomerWindow(Customer customer = null)
        {
            InitializeComponent();
            CustomerModel = new Customer();
            if (customer != null)
            {
                CustomerModel = customer;
                CustomerFirstName.Text = customer.FirstName;
                CustomerLastName.Text = customer.LastName;
                CustomerAddress.Text = customer.Address;
                CustomerCity.Text = customer.City;
                CustomerCountry.Text = customer.Country;
                CustomerPhoneNumber.Text = customer.PhoneNumber;
                CustomerEmail.Text = customer.Email;
            }
        }

        private void CustomerButtonOk_Click(object sender, EventArgs e)
        {
            if (!IsNullOrEmpty(CustomerFirstName.Text, CustomerLastName.Text, CustomerAddress.Text, CustomerCity.Text, CustomerCountry.Text, CustomerPhoneNumber.Text, CustomerEmail.Text))
            {
                if (IsValidEmail(CustomerEmail.Text))
                {
                    CustomerModel.FirstName = CustomerFirstName.Text;
                    CustomerModel.LastName = CustomerLastName.Text;
                    CustomerModel.Address = CustomerAddress.Text;
                    CustomerModel.City = CustomerCity.Text;
                    CustomerModel.Country = CustomerCountry.Text;
                    CustomerModel.PhoneNumber = CustomerPhoneNumber.Text;
                    CustomerModel.Email = CustomerEmail.Text;
                    using (var context = new DatabaseContext())
                    {
                        context.Customers.AddOrUpdate(CustomerModel);
                        context.SaveChanges();
                    }
                    this.Close();
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

        private void CustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
