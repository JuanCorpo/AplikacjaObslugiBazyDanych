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
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class OrderListWindow : Form
    {
        private List<Order> orderList;
        public OrderListWindow()
        {
            orderList = new List<Order>();
            InitializeComponent();

            UpdateTable();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var RowId = DataTable.SelectedCells[0].RowIndex;

                    var orderID = (int)DataTable.Rows[RowId].Cells[0].Value;
                    var order = context.Orders.FirstOrDefault(a => a.OrderId == orderID);

                    context.Orders.Remove(order);
                    context.SaveChanges();

                    UpdateTable();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var RowId = DataTable.SelectedCells[0].RowIndex;

                    var orderID = (int)DataTable.Rows[RowId].Cells[0].Value;
                    var order = context.Orders.Include(a=>a.Employee).Include(a=>a.Customer).FirstOrDefault(a => a.OrderId == orderID);

                    var orderWindow = new AddOrderWindow(order);
                    orderWindow.ShowDialog();
                    UpdateTable();
                }
            }
        }

        private void UpdateTable()
        {
            using (var context = new DatabaseContext())
            {
                orderList = context.Orders.Include(a => a.Employee).Include(a => a.Customer).Include(a => a.Status).ToList();
                DataTable.DataSource = orderList;
            }
        }
    }
}
