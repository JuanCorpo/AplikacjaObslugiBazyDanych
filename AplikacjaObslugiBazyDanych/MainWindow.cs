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
        private List<Button> buttons;

        public MainWindow()
        {
            InitializeComponent();

            RoleName.Text = UserHelper.Employee.Role?.RoleName?? "brak grupy";
            UserName.Text = UserHelper.Employee.GetFullName();

            buttons = new List<Button>()
            {
                AddProduct,AddClient,AddOrder,AddEmployee,
                EditClient,EditProduct,
                DeleteClient,DeleteProduct,
                EditParametersTypes,EditStatuses,EditCategories,EditRole
            };
            ValidateRights();
        }

        private void ValidateRights()
        {
            // TODO !!
            // TODO Aktualizować uprawnienia pracownika
            // TODO !!
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
            
            if (!UserHelper.IsInClaim(Claims.EditCustomers))
            {
                EditClient.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditProducts))
            {
                EditProduct.Enabled = false;
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

            if (!UserHelper.IsInClaim(Claims.EditEmployee) && !UserHelper.IsInClaim(Claims.RemoveEmployee))
            {
                EditRemoveEmployee.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditOrders) && !UserHelper.IsInClaim(Claims.RemoveOrders))
            {
                EditRemoveOrder.Enabled = false;
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
            window.ShowDialog();
            ValidateRights();
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            var window = new EditProductWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            var window = new DeleteProductWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var window = new AddCustomerWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            var window = new EditCustomerWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            var window = new DeleteCustomerWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            var window = new AddOrderWindow();
            window.ShowDialog();
            ValidateRights();
        }
        
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var window = new AddEmployeeWindow();
            window.ShowDialog();
            ValidateRights();
        }
        
        private void EditRole_Click(object sender, EventArgs e)
        {
            var window = new EditRoleWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void EditCategories_Click(object sender, EventArgs e)
        {
            var window = new EditCategoryWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void EditStatuses_Click(object sender, EventArgs e)
        {
            var window = new EditStatusWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void EditParametersTypes_Click(object sender, EventArgs e)
        {
            var window = new EditParametersWindow();
            window.ShowDialog();
            ValidateRights();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            UserHelper.Employee = null;
            UserHelper.LoggedIn = false;
            UserHelper.Claims.Clear();
            this.Close();
        }

        private void EditRemoveEmployee_Click(object sender, EventArgs e)
        {
            var window = new EmployeeListWindow();
            window.ShowDialog();
            ValidateRights();
        }

        private void EditRemoveOrder_Click(object sender, EventArgs e)
        {
            var window = new OrderListWindow();
            window.ShowDialog();
            ValidateRights();
        }
    }
}
