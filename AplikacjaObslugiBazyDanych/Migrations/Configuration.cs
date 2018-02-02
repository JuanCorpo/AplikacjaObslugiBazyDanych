using System.Security.Cryptography;
using System.Text;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AplikacjaObslugiBazyDanych.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AplikacjaObslugiBazyDanych.Models.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var admin = new Employee()
            {
                UserName = "admin",
                Password = Md5Hash("admin"),
                Email = "admin@admin.admin",
                FirstName = "Super",
                LastName = "Administrator",
                RoleId = 0,
                PhoneNumber = "(000) 000-000-000"
            };

            context.Employees.AddOrUpdate(admin);
        }

        public static string Md5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(Encoding.ASCII.GetBytes(text));

            var result = md5.Hash;

            var strBuilder = new StringBuilder();
            foreach (var t in result)
            {
                strBuilder.Append(t.ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
