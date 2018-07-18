namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderList_OrderStatus_Customer_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "OrderList_Id", c => c.Int());
            CreateIndex("dbo.Products", "OrderList_Id");
            AddForeignKey("dbo.Products", "OrderList_Id", "dbo.OrderLists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "OrderList_Id", "dbo.OrderLists");
            DropForeignKey("dbo.OrderLists", "OrderStatusId", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderLists", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "OrderList_Id" });
            DropIndex("dbo.OrderLists", new[] { "OrderStatusId" });
            DropIndex("dbo.OrderLists", new[] { "CustomerId" });
            DropColumn("dbo.Products", "OrderList_Id");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.OrderLists");
            DropTable("dbo.Customers");
        }
    }
}
