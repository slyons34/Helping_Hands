using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpingHands.Models;

namespace HelpingHands.Controllers
{
    public class DonationsController : Controller
    {
        HelpingHandsEntities HelpingHandsDb = new HelpingHandsEntities();

        // GET: Donations
        public ActionResult Index()
        {
            return View(HelpingHandsDb.Donations.ToList());
        }

        // GET: Donations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Donations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donations/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Donations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Donations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Donations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Donations/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
