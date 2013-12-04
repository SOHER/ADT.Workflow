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

namespace ADT.Workflow.Web.Controllers 
{
    public class VideoController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View(db.VIDEO.ToList());
        }

        //
        // GET: /Video/Details/5

        public ActionResult Details(int id = 0)
        {
            VIDEO video = db.VIDEO.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

        //
        // GET: /Video/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Video/Create

        [HttpPost]
        public ActionResult Create(VIDEO video)
        {
            if (ModelState.IsValid)
            {
                db.VIDEO.Add(video);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(video);
        }

        //
        // GET: /Video/Edit/5

        public ActionResult Edit(int id = 0)
        {
            VIDEO video = db.VIDEO.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

        //
        // POST: /Video/Edit/5

        [HttpPost]
        public ActionResult Edit(VIDEO video)
        {
            if (ModelState.IsValid)
            {
                db.Entry(video).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(video);
        }

        //
        // GET: /Video/Delete/5

        public ActionResult Delete(int id = 0)
        {
            VIDEO video = db.VIDEO.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

        //
        // POST: /Video/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            VIDEO video = db.VIDEO.Find(id);
            db.VIDEO.Remove(video);
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