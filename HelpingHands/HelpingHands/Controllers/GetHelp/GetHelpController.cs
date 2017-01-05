using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HelpingHands.Models;

namespace HelpingHands.Controllers.GetHelp
{
     public class GetHelpController : Controller
    {
        private HelpingHandsEntities db = new HelpingHandsEntities();

        // GET: Donations
        public ActionResult Index()
        {
            logDebug("I'm in index");
            var categories = new List<Category>();
                categories.Add(new Category() { CategoryId = 0, Description = "All" });
                categories.AddRange(db.Categories.ToList());

            String CategoryIDstr = Request["CategoryId"];
            if (CategoryIDstr == null) { CategoryIDstr = "0"; }
            int CategoryID = Int32.Parse(CategoryIDstr);

            
            ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Description");

            if (CategoryID == 0)
            {
                logDebug("Cat=0");
                var donations = db.Donations.Include(d => d.Category).Include(d => d.Location);
                return View(donations.ToList());
            }
            else
            {
                logDebug("Filter");
                var donations = db.Donations.Where(d => d.CategoryId == CategoryID).Include(d => d.Category).Include(d => d.Location);
                return View(donations.ToList());
            }
        }
                

        private static void logDebug(String message)
        {
            System.Diagnostics.Debug.WriteLine(message);//It works in debug mode only
            Console.WriteLine(message);// Doesn't work in ASP.NET
            // Libraries like: NLOG  nlog.Debug(message)
            // nlog.config
            // appenders= Console
            // appender.HelpingHands.Controller=DEBUG,INFO,FATAL,TRACE
        }        

        // GET: Donations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            return View(donation);
        }
    }
}
