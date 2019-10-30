namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        BookTime = c.DateTime(nullable: false),
                        Book_bookID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Books", t => t.Book_bookID)
                .Index(t => t.Book_bookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Book_bookID", "dbo.Books");
            DropIndex("dbo.Users", new[] { "Book_bookID" });
            DropTable("dbo.Users");
        }
    }
}
