namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchaes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        Money = c.Single(nullable: false),
                        BookReturnededDate = c.DateTime(nullable: false),
                        Management_OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.Managements", t => t.Management_OrderID, cascadeDelete: true)
                .Index(t => t.Management_OrderID);
            
            DropColumn("dbo.Managements", "Money");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managements", "Money", c => c.Single(nullable: false));
            DropForeignKey("dbo.Purchases", "Management_OrderID", "dbo.Managements");
            DropIndex("dbo.Purchases", new[] { "Management_OrderID" });
            DropTable("dbo.Purchases");
        }
    }
}
