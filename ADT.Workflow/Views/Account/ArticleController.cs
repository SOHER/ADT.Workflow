using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADT.Workflow.Web.Models;

namespace ADT.Workflow.Web.UI.Views.Account
{
    public class ArticleController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Article/

        public ActionResult Index()
        {
            return View(db.ARTICLE.ToList());
        }

        //
        // GET: /Article/Details/5

        public ActionResult Details(int id = 0)
        {
            ARTICLE article = db.ARTICLE.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // GET: /Article/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Article/Create

        [HttpPost]
        public ActionResult Create(ARTICLE article)
        {
            if (ModelState.IsValid)
            {
                db.ARTICLE.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        //
        // GET: /Article/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ARTICLE article = db.ARTICLE.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public ActionResult Edit(ARTICLE article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        //
        // GET: /Article/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ARTICLE article = db.ARTICLE.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Article/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ARTICLE article = db.ARTICLE.Find(id);
            db.ARTICLE.Remove(article);
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