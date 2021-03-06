namespace Whatfits.Models.Migrations.ContentMigrations.ReviewsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reviews : DbMigration
    {
        public override void Up()
        {
             CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        RevieweeID = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        ReviewMessage = c.String(nullable: false),
                        DateAndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.UserProfiles", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "UserID", "dbo.UserProfiles");
            DropIndex("dbo.Reviews", new[] { "UserID" });
            DropTable("dbo.Reviews");
        }
    }
}
