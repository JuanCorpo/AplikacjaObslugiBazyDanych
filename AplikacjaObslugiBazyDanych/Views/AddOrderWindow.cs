using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.CustomClasses;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddOrderWindow : Form
    {
        private Order order;
        private List<OrderDetail> orderDetails;

        public AddOrderWindow(Order loadedOrder = null)
        {
            using (var context = new DatabaseContext())
            {
                orderDetails = new List<OrderDetail>();
                order = new Order()
                {
                    EmployeeId = UserHelper.Employee.EmployeeId,
                };

                InitializeComponent();

                var customers = context.Customers.ToList();
                var statuses = context.Statuses.ToList();

                foreach (var item in customers)
                {
                    Customers.Items.Add(new CustomComboBox()
                    {
                        Id = item.CustomerId,
                        Value = item.GetFullName()
                    });
                }

                foreach (var item in statuses)
                {
                    Status.Items.Add(new CustomComboBox()
                    {
                        Id = item.StatusId,
                        Value = item.StatusName
                    });
                }
                Status.SelectedIndex = 0;


                if (loadedOrder != null)
                {
                    order.OrderId = loadedOrder.OrderId;

                    orderDetails = context.OrdersDetails.Include(a => a.Product).Include(a => a.Order).Where(a => a.OrderId == loadedOrder.OrderId).ToList();

                    foreach (var item in Customers.Items)
                    {
                        if (item is CustomComboBox element && element.Id == loadedOrder.CustomerId)
                        {
                            Customers.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (var item in Status.Items)
                    {
                        if (item is CustomComboBox element && element.Id == loadedOrder.StatusId)
                        {
                            Status.SelectedItem = item;
                            break;
                        }
                    }

                }
            }
            UpdateTable();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var window = new SelectOrderProductWindow();
            window.ShowDialog();
            if (window.Added)
            {
                var product = window.GetSelected();
                var numberOf = window.GetCount();
                var discount = window.GetDiscount();
                orderDetails.Add(new OrderDetail()
                {
                    Amount = numberOf,
                    Discount = discount,
                    Price = (int)product.Price,
                    ProductId = product.ProductId,
                    Product = product
                });
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            ClearTable(DataTable);
            var i = 1;
            foreach (var item in orderDetails)
            {
                DataTable.RowCount++;
                DataTable.Rows[DataTable.RowCount - 1].Cells[0].Value = i++;
                DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = item.Product.Name;
                DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value = item.Amount;
                DataTable.Rows[DataTable.RowCount - 1].Cells[3].Value = item.Product.Price;
                DataTable.Rows[DataTable.RowCount - 1].Cells[4].Value = item.Discount;
                DataTable.Rows[DataTable.RowCount - 1].Cells[5].Value = ((100 - item.Discount) * (item.Product.Price * item.Amount)) / 100;
                DataTable.Rows[DataTable.RowCount - 1].Cells[6].Value = item.ProductId;
            }
        }

        private void ClearTable(DataGridView table)
        {
            var count = table.Rows.Count;
            for (var i = 0; i < count; i++)
            {
                table.Rows.RemoveAt(0);
            }
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var rowId = DataTable.SelectedCells[0].RowIndex;

                    var id = (int)DataTable.Rows[rowId].Cells[0].Value;

                    var element = orderDetails.ElementAt(id - 1);
                    if (element?.ID != null)
                    {
                        var toRemove = context.OrdersDetails.FirstOrDefault(a => a.ID == element.ID);
                        context.OrdersDetails.Remove(toRemove);
                        context.SaveChanges();
                    }

                    orderDetails.RemoveAt(id - 1);
                }
                UpdateTable();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count > 0)
            {
                var rowId = DataTable.SelectedCells[0].RowIndex;
                var id = (int)DataTable.Rows[rowId].Cells[0].Value;

                var window = new SelectOrderProductWindow(orderDetails[id - 1]);
                window.ShowDialog();
                if (window.Added)
                {
                    var product = window.GetSelected();
                    var numberOf = window.GetCount();
                    var discount = window.GetDiscount();

                    var idO = orderDetails[id - 1].ID;

                    orderDetails[id - 1] = new OrderDetail()
                    {
                        ID = idO,
                        Amount = numberOf,
                        Discount = discount,
                        Price = (int)product.Price,
                        ProductId = product.ProductId,
                        Product = product,
                    };

                    UpdateTable();
                }
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if (Customers.SelectedIndex >= 0 && Status.SelectedIndex >= 0 && orderDetails.Count > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var idC = ((CustomComboBox)Customers.SelectedItem).Id;

                    if (idC != null)
                        order.CustomerId = idC.Value;

                    var idS = ((CustomComboBox)Status.SelectedItem).Id;

                    if (idS != null)
                        order.StatusId = idS.Value;

                    var or = new Order()
                    {
                        OrderId = order.OrderId,
                        CustomerId = order.CustomerId,
                        EmployeeId = order.EmployeeId,
                        StatusId = order.StatusId
                    };

                    context.Orders.AddOrUpdate(or);

                    context.SaveChanges();

                    orderDetails = orderDetails.Select(a =>
                    {
                        a.Product = null;
                        a.OrderId = or.OrderId;
                        return a;
                    }).ToList();

                    foreach (var item in orderDetails)
                    {
                        context.OrdersDetails.AddOrUpdate(item);
                    }

                    context.SaveChanges();

                    // TODO !!
                    // TODO Wysłanie powiadomienia o zamówieniu
                    // TODO !!
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Prosze wybrać klienta oraz status oraz zamówienie musi składać się z przynajmniej jednego produktu!");
            }
        }
    }
}
