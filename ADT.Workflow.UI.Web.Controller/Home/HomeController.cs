using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADT.Workflow.Web.Models;

namespace ADT.Workflow.Web.Controllers
{
    /// <summary>
    /// Class HomeController.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            // If user session not exist
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Message = "Bienvenue.";
            ViewBag.Role = Session["role"];

            return View();
        }
    }
}
