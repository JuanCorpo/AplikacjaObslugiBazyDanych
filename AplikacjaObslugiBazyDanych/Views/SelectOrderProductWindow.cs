using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.CustomClasses;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class SelectOrderProductWindow : Form
    {
        public bool Added { get; set; }
        private int count;
        private int discount;
        private Product product;

        public SelectOrderProductWindow(OrderDetail orderDetail = null)
        {
            using (var context = new DatabaseContext())
            {
                InitializeComponent();

                selectedCount.Minimum = 1;
                Discount.Minimum = 0;
                Discount.Maximum = 100;

                Added = false;

                var products = context.Products.ToList();
                foreach (var item in products)
                {
                    selectedProduct.Items.Add(
                        new CustomComboBox()
                        {
                            Id = item.ProductId,
                            Value = item.Name
                        });
                }

                if (orderDetail != null)
                {
                    foreach (var item in selectedProduct.Items)
                    {
                        if (item is CustomComboBox element && element.Id == orderDetail.ProductId)
                        {
                            selectedProduct.SelectedItem = item;
                            break;
                        }
                    }

                    selectedCount.Value = orderDetail.Amount;
                    Discount.Value = orderDetail.Discount;

                    ID.Text = orderDetail.ProductId.ToString();
                    Name.Text = orderDetail.Product.Name;
                    Price.Text = orderDetail.Product.Price.ToString();
                    Stock.Text = orderDetail.Product.StockStatus.ToString();


                    orderDetail.Product.Employee =
                        context.Employees.FirstOrDefault(a => a.EmployeeId == orderDetail.Product.EmployeeId);


                    Employee.Text = orderDetail.Product.Employee.GetFullName();
                }
            }
        }

        public int GetCount()
        {
            return count;
        }

        public Product GetSelected()
        {
            return product;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (selectedProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Prosze wybrać produkt!");
                return;
            }

            Added = true;
            count = (int)selectedCount.Value;
            discount = (int)Discount.Value;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Added = false;
            this.Close();
        }

        private void selectedProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                if (selectedProduct.SelectedItem is CustomComboBox element)
                {
                    var id = element.Id;
                    product = context.Products.Include(a => a.Category).FirstOrDefault(a => a.ProductId == id);

                    ID.Text = product.ProductId.ToString();
                    Name.Text = product.Name;
                    Price.Text = product.Price.ToString();
                    Stock.Text = product.StockStatus.ToString();
                    Employee.Text = product.Employee.GetFullName();
                }
            }
        }

        public int GetDiscount()
        {
            return discount;
        }
    }
}
