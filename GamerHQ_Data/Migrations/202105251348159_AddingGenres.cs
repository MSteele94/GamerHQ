namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "GenreType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "GenreType");
        }
    }
}
