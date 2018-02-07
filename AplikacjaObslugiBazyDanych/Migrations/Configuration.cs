using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Security.Cryptography;
using System.Text;
using AplikacjaObslugiBazyDanych.Code.Enums;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (context.Claims.Count() < 10)
            {
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.AddProducts, ClaimName = "Dodawanie produktów" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.EditProducts, ClaimName = "Edycja produktów" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.RemoveProducts, ClaimName = "Usuwanie produktów" });

                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.AddCustomers, ClaimName = "Dodawanie klientów" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.EditCustomers, ClaimName = "Edycja klientów" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.RemoveCustomers, ClaimName = "Usuwanie klientów" });

                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.PlaceOrders, ClaimName = "Sk³adanie zamówieñ" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.EditOrders, ClaimName = "Edycja zamówieñ" });

                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.AddEmployee, ClaimName = "Dodawanie pracowników" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.EditEmployee, ClaimName = "Edycja pracowników" });
                context.Claims.AddOrUpdate(new Claim() { ClaimId = (int)Claims.RemoveEmployee, ClaimName = "Usuwanie pracowników" });
            }
            if (!context.Roles.Any())
            {
                var adminRole = new Role()
                {
                    RoleId = 0,
                    RoleName = "Administrator"
                };

                context.Roles.AddOrUpdate(adminRole);

                AddClaimsToRole(context, 0, Claims.AddProducts, Claims.EditProducts, Claims.RemoveProducts, Claims.AddCustomers, Claims.EditCustomers, Claims.RemoveCustomers, Claims.PlaceOrders, Claims.EditOrders, Claims.AddEmployee, Claims.EditEmployee, Claims.RemoveEmployee);
            }

            if (!context.Employees.Any())
            {
                var admin = new Employee()
                {
                    UserName = "admin",
                    Password = UserHelper.HashPassword("admin"),
                    Email = "admin@admin.admin",
                    FirstName = "Super",
                    LastName = "Administrator",
                    RoleId = 0,
                    PhoneNumber = "(000) 000-000-000",
                };

                context.Employees.AddOrUpdate(admin);
            }

            context.SaveChanges();
        }

        public static void AddClaimsToRole(DatabaseContext context, int groupId, params Claims[] claims)
        {
            foreach (Claims c in claims)
            {
                context.RolesClaims.AddOrUpdate(new RoleClaim() { RoleId = groupId, ClaimId = (int)c });
            }
        }
    }
}
