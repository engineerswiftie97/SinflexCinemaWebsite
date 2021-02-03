using Cinema.BLL.Concrete;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Controllers
{
    public class SeatController : Controller
    {
        // GET: Seat
        SeatRepository mrep = new SeatRepository();
        // GET: Seat2
        public List<Seat> GetAllSeats()
        {
            return mrep.SelectAll().Select(x => new Seat
            {
                ID = x.ID,
                SeatNumber=x.SeatNumber

            }).ToList();
        }
    }
}