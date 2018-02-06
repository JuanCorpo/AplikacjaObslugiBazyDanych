namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    CustomerId = c.Int(nullable: false),
                    EmployeeId = c.Int(nullable: false),
                    StatusId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.OrderId);

        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
