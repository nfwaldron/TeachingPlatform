namespace LessonsUnlimited.Migrations

{
using LessonsUnlimited.Models;

//REMEMBER TO BRING IN Microsoft.AspNet.Identity
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
    using System.Security.Claims;


internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
{
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ApplicationDdContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);

           // MAIN API FOR INTERACTIONS WITH USERS IS THE APPLICATIONUSERMANAGER
            var userManager = new ApplicationUserManager(userStore); //

            // Ensure Stephen
            var user = userManager.FindByName("waldron.nathan@gmail.com");
            
            if (user == null) 
            {
                // create user
                user = new ApplicationUser 
                {
                    FirstName = "Nathan",
                    LastName = "Waldron",
                    UserName = "waldron.nathan@gmail.com",
                    Email = "waldron.nathan@gmail.com"
                };
            userManager.Create(user, "Secret123!");
            // add claims
            userManager.AddClaim(user.Id, new Claim("CanEdit", "true"));
            userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "11/28/1988"));
            }

           
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

