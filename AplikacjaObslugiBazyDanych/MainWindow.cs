using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Enums;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;
using AplikacjaObslugiBazyDanych.Views;

namespace AplikacjaObslugiBazyDanych
{
    public partial class MainWindow : Form
    {
        private DatabaseContext context = new DatabaseContext();
        private List<Button> buttons;

        public MainWindow()
        {
            InitializeComponent();

            RoleName.Text = UserHelper.Employee.Role.RoleName;
            UserName.Text = UserHelper.Employee.GetFullName();

            buttons = new List<Button>()
            {
                AddProduct,AddClient,AddOrder,AddEmployee,
                EditEmployee,EditOrder,EditClient,EditProduct,
                DeleteEmployee,DeleteOrder,DeleteClient,DeleteProduct,
                EditParametersTypes,EditStatuses,EditCategories,EditRole
            };

            if (!UserHelper.IsInClaim(Claims.AddProducts))
            {
                AddProduct.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.AddCustomers))
            {
                AddClient.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.PlaceOrders))
            {
                AddOrder.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.AddEmployee))
            {
                AddEmployee.Enabled = false;
            }

            if (!UserHelper.IsInClaim(Claims.EditEmployee))
            {
                EditEmployee.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditOrders))
            {
                EditOrder.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditCustomers))
            {
                EditClient.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditProducts))
            {
                EditProduct.Enabled = false;
            }

            if (!UserHelper.IsInClaim(Claims.RemoveEmployee))
            {
                DeleteEmployee.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.RemoveOrders))
            {
                DeleteOrder.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.RemoveCustomers))
            {
                DeleteClient.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.RemoveProducts))
            {
                DeleteProduct.Enabled = false;
            }

            if (!UserHelper.IsInClaim(Claims.EditParameterTypes))
            {
                EditParametersTypes.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditStatuses))
            {
                EditStatuses.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditCategories))
            {
                EditCategories.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditRoles))
            {
                EditRole.Enabled = false;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            var width = (panel2.Width - 24) / 4;
            var height = (panel2.Height - 24) / 4;

            int positionX = 3, positionY = 3;
            var count = 1;

            buttons.Select(a =>
            {
                a.Width = width;
                a.Height = height;

                a.Location = new Point(positionX, positionY);

                positionX += width + 6;
                if (count % 4 == 0)
                {
                    positionY += height + 6;
                    positionX = 3;
                }

                count++;

                return a;
            }).ToList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var window = new AddProductWindow();
            window.Show();
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            var window = new EditProductWindow();
            window.Show();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            var window = new DeleteProductWindow();
            window.Show();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var window = new AddCustomerWindow();
            window.Show();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            var window = new EditCustomerWindow();
            window.Show();
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            var window = new DeleteCustomerWindow();
            window.Show();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            var window = new AddOrderWindow();
            window.Show();
        }

        private void EditOrder_Click(object sender, EventArgs e)
        {
            var window = new EditOrderWindow();
            window.Show();
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            var window = new DeleteOrderWindow();
            window.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var window = new AddEmployeeWindow();
            window.Show();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            var window = new EditEmployeeWindow();
            window.Show();
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            var window = new DeleteEmployeeWindow();
            window.Show();
        }

        private void EditRole_Click(object sender, EventArgs e)
        {
            var window = new EditRoleWindow();
            window.Show();
        }

        private void EditCategories_Click(object sender, EventArgs e)
        {
            var window = new EditCategoryWindow();
            window.Show();
        }

        private void EditStatuses_Click(object sender, EventArgs e)
        {
            var window = new EditStatusWindow();
            window.Show();
        }

        private void EditParametersTypes_Click(object sender, EventArgs e)
        {
            var window = new EditParametersWindow();
            window.ShowDialog();
            
        }
    }
}
