namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Books : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        bookID = c.Int(nullable: false, identity: true),
                        bookName = c.String(nullable: false),
                        bookGenre = c.String(),
                    })
                .PrimaryKey(t => t.bookID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
