using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class DatabaseContext : DbContext
    {
        //public DbSet<Employees> Employees { get; set; }

        public DatabaseContext() : base("name=DatabaseContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
