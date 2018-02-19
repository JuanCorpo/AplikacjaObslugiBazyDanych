using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EditRoleWindow : Form
    {
        private List<Role> roles;
        private List<Claim> allClaims;
        private List<RoleClaim> claims;
        private List<Employee> allEmployees;

        public EditRoleWindow()
        {
            InitializeComponent();

            RevokeEmployeeRole.Enabled = false;
            AddEmployeeToRole.Enabled = false;
            EmployeesList.Enabled = false;
            AddClaimToRole.Enabled = false;
            RevokeRoleClaim.Enabled = false;

            using (var context = new DatabaseContext())
            {
                allClaims = context.Claims.ToList();
                allEmployees = context.Employees.ToList();
            }

            UpdateRolesTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = ((DataGridView)sender).SelectedCells[0].RowIndex;

            var roleId = (int)((DataGridView)sender).Rows[id].Cells[1].Value;

            UpdateRolesClaimsTable(roleId);
            UpdateFreeRoleClaims(roleId);
            UpdateEmployeesList(roleId);

            AddEmployeeToRole.Enabled = true;
            EmployeesList.Enabled = true;
            RevokeEmployeeRole.Enabled = false;
        }

        private void RoleClaims_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RevokeRoleClaim.Enabled = true;
        }

        private void RevokeRoleClaim_Click(object sender, EventArgs e)
        {
            if (RoleClaims.SelectedCells.Count > 0)
            {
                var claimRowId = RoleClaims.SelectedCells[0].RowIndex;
                var claimId = (int)RoleClaims.Rows[claimRowId].Cells[1].Value;

                var roleRowId = RoleTable.SelectedCells[0].RowIndex;
                var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

                using (var context = new DatabaseContext())
                {
                    var entry = context.RolesClaims.SingleOrDefault(a => a.RoleId == roleId && a.ClaimId == claimId);
                    if (entry != null)
                    {
                        context.RolesClaims.Remove(entry);
                        context.SaveChanges();
                        UpdateRolesClaimsTable(roleId);
                        UpdateFreeRoleClaims(roleId);
                    }
                }
            }
        }

        private void AddClaimToRole_Click(object sender, EventArgs e)
        {
            if (ExcludedRoleClaims.SelectedCells.Count > 0)
            {
                var claimRowId = ExcludedRoleClaims.SelectedCells[0].RowIndex;
                var claimId = (int)ExcludedRoleClaims.Rows[claimRowId].Cells[1].Value;

                var roleRowId = RoleTable.SelectedCells[0].RowIndex;
                var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

                var newEntry = new RoleClaim()
                {
                    ClaimId = claimId,
                    RoleId = roleId
                };

                using (var context = new DatabaseContext())
                {
                    context.RolesClaims.Add(newEntry);
                    context.SaveChanges();
                }
                UpdateRolesClaimsTable(roleId);
                UpdateFreeRoleClaims(roleId);
            }
        }

        private void ExcludedRoleClaims_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddClaimToRole.Enabled = true;
        }

        private void UpdateRolesClaimsTable(int roleId)
        {
            ClearTable(RoleClaims);

            using (var context = new DatabaseContext())
            {
                claims = context.RolesClaims.Where(a => a.RoleId == roleId).ToList();


                foreach (var claim in claims)
                {
                    RoleClaims.RowCount++;
                    RoleClaims.Rows[RoleClaims.RowCount - 1].Cells[0].Value = claim.Claim.ClaimName;
                    RoleClaims.Rows[RoleClaims.RowCount - 1].Cells[1].Value = claim.ClaimId;
                }

            }
        }

        private void UpdateFreeRoleClaims(int roleId)
        {
            ClearTable(ExcludedRoleClaims);

            var free = allClaims.Where(a => claims.All(b => b.ClaimId != a.ClaimId)).ToList();

            foreach (var claim in free)
            {
                ExcludedRoleClaims.RowCount++;
                ExcludedRoleClaims.Rows[ExcludedRoleClaims.RowCount - 1].Cells[0].Value = claim.ClaimName;
                ExcludedRoleClaims.Rows[ExcludedRoleClaims.RowCount - 1].Cells[1].Value = claim.ClaimId;
            }
        }

        private void UpdateEmployeesList(int roleId)
        {
            using (var context = new DatabaseContext())
            {
                List<Employee> employees;

                employees = context.Employees.Where(a => a.RoleId == roleId).ToList();

                EmployeesList.Items.Clear();
                var notAssigned = allEmployees.Where(a => employees.All(b => b.EmployeeId != a.EmployeeId && a.RoleId == null)).ToList();
                EmployeesList.Items.AddRange(notAssigned.Select(a => a.GetFullName()).ToArray());

                ClearTable(EmployeesTable);

                foreach (var emp in employees)
                {
                    EmployeesTable.RowCount++;
                    EmployeesTable.Rows[EmployeesTable.RowCount - 1].Cells[0].Value = emp.GetFullName();
                    EmployeesTable.Rows[EmployeesTable.RowCount - 1].Cells[1].Value = emp.EmployeeId;
                }
            }
        }

        private void UpdateRolesTable()
        {
            using (var context = new DatabaseContext())
            {
                roles = context.Roles.ToList();
            }
            ClearTable(RoleTable);

            foreach (var role in roles)
            {
                RoleTable.RowCount++;
                RoleTable.Rows[RoleTable.RowCount - 1].Cells[0].Value = role.RoleName;
                RoleTable.Rows[RoleTable.RowCount - 1].Cells[1].Value = role.RoleId;
            }
        }

        private void ClearTable(DataGridView table)
        {
            var count = table.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                table.Rows.RemoveAt(0);
            }
        }

        private void AddRole_Click(object sender, EventArgs e)
        {
            RoleTable.RowCount++;
            RoleTable.Rows[RoleTable.RowCount - 1].Cells[0].Value = "Nowa grupa";
            RoleTable.Rows[RoleTable.RowCount - 1].Cells[1].Value = -1;

            roles.Add(new Role()
            {
                RoleName = "Nowa grupa",
                RoleId = -1
            });

            using (var context = new DatabaseContext())
            {
                context.Roles.Add(new Role()
                {
                    RoleName = "Nowa grupa"
                });

                context.SaveChanges();
            }
            UpdateRolesTable();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var count = RoleTable.Rows.Count;
                for (var i = 0; i < count; i++)
                {
                    var roleName = RoleTable.Rows[i].Cells[0].Value.ToString();
                    var roleId = (int)RoleTable.Rows[i].Cells[1].Value;

                    context.Roles.AddOrUpdate(new Role()
                    {
                        RoleId = roleId,
                        RoleName = roleName
                    });
                }
                context.SaveChanges();
            }
        }

        private void RemoveRole_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var roleRowId = RoleTable.SelectedCells[0].RowIndex;
                var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

                var employees = context.Employees.Where(a => a.RoleId == roleId).ToList();

                if (employees.Count == 0)
                {

                    var role = context.Roles.Single(a => a.RoleId == roleId);
                    context.Roles.Remove(role);

                    var roleClaims = context.RolesClaims.Where(a => a.RoleId == roleId).ToList();
                    context.RolesClaims.RemoveRange(roleClaims);

                    context.SaveChanges();
                    UpdateWindow();
                }
                else
                {
                    MessageBox.Show("Nie można usunąć grupy do której są przypisani użytkownicy!", "Błąd");
                }
            }
        }

        private void UpdateWindow()
        {
            UpdateRolesTable();

            var roleRowId = RoleTable.SelectedCells[0].RowIndex;
            var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

            UpdateRolesClaimsTable(roleId);
            UpdateFreeRoleClaims(roleId);
            UpdateEmployeesList(roleId);
        }

        private void EmployeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RevokeEmployeeRole.Enabled = true;
        }

        private void RevokeEmployeeRole_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var rowIndex = EmployeesTable.SelectedCells[0].RowIndex;
                var employeeId = (int)EmployeesTable.Rows[rowIndex].Cells[1].Value;

                var employee = context.Employees.FirstOrDefault(a => a.EmployeeId == employeeId);
                if (employee != null)
                {
                    employee.RoleId = null;
                    context.SaveChanges();

                    var roleRowId = RoleTable.SelectedCells[0].RowIndex;
                    var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

                    UpdateEmployeesList(roleId);
                }
            }
        }

        private void AddEmployeeToRole_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var selectedToAdd = EmployeesList.SelectedItem;

                if (selectedToAdd != null)
                {
                    var employee =
                        context.Employees.SingleOrDefault(a =>
                            (a.FirstName + " " + a.LastName).Equals(selectedToAdd.ToString()));

                    if (employee != null)
                    {
                        var roleRowId = RoleTable.SelectedCells[0].RowIndex;
                        var roleId = (int)RoleTable.Rows[roleRowId].Cells[1].Value;

                        employee.RoleId = roleId;

                        context.Employees.AddOrUpdate(employee);
                        context.SaveChanges();

                        UpdateEmployeesList(roleId);
                    }
                }
            }
        }
    }
}
