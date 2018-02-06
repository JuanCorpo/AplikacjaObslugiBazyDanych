namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClaims : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ClaimId = c.Int(nullable: false, identity: true),
                        ClaimName = c.String(),
                    })
                .PrimaryKey(t => t.ClaimId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Claims");
        }
    }
}
