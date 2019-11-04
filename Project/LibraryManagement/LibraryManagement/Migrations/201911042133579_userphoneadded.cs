namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userphoneadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Phonenumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Phonenumber");
        }
    }
}
