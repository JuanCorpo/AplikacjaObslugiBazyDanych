namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_InitRelations : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Parameters");
            AlterColumn("dbo.Categories", "ParentId", c => c.Int());
            AlterColumn("dbo.Employees", "RoleId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parameters", "ParameterId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parameters", "ProductId", c => c.Int());
            AlterColumn("dbo.Parameters", "CategoryId", c => c.Int());
            AddPrimaryKey("dbo.Parameters", "ParameterId");
            CreateIndex("dbo.Categories", "ParentId");
            CreateIndex("dbo.Employees", "RoleId");
            CreateIndex("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "StatusId");
            CreateIndex("dbo.OrderDetails", "OrderId");
            CreateIndex("dbo.OrderDetails", "ProductId");
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "EmployeeId");
            CreateIndex("dbo.Parameters", "ParameterId");
            CreateIndex("dbo.Parameters", "ProductId");
            CreateIndex("dbo.Parameters", "CategoryId");
            CreateIndex("dbo.RoleClaims", "RoleId");
            CreateIndex("dbo.RoleClaims", "ClaimId");
            AddForeignKey("dbo.Categories", "ParentId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Employees", "RoleId", "dbo.Roles", "RoleId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.Parameters", "CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Parameters", "ParameterId", "dbo.ParameterTypes", "ParameterId");
            AddForeignKey("dbo.Parameters", "ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.RoleClaims", "ClaimId", "dbo.Claims", "ClaimId", cascadeDelete: true);
            AddForeignKey("dbo.RoleClaims", "RoleId", "dbo.Roles", "RoleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleClaims", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RoleClaims", "ClaimId", "dbo.Claims");
            DropForeignKey("dbo.Parameters", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Parameters", "ParameterId", "dbo.ParameterTypes");
            DropForeignKey("dbo.Parameters", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropIndex("dbo.RoleClaims", new[] { "ClaimId" });
            DropIndex("dbo.RoleClaims", new[] { "RoleId" });
            DropIndex("dbo.Parameters", new[] { "CategoryId" });
            DropIndex("dbo.Parameters", new[] { "ProductId" });
            DropIndex("dbo.Parameters", new[] { "ParameterId" });
            DropIndex("dbo.Products", new[] { "EmployeeId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropPrimaryKey("dbo.Parameters");
            AlterColumn("dbo.Parameters", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parameters", "ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parameters", "ParameterId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Employees", "RoleId", c => c.Int());
            AlterColumn("dbo.Categories", "ParentId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Parameters", "ParameterId");
        }
    }
}
