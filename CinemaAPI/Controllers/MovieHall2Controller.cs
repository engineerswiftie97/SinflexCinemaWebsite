using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class MovieHall2Controller : Controller
    {
        // GET: MovieHall
        MovieHallVMRepository mhrep = new MovieHallVMRepository();
        
        public List<MovieHallVM> GetAllMovieHalls()
        {
            return mhrep.SelectAll().Select(x => new MovieHallVM
            {
                ID = x.ID,
                HallName = x.HallName
            }).ToList();
        }

    }
}