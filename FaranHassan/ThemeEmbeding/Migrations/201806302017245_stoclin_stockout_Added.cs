namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stoclin_stockout_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TotalCost = c.Long(nullable: false),
                        UnitCost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockOuts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TotalPrice = c.Long(nullable: false),
                        UnitPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockOuts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.StockIns", "ProductId", "dbo.Products");
            DropIndex("dbo.StockOuts", new[] { "ProductId" });
            DropIndex("dbo.StockIns", new[] { "ProductId" });
            DropTable("dbo.StockOuts");
            DropTable("dbo.StockIns");
        }
    }
}
