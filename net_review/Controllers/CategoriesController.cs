using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using net_review.Models;

namespace net_review.Controllers
{
    public class CategoriesController : Controller
    {
        private ReviewDbContext db = new ReviewDbContext();

        // GET: Categories
        public ActionResult Index(int? id)
        {
            
            //Category data = new Category;
            //data.ID= id;
            if (id == null)
            {
                id = 0;
            }
            return View(db.Category.Where(x => x.ParentID == id).ToList());
            //return View(db.Category.ToList());
        }

        [HttpPost]
        public ActionResult BatchInsert(string textArea, int? pid)
        {
            if (!pid.HasValue)
                pid = 0;

                string[] stringSeparators = new string[] { "\r\n" };
                string[] lines = textArea.Split(stringSeparators, StringSplitOptions.None);
                for (int count = 0; count <= lines.Length - 1; count++)
                {
                    db.Category.Add(new Category() { CategoryName = lines[count], ParentID = pid.Value });

                }

                db.SaveChanges();
                return RedirectToAction("Index", new { id=pid });
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Categories/Create
        public ActionResult Create(int? id)
        {
            if (!id.HasValue)
            {
                id = 0;
            }
            Category data = new Category();
            data.ParentID = id.Value;
            return View(data);
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryName,ParentID,Status,Image,Sort,Note,Appendix")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Category.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryName,ParentID,Status,Image,Sort,Note,Appendix")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Category.Find(id);
            db.Category.Remove(category);
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
