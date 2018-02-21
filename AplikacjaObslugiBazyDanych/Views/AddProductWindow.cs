using AplikacjaObslugiBazyDanych.CustomClasses;
using AplikacjaObslugiBazyDanych.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class AddProductWindow : Form
    {
        List<Category> Categories;
        List<Employee> Employees;
        List<ParameterType> Parameters;
        List<int> ParametersToDelete;

        public AddProductWindow(Product product = null)
        {

            InitializeComponent();
            ParametersToDelete = new List<int>();
            using (var context = new DatabaseContext())
            {
                Categories = context.Categories.ToList();
                Employees = context.Employees.ToList();
                Parameters = context.ParametersTypes.ToList();

                foreach (var item in Categories)
                {
                    ProductCategory.Items.Add(new CustomComboBox()
                    {
                        Id = item.CategoryId,
                        Value = item.Name
                    });
                }
                foreach (var item in Employees)
                {
                    ProductEmployee.Items.Add(new CustomComboBox()
                    {
                        Id = item.EmployeeId,
                        Value = item.GetFullName()
                    });
                }

                var column = ProductParametersTable.Columns[1] as DataGridViewComboBoxColumn;
                foreach (var item in Parameters)
                {
                    column.Items.Add(item.ParameterName);
                }
                //var column = ProductParametersTable.Columns[1] as DataGridViewComboBoxColumn;
                //foreach (var item in Parameters)
                //{
                //    column.Items.Add(new CustomComboBox()
                //    {
                //        Id = item.ParameterId,
                //        Value = item.ParameterName
                //    });
                //}
                if (product != null)
                {
                    ProductId.Text = product.ProductId.ToString();

                    var Category = context.Categories.FirstOrDefault(a => a.CategoryId == product.CategoryId);
                    foreach (var item in ProductCategory.Items)
                    {
                        if ((item as CustomComboBox).Id == Category.CategoryId)
                        {
                            ProductCategory.SelectedItem = item;
                            break;
                        }
                    }

                    ProductName.Text = product.Name;

                    ProductPrice.Text = product.Price.ToString();

                    ProductStockStatus.Value = product.StockStatus;

                    var Employee = context.Employees.FirstOrDefault(a => a.EmployeeId == product.EmployeeId);
                    foreach (var item in ProductEmployee.Items)
                    {
                        if ((item as CustomComboBox).Id == Employee.EmployeeId)
                        {
                            ProductEmployee.SelectedItem = item;
                            break;
                        }
                    }

                    var ParametersList = context.Parameters.Where(a => a.ProductId == product.ProductId).ToList();


                    foreach (var item in ParametersList)
                    {
                        var BuffParameterType = context.ParametersTypes.FirstOrDefault(a => a.ParameterId == item.ParameterTypeId);
                        ProductParametersTable.RowCount++;
                        SetIndexes();
                        ProductParametersTable.Rows[ProductParametersTable.RowCount - 1].Cells[1].Value = BuffParameterType.ParameterName;
                        ProductParametersTable.Rows[ProductParametersTable.RowCount - 1].Cells[2].Value = item.Value;
                        ProductParametersTable.Rows[ProductParametersTable.RowCount - 1].Cells[3].Value = item.ParameterId;
                    }
                }
            }
        }
        private void AddProductButton_Click(object sender, System.EventArgs e)
        {
            var ProductModel = new Product();
            var ParametersModel = new List<Parameter>();

            decimal PriceBuff;
            if (decimal.TryParse(ProductPrice.Text, out PriceBuff)) // TODO przetestować czy działczy
            {
                var SelectedCategory = ProductCategory.SelectedItem;
                var SelectedEmployee = ProductEmployee.SelectedItem;
                if (SelectedCategory != null && SelectedEmployee != null)
                {
                    using (var context = new DatabaseContext())
                    {
                        string CategoryNameBuff = SelectedCategory.ToString();
                        string EmployeeNameBuff = SelectedEmployee.ToString();
                        var Category = context.Categories.SingleOrDefault(c => c.Name.Equals(CategoryNameBuff));
                        var Employee = context.Employees.SingleOrDefault(em => (em.FirstName + " " + em.LastName).Equals(EmployeeNameBuff));
                        if (!string.IsNullOrEmpty(ProductId.Text))
                        {
                            ProductModel.ProductId = int.Parse(ProductId.Text);
                        }
                        ProductModel.CategoryId = Category.CategoryId;
                        ProductModel.Name = ProductName.ToString();
                        ProductModel.Name = ProductName.Text.ToString();
                        ProductModel.Price = PriceBuff;
                        ProductModel.NumberOfBought = 0;
                        ProductModel.StockStatus = int.Parse(ProductStockStatus.Value.ToString());
                        ProductModel.EmployeeId = Employee.EmployeeId;

                        context.Products.AddOrUpdate(ProductModel);
                        context.SaveChanges();
                        foreach (var item in ParametersToDelete)
                        {
                            var ParameterModelToDelete = context.Parameters.SingleOrDefault(a => a.ParameterId == item);
                            context.Parameters.Remove(ParameterModelToDelete);
                        }
                        foreach (DataGridViewRow item in ProductParametersTable.Rows)
                        {
                            if (item.Cells[1].Value != null && item.Cells[2].Value != null)
                            {
                                var Parameter = Parameters.FirstOrDefault(a => a.ParameterName.Equals(item.Cells[1].Value.ToString()));

                                if (item.Cells[3].Value != null)
                                {
                                    context.Parameters.AddOrUpdate(new Parameter()
                                    {
                                        ParameterId = int.Parse(item.Cells[3].Value.ToString()),
                                        ProductId = ProductModel.ProductId,
                                        CategoryId = Category.CategoryId,
                                        ParameterTypeId = Parameter.ParameterId,
                                        Value = item.Cells[2].Value.ToString()
                                    });
                                }
                                else
                                {
                                    context.Parameters.AddOrUpdate(new Parameter()
                                    {
                                        ProductId = ProductModel.ProductId,
                                        CategoryId = Category.CategoryId,
                                        ParameterTypeId = Parameter.ParameterId,
                                        Value = item.Cells[2].Value.ToString()
                                    });
                                }
                            }
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
                int IdBuff = selected[0].RowIndex;
                ParametersToDelete.Add(int.Parse(ProductParametersTable.Rows[IdBuff].Cells[3].Value.ToString()));
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
