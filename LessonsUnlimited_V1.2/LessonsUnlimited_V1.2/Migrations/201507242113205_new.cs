namespace LessonsUnlimited_V1._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lessons", "VideoLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lessons", "VideoLink");
        }
    }
}
