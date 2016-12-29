using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpingHands.Data;

namespace HelpingHands.Controllers
{
    public class TestController : Controller
    {
        private LocationsRepository _locationsRepository = null;

        public TestController()
        {
            _locationsRepository = new LocationsRepository();
        }

        // GET: Test
        //public ActionResult Testing()
        //{
        //    //var repository = _locationsRepository.GetLocations;            

        //    //return View(repository);
        //}
    }
}