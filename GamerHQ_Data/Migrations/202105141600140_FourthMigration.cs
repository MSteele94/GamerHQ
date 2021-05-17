namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JoiningTable", "PlatformID", "dbo.Platform");
            DropIndex("dbo.JoiningTable", new[] { "PlatformID" });
            DropColumn("dbo.JoiningTable", "PlatformID");
            DropTable("dbo.Platform");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Platform",
                c => new
                    {
                        PlatformID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PlatformID);
            
            AddColumn("dbo.JoiningTable", "PlatformID", c => c.Int(nullable: false));
            CreateIndex("dbo.JoiningTable", "PlatformID");
            AddForeignKey("dbo.JoiningTable", "PlatformID", "dbo.Platform", "PlatformID", cascadeDelete: true);
        }
    }
}
