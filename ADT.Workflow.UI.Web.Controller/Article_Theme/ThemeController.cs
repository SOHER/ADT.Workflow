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
    public class ThemeController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Theme/

        public ActionResult Index()
        {
            return View(db.THEME.ToList());
        }

        //
        // GET: /Theme/Details/5

        public ActionResult Details(int id = 0)
        {
            THEME theme = db.THEME.Find(id);
            if (theme == null)
            {
                return HttpNotFound();
            }
            return View(theme);
        }

        //
        // GET: /Theme/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Theme/Create

        [HttpPost]
        public ActionResult Create(THEME theme)
        {
            if (ModelState.IsValid)
            {
                db.THEME.Add(theme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theme);
        }

        //
        // GET: /Theme/Edit/5

        public ActionResult Edit(int id = 0)
        {
            THEME theme = db.THEME.Find(id);
            if (theme == null)
            {
                return HttpNotFound();
            }
            return View(theme);
        }

        //
        // POST: /Theme/Edit/5

        [HttpPost]
        public ActionResult Edit(THEME theme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theme);
        }

        //
        // GET: /Theme/Delete/5

        public ActionResult Delete(int id = 0)
        {
            THEME theme = db.THEME.Find(id);
            if (theme == null)
            {
                return HttpNotFound();
            }
            return View(theme);
        }

        //
        // POST: /Theme/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            THEME theme = db.THEME.Find(id);
            db.THEME.Remove(theme);
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