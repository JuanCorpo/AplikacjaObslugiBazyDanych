namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNullabeEmployeeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "RoleId" });
            AlterColumn("dbo.Employees", "RoleId", c => c.Int());
            CreateIndex("dbo.Employees", "RoleId");
            AddForeignKey("dbo.Employees", "RoleId", "dbo.Roles", "RoleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "RoleId" });
            AlterColumn("dbo.Employees", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "RoleId");
            AddForeignKey("dbo.Employees", "RoleId", "dbo.Roles", "RoleId", cascadeDelete: true);
        }
    }
}
