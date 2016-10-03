namespace SHOP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblGroupProduct", "ParentID", c => c.Int(nullable: false));
            DropColumn("dbo.tblGroupProduct", "idCate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblGroupProduct", "idCate", c => c.Int(nullable: false));
            DropColumn("dbo.tblGroupProduct", "ParentID");
        }
    }
}
