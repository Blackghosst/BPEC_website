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
    public class CertificateController : Controller
    {
        private PageContentContext db = new PageContentContext();

        //
        // GET: /Certificate/

        public ActionResult Index()
        {
            return View(db.Certificates.ToList());
        }

        //
        // GET: /Certificate/Details/5

        public ActionResult Details(int id = 0)
        {
            Certificate certificate = db.Certificates.Find(id);
            if (certificate == null)
            {
                return HttpNotFound();
            }
            return View(certificate);
        }

        //
        // GET: /Certificate/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Certificate/Create

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Certificate certificate)
        {
            if (ModelState.IsValid)
            {
                db.Certificates.Add(certificate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(certificate);
        }

        //
        // GET: /Certificate/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Certificate certificate = db.Certificates.Find(id);
            if (certificate == null)
            {
                return HttpNotFound();
            }
            return View(certificate);
        }

        //
        // POST: /Certificate/Edit/5

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Certificate certificate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(certificate);
        }

        //
        // GET: /Certificate/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Certificate certificate = db.Certificates.Find(id);
            if (certificate == null)
            {
                return HttpNotFound();
            }
            return View(certificate);
        }

        //
        // POST: /Certificate/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Certificate certificate = db.Certificates.Find(id);
            db.Certificates.Remove(certificate);
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