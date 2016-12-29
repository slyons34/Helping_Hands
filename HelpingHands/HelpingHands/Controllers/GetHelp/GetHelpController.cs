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
            var donations = db.Donations.Include(d => d.Category).Include(d => d.Location);
            return View(donations.ToList());
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
