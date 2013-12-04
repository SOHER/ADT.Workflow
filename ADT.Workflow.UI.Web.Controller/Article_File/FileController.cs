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
    public class FileController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /File/

        public ActionResult Index()
        {
            var file = db.FILE.Include(f => f.ARTICLE).Include(f => f.FILE_TYPE);
            return View(file.ToList());
        }

        //
        // GET: /File/Details/5

        public ActionResult Details(int id = 0)
        {
            FILE file = db.FILE.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        //
        // GET: /File/Create

        public ActionResult Create()
        {
            ViewBag.ARTICLE_ID = new SelectList(db.ARTICLE, "ARTICLE_ID", "ARTICLE_ID");
            ViewBag.FILE_TYPE_ID = new SelectList(db.FILE_TYPE, "FILE_TYPE_ID", "FILE_TYPE_LABEL");
            return View();
        }

        //
        // POST: /File/Create

        [HttpPost]
        public ActionResult Create(FILE file)
        {
            if (ModelState.IsValid)
            {
                db.FILE.Add(file);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ARTICLE_ID = new SelectList(db.ARTICLE, "ARTICLE_ID", "AUTHOR", file.ARTICLE_ID);
            ViewBag.FILE_TYPE_ID = new SelectList(db.FILE_TYPE, "FILE_TYPE_ID", "FILE_TYPE_LABEL", file.FILE_TYPE_ID);
            return View(file);
        }

        //
        // GET: /File/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FILE file = db.FILE.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            ViewBag.ARTICLE_ID = new SelectList(db.ARTICLE, "ARTICLE_ID", "AUTHOR", file.ARTICLE_ID);
            ViewBag.FILE_TYPE_ID = new SelectList(db.FILE_TYPE, "FILE_TYPE_ID", "FILE_TYPE_LABEL", file.FILE_TYPE_ID);
            return View(file);
        }

        //
        // POST: /File/Edit/5

        [HttpPost]
        public ActionResult Edit(FILE file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(file).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ARTICLE_ID = new SelectList(db.ARTICLE, "ARTICLE_ID", "AUTHOR", file.ARTICLE_ID);
            ViewBag.FILE_TYPE_ID = new SelectList(db.FILE_TYPE, "FILE_TYPE_ID", "FILE_TYPE_LABEL", file.FILE_TYPE_ID);
            return View(file);
        }

        //
        // GET: /File/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FILE file = db.FILE.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        //
        // POST: /File/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FILE file = db.FILE.Find(id);
            db.FILE.Remove(file);
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