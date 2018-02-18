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
        DatabaseContext context = new DatabaseContext();
        private List<Category> categories;

        public EditCategoryWindow()
        {
            InitializeComponent();

            categories = context.Categories.ToList();

            var parentCategory = DataTable.Columns[2] as DataGridViewComboBoxColumn;

            parentCategory.Items.Add("brak");
            foreach (var category in categories)
            {
                parentCategory.Items.Add(category.Name);
            }

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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var count = DataTable.RowCount;
            for (var i = 0; i < count; i++)
            {
                var parent =
                    categories.FirstOrDefault(a => a.Name.Equals(DataTable.Rows[i].Cells[2].Value));

                if (parent != null || (DataTable.Rows[i].Cells[2].Value != null && DataTable.Rows[i].Cells[2].Value.ToString() == "brak"))
                {
                    var category = new Category()
                    {
                        CategoryId = (int) DataTable.Rows[i].Cells[0].Value,
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

            context.Categories.Add(newCategory);
            context.SaveChanges();

            DataTable.Rows[DataTable.RowCount - 1].Cells[0].Value = newCategory.CategoryId;
            DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = "Nowa kategoria";
        }
    }
}
