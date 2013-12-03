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
    public class FunctionController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Function/

        public ActionResult Index()
        {
            return View(db.FUNCTION.ToList());
        }

        //
        // GET: /Function/Details/5

        public ActionResult Details(int id = 0)
        {
            FUNCTION function = db.FUNCTION.Find(id);
            if (function == null)
            {
                return HttpNotFound();
            }
            return View(function);
        }

        //
        // GET: /Function/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Function/Create

        [HttpPost]
        public ActionResult Create(FUNCTION function)
        {
            if (ModelState.IsValid)
            {
                db.FUNCTION.Add(function);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(function);
        }

        //
        // GET: /Function/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FUNCTION function = db.FUNCTION.Find(id);
            if (function == null)
            {
                return HttpNotFound();
            }
            return View(function);
        }

        //
        // POST: /Function/Edit/5

        [HttpPost]
        public ActionResult Edit(FUNCTION function)
        {
            if (ModelState.IsValid)
            {
                db.Entry(function).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(function);
        }

        //
        // GET: /Function/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FUNCTION function = db.FUNCTION.Find(id);
            if (function == null)
            {
                return HttpNotFound();
            }
            return View(function);
        }

        //
        // POST: /Function/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FUNCTION function = db.FUNCTION.Find(id);
            db.FUNCTION.Remove(function);
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