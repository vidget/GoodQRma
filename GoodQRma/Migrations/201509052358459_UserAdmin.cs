namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAdmin : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserViewModel");
            AlterColumn("dbo.UserViewModel", "UserViewModelId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserViewModel", "UserViewModelId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserViewModel");
            AlterColumn("dbo.UserViewModel", "UserViewModelId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.UserViewModel", "UserViewModelId");
        }
    }
}
