using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BPEC.Models;
using BPEC.DAL;

namespace BPEC.Controllers
{
    public class PageContentController : Controller
    {
        private PageContentContext db = new PageContentContext();

        //
        // GET: /PageContent/

        public ActionResult Index()
        {
            return View(db.PagesContent.ToList());
        }

        //
        // GET: /PageContent/Details/5

        public ActionResult Details(int id = 0)
        {
            PageContent pagecontent = db.PagesContent.Find(id);
            if (pagecontent == null)
            {
                return HttpNotFound();
            }
            return View(pagecontent);
        }

        //
        // GET: /PageContent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PageContent/Create

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(PageContent pagecontent)
        {
            if (ModelState.IsValid)
            {
                db.PagesContent.Add(pagecontent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagecontent);
        }

        //
        // GET: /PageContent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PageContent pagecontent = db.PagesContent.Find(id);
            if (pagecontent == null)
            {
                return HttpNotFound();
            }
            return View(pagecontent);
        }

        //
        // POST: /PageContent/Edit/5

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(PageContent pagecontent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagecontent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagecontent);
        }

        //
        // GET: /PageContent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PageContent pagecontent = db.PagesContent.Find(id);
            if (pagecontent == null)
            {
                return HttpNotFound();
            }
            return View(pagecontent);
        }

        //
        // POST: /PageContent/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PageContent pagecontent = db.PagesContent.Find(id);
            db.PagesContent.Remove(pagecontent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}