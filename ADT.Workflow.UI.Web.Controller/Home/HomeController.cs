using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADT.Workflow.Web.Models;
// using ADT.Workflow.Web.UI.Filters;

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
        //[Authorize]
        public ActionResult Index()
        {

            ViewBag.Message = "Bienvenue.";

            return View();
        }
    }
}
