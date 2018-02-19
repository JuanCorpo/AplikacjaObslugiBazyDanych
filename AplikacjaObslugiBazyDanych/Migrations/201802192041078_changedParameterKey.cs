namespace AplikacjaObslugiBazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedParameterKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parameters", "ParameterId", "dbo.ParameterTypes");
            DropIndex("dbo.Parameters", new[] { "ParameterId" });
            DropPrimaryKey("dbo.Parameters");
            AddColumn("dbo.Parameters", "ParameterTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parameters", "ParameterId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Parameters", "ParameterId");
            CreateIndex("dbo.Parameters", "ParameterTypeId");
            AddForeignKey("dbo.Parameters", "ParameterTypeId", "dbo.ParameterTypes", "ParameterId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parameters", "ParameterTypeId", "dbo.ParameterTypes");
            DropIndex("dbo.Parameters", new[] { "ParameterTypeId" });
            DropPrimaryKey("dbo.Parameters");
            AlterColumn("dbo.Parameters", "ParameterId", c => c.Int(nullable: false));
            DropColumn("dbo.Parameters", "ParameterTypeId");
            AddPrimaryKey("dbo.Parameters", "ParameterId");
            CreateIndex("dbo.Parameters", "ParameterId");
            AddForeignKey("dbo.Parameters", "ParameterId", "dbo.ParameterTypes", "ParameterId");
        }
    }
}
