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
            ViewBag.DonorSignIn = "Already a donor?";
            ViewBag.Categories = new string[]
            {
                "Time: (For more info or to speak w/ someone directly about volunteering, ContactUs",
                "Food:",
                "Clothes:",
                "Money:"
            };
            ViewBag.Locations = new string[]
            {
                "Greater Cleveland Food Bank",
                "Parma Christian Church Disciples of Christ",
                "Kosher Food Bank",
                "Hunger Network of Greater Cleveland",

            };

            return View();
            //return "Hello Donors!"
        }


        public ActionResult GiveNow()
            {
                return View();
            }


        //public ActionResult GiveTime()
        //{
        //    ViewBag.Time = new string[]

        //    {

        //    };
        //    return View();
        //}
    }
}