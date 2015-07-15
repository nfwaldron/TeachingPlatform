using MVCDropDownHelpers.Models;
using MVCDropDownHelpers.Views.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownHelpers.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            var categories = new List<Category>()
            {
                new Category{Id = 1, Name = "Electronics"},
                new Category{Id = 2, Name = "Beverages"}
            };

            var vm = new CreateVM
            {
                // Anything that you can iterate over, you can pass to a select list.
                // Use Id property of Category to represent the data value, and the Name property to represent the label value
                Categories = new SelectList(categories, "Id", "Name") 
            };

            return View(vm);
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(CreateVM vm)
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

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
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

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
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
