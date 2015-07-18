using LessonsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Controllers
{
    public class MembersDBController : Controller
    {
        //Create gateway to the LessonsUnlimitedDB which allows us access to our database
        private LessonsUnlimitedDataContext _db = new LessonsUnlimitedDataContext();

        
        //Access database and perform CRUD operations on Lessons.
        public ActionResult ValidateUserName(Member member)
        {
            
            var userCount = (from m in _db.Member where m.UserName == member.UserName && m.Id != member.Id  select m).Count();
            
            // If it finds the username it returns true, if not, false
            return Json((userCount==0 ? true : false));
                   
        }


        // GET: Members
        public ActionResult Index()
        {
            //Utilize LINQ syntax to retreive all members from the database
            var members = from m in _db.Member select m;

            //Store the information retrieved from the database in a list.
            return View(members.ToList());
        }

        // GET: Members/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        [HttpPost]
        public ActionResult Create(Member member)
        {
           
            if (ModelState.IsValid)
            {
                // If the ModelState is valid then...
                // Add the given entity to the context
                _db.Member.Add(member);
                _db.SaveChanges();
                
                // Redirect viewer to the Index 
                return RedirectToAction("Index");
            }
             return View();
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int id)
        {
            var member = _db.Member.Find(id);
            
            return View(member);
        }

        // POST: Members/Edit/5
        [HttpPost]
        public ActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                var original = _db.Member.Find(member.Id);
                original.FirstName = member.FirstName;
                original.LastName = member.LastName;
                original.UserName = member.UserName;
                original.Password = member.Password;
                original.Email = member.Email;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int id)
        {
            var member = _db.Member.Find(id);

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var original = _db.Member.Find(id);
            _db.Member.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
