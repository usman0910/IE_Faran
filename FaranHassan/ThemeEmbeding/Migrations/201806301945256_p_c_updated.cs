namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p_c_updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Type", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Weight", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "Length", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "Width", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "Height", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "TotalQuantity", c => c.Long(nullable: false));
            DropColumn("dbo.Categories", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Products", "TotalQuantity");
            DropColumn("dbo.Products", "Height");
            DropColumn("dbo.Products", "Width");
            DropColumn("dbo.Products", "Length");
            DropColumn("dbo.Products", "Weight");
            DropColumn("dbo.Categories", "Type");
        }
    }
}
