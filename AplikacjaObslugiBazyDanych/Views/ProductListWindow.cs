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
using System.Data.Entity;


namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class ProductListWindow : Form
    {
        List<Product> ProductsList;
        public ProductListWindow()
        {
            ProductsList = new List<Product>();
            using (var context = new DatabaseContext())
            {
                ProductsList = context.Products.Include(a => a.Category).Include(a => a.Employee).ToList();
                InitializeComponent();
                ProductsTable.DataSource = ProductsList;
            }
        }

        private void EditCategoryButton_Click(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedCells.Count > 0)
            {
                var RowId = ProductsTable.SelectedCells[0].RowIndex;

                var ProductID = (int)ProductsTable.Rows[RowId].Cells[0].Value;
                var ProductModel = ProductsList.FirstOrDefault(a => a.ProductId == ProductID);

                var ProductWindow = new AddProductWindow(ProductModel);
                ProductWindow.ShowDialog();
                UpdateTable();
            }
        }
        private void UpdateTable()
        {
            using (var context = new DatabaseContext())
            {
                ProductsList = context.Products.Include(a => a.Category).Include(a => a.Employee).ToList();
                ProductsTable.DataSource = ProductsList;
            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedCells.Count <= 0) return;

            using (var context = new DatabaseContext())
            {
                var RowId = ProductsTable.SelectedCells[0].RowIndex;
                var ProductID = (int)ProductsTable.Rows[RowId].Cells[0].Value;
                var ProductModel = context.Products.FirstOrDefault(a => a.ProductId == ProductID);

                if (ProductModel == null) return;

                context.Products.Remove(ProductModel);
                context.SaveChanges();
                UpdateTable();
            }
        }
    }
}
