namespace LessonsUnlimited.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        LessonTitle = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        BillingAddress_Street = c.String(),
                        BillingAddress_City = c.String(),
                        BillingAddress_State = c.String(),
                        BillingAddress_Zipcode = c.String(),
                        ShippingAddress_Street = c.String(),
                        ShippingAddress_City = c.String(),
                        ShippingAddress_State = c.String(),
                        ShippingAddress_Zipcode = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        MemberType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
            DropTable("dbo.Lessons");
        }
    }
}
