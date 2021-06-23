using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
           
            //truyen theo viewBag
            ViewBag.Message = "Brand Of Product";
            ViewBag.CurrentTime = DateTime.Now;

            Brand brand = new Brand() { Name = "Watch", Image = "Watch.png", Description = "Watch description" };
            return View(brand);
        }

        // GET: Brand/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    RedirectToAction("Index");
                }
                return View(brand);
            }
            catch
            {
                return View(brand);
            }
        }
        [HttpPost]
        public ActionResult CreateCategory(Brand brand)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    RedirectToAction("Index");
                }
                return View(brand);
            }
            catch
            {
                return View(brand);
            }
        }


        // GET: Brand/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Brand/Edit/5
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

        // GET: Brand/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brand/Delete/5
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
