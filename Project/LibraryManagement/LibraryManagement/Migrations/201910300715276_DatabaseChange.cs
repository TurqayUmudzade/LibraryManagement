namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Book_bookID", "dbo.Books");
            DropIndex("dbo.Users", new[] { "Book_bookID" });
            AddColumn("dbo.Books", "bookPrice", c => c.Single(nullable: false));
            DropColumn("dbo.Users", "BookReturnDate");
            DropColumn("dbo.Users", "Book_bookID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Book_bookID", c => c.Int());
            AddColumn("dbo.Users", "BookReturnDate", c => c.DateTime());
            DropColumn("dbo.Books", "bookPrice");
            CreateIndex("dbo.Users", "Book_bookID");
            AddForeignKey("dbo.Users", "Book_bookID", "dbo.Books", "bookID");
        }
    }
}
