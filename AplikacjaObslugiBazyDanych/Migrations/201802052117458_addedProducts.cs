namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfBought = c.Int(nullable: false),
                        StockStatus = c.Int(nullable: false),
                        EmployeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
