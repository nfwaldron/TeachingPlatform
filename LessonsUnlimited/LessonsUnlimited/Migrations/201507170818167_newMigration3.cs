namespace LessonsUnlimited.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Password", c => c.String());
            AlterColumn("dbo.Members", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "Password", c => c.String(nullable: false));
        }
    }
}
