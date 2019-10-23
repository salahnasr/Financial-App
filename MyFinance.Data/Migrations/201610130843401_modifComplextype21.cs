namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifComplextype21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Adresse_StreetAddress", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Adresse_StreetAddress", c => c.String());
        }
    }
}
