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
using AplikacjaObslugiBazyDanych.Code.Enums;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EmployeeListWindow : Form
    {
        private List<Employee> employeesList;

        public EmployeeListWindow()
        {
            InitializeComponent();
            employeesList = new List<Employee>();
            UpdateTable();

            if (!UserHelper.IsInClaim(Claims.EditCategories))
            {
                Edit.Enabled = false;
            }
            if (!UserHelper.IsInClaim(Claims.EditRoles))
            {
                Delete.Enabled = false;
            }

        }

        private void UpdateTable()
        {
            using (var context = new DatabaseContext())
            {
                employeesList = context.Employees.Include(a => a.Role).ToList();
                DataTable.DataSource = employeesList;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count > 0)
            {
                var rowId = DataTable.SelectedCells[0].RowIndex;

                var employeeId = (int)DataTable.Rows[rowId].Cells[0].Value;
                var employee = employeesList.FirstOrDefault(a => a.EmployeeId == employeeId);

                var window = new AddEmployeeWindow(employee);
                window.ShowDialog();
                UpdateTable();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DataTable.SelectedCells.Count <= 0) return;

            using (var context = new DatabaseContext())
            {
                var rowId = DataTable.SelectedCells[0].RowIndex;
                var employeeId = (int)DataTable.Rows[rowId].Cells[0].Value;
                var employee = context.Employees.SingleOrDefault(a => a.EmployeeId == employeeId);

                if (employee == null) return;

                context.Employees.Remove(employee);
                context.SaveChanges();
                UpdateTable();
            }
        }
    }
}
