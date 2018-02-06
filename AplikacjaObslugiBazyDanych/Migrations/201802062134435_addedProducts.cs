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
                        ProductId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfBought = c.Int(nullable: false),
                        StockStatus = c.Int(nullable: false),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
