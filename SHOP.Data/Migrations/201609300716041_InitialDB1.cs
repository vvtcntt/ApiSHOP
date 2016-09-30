namespace SHOP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblProduct", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.tblProduct", "PriceSale", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblProduct", "PriceSale", c => c.Single(nullable: false));
            AlterColumn("dbo.tblProduct", "Price", c => c.Single(nullable: false));
        }
    }
}
