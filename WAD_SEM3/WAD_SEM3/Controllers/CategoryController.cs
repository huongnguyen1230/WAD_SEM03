﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAD_SEM3.Models;

namespace WAD_SEM3.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            //truyen theo data
            ViewData["Message"] = "Hello World";
            ViewData["CurrentTime"] = DateTime.Now;
            //truyen theo viewBag
            ViewBag.Message = "Hello World";
            ViewBag.CurrentTime = DateTime.Now;

            Category cat = new Category() { Name = "Watch", Image = "Watch.png", Description = "Watch description" };
            return View(cat);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                     RedirectToAction("Index");
                }
                return View(category);                
            }
            catch
            {
                return View(category);
            }
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    RedirectToAction("Index");
                }
                return View(category);
            }
            catch
            {
                return View(category);
            }
        }
        

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
