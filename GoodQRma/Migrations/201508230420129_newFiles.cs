namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFiles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.File", "FileType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.File", "FileType");
        }
    }
}
