namespace GamerHQ_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingPlatformClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlatformEnum",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlatformEnum");
        }
    }
}
