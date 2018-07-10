namespace SMS.Migrations.SMSmigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserStatus_datatype_change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "UserStatusId", "dbo.UserStatus");
            DropIndex("dbo.Students", new[] { "UserStatusId" });
            DropPrimaryKey("dbo.UserStatus");
            AddColumn("dbo.UserStatus", "UserStatusName", c => c.String());
            AlterColumn("dbo.Students", "UserStatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserStatus", "UserStatusId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserStatus", "UserStatusId");
            CreateIndex("dbo.Students", "UserStatusId");
            AddForeignKey("dbo.Students", "UserStatusId", "dbo.UserStatus", "UserStatusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserStatusId", "dbo.UserStatus");
            DropIndex("dbo.Students", new[] { "UserStatusId" });
            DropPrimaryKey("dbo.UserStatus");
            AlterColumn("dbo.UserStatus", "UserStatusId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Students", "UserStatusId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.UserStatus", "UserStatusName");
            AddPrimaryKey("dbo.UserStatus", "UserStatusId");
            CreateIndex("dbo.Students", "UserStatusId");
            AddForeignKey("dbo.Students", "UserStatusId", "dbo.UserStatus", "UserStatusId", cascadeDelete: true);
        }
    }
}
