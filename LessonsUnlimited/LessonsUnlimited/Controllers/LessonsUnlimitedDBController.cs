using LessonsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Controllers
{
    public class LessonsUnlimitedDBController : Controller
    {
        //_db acts as a gateway that permits access to the database through the class
        // LessonsUnlimitedDataContext. This has the private access modified because we do not
        // want user to have access to our database through our controller.

        private LessonsUnlimitedDataContext _db = new LessonsUnlimitedDataContext(); 

        // GET: LessonsUnlimitedDB
        public ActionResult Index()
        {
            var dataBase = from d in _db select d; 

            return View();
        }

        // GET: LessonsUnlimitedDB/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LessonsUnlimitedDB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LessonsUnlimitedDB/Create
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

        // GET: LessonsUnlimitedDB/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LessonsUnlimitedDB/Edit/5
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

        // GET: LessonsUnlimitedDB/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LessonsUnlimitedDB/Delete/5
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
