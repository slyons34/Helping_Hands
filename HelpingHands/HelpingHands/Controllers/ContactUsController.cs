using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpingHands.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Contact()
        {
            ViewBag.ContactHeading = "ContactUs:";
            ViewBag.ContactName = "Helping Hands";
            
            return View();

            return RedirectToAction("Sent");

        }



        public ActionResult Sent()
        {

            return View();
        }
    }
}