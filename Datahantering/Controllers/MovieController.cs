using Datahantering.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Datahantering.Controllers
{
    public class MovieController : Controller
    {
        private DatahanteringEntities _db;
        
 
        public ActionResult Movie()
        {
            List<MovieViewModel> list = getMovies();


            return View("movie", list);
        }

        public ActionResult Create(string name, int grade, int length, string summary, string actor)
        {
           // movie_actor ma = new movie_actor(actor);
           // movie_actor ma_two = new movie_actor(actor_two);
            movie_data new_movie = new movie_data();
            new_movie.Name = name;
            new_movie.Grade = grade;
            new_movie.Length = length;
            new_movie.Summary = summary;
            movie_actor actor_ = new movie_actor(actor);
            new_movie.movie_actor.Add(actor_);
            // m.movie_actor.Add(ma_one);
            //m.movie_actor.Add(ma_two);

            using (_db = new DatahanteringEntities())
            {
                _db.movie_data.Add(new_movie);
                _db.SaveChanges();


            }
            return RedirectToAction("Movie", "Movie");
;        }

        public ActionResult Get()
        {
            List<MovieViewModel> list = getMovies();

            
            return View("movie",list);
        }

        public ActionResult Delete(int[] ids)
        {
            movie_data md = new movie_data() { ID = ids[0] };
            
            using (_db = new DatahanteringEntities())
            {
                _db.movie_data.Attach(md);
                _db.movie_data.Remove(_db.movie_data.Single(m => m.ID == md.ID));
                _db.SaveChanges();
            }
            List<MovieViewModel> list = getMovies();
            return View("movie",list);
        }
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

        private List<MovieViewModel> getMovies()
        {
            List<MovieViewModel> list = new List<MovieViewModel>();
            using (_db = new DatahanteringEntities())
            {
                Debugger.NotifyOfCrossThreadDependency();
                //var getMovie = from md in _db.movie_data
                //            orderby md.Name
                //            select md;


                var query = from md in _db.movie_data
                            join ma in _db.movie_actor on md.ID equals ma.movieID

                            select new { md, ma };
                foreach (var row in query)
                {
                    MovieViewModel mvd = new MovieViewModel();//{row.md.ID, row.md.Name, row.md.Grade, row.md.Length, row.md.Summary, row.ma.Actor.ToString() };
                    mvd.ID = row.md.ID;
                    mvd.Name = row.md.Name;
                    mvd.Grade = row.md.Grade;
                    mvd.Length = row.md.Length;
                    mvd.Summary = row.md.Summary;
                    mvd.Actor = row.ma.Actor;

                    list.Add(mvd);
                }

                //var query = from md in _db.movie_data
                //            join ma in _db.movie_actor on md.ID equals ma.movieID

                //            select new { md, ma };
            }
            return list;
        }

    }
}