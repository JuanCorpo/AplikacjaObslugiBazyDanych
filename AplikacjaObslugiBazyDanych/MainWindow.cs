using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Enums;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;

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
            var width = panel2.Width / 4;
            var height = panel2.Height / 4;

            int positionX = 0, positionY = 0;
            var count = 1;

            buttons.Select(a =>
            {
                a.Width = width;
                a.Height = height;

                a.Location = new Point(positionX,positionY);

                positionX += width;
                if (count % 4 == 0)
                {
                    positionY += height;
                    positionX = 0;
                }

                count++;

                return a;
            }).ToList();
        }
    }
}
