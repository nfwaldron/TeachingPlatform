using LessonsUnlimited.Models;
using LessonsUnlimited.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Controllers
{
    public class MembersController : Controller
    {
        // Create access to the MemberServices interface.
        private IApplicationUserServices _service;

        public MembersController( IApplicationUserServices service)
        {
            _service = service;
        }
        
        // GET: Members
        public ActionResult Index()
        {
            return View(_service.List());
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
        public ActionResult Create(ApplicationUser member)
        {
            if (ModelState.IsValid)
            {
                _service.Create(member);
                return RedirectToAction("Index");      
            }

            return View();
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Members/Edit/5
        [HttpPost]
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

        // GET: Members/Delete/5
        public ActionResult Delete(int id)
        {
            var original = _service.Find(id);
            return View(original);
        }

        // POST: Members/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
