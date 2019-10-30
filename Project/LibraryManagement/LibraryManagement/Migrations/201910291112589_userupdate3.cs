namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userupdate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "BookReturnDate", c => c.DateTime());
            DropColumn("dbo.Users", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Date", c => c.DateTime());
            DropColumn("dbo.Users", "BookReturnDate");
        }
    }
}
