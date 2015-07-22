using CoderCamps;
using LessonsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Services
{
    public class ApplicationUserServices : LessonsUnlimited.Services.IApplicationUserServices
    {
        public IGenericRepository _repo;

        public ApplicationUserServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        // Querying the Database
        public IList<ApplicationUser> List()
        {
            return _repo.Query<ApplicationUser>().ToList();
        }

        // Find Member
        public ApplicationUser Find(int id)
        {
            return _repo.Find<ApplicationUser>(id);
        }

       


        // Create Member
        public void Create(ApplicationUser member)
        {
            _repo.Add<ApplicationUser>(member);
            _repo.SaveChanges();
        }



        //public ActionResult ValidateUserName(Member member)
        //{

        //    var userCount = (from m in _db.Member where m.UserName == member.UserName && m.Id != member.Id select m).Count();

        //    // If it finds the username it returns true, if not, false
        //    return Json((userCount == 0 ? true : false));

        //}


        // Edit Member
        public void Edit(ApplicationUser member)
        {
            var original = _repo.Find<ApplicationUser>(member.Id);
            original.Email = member.Email;
            original.FirstName = member.FirstName;
            original.LastName = member.LastName;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<ApplicationUser>(id);
            _repo.SaveChanges();
        }

    }
}