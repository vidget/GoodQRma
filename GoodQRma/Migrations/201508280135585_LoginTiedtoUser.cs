namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginTiedtoUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "userIDLogin", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "userIDLogin");
        }
    }
}
