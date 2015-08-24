namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class joinUserEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceLog",
                c => new
                    {
                        EventID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventID, t.UserID })
                .ForeignKey("dbo.Event", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.EventID)
                .Index(t => t.UserID);
            
            DropTable("dbo.eventLog");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.eventLog",
                c => new
                    {
                        eventLogID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        eventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.eventLogID);
            
            DropForeignKey("dbo.AttendanceLog", "UserID", "dbo.User");
            DropForeignKey("dbo.AttendanceLog", "EventID", "dbo.Event");
            DropIndex("dbo.AttendanceLog", new[] { "UserID" });
            DropIndex("dbo.AttendanceLog", new[] { "EventID" });
            DropTable("dbo.AttendanceLog");
        }
    }
}
