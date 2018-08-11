namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "OverView", c => c.String());
            AddColumn("dbo.Products", "AdditionalInfo", c => c.String());
            AddColumn("dbo.Products", "VideoLink", c => c.String());
            AddColumn("dbo.Products", "Price", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "VideoLink");
            DropColumn("dbo.Products", "AdditionalInfo");
            DropColumn("dbo.Products", "OverView");
        }
    }
}
