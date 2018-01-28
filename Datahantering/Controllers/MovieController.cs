using Datahantering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Datahantering.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Movie()
        {
            return View();
        }

        public ActionResult Create(movie_data m)
        {
            return View("Movie")
;        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}