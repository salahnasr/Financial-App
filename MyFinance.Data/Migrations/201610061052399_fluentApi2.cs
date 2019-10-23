namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fluentApi2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories’");
            RenameTable(name: "dbo.ProviderProducts", newName: "Product_Provider");
            RenameColumn(table: "dbo.Product_Provider", name: "Provider_Id", newName: "ProviderId");
            RenameColumn(table: "dbo.Product_Provider", name: "Product_ProductId", newName: "ProductId");
            RenameIndex(table: "dbo.Product_Provider", name: "IX_Product_ProductId", newName: "IX_ProductId");
            RenameIndex(table: "dbo.Product_Provider", name: "IX_Provider_Id", newName: "IX_ProviderId");
            DropPrimaryKey("dbo.Product_Provider");
            AddColumn("dbo.Products", "isBio", c => c.Int());
            AlterColumn("dbo.MyCategories’", "Name", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Product_Provider", new[] { "ProductId", "ProviderId" });
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Product_Provider");
            AlterColumn("dbo.MyCategories’", "Name", c => c.String());
            DropColumn("dbo.Products", "isBio");
            AddPrimaryKey("dbo.Product_Provider", new[] { "Provider_Id", "Product_ProductId" });
            RenameIndex(table: "dbo.Product_Provider", name: "IX_ProviderId", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Product_Provider", name: "IX_ProductId", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Product_Provider", name: "ProductId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Product_Provider", name: "ProviderId", newName: "Provider_Id");
            RenameTable(name: "dbo.Product_Provider", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories’", newName: "Categories");
        }
    }
}
