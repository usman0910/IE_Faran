namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartUpdate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CartId", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "CartId" });
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CartDetails", c => c.String());
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "CartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "CartId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropColumn("dbo.Orders", "Date");
            DropColumn("dbo.Orders", "CartDetails");
            DropColumn("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "CartId");
            AddForeignKey("dbo.Orders", "CartId", "dbo.Carts", "Id", cascadeDelete: true);
        }
    }
}
