namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2TestProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "LastTest", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "LastTest");
        }
    }
}
