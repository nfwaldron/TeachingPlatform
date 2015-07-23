using LessonsUnlimited_V1._2.Models;
using LessonsUnlimited_V1._2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }

        // GET: Lessons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lessons/Create
        [HttpPost]
        public ActionResult Create(Lesson lesson)
        {
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
            var original = _service.Find(id);
            return View(original);
        }

        // POST: Lessons/Edit/5
        [HttpPost]
        public ActionResult Edit(Lesson lesson)
        {
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
            var original = _service.Find(id);
            return View(original);
        }

        // POST: Lessons/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
