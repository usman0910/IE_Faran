namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandRelationaDDED : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropColumn("dbo.Products", "BrandId");
        }
    }
}
