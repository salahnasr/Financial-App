namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1TestProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BestTest", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BestTest");
        }
    }
}
