namespace LessonsUnlimited.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "ConfirmPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Members", "Password", c => c.String());
            AlterColumn("dbo.Members", "Email", c => c.String());
            AlterColumn("dbo.Members", "LastName", c => c.String());
            AlterColumn("dbo.Members", "FirstName", c => c.String());
            AlterColumn("dbo.Members", "UserName", c => c.String());
        }
    }
}
