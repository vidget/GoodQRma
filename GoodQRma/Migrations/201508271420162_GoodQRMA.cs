namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoodQRMA : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Event", "description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Event", "eventType", c => c.String(nullable: false));
            AlterColumn("dbo.Event", "address1", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Event", "address2", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Event", "city", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Event", "state", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Event", "zipCode", c => c.String(maxLength: 9));
            AlterColumn("dbo.Event", "country", c => c.String(maxLength: 15));
            AlterColumn("dbo.Event", "contact", c => c.String(maxLength: 25));
            AlterColumn("dbo.User", "profileName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "address1", c => c.String(maxLength: 25));
            AlterColumn("dbo.User", "address2", c => c.String(maxLength: 25));
            AlterColumn("dbo.User", "city", c => c.String(maxLength: 25));
            AlterColumn("dbo.User", "state", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.User", "zipCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.User", "country", c => c.String(maxLength: 15));
            AlterColumn("dbo.User", "phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.User", "email", c => c.String(nullable: false));
            AlterColumn("dbo.User", "webURL1", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "webURL1", c => c.String());
            AlterColumn("dbo.User", "email", c => c.String());
            AlterColumn("dbo.User", "phone", c => c.String());
            AlterColumn("dbo.User", "country", c => c.String());
            AlterColumn("dbo.User", "zipCode", c => c.String());
            AlterColumn("dbo.User", "state", c => c.String());
            AlterColumn("dbo.User", "city", c => c.String());
            AlterColumn("dbo.User", "address2", c => c.String());
            AlterColumn("dbo.User", "address1", c => c.String());
            AlterColumn("dbo.User", "profileName", c => c.String());
            AlterColumn("dbo.Event", "contact", c => c.String());
            AlterColumn("dbo.Event", "country", c => c.String());
            AlterColumn("dbo.Event", "zipCode", c => c.String());
            AlterColumn("dbo.Event", "state", c => c.String());
            AlterColumn("dbo.Event", "city", c => c.String());
            AlterColumn("dbo.Event", "address2", c => c.String());
            AlterColumn("dbo.Event", "address1", c => c.String());
            AlterColumn("dbo.Event", "eventType", c => c.String());
            AlterColumn("dbo.Event", "description", c => c.String());
            AlterColumn("dbo.Event", "name", c => c.String());
        }
    }
}
