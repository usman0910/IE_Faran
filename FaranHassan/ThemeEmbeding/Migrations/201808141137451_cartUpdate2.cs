namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartUpdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Carts", new[] { "CustomerId" });
            DropColumn("dbo.Carts", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "CustomerId");
            AddForeignKey("dbo.Carts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
