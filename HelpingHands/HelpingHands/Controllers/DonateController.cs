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
<<<<<<< HEAD
            ViewBag.DonorSignIn = "Already a donor? Sign in here:";
=======
            ViewBag.DonorSignIn = "Already a donor?";
>>>>>>> refs/remotes/origin/master
            ViewBag.Categories = new string[]
            {
                "Time: (For more info or to speak w/ someone directly about volunteering, ContactUs",
                "Food:",
                "Clothes:",
                "Money:"
            };

            return View();
            //return "Hello Donors!"
        }

<<<<<<< HEAD
        
=======

        public ActionResult GiveNow()
            {
                return View();
            }


>>>>>>> refs/remotes/origin/master
        //public ActionResult GiveTime()
        //{
        //    ViewBag.Time = new string[]

        //    {

        //    };
        //    return View();
        //}
    }
}