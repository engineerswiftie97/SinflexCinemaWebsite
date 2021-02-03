using Cinema.VIEWMODEL.VMRepository;
using Cinema.VIEWMODEL.VMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaAPI.Controllers
{
    public class MovieSession2Controller : Controller
    {
        // GET: MovieSession
        MovieSessionVMRepository msrep = new MovieSessionVMRepository();
        // GET: MovieSession
        public List<MovieSessionVM> GetAllMovieSessions()
        {
            return msrep.SelectAll().Select(x => new MovieSessionVM
            {
                ID = x.ID,

            }).ToList();
        }
        [HttpPost]
        public List<MovieSessionVM> AddTicket(MovieSessionVM item)
        {

            msrep.Add(item);
            msrep.Save();
            return GetAllMovieSessions();

        }

        [HttpDelete]
        public void RemoveMovieSession(int id)
        {
            msrep.Delete(msrep.GetByID(id));
            msrep.Save();
        }


        [HttpPut]
        public void UpdateMovieSessions(MovieSessionVM item)
        {
            msrep.Update(item);
        }
    }
}