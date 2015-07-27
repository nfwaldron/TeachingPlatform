namespace LessonsUnlimited_V1._2.Migrations
{
    // Add the using Microsoft.Aspnet.Identity namespace
    using Microsoft.AspNet.Identity;
    using LessonsUnlimited_V1._2.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<LessonsUnlimited_V1._2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LessonsUnlimited_V1._2.Models.ApplicationDbContext context)
        {
            // UserStore connects the database.
            var userStore = new UserStore<ApplicationUser>(context);

            // Main API for interactions with users is the ApplicationUserManager
            // ApplicationUserManager gives a set of tools you can use to perfoem CRUD operations on
            // the user. It needs to know what database to connect to, which is why we pass
            // userStore as an arguement.
            var userManager = new ApplicationUserManager(userStore);

            // Ensure that the userManager is Nathan.
            // looks in database where name matches this email,
            // and return to the variable user.
            var user = userManager.FindByName("waldron.nathan@gmail.com");

            // If there is no user with the name "waldron.nathan@gmail.com"
            if (user == null )
            {
                // Create a new instance of the application user class, stored in the variable 
                // user.
                user = new ApplicationUser
                {
                    UserName = "waldron.nathan@gmail.com",
                    Email = "waldron.nathan@gmail.com",
                };

                // Create the userManager.
                // the Create method takes as arguements the new instance of the ApplicationUser
                // 'user' and the user's password as a string that is then hashed.
                userManager.Create(user, "Secret123!");

                // Add Claims
                // After user Id is generated, look for the Id and then add the Claim.
                userManager.AddClaim(user.Id, new Claim("CanEdit", "true"));
                //userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "11/28/1988"));
            }

            var lessons = new Lesson[]
            {
                new Lesson{Author  = "Riley Hagan", Description = "Master the Cycle of Fourths!", Title = "Cycle of Fourths", VideoLink="3TRDtpkbL3c"},
                new Lesson{Author  = "Riley Hagan", Description = "Master the Pentatonic Scale!", Title = "Bb Pentatonics", VideoLink="cr3_Vim0JcI"},
                new Lesson{Author  = "Riley Hagan", Description = "Master Arpeggios!", Title = "1-3-5 Arpeggios", VideoLink="cr3_Vim0JcI"}
            };

            //The Migrations Seed() method is called everytime you execute the Update-Database command. 
            //You won't be starting from a new database every time the Migrations Seed() method is called.
            //For this reason, you use the AddOrUpdate() method to seed the database. 
            //This methods adds new data only when the data does not already exist.
            context.Lessons.AddOrUpdate(model => model.Title, lessons);
        }
    }
}
