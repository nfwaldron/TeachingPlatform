using LessonsUnlimited_V1._2.Models;
using LessonsUnlimited_V1._2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited_V1._2.Controllers
{
    public class LessonsController : Controller
    {
        
        private ILessonServices _service;
        public LessonsController(ILessonServices service)
        {
            _service = service;
        }

        // GET: Lessons
        public ActionResult Index()
        {
            return View(_service.List());
        }

        // GET: Lessons/Details/5
        public ActionResult Details(int id)
        {
            return View(_service.Find(id));
        }


        // GET: Lessons/Create
        public ActionResult Create()
        {
            // Employing claims to access user access to actions inside a contoller.
            // Cast the user as a ClaimsIdentity

            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit","true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }
            
            return View();
        }

        // POST: Lessons/Create
        [HttpPost]
        public ActionResult Create(Lesson lesson)
        {
            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit", "true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }

            if (ModelState.IsValid)
            {
                _service.Create(lesson);
                return RedirectToAction("Index");
            }
                return View();
        }

        // GET: Lessons/Edit/5
        public ActionResult Edit(int id)
        {
            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit", "true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }
            var original = _service.Find(id);
            return View(original);
        }

        // POST: Lessons/Edit/5
        [HttpPost]
        public ActionResult Edit(Lesson lesson)
        {
            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit", "true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }

            if (ModelState.IsValid)
            {
                _service.Edit(lesson);
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Lessons/Delete/5
        public ActionResult Delete(int id)
        {
            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit", "true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }

            var original = _service.Find(id);
            return View(original);
        }

        // POST: Lessons/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var user = User.Identity as ClaimsIdentity;
            if (!user.HasClaim("CanEdit", "true"))
            {
                return new HttpUnauthorizedResult("Hey, Go Away!");
            }
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
