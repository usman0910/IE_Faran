namespace ThemeEmbeding.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class brandsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Brands", "CategoryId");
            AddForeignKey("dbo.Brands", "CategoryId", "dbo.Categories", "Id", cascadeDelete: false);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Brands", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Brands", new[] { "CategoryId" });
            DropColumn("dbo.Brands", "CategoryId");
        }
    }
}
