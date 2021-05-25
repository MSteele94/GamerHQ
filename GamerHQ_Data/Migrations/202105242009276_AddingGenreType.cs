namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "GenreType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "GenreType");
        }
    }
}
