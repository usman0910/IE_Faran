namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartUpdate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Cart_Id", "dbo.Carts");
            DropIndex("dbo.Products", new[] { "Cart_Id" });
            DropColumn("dbo.Products", "Cart_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Cart_Id", c => c.Int());
            CreateIndex("dbo.Products", "Cart_Id");
            AddForeignKey("dbo.Products", "Cart_Id", "dbo.Carts", "Id");
        }
    }
}
