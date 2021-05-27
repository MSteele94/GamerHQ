namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPlatformEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "PlatformTypes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "PlatformTypes");
        }
    }
}
