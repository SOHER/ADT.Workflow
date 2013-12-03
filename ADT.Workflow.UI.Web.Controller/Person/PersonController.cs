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
    public class PersonController : Controller
    {
        private workflowEntities db = new workflowEntities();

        //
        // GET: /Person/

        public ActionResult Index()
        {
            var person = db.PERSON.Include(p => p.FUNCTION).Include(p => p.TEAM).Include(p => p.ROLE);
            return View(person.ToList());
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id = 0)
        {
            PERSON person = db.PERSON.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            ViewBag.FUNCTION_ID = new SelectList(db.FUNCTION, "FUNCTION_ID", "FUNCTION_LABEL");
            ViewBag.TEAM_ID = new SelectList(db.TEAM, "TEAM_ID", "TEAM_LABEL");
            ViewBag.ROLE_ID = new SelectList(db.ROLE, "ROLE_ID", "ROLE_LABEL");
            return View();
        }

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(PERSON person)
        {
            if (ModelState.IsValid)
            {
                db.PERSON.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FUNCTION_ID = new SelectList(db.FUNCTION, "FUNCTION_ID", "FUNCTION_LABEL", person.FUNCTION_ID);
            ViewBag.TEAM_ID = new SelectList(db.TEAM, "TEAM_ID", "TEAM_LABEL", person.TEAM_ID);
            ViewBag.ROLE_ID = new SelectList(db.ROLE, "ROLE_ID", "ROLE_LABEL", person.ROLE_ID);
            return View(person);
        }

        //
        // GET: /Person/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PERSON person = db.PERSON.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            ViewBag.FUNCTION_ID = new SelectList(db.FUNCTION, "FUNCTION_ID", "FUNCTION_LABEL", person.FUNCTION_ID);
            ViewBag.TEAM_ID = new SelectList(db.TEAM, "TEAM_ID", "TEAM_LABEL", person.TEAM_ID);
            ViewBag.ROLE_ID = new SelectList(db.ROLE, "ROLE_ID", "ROLE_LABEL", person.ROLE_ID);
            return View(person);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(PERSON person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FUNCTION_ID = new SelectList(db.FUNCTION, "FUNCTION_ID", "FUNCTION_LABEL", person.FUNCTION_ID);
            ViewBag.TEAM_ID = new SelectList(db.TEAM, "TEAM_ID", "TEAM_LABEL", person.TEAM_ID);
            ViewBag.ROLE_ID = new SelectList(db.ROLE, "ROLE_ID", "ROLE_LABEL", person.ROLE_ID);
            return View(person);
        }

        //
        // GET: /Person/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PERSON person = db.PERSON.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PERSON person = db.PERSON.Find(id);
            db.PERSON.Remove(person);
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