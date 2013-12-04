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


namespace ADT.Workflow.Web.UI.Views.Theme
{
    public class FileTypeController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /FileType/

        public ActionResult Index()
        {
            return View(db.FILE_TYPE.ToList());
        }

        //
        // GET: /FileType/Details/5

        public ActionResult Details(int id = 0)
        {
            FILE_TYPE file_type = db.FILE_TYPE.Find(id);
            if (file_type == null)
            {
                return HttpNotFound();
            }
            return View(file_type);
        }

        //
        // GET: /FileType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FileType/Create

        [HttpPost]
        public ActionResult Create(FILE_TYPE file_type)
        {
            if (ModelState.IsValid)
            {
                db.FILE_TYPE.Add(file_type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(file_type);
        }

        //
        // GET: /FileType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FILE_TYPE file_type = db.FILE_TYPE.Find(id);
            if (file_type == null)
            {
                return HttpNotFound();
            }
            return View(file_type);
        }

        //
        // POST: /FileType/Edit/5

        [HttpPost]
        public ActionResult Edit(FILE_TYPE file_type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(file_type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(file_type);
        }

        //
        // GET: /FileType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FILE_TYPE file_type = db.FILE_TYPE.Find(id);
            if (file_type == null)
            {
                return HttpNotFound();
            }
            return View(file_type);
        }

        //
        // POST: /FileType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FILE_TYPE file_type = db.FILE_TYPE.Find(id);
            db.FILE_TYPE.Remove(file_type);
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