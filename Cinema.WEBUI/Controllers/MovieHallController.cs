using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class MovieHallController : Controller
    {
        MovieHallRepository mhrep = new MovieHallRepository();
        // GET: MovieHall
        public List<MovieHall> GetAllMovieHalls()
        {
            return mhrep.SelectAll().Select(x => new MovieHall
            {
                ID = x.ID,
                HallName= x.HallName
            }).ToList();
        }

        
    }
}