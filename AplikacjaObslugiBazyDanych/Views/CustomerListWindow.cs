using AplikacjaObslugiBazyDanych.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class CustomerListWindow : Form
    {
        List<Customer> CustomerList;
        public CustomerListWindow()
        {
            using (var context = new DatabaseContext())
            {
                InitializeComponent();
                CustomerList = context.Customers.ToList();
                CustomersTable.DataSource = CustomerList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustomersTable.SelectedCells.Count > 0)
            {
                var RowId = CustomersTable.SelectedCells[0].RowIndex;

                var CustomerId = (int)CustomersTable.Rows[RowId].Cells[0].Value;
                var CustomerModel = CustomerList.FirstOrDefault(a => a.CustomerId == CustomerId);

                var CustomerWindow = new AddCustomerWindow(CustomerModel);
                CustomerWindow.ShowDialog();
                UpdateTable();
            }
        }
        private void UpdateTable()
        {
            using (var context = new DatabaseContext())
            {
                CustomerList = context.Customers.ToList();
                CustomersTable.DataSource = CustomerList;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustomersTable.SelectedCells.Count <= 0) return;

            using (var context = new DatabaseContext())
            {
                var RowId = CustomersTable.SelectedCells[0].RowIndex;
                var CustomerId = (int)CustomersTable.Rows[RowId].Cells[0].Value;
                var CustomerModel = context.Customers.FirstOrDefault(a => a.CustomerId == CustomerId);

                if (CustomerModel == null) return;

                context.Customers.Remove(CustomerModel);
                context.SaveChanges();
                UpdateTable();
            }
        }
    }
}
