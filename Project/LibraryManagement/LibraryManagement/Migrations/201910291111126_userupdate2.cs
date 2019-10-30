namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userupdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Date", c => c.DateTime());
            DropColumn("dbo.Users", "BookTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "BookTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "Date");
        }
    }
}
