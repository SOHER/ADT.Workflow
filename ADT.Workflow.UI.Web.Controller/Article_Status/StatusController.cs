using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Web;
using System.Linq;
using System.Transactions;
using System.Web.Security;
using System.Web.Mvc;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using ADT.Workflow.Web.Models;


namespace ADT.Workflow.Web.UI.Views.Video
{
    public class StatusController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Status/

        public ActionResult Index()
        {
            return View(db.STATUS.ToList());
        }

        //
        // GET: /Status/Details/5

        public ActionResult Details(int id = 0)
        {
            STATUS status = db.STATUS.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // GET: /Status/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Status/Create

        [HttpPost]
        public ActionResult Create(STATUS status)
        {
            if (ModelState.IsValid)
            {
                db.STATUS.Add(status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(status);
        }

        //
        // GET: /Status/Edit/5

        public ActionResult Edit(int id = 0)
        {
            STATUS status = db.STATUS.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // POST: /Status/Edit/5

        [HttpPost]
        public ActionResult Edit(STATUS status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(status);
        }

        //
        // GET: /Status/Delete/5

        public ActionResult Delete(int id = 0)
        {
            STATUS status = db.STATUS.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // POST: /Status/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            STATUS status = db.STATUS.Find(id);
            db.STATUS.Remove(status);
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