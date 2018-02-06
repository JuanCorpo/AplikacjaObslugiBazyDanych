namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedParametersTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParameterTypes",
                c => new
                    {
                        ParameterId = c.Int(nullable: false, identity: true),
                        ParameterName = c.String(),
                        ValueType = c.String(),
                    })
                .PrimaryKey(t => t.ParameterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParameterTypes");
        }
    }
}
