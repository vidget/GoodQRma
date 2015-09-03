namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFile : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.File", new[] { "eventId" });
            CreateIndex("dbo.File", "EventId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.File", new[] { "EventId" });
            CreateIndex("dbo.File", "eventId");
        }
    }
}
