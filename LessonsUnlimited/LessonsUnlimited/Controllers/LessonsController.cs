using LessonsUnlimited.Models;
using LessonsUnlimited.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Controllers
{
    public class LessonsController : Controller
    {
        private ILessonServices _service;
        public LessonsController(ILessonServices services)
        {
            _service = services;
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
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            // id is now a nullable type. nullable types are class wrappers around the value.
            // in order to access the value of a nullable property, you must access it by
            // propertyName.Value
            var original = _service.Find(id.Value);

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
