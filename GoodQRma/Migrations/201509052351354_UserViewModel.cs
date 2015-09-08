namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserViewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserViewModel",
                c => new
                    {
                        UserViewModelId = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Roles = c.String(),
                    })
                .PrimaryKey(t => t.UserViewModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserViewModel");
        }
    }
}
