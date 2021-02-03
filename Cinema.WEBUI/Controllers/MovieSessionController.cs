using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class MovieSessionController : Controller
    {
        MovieSessionRepository msrep = new MovieSessionRepository();
        // GET: MovieSession
        public List<MovieSession> GetAllMovieSessions()
        {
            return msrep.SelectAll().Select(x => new MovieSession
            {
                ID = x.ID,
                
            }).ToList();
        }
        [HttpPost]
        public List<MovieSession> AddTicket(MovieSession item)
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
        public void UpdateMovieSessions(MovieSession item)
        {
            msrep.Update(item);
        }
    }
}