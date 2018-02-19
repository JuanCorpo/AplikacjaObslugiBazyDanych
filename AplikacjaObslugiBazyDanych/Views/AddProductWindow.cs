using AplikacjaObslugiBazyDanych.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddProductWindow : Form
    {
        List<Category> Categories;
        List<Employee> Employees;
        List<ParameterType> Parameters;

        public AddProductWindow(Product product = null)
        {
            InitializeComponent();
            using (var context = new DatabaseContext())
            {
                Categories = context.Categories.ToList();
                Employees = context.Employees.ToList();
                Parameters = context.ParametersTypes.ToList();
            }
            foreach (var item in Categories)
            {
                ProductCategory.Items.Add(item.Name);
            }
            foreach (var item in Employees)
            {
                ProductEmployee.Items.Add(item.GetFullName());
            }
            var column = ProductParametersTable.Columns[1] as DataGridViewComboBoxColumn;
            foreach (var item in Parameters)
            {
                column.Items.Add(item.ParameterName);
            }
        }
        private void AddProductButton_Click(object sender, System.EventArgs e)
        {
            var ProductModel = new Product();
            var ParametersModel = new List<Parameter>();

            int PriceBuff;
            if (int.TryParse(ProductPrice.Text, out PriceBuff)) // TODO przetestować czy działczy
            {
                var SelectedCategory = ProductCategory.SelectedItem;
                var SelectedEmployee = ProductEmployee.SelectedItem;
                if (SelectedCategory != null && SelectedEmployee != null)
                {
                    using (var context = new DatabaseContext())
                    {
                        var Category = context.Categories.SingleOrDefault(c => c.Name.Equals(SelectedCategory.ToString()));
                        var Employee = context.Employees.SingleOrDefault(em => (em.FirstName + " " + em.LastName).Equals(SelectedEmployee.ToString()));
                        ProductModel.CategoryId = Category.CategoryId;
                        ProductModel.Name = ProductName.ToString();
                        ProductModel.Name = ProductName.Text.ToString();
                        ProductModel.Price = PriceBuff;
                        ProductModel.NumberOfBought = 0;
                        ProductModel.StockStatus = int.Parse(ProductStockStatus.Value.ToString());
                        ProductModel.EmployeeId = Employee.EmployeeId;

                        context.Products.Add(ProductModel);
                        context.SaveChanges();

                        foreach (DataGridViewRow item in ProductParametersTable.Rows)
                        {
                            var Parameter = Parameters.FirstOrDefault(a => a.ParameterName.Equals(item.Cells[1].Value.ToString()));
                            
                            context.Parameters.Add(new Parameter()
                            {
                                ProductId = ProductModel.ProductId,
                                CategoryId = Category.CategoryId,
                                ParameterTypeId = Parameter.ParameterId,
                                Value = item.Cells[2].Value.ToString()
                            });
                        }

                        context.SaveChanges(); // TODO nie działa 
                        this.Close();
                    }
                }
                else MessageBox.Show("Wybierz kategorię i opiekuna produktu!");
            }
            else
            {
                MessageBox.Show("Wypełnij prawidłowo wszystkie pola!");
            }
        }

        private void CloseWindowButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void AddParameterButton_Click(object sender, System.EventArgs e)
        {
            ProductParametersTable.RowCount++;
            SetIndexes();

        }
        private void DeleteParameterButton_Click(object sender, System.EventArgs e)
        {
            var selected = ProductParametersTable.SelectedCells;
            if (selected.Count > 0)
            {
                ProductParametersTable.Rows.RemoveAt(selected[0].RowIndex);
                SetIndexes();
            }
        }
        private void SetIndexes()
        {
            for (var i = 0; i < ProductParametersTable.Rows.Count; i++)
            {
                ProductParametersTable.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
