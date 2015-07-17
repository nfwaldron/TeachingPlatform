using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Controllers
{
    public class LessonsDBController : Controller
    {
        // GET: Lessons
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lessons/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lessons/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lessons/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lessons/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
