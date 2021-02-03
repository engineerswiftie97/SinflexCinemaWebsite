using Cinema.BLL.BaseRepository;
using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;



namespace CinemaAPI.Controllers
{
    public class Movie2Controller : ApiController
    {
       MovieVMRepository mrep = new MovieVMRepository();
        // GET: Movie
        public List<MovieVM> GetAllMovies()
        {
            return mrep.SelectAll().Select(x => new MovieVM
            {
                ID = x.ID,
                MovieName = x.MovieName,
                Summary = x.Summary
            }).ToList();
        }
        [HttpPost]
        public List<MovieVM> AddMovie(MovieVM item)
        {

            mrep.Add(item);
            mrep.Save();
            return GetAllMovies();
            
        }

        [HttpDelete]
        public void RemoveMovie(int id)
        {
            mrep.Delete(mrep.GetByID(id));
            mrep.Save();
        }

        public MovieVM GetMovieByID(int id)
        {
            return mrep.GetByID(id);
        }

        [HttpPut]
        public void UpdateMovie(MovieVM item)
        {
            mrep.Update(item);
        }

    }
}