using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Datahantering.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult GetMovies()
        {
            return View();
        }
    }
}