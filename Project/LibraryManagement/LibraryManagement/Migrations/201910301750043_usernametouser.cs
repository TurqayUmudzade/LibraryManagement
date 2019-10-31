namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usernametouser : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Managements", name: "Username_UserID", newName: "User_UserID");
            RenameIndex(table: "dbo.Managements", name: "IX_Username_UserID", newName: "IX_User_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Managements", name: "IX_User_UserID", newName: "IX_Username_UserID");
            RenameColumn(table: "dbo.Managements", name: "User_UserID", newName: "Username_UserID");
        }
    }
}
