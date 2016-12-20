using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpingHands.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donate
        public ActionResult Index()
        {
            ViewBag.PageHeading = "THANKS FOR YOUR GENEROSITY!";
            ViewBag.GiveHeading = "Give Now:";
            ViewBag.Categories = new string[]
            {
                "Time:",
                "Food:",
                "Clothes:",
                "Money:"
            };

            return View();
            //return "Hello Donors!"
        }
    }
}