namespace ThemeEmbeding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandaDDED : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Products", "Brand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Brand", c => c.String());
            DropTable("dbo.Brands");
        }
    }
}
