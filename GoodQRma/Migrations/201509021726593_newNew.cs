namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.File", "userId", c => c.Int(nullable: false));
            AlterColumn("dbo.Event", "userID", c => c.Int());
            DropColumn("dbo.File", "userIdPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.File", "userIdPhoto", c => c.String());
            AlterColumn("dbo.Event", "userID", c => c.String());
            DropColumn("dbo.File", "userId");
        }
    }
}
