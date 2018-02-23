using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EditCategoryWindow : Form
    {
        private List<Category> categories;

        public EditCategoryWindow()
        {
            InitializeComponent();

            using (var context = new DatabaseContext())
            {
                categories = context.Categories.ToList();
            }

            var parentCategory = DataTable.Columns[2] as DataGridViewComboBoxColumn;

            parentCategory.Items.Add("brak");
            foreach (var category in categories)
            {
                parentCategory.Items.Add(category.Name);
            }

            UpdateTable();
        }

        private void UpdateTable()
        {
            var count = DataTable.RowCount;
            for (var i = 0; i < count; i++)
            {
                DataTable.Rows.RemoveAt(0);
            }

            using (var context = new DatabaseContext())
            {
                categories = context.Categories.ToList();
            }
            var parentCategory = DataTable.Columns[2] as DataGridViewComboBoxColumn;

            foreach (var category in categories)
            {
                DataTable.RowCount++;
                DataTable.Rows[DataTable.RowCount - 1].Cells[0].Value = category.CategoryId;
                DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = category.Name;
                if (category.Parent != null)
                {
                    DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value =
                        parentCategory.Items[parentCategory.Items.IndexOf(category.Parent.Name)];
                }
                else
                {
                    DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value =
                        parentCategory.Items[parentCategory.Items.IndexOf("brak")];
                }
            }
            UpdateParentsDropdown();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var count = DataTable.RowCount;
            using (var context = new DatabaseContext())
            {
                for (var i = 0; i < count; i++)
                {
                    var parent =
                        categories.FirstOrDefault(a => a.Name.Equals(DataTable.Rows[i].Cells[2].Value));

                    if (parent != null || (DataTable.Rows[i].Cells[2].Value != null && DataTable.Rows[i].Cells[2].Value.ToString() == "brak" && DataTable.Rows[i].Cells[1].Value != null))
                    {
                        var category = new Category()
                        {
                            CategoryId = (int)DataTable.Rows[i].Cells[0].Value,
                            Name = DataTable.Rows[i].Cells[1].Value.ToString(),
                        };


                        if (DataTable.Rows[i].Cells[2].Value.ToString() == "brak")
                        {
                            category.ParentId = null;
                        }
                        else
                        {
                            category.ParentId = parent.CategoryId;
                        }


                        context.Categories.AddOrUpdate(category);
                        context.SaveChanges();
                        UpdateParentsDropdown();
                    }
                }
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            DataTable.RowCount++;

            Category newCategory = new Category()
            {
                Name = "Nowa kategoria",
                ParentId = null,
            };

            using (var context = new DatabaseContext())
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }

            DataTable.Rows[DataTable.RowCount - 1].Cells[0].Value = newCategory.CategoryId;
            DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = "Nowa kategoria";
            DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value = "brak";
            UpdateParentsDropdown();
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            var selected = DataTable.SelectedCells;
            if (selected.Count > 0)
            {
                var categoryId = (int)DataTable.Rows[selected[0].RowIndex].Cells[0].Value;

                using (var context = new DatabaseContext())
                {
                    var category = context.Categories.FirstOrDefault(a => a.CategoryId == categoryId);
                    if (category != null)
                    {
                        if (!context.Products.Any(p => p.CategoryId == category.CategoryId))
                        {
                            if (!context.Categories.Any(p => p.ParentId == category.CategoryId))
                            {
                                context.Categories.Remove(category);
                                context.SaveChanges();
                                UpdateTable();
                                return;
                            }
                        }
                        MessageBox.Show(
                            "Nie można usunąć kategori ponieważ jest powiązana z produktem lub jest kategorią nadrzędną!");
                    }
                }
            }
        }
        private void UpdateParentsDropdown()
        {
            using (var context = new DatabaseContext())
            {
                categories = context.Categories.ToList();
            }
            var parentCategory = DataTable.Columns[2] as DataGridViewComboBoxColumn;
            parentCategory.Items.Clear();

            parentCategory.Items.Add("brak");
            foreach (var category in categories)
            {
                parentCategory.Items.Add(category.Name);
            }
        }
    }
}
