namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Game", "CreatedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Game", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
