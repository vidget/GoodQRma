namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userIdPhotoString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.File", "userIdPhoto", c => c.String());
            DropColumn("dbo.File", "userId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.File", "userId", c => c.Int(nullable: false));
            DropColumn("dbo.File", "userIdPhoto");
        }
    }
}
