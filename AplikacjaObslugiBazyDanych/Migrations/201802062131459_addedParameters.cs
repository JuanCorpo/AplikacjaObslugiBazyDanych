namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedParameters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        ParameterId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ParameterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parameters");
        }
    }
}
