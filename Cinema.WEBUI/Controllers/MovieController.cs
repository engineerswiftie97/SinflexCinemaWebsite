using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using Cinema.WEBUI.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        MovieRepository mrep = new MovieRepository();

        

        // GET: Movie
        public List<Movie> GetAllMovies()
        {
            return mrep.SelectAll().Select(x => new Movie
            {
                ID = x.ID,
                MovieName = x.MovieName,
                Summary = x.Summary
            }).ToList();
        }
        [HttpPost]
        [EmployeeAuthentication]
        public List<Movie> AddMovie(Movie item)
        {

            mrep.Add(item);
            mrep.Save();
            return GetAllMovies();

        }

        
        [EmployeeAuthentication]
        public void RemoveMovie(int id)
        {
            mrep.Delete(mrep.GetByID(id));
            mrep.Save();
        }
        [EmployeeAuthentication]
        public Movie GetMovieByID(int id)
        {
            return mrep.GetByID(id);
        }
        
        [EmployeeAuthentication]
        public void UpdateMovie(Movie item)
        {
            mrep.Update(item);
        }
    }
}