namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedManagement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managements", "returned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managements", "returned");
        }
    }
}
