using AplikacjaObslugiBazyDanych.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddCustomerWindow : Form
    {
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void CustomerButtonOk_Click(object sender, EventArgs e)
        {
            if (!IsNullOrEmpty(CustomerFirstName.Text, CustomerLastName.Text, CustomerAddress.Text, CustomerCity.Text, CustomerCountry.Text, CustomerPhoneNumber.Text, CustomerEmail.Text))
            {
                if (IsValidEmail(CustomerEmail.Text))
                {
                    var CustomerModel = new Customer();
                    CustomerModel.FirstName = CustomerFirstName.Text;
                    CustomerModel.LastName = CustomerLastName.Text;
                    CustomerModel.Address = CustomerAddress.Text;
                    CustomerModel.City = CustomerCity.Text;
                    CustomerModel.Country = CustomerCountry.Text;
                    CustomerModel.PhoneNumber = CustomerPhoneNumber.Text;
                    CustomerModel.Email = CustomerEmail.Text;
                    using (var context = new DatabaseContext())
                    {
                        context.Customers.Add(CustomerModel);
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
