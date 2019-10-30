namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseChange21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managements", "Money", c => c.Single(nullable: false));
            AddColumn("dbo.Managements", "Book_bookID", c => c.Int(nullable: false));
            CreateIndex("dbo.Managements", "Book_bookID");
            AddForeignKey("dbo.Managements", "Book_bookID", "dbo.Books", "bookID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managements", "Book_bookID", "dbo.Books");
            DropIndex("dbo.Managements", new[] { "Book_bookID" });
            DropColumn("dbo.Managements", "Book_bookID");
            DropColumn("dbo.Managements", "Money");
        }
    }
}
