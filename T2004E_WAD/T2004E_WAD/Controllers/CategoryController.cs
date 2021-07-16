﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using T2004E_WAD.Context;
using T2004E_WAD.Models;
using System.Dynamic;
using System.IO;

namespace T2004E_WAD.Controllers
{
    public class CategoryController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id); //class Category co bien la category
            if (category == null)
            {
                return HttpNotFound();
            }
            dynamic data = new ExpandoObject();
            data.Category = category;
            data.Products = db.Products.Where(p => p.CategoryID == category.Id).ToList();
            return View(data);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] Category category, HttpPostedFileBase Image) //action method, tab cuoi cung trong url
        {
            String categoryImage = "default.png";
            //upload file len thu muc upload
            //luu ten file vao categoryImage
            if(Image != null)
            {
                string fileName = Path.GetFileName(Image.FileName);
                string path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                Image.SaveAs(path);// luu file xong
                categoryImage = "Uploads/" + fileName;
            }
            category.Image = categoryImage;

            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] //phương thức post
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Image,Description")] Category category) //category là đối tượng nhận được khi submit form edit lên, 
                                                                                                  //controller sẽ nhận view models đó
        {
            if (ModelState.IsValid) //nếu isvalid thành công
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
