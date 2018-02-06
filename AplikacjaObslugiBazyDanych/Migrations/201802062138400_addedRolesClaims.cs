namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRolesClaims : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoleClaims",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        ClaimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.ClaimId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoleClaims");
        }
    }
}
