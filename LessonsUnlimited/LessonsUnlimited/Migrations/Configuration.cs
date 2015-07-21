namespace LessonsUnlimited.Migrations
{
    using LessonsUnlimited.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LessonsUnlimited.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LessonsUnlimited.Models.LessonsUnlimitedDataContext";
        }

        protected override void Seed(LessonsUnlimited.Models.DataContext context)
        {
            var members = new Member[]
            {
                new Member {FirstName = "John", LastName = "Doe", UserName="jdoe1" , Email = "johndc@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Die", UserName="jdoe2" , Email = "johndl@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Dae", UserName="jdoe3" , Email = "johndr@gmail.com", Password="hello", ConfirmPassword="hello"},
                new Member {FirstName = "John", LastName = "Doo", UserName="jdoe4" , Email = "johndl@gmail.com", Password="hello", ConfirmPassword="hello"}
            };

            context.Member.AddOrUpdate(model => model.UserName, members);

           
            var lessons = new Lesson[]
            {
                new Lesson{LessonTitle="Cycle of Fourths", Author="Riley Hagan", Description="Master the Cycle of Fourths!"},
                new Lesson{LessonTitle = "1-3-5-7", Author="Riley Hagan", Description="Master These Arpeggios!"},
                new Lesson{LessonTitle = "CMaj3", Author="Jim Stinnett", Description="Build Speed And Dexterity With This Exercise"}
            };

            context.Lesson.AddOrUpdate(model => model.LessonTitle, lessons);


        }
    }
}
