namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        eventID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        image = c.Byte(nullable: false),
                        name = c.String(),
                        description = c.String(),
                        eventType = c.String(),
                        eventDate = c.DateTime(nullable: false),
                        eventTime = c.DateTime(nullable: false),
                        numVolunteersNeeded = c.Int(nullable: false),
                        address1 = c.String(),
                        address2 = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zipCode = c.String(),
                        country = c.String(),
                        contact = c.String(),
                        phone = c.String(),
                        gpsLong = c.Double(nullable: false),
                        gpsLat = c.Double(nullable: false),
                        eventURL = c.String(),
                    })
                .PrimaryKey(t => t.eventID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        profilePic = c.Byte(nullable: false),
                        profileName = c.String(),
                        address1 = c.String(),
                        address2 = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zipCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        email = c.String(),
                        webURL1 = c.String(),
                        webURL2 = c.String(),
                        webURL3 = c.String(),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Event");
            DropTable("dbo.eventLog");
        }
    }
}
