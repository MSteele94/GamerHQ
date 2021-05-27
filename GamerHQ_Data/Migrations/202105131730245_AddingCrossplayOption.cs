namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCrossplayOption : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "WantsCrossplay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "WantsCrossplay");
        }
    }
}
