namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventUserIDIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "userID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "userID", c => c.Int());
        }
    }
}
