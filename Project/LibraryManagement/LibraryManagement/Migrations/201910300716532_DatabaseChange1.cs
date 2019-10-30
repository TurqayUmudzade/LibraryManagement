namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseChange1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managements",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        BookReturnDate = c.DateTime(nullable: false),
                        Username_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Users", t => t.Username_UserID, cascadeDelete: true)
                .Index(t => t.Username_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managements", "Username_UserID", "dbo.Users");
            DropIndex("dbo.Managements", new[] { "Username_UserID" });
            DropTable("dbo.Managements");
        }
    }
}
