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
    public class ImgController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Img/

        public ActionResult Index()
        {
            return View(db.IMG.ToList());
        }

        //
        // GET: /Img/Details/5

        public ActionResult Details(int id = 0)
        {
            IMG img = db.IMG.Find(id);
            if (img == null)
            {
                return HttpNotFound();
            }
            return View(img);
        }

        //
        // GET: /Img/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Img/Create

        [HttpPost]
        public ActionResult Create(IMG img)
        {
            if (ModelState.IsValid)
            {
                db.IMG.Add(img);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(img);
        }

        //
        // GET: /Img/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IMG img = db.IMG.Find(id);
            if (img == null)
            {
                return HttpNotFound();
            }
            return View(img);
        }

        //
        // POST: /Img/Edit/5

        [HttpPost]
        public ActionResult Edit(IMG img)
        {
            if (ModelState.IsValid)
            {
                db.Entry(img).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(img);
        }

        //
        // GET: /Img/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IMG img = db.IMG.Find(id);
            if (img == null)
            {
                return HttpNotFound();
            }
            return View(img);
        }

        //
        // POST: /Img/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            IMG img = db.IMG.Find(id);
            db.IMG.Remove(img);
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