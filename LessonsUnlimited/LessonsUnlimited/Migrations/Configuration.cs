namespace LessonsUnlimited.Migrations
{
    using LessonsUnlimited.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LessonsUnlimited.Models.LessonsUnlimitedDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LessonsUnlimited.Models.LessonsUnlimitedDataContext";
        }

        protected override void Seed(LessonsUnlimited.Models.LessonsUnlimitedDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //DATABASE NOT SEEDED CORRECTLY???
            var members = new Member[]
            {
                new Member {FirstName = "John", LastName = "Doe", UserName="jdoe1" , Email = "johndc@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Die", UserName="jdoe2" , Email = "johndl@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Dae", UserName="jdoe3" , Email = "johndr@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Doo", UserName="jdoe4" , Email = "johndl@gmail.com", Password="hello", ConfirmPassword="hello"}
            };

            // The AddOrUpdate method acts as a means to look at a property of the model object...
            // If any of the Member entities in the members array
            // Has the same value of the selected property...
            // in this case 'Id', when we update our database,
            // that entity will not be update/re-add to database
            // I need better explanation...

            context.Member.AddOrUpdate(model => model.UserName, members);

            var lessons = new Lesson[]
            {
                new Lesson{LessonTitle="Cycle of Fourths", Author="Riley Hagan", Description="Master the Cycle of Fourths!"},
                new Lesson{LessonTitle = "1-3-5-7", }
            };


        }
    }
}
